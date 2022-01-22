using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategy
{
                           //ДВИЖУЮЩИЕСЯ ЮНИТЫ (ЛУЧНИКИ,СОЛДАТЫ И Т.Д.)------------------------
    class MovableUnits : Unit              /*НАСЛЕДУЕМ ОТ КСЛАССА Unit*/
    {
        public string profession;   /*Создание профессии движующегося юнита*/
        public int speed;          /*Создание переменной  скорости движующегося юнита*/
        public int lxl;            /*Уровень прокачки*/

        public MovableUnits(string name, int healt, int armor, string profissionParam, int speedParam) : base(name, healt, armor)   /* <---КОНСТРУКТОР*/
        {
            profession = profissionParam;            /*Добавили в конструктор поля profession и speed чтобы мы через конструктор могли его заполнить*/
            speed = speedParam;
        }

        public void Move()   /*Метод передвижения двигующегося юнита*/
        {
            Console.WriteLine($"{profession} {name} передвигается со скоростью {speed}.Здоровье:{Healt} HP" );
        }
    }
}
