using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkTasksLibrary
{
    //Create class Shape and derived Triangle, Rectangle, Circle(Perimetr, Square)
    public interface IShape
    {
        double GetPerimetr();
        double GetSquare();
        public string shapeName { get; }
    }

    public class Rectangle : IShape
    {
        private double _a;
        private double _b;
        public string shapeName { get; }

        public Rectangle(double a, double b)
        {
            shapeName = "Rectangle";
            if (a > 0 && b > 0)
            {
                _a = a;
                _b = b;
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public double GetPerimetr()
        {
            return 2 * (_a + _b);
        }

        public double GetSquare()
        {
            return _a * _b;
        }
    }

    public class Triangle : IShape
    {
        private double _a;
        private double _b;
        private double _c;
        public string shapeName { get; }

        public Triangle(double a, double b, double c)
        {
            shapeName = "Triangle";
            _a = a;
            _b = b;
            _c = c;
        }

        public double GetPerimetr()
        {
            return _a + _b + _c;
        }

        public double GetSquare()
        {
            double p = GetPerimetr() / 2;

            return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
        }

    }

    public class Circle : IShape
    {
        private double _r;
        private const double _p = 3.14159265;
        public string shapeName { get; }

        public Circle(double r)
        {
            shapeName = "Circle";
            _r = r;
        }

        public double GetPerimetr()
        {
            return 2 * _p * _r;
        }

        public double GetSquare()
        {
            return _p * (_r * _r);
        }
    }


    //Create class Money (with base operations + and -)
    //public class Money

    /*Create class Unit and derived Warrior and Archer
    Both can Attack(Unit) and Defense();
    Warrior will have 50% of attack damage.(Воин получит 50 % от урона)
    ....Archer will have 70% chance to dodge attack at all but will have 120% damage.(т.е. он защититься на 50% от наносимого ему урона)
    ....Archer has 33% chance to have critical strike(crit damage = 200 % of base damage)
    ....Warrior will get only 70% of attack damage.(Лучник получит 70% процентов от урона )
    Base stats: Warrior(200HP, 20 AD),  Archer(120 HP, 35 AD)
    Simulate game with random unit turn first until death of opponent;
    Simulate game with 3x3 parties(attack random unit in opponent party) until full death of enemies.
    Simulate battle-royal N units vs all.*/


    public class Unit
    {

        virtual public void Attack(Unit unit){}
        virtual public int Defense(int attackDamage, string type, bool isItcriticalStrike = false) {
            return attackDamage;
        }
        public int _healthPoints;//очки жизни
        public int _attackDamage;// сила атаки
        public int _dodgeAttack; // уклон от атаки
        public int _criticalStrike;//критический урон
        public float _percentOfAttackDamage;// процент от урона
        public string type;
        public Unit(int healthPoints, int attackDamage, int dodgeAttack, int criticalStrike, int percentOfAttackDamage)
        {
            _healthPoints = healthPoints;
            _attackDamage = attackDamage;
            _dodgeAttack = dodgeAttack;
            _criticalStrike = criticalStrike;
            _percentOfAttackDamage = (float)percentOfAttackDamage / 100;
        }
    }
    public class Warrior : Unit
    {
        public Warrior() : base(200, 20, 0, 0, 50)
        {
            type = "Warrior";
        }

        override public void Attack(Unit unit)
        {
            unit._healthPoints = unit._healthPoints - unit.Defense(this._attackDamage, this.type);
        }

        override public int Defense(int attackDamage, string type, bool isItcriticalStrike = false)
        {
            if (isItcriticalStrike)
            {
                this._percentOfAttackDamage = 0.7f;
            }
            return attackDamage = (int)(attackDamage * this._percentOfAttackDamage);
        }
    }

    public class Archer : Unit
    {
        public Archer() : base(120, 35, 70, 33, 120)
        {
            type = "Archer";
        }

        override public void Attack(Unit unit)
        {
            Random random = new Random();
            int rand = random.Next(1, 100);
            bool randomResult;

            if (this._criticalStrike <= rand)
            {
                randomResult = true;
            }
            else
            {
                randomResult = false;
            }

            if (randomResult)
            {
                this._attackDamage = this._attackDamage * 2;
            }
            unit._healthPoints = unit._healthPoints - unit.Defense(this._attackDamage, this.type, randomResult);

        }

        override public int Defense(int attackDamage, string type, bool isItcriticalStrike = false)
        {

            Random random = new Random();
            int rand = random.Next(1, 100);
            bool randomResult;

            if (this._dodgeAttack <= rand)
            {
                randomResult = true;
            }

            else
            {
                randomResult = false;
            }

            if (randomResult)
            {
                attackDamage = 0;
            }
            else
            {
                attackDamage = (int)(attackDamage * this._percentOfAttackDamage);
            }

            return attackDamage;
        }
    }


    static public class GAME {

        static public void RUNGAME() {


            Unit warrior = new Warrior();
            Unit archer = new Archer();

            archer.Attack(warrior);

            Console.WriteLine($"Warrior2 = {warrior._healthPoints}");
            //Console.WriteLine($"Warrior2 = {warrior1._healthPoints}");


        }

        //Random random = new Random();
        //int rand = random.Next(1, 100);

        //if(_dodgeAttack <= rand)
        //{
        //    return true;
        //}
        //else
        //{
        //    return false;
        //}

        //Random random = new Random();
        //int whostart = random.Next(1, 2);
        //    if (whostart == 1)
        //    {

        //    }
    }






    
}
