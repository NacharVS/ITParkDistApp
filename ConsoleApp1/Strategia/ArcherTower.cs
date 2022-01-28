﻿using ConsoleApp1.Strategia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategia
{
    
    class ArcherTower : Bildings    //Башня с лучником
    {
        private List<Archer> archers = new List<Archer>();              /*Список из класса Archer(Лучник)*/

        public ArcherTower() : base("1-ая башня с лучником", 150, 30)    /*Конструктор башни с лучниками*/
        {

            this.isFull = false;
            CanAttack = false;
        }

        public bool isFull { get; set; }              /*Переменная полная ли башня лучников*/
        public bool CanAttack { get; private set; }

        public void LoadArchers(Archer archer)     /*   Метод по зaгрузки лучников*/
        {
            if (archers.Count >= 5)                 /*Проверка на полноту башни*/
            {
                Console.WriteLine("В башне 5 лучников");
                isFull = true;
            }
            else
            {

                archers.Add(archer);            /* Добавление лучника*/
                CanAttack = true;
            }

        }

        public double Attack(Random rnd)    /*Метод атаки башни*/
        {
            double totalDamage = 0;


            foreach (var item in archers)
            {
                totalDamage += item.RangeAttack(rnd);

            }


            return totalDamage;
        }
    }
}
