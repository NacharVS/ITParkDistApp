﻿using ConsoleApp1.Strategy;
using System;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
       
        static void Main(string[] args)
        {
            //Store.StoreWorks.StoreWork();

            Random rnd = new Random();

            Peasant peasant1 = new Peasant("Ivan");
            Archer archer = new Archer("Legolas");
            Healer healer = new Healer("Gendalf", 20);
            Warrior war1 = new Warrior("Bob");
            Warrior war2 = new Warrior("John");
            war1.DamageEvent += Damage;
            war1.HealEvent += Heal;
            WathingTower wTower = new WathingTower();
            Catapult catapult = new Catapult();
            ArcherTower archerTower = new ArcherTower();
            Shaman shaman = new Shaman("Peter");
            healer.SalvationBuff(war1);
            shaman.FrenzyBuff(war2);
            Battle.Fight(war1, war2);


            // Health = Health + 5;

        }


        public static void Damage(string name, double health, double damagecount)
        {
            Console.WriteLine($"{name} with {health} HP. Injured by {damagecount}");
        }

        public static void Heal(string name, double health, double healcount)
        {
            Console.WriteLine($"{name} with {health} HP. Healed by {Math.Abs(healcount)}");
        }


        
            //Hospital hospital = new Hospital("imBurdenko", 30, 20);
            //Healer healer1 = new Healer("House", 3);

            //Archer archer2 = new Archer("Fedot");

            //archer.RangeAttack(peasant1, rnd);
            //peasant1.Info();

            //archer.Attack(archer2, rnd);
            //archer.Info();
            //archer2.Info();

            //archer.RangeAttack(healer1, rnd);
            //healer1.Info();

            //archer.RangeAttack(peasant1, rnd);
            //peasant1.Info();
            //peasant1.Repare(wTower);
            //archer.RangeAttack(peasant1, rnd);
            //peasant1.Repare(wTower);
            //peasant1.Info();

            //healer1.Cure(peasant1);

            //archer.RangeAttack(peasant1, rnd);
            //hospital.Cure(peasant1);
            //hospital.Cure(healer1);
            //peasant1.Repare(wTower);
            //peasant1.Info();
            //healer1.Info();

            //1. Доработать методы боя с учетом показателя Armor. 
            //2. Реализовать атаку катапульты по зданиям.
            //3.* Реализовать атаку катапульты по движущимся юнитам
            //4.** Доработать ArcherTower. 
            //В башне может быть до 5 лучников, чем больше лучников - тем больше урон. 
            //Если лучников нет, башня не атакует, если емть хотя бы 1 то атакует.

            // Реализовать новый юнит Shaman которыйможет накидывать ряд усилений. 
            // 1. BoostHealth - Увеличивает максимальное здоровье на 50%
            // 2. Frenzy - Увеличивает показатель урона на 1,5 и снижает показатель защиты 0.5
            // 3. StoneSkin - увеличивает показатель защиты в 2 раза, и снижает скорость в 2 раза
            // *все усиления могут накладывать только 1 раз на 1 юнита (не стакаються)

    }
}

//Console.WriteLine("Rows of mass1: ");
//int row1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Columns of mass1: ");
//int column1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Rows of mass2: ");
//int row2 = int.Parse(Console.ReadLine());
//Console.WriteLine("Columns of mass2: ");
//int column2 = int.Parse(Console.ReadLine());

//int[,] mass1 = new int[row1, column1];
//ArrayMethods.ArrayGeneration2(row1, column1, mass1);
//Console.WriteLine();
//Console.WriteLine();
//int[,] mass2 = new int[row2, column2];
//ArrayMethods.ArrayGeneration2(row2, column2, mass2);

//Shop.ShopWork();

/*
//массивы
int[] array = new int[10];
41int max = 10;
int min = 100;

Random random = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(10, 100);
    if (max <= array[i])
        max = array[i];
    if (min >= array[i])
        min = array[i];
    Console.Write($" {array[i]} ");
}
//сортировка
for(int j = 0; j < array.Length - 1; j++)
{
    for (int i = 0; i < array.Length - 1 - j; i++)
    {
        int buffer;
        if (array[i] >= array[i + 1])
        {
  041          buffer = array[i + 1];
            array[i + 1] = array[i];
            array[i] = buffer;
        }
    }
}

Console.WriteLine();


foreach (int item in array)
{
    Console.Write($" {item} ");
}
Console.WriteLine();
Console.WriteLine($"min = {min}, max = {max}");

//двумерный массив
Console.WriteLine("введите количество столбцов");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("введите количество строк");
int b041 = int.Parse(Console.ReadLine());
int[,] array2 = new int[a, b];
int summ = 0;
int[] sumRow = new int[b];
for(int i = 0; i < array2.GetLength(1); i++)
{
    for (int j = 0; j < array2.GetLength(0); j++)
    {
        array2[j, i] = random.Next(2);
        Console.Write($" {array2[j, i]} ");
        summ += array2[j, i];
    }
    sumRow[i] = summ;
    Console.WriteLine( $"                   сумма строки {summ}");
    Console.WriteLine();
    summ = 0;
}

for (int j = 0; j < sumRow.Length - 1; j++)
{
    for (int i = 0; i < sumRow.Length - 1 - j; i++)
    {041
        int buffer;
        if (sumRow[i] >= sumRow[i + 1])
        {
            buffer = sumRow[i + 1];
            sumRow[i + 1] = sumRow[i];
            sumRow[i] = buffer;
        }
    }
}

Console.WriteLine();

foreach (int item in sumRow)
{
    Console.Write($" {item} ");
}
*/

/*
//Combinations of 3 digits
Console.041WriteLine("Комбинации цифр для кодового замка. 3 цифры:");
Console.WriteLine("Enter the sum of digits: ");
int summ = int.Parse(Console.ReadLine());
int combinations = 0;
int n = 0; //порядковый номер комбинации
if (summ >= 3 & summ <= 24)     //проверка 0+1+2 - мин, 7+8+9 - макс.
{
    for (int i = 0; i < 10; i++)
    {
        for (int j = i + 1; j < 10; j++)
        {
            for (int k = j + 1; k < 10; k++)
            {
                if(i + j + k == summ)
                {
                    combinations++;
                    Console.WriteLine($"{combinations} -- {i}{j}{k}");
                }

            }

        }041
    }
    Console.WriteLine($"The sum of digits is {summ}");
    Console.WriteLine($"count {combinations}");
}
else Console.WriteLine("The sum of digits is incorrect");


Console.WriteLine();



//разложение на простые числа
//если число < 100, оно будет разлагаться на 2, 3, 5, 7 или само себя
//т.е. проверять можно только до 7 (11*11 = 121 > 100 -- на 11 не проверяем)
Console.WriteLine("enter number from 1 to 100 ");
int number = int.Parse(Console.ReadLine());
Console.Write($"{number}: ");
while(number%2 < 1)
{
    number = number / 2;
    Console.041Write(" 2 ");
}
while (number % 3 < 1)
{
    number = number / 3;
    Console.Write(" 3 ");
} 
while (number % 5 < 1)
{
    number = number / 5;
    Console.Write(" 5 ");
} 
while (number % 7 < 1)
{
    number = number / 7;
    Console.Write(" 7 ");
}
if(number > 1) Console.Write(number);
Console.WriteLine();
Console.WriteLine();

//MaxSum of dig041its
Console.WriteLine("enter number ");
int number1 = int.Parse(Console.ReadLine());
int sumDigit = 0;
int maxSumDigit = 0;
int numberResult = 0;

for(int i = 1; i <= number1; i++)
{
    int number2 = i;
    while (number2 > 0)
    {
        sumDigit += number2 % 10;
        number2 = number2 / 10;
    }

    if (maxSumDigit < sumDigit)
    {
        maxSumDigit = sumDigit;
        numberResult = i;
    }
    sumDigit = 0;041
}

Console.WriteLine($"Number {numberResult}  Sum of digits is: {maxSumDigit}");
*/

/*
//reverse of digit
Console.WriteLine("enter number ");
int number1 = int.Parse(Console.ReadLine());
double reverseDigit = 0;
int n = number1;
int n1 = 0;
while (n > 0)
{
    n1 = n1 + 1;
    n = n / 10;
}
while (number1 > 0)
{
    reverseDigit = reverseDigit + number1 % 10 * Math.Pow(10, n1 - 1);
    n1 = n1 - 1; 041
    number1 = number1 / 10;

}
Console.WriteLine($"The reverse digit is: {reverseDigit}");


//sum of digit
Console.WriteLine("enter number ");
int number = int.Parse(Console.ReadLine());
int sumDigit = 0;
while (number > 0)
{
    sumDigit += number % 10;
    number = number / 10;
}
Console.WriteLine($"Sum of digit is: {sumDigit}");

//степень
Console.WriteLine("enter a ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("e041nter b ");
int b = int.Parse(Console.ReadLine());
int result = a;
for (int i = b; i > 1; i--)
{
    result = result * a;
}
Console.WriteLine($"a в степени b = {result}");

//Deposit
Console.WriteLine("Enter the sum of deposit");
double sum = double.Parse(Console.ReadLine());
Console.WriteLine("Enter how many mounths deposit lasts: ");
int mounth = int.Parse(Console.ReadLine());
double interest = 4;
Console.WriteLine($"The interest is {interest} per mounth");


for (int i = mounth; i > 0; i--)
{
    sum = sum * (1 + interest/100);
}041
Console.WriteLine($"The sum with interest is: {sum}");
*/

/*
//MiddleDigit
Console.WriteLine("enter digit1 ");
int digit1 = int.Parse(Console.ReadLine());
Console.WriteLine("enter digit2 ");
int digit2 = int.Parse(Console.ReadLine());
Console.WriteLine("enter digit3 ");
int digit3 = int.Parse(Console.ReadLine());

if (digit1 > digit2 & digit1 < digit3 | digit1 > digit3 & digit1 < digit2)
    Console.WriteLine ( $"The Middle digit is {digit1}");
else if (digit2 > digit1 & digit2 < digit3 | digit2 > digit3 & digit2 < digit1)
    Console.WriteLine($"The Middle digit is {digit2}");
else if (digit3 > digit1 & digit3 < digit2 | digit3 > digit2 & digit3 < digit1)
    Console.WriteLine($"The Middle digit is {digit3}");
else Console.WriteLine("There is no correct middle digit among these digits");
Console.WriteLine();
041
//ThreeDigitNumber
Console.WriteLine ("Please enter three-digit number ");
int threeDigitNumber = int.Parse (Console.ReadLine());

digit1 = threeDigitNumber % 10;
digit3 = threeDigitNumber / 100;
digit2 = (threeDigitNumber - digit3 * 100) / 10;

if (threeDigitNumber % 2 == 0)
    Console.WriteLine ($"The sum of digits is {digit1 + digit2 + digit3}");
else
    Console.WriteLine ($"The multiplication of digits is {digit1 * digit2 * digit3}");
Console.WriteLine();

//Area
Console.WriteLine ("Choose the figure: square, circle, rectangle, triangle");

string figure = Console.ReadLine();
figure = figure.ToLower();
switch (figure)
{
    case "square":
        Console.WriteLine ("enter the side length");
        double side = double.Parse (Console.ReadLine());
        Console.WriteLine ($"Area of the square is: {side * side}");
        break;
    case "circle":
        Console.WriteLine("enter the radius length");
        double radius = double.Parse(Console.ReadLine());
        Console.WriteLine($"Area of the circle is: {Math.PI * radius * 2}");
        break;
    case "rectangle":
        Console.WriteLine("enter the length of first side");
        double side1 = double.Parse(Console.ReadLine());
        Console.WriteLine("enter the length of first side");
        double side2 = double.Parse(Console.ReadLine());
        Console.WriteLine($"Area of the rectangle is: {side1 * side2}");
        break;
    case "triangle":
        Console.WriteLine("enter the length of the side");
        double side3 = double.Parse(Console.ReadLine());
        Console.WriteLine("enter the length of the triangle height");
        double height = double.Parse(Console.ReadLine());
        Console.WriteLine($"Area of the triangle is: {side3 * height / 2}");
        break;
    default:
        Console.WriteLine("incorrect input");
        break;
}
Console.WriteLine();

//Deposit
Console.WriteLine ("Enter the sum of deposit");
double sum = double.Parse (Console.ReadLine());
Console.WriteLine ("Enter how many mounths deposit lasts: ");
int mounth = int.Parse(Console.ReadLine());
double interest = 4;
Console.WriteLine($"The interest is {interest} per mounth");

Console.WriteLine($"The sum with interest is: {sum * Math.Pow(1 + interest/100, mounth)}");
*/


//double footDistance = double.Parse(Console.ReadLine()); //0.305 metr
//double metrDistance = double.Parse(Console.ReadLine());
/*
Console.WriteLine( "enter Speed meter/sec");
double msSpeed = double.Parse(Console.ReadLine());
Console.WriteLine("enter Speed km/h");
double kmhSpeed = double.Parse(Console.ReadLine()); // *1000/3600

if (msSpeed > kmhSpeed * 1000 / 3600)
{
    Console.WriteLine ( $"max Speed is:{msSpeed}  meter/sec");
}
else
{
    Console.WriteLine($"max Speed is:{kmhSpeed}  km/h");
}
*/


