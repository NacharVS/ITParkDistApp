using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
                           //ДВИЖУЮЩИЕСЯ ЮНИТЫ (ЛУЧНИКИ,СОЛДАТЫ И Т.Д.)------------------------
    class MovableUnits : Unit              /*НАСЛЕДУЕМ ОТ КСЛАССА Unit*/
    {
        public delegate void HealDelegate(string unitName, double unitHealth, double healCount);
        public delegate void DamageDelegate(string unitName, double unitHealth, double damageCount);
        public delegate void MaxHealthChangeDekegate(string unitName, double unitMaxHealthDiff);

        public string profession;   /*Создание профессии движующегося юнита*/
        public int speed;          /*Создание переменной  скорости движующегося юнита*/
        public int lxl;            /*Уровень прокачки*/
        public bool Salvation { get; set; }

        public override double Healt
        {
            get { return _healt; }
            set
            {
                double diff = Healt - value;
                if (diff > 0)
                {
                    DamageEvent?.Invoke(name, Healt, (int)diff);
                }
                else
                {
                    HealEvent?.Invoke(name, Healt, (int)diff);

                }
                if (value <= 0)
                {
                    if (Salvation)
                    {
                        SalvationActivate();
                        Salvation = false;
                    }
                    else
                    {
                        _healt = 0;
                        Termination();
                    }
                }
                else if (value > _maxHealth)
                {
                    _healt = _maxHealth;
                }
                else
                    _healt = value;

            }
        }

        public override double MaxHealth
        {
            get => _healt;
            set
            {
                var diff = _maxHealth - value;
                _maxHealth = value;
                MaxHealthEvent?.Invoke(name, Math.Abs(diff));
            }
        }

        public MovableUnits(string name, int healt, int armor, string profissionParam, int speedParam) : base(name, healt, armor)   /* <---КОНСТРУКТОР*/
        {
            profession = profissionParam;            /*Добавили в конструктор поля profession и speed чтобы мы через конструктор могли его заполнить*/
            speed = speedParam;
            Salvation = false;
            lxl = 0;
        }

        public void Move()   /*Метод передвижения двигующегося юнита*/
        {
            Console.WriteLine($"{profession} {name} передвигается со скоростью {speed}.Здоровье:{Healt}");
        }

        private void SalvationActivate()  /*  Метод спасения*/
        {
            Healt = _maxHealth;
            Console.WriteLine($"{name} спасён");
        }

        public event HealDelegate HealEvent;
        public event DamageDelegate DamageEvent;
        public event MaxHealthChangeDekegate MaxHealthEvent;

    }
}
