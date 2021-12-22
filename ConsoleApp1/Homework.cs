using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Mylib;

namespace ConsoleApp1
{
    class Homework
    {
        public static void Homework_3_1()
        {
            //Entering the sum of three numbers.
            Console.WriteLine("Enter the sum of numbers in the range from 3 to 24:");
            int summ = int.Parse(Console.ReadLine());

            int combinationCount = 0;// 2 (0, 1, 2) < summ < 25 (7, 8, 9).

            //Checking a summ is in the correct range.
            if (summ > 2 && summ < 25)
            {
                //Matching small numbers in combination.
                for (int i = 0; i <= 9; i++)
                {
                    //Matching averages numbers in combination
                    for (int j = 0; j <= 9; j++)
                    {
                        //Matching larges numbers in combination.
                        for (int k = 0; k <= 9; k++)
                        {
                            //Selection condition for a combination of three digits.
                            if (i + j + k == summ && i < j && j < k)
                            {

                                Console.WriteLine($"{i}{j}{k}");

                                combinationCount++;
                            }
                        }
                    }
                }
            }

            else Console.WriteLine("You entered the wrong number. The number must be between 3 and 24!");

            Console.WriteLine($" count {combinationCount}");
        }

        public static void Homework_3_2()
        {
            // Дана числовая последовательность от 1 до N. Найти такое число сумма цифр которого будет
            // наибольшей среди всей последовательности. Вывести само число и его сумму цифр
            // input 20 output 19 10
            // input 44 output 39 12
            Console.WriteLine("Enter number N;");
            int number = int.Parse(Console.ReadLine());

            while (number > 1)
            {
                for (int i = 2; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        number = number / i;

                        Console.Write($"{i} ");
                        break;
                    }
                }
            }

        }

        public static void Homework_3_3()
        {
            // Дана числовая последовательность от 1 до N. Найти такое число сумма цифр которого будет
            // наибольшей среди всей последовательности. Вывести само число и его сумму цифр
            // input 20 output 19 10
            // input 44 output 39 12

            Console.WriteLine("Enter number N;");
            int n = int.Parse(Console.ReadLine());

            int maxNumber = 0;
            int maxSumm = 0;

            //Iterate through all digits of the sequence.
            for (int i = 1; i <= n; i++)
            {
                int number = i;
                int summ = 0;

                //Finding the sum of the digits of the number i from the sequence.
                while (number > 0)
                {
                    summ = summ + number % 10;
                    number = number / 10;
                }

                if (maxSumm < summ)
                {
                    maxSumm = summ;
                    maxNumber = i;
                }
            }

            Console.WriteLine($"The number: {maxNumber} has the largest sum of digits: {maxSumm} among all the numbers in the sequence from 1 to {n}");
        }
    
        public static void Homework_4()
        {
            List<string> groceryList = new List<string>();
            List<int> priceList = new List<int>();

            List<string> klientProductList = new List<string>();
            List<int> klientQuantityList = new List<int>();
            List<int> klientSumList = new List<int>();

            int terminalOperation = 1;
            int adminChangeList = 0;
            int klientChoiceProduct = 0;
            int productBasket = 0;

            int summ = 0;
            int klientMoney = 0;

            //List of products
            groceryList.Add("Bread");
            groceryList.Add("Egg");
            groceryList.Add("Milk");
            groceryList.Add("Cheese");
            groceryList.Add("Butter");
            groceryList.Add("Potatoes");
            groceryList.Add("Carrots");
            groceryList.Add("Onions");
            groceryList.Add("Cabbage");

            //List of price
            priceList.Add(26);
            priceList.Add(7);
            priceList.Add(60);
            priceList.Add(450);
            priceList.Add(120);
            priceList.Add(42);
            priceList.Add(35);
            priceList.Add(30);
            priceList.Add(45);



            //Terminal cycle
            while (terminalOperation == 1)
            {
                Console.WriteLine();
                Console.WriteLine("Go to the terminal if as an administrator then select 0 if as a client then 1.");
                int adminOrClient = int.Parse(Console.ReadLine());

                if (adminOrClient == 0) adminChangeList = 1;
                else if (adminOrClient == 1)
                {
                    klientChoiceProduct = 1;
                    Console.WriteLine();
                    Console.WriteLine("Enter your account balance:");
                    klientMoney = int.Parse(Console.ReadLine());
                    summ = 0;
                }
                else Console.WriteLine("You entered the wrong answer.");

                //Administrator work cycle
                while (adminChangeList == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("You want to change the list of products? If you want enter 1, not - 0.");
                    int answerToChange = int.Parse(Console.ReadLine());

                    switch (answerToChange)
                    {
                        case 0:
                            adminChangeList = 0;
                            break;

                        //Change the list of products
                        case 1:
                            Console.WriteLine("If you want to add - enter 1, remove - 0");
                            int answerToAddOrRemove = int.Parse(Console.ReadLine());

                            switch (answerToAddOrRemove)
                            {
                                //Remove a product
                                case 0:
                                    Console.WriteLine();
                                    for (int i = 0; i < groceryList.Count; i++)
                                    {
                                        Console.WriteLine($"{i + 1}.{groceryList[i]} / {priceList[i]}");
                                    }

                                    Console.WriteLine();
                                    Console.WriteLine("Enter product number:");
                                    int productNumber = int.Parse(Console.ReadLine()) - 1;
                                    groceryList.RemoveAt(productNumber);
                                    priceList.RemoveAt(productNumber);

                                    Console.WriteLine();
                                    for (int i = 0; i < groceryList.Count; i++)
                                    {
                                        Console.WriteLine($"{i + 1}.{groceryList[i]} / {priceList[i]}");
                                    }

                                    break;

                                //Add a new product
                                case 1:
                                    Console.WriteLine();
                                    for (int i = 0; i < groceryList.Count; i++)
                                    {
                                        Console.WriteLine($"{i + 1}.{groceryList[i]} / {priceList[i]}");
                                    }

                                    Console.WriteLine();
                                    Console.WriteLine("Write the name of the product:");
                                    string newProduct = Console.ReadLine();

                                    Console.WriteLine();
                                    Console.WriteLine("Enter a price for a new product:");
                                    int newPrice = int.Parse(Console.ReadLine());


                                    if (groceryList.Contains(newProduct) == false)
                                    {
                                        groceryList.Add(newProduct);
                                        priceList.Add(newPrice);

                                        //groceryList.Sort();

                                        Console.WriteLine();
                                        for (int i = 0; i < groceryList.Count; i++)
                                        {
                                            Console.WriteLine($"{i + 1}.{groceryList[i]} / {priceList[i]}");
                                        }
                                    }

                                    else
                                    {
                                        Console.WriteLine("This product is already on the list!");

                                        Console.WriteLine();
                                        for (int i = 0; i < groceryList.Count; i++)
                                        {
                                            Console.WriteLine($"{i + 1}.{groceryList[i]} / {priceList[i]}");
                                        }
                                    }

                                    break;

                                default:
                                    Console.WriteLine("You entered the wrong answer.");
                                    break;
                            }

                            break;



                        default:
                            Console.WriteLine("You entered the wrong answer.");
                            break;
                    }

                }

                //Cart selection cycle
                while (klientChoiceProduct == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine($"You have selected products for the amount: {summ}. You have left: {klientMoney - summ}");

                    Console.WriteLine();
                    Console.WriteLine("You want to add/ remove a product to your cart? If you want add enter 1, if remove enter 2, if not - 0.");
                    int addToBasket = int.Parse(Console.ReadLine());

                    int sumProduct;
                    int productNumber;

                    switch (addToBasket)
                    {

                        case 0:
                            klientChoiceProduct = 0;
                            productBasket = 1;
                            break;

                        //Add product
                        case 1:
                            Console.WriteLine();

                            for (int i = 0; i < groceryList.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}.{groceryList[i]} / {priceList[i]}");
                            }

                            Console.WriteLine();
                            Console.WriteLine("Enter product number:");
                            productNumber = int.Parse(Console.ReadLine()) - 1;

                            Console.WriteLine();
                            Console.WriteLine("Enter quantity:");
                            int productQuantity = int.Parse(Console.ReadLine());

                            sumProduct = productQuantity * priceList[productNumber];

                            summ += sumProduct;

                            klientProductList.Add(groceryList[productNumber]);
                            klientQuantityList.Add(productQuantity);
                            klientSumList.Add(sumProduct);

                            break;
                        //Remove product
                        case 2:
                            Console.WriteLine();

                            for (int i = 0; i < klientProductList.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}.{klientProductList[i]} / {klientQuantityList[i]} - {klientSumList[i]}");
                            }

                            Console.WriteLine();
                            Console.WriteLine("Enter product number:");
                            productNumber = int.Parse(Console.ReadLine()) - 1;

                            summ -= klientSumList[productNumber];

                            klientProductList.RemoveAt(productNumber);
                            klientQuantityList.RemoveAt(productNumber);
                            klientSumList.RemoveAt(productNumber);

                            break;

                        //error
                        default:
                            Console.WriteLine();
                            Console.WriteLine("You entered the wrong answer.");
                            break;
                    }
                }

                while (productBasket == 1)
                {
                    if (klientMoney > summ)
                    {
                        Console.WriteLine();
                        Console.WriteLine("You have selected the following products.");
                        Console.WriteLine();

                        for (int i = 0; i < klientProductList.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}.{klientProductList[i]} / {klientQuantityList[i]} - {klientSumList[i]}");
                        }

                        Console.WriteLine($"Total: {summ}");

                        productBasket = 0;

                        Console.WriteLine("Buy? If yes - enter 1, if no - 0.");
                        int buy = int.Parse(Console.ReadLine());

                        switch (buy)
                        {
                            case 0:
                                klientChoiceProduct = 1;
                                break;

                            case 1:
                                Console.WriteLine();
                                Console.WriteLine("You bought the following products.");
                                Console.WriteLine();
                                for (int i = 0; i < klientProductList.Count; i++)
                                {
                                    Console.WriteLine($"{i + 1}.{klientProductList[i]} / {klientQuantityList[i]} - {klientSumList[i]}");
                                }

                                Console.WriteLine($"Total: {summ}");
                                Console.WriteLine();
                                Console.WriteLine($"Your change: {klientMoney - summ}.");

                                terminalOperation = 0;
                                break;


                            //error
                            default:
                                Console.WriteLine();
                                Console.WriteLine("You entered the wrong answer.");
                                break;
                        }
                    }

                    else
                    {
                        Console.WriteLine("You don't have enough money!");
                        productBasket = 0;
                        klientChoiceProduct = 1;
                    }
                }
            }
        }

        public static void Homework_5()
        {
            bool key = true;

            int sizeA;
            int sizeB;

            int sizeA1;
            int sizeA2;
            int sizeB1;
            int sizeB2;

            int[,] arrayA;
            int[,] arrayB;

            Random rnd = new Random();

            int[,] arraySum;



            while (key)
            {
                Console.WriteLine();
                Console.WriteLine("Select job number or exit 1/ 2/ 3 or 0:");
                int jobNumber = int.Parse(Console.ReadLine());

                switch (jobNumber)
                {
                    case 0:
                        key = false;
                        break;

                    case 1:
                        sizeA = Library.GetSize("Enter the size of the first matrix:");
                        sizeB = Library.GetSize("Enter the size of the second matrix:");

                        arrayA = new int[sizeA, sizeA];
                        ArrayOperations.ArrayGeneration(arrayA, rnd);

                        arrayB = new int[sizeB, sizeB];
                        ArrayOperations.ArrayGeneration(arrayB, rnd);

                        arraySum = ArrayOperations.ArraySumm1(arrayA, arrayB);

                        ArrayOperations.PrintArray(arraySum);

                        break;

                    case 2:
                        sizeA1 = Library.GetSize("Enter the size one of the first array:");
                        sizeA2 = Library.GetSize("Enter the size two of the first array:");
                        sizeB1 = Library.GetSize("Enter the size one of the second array:");
                        sizeB2 = Library.GetSize("Enter the size two of the second array:");

                        arrayA = new int[sizeA1, sizeA2];
                        ArrayOperations.ArrayGeneration(arrayA, rnd);

                        arrayB = new int[sizeB1, sizeB2];
                        ArrayOperations.ArrayGeneration(arrayB, rnd);

                        arraySum = ArrayOperations.ArraySumm2(arrayA, arrayB);

                        ArrayOperations.PrintArray(arraySum);

                        break;

                    case 3:
                        sizeA1 = Library.GetSize("Enter the size one of the first array:");
                        sizeA2 = Library.GetSize("Enter the size two of the first array:");
                        sizeB1 = Library.GetSize("Enter the size one of the second array:");
                        sizeB2 = Library.GetSize("Enter the size two of the second array:");

                        arrayA = new int[sizeA1, sizeA2];
                        ArrayOperations.ArrayGeneration(arrayA, rnd);

                        arrayB = new int[sizeB1, sizeB2];
                        ArrayOperations.ArrayGeneration(arrayB, rnd);

                        arraySum = ArrayOperations.ArraySumm3(arrayA, arrayB);

                        ArrayOperations.PrintArray(arraySum);

                        break;

                    default:
                        Console.WriteLine("You entered the wrong job number!");
                        break;
                }
            }

        }

        public static void Homework_6_1()
        {
            int[,] array = new int[10, 10];
            ArrayOperations.ArrayGeneration(array, 10);

            SummID[] summId = new SummID[array.GetLength(0)];

            for (int i = 0; i < summId.Length; i++)
            {
                summId[i] = new SummID();
            }

            ArrayOperations.ArrayRowSumm(array, summId);

            SummID.PrintArraySummID(summId);

            SummID.ArraySummIDSorting(summId);

            SummID.PrintArraySummID(summId);
        }

        public static void Homework_6_2()
        {
            
            List<Grocery> groceryList = new List<Grocery>();
            List<int> priceList = new List<int>();

            List<string> klientProductList = new List<string>();
            List<int> klientQuantityList = new List<int>();
            List<int> klientSumList = new List<int>();

            bool terminalOperation = true;
            bool adminChangeList = false;
            bool klientChoiceProduct = false;
            bool productBasket = false;

            int summ = 0;
            int klientMoney = 0;

            //List of products
            Grocery.GetGroceryList(groceryList);

            //Terminal cycle
            while (terminalOperation)
            {
                string adminOrClient = Library.GetDataQuestionST("Admin or Klient? (A/K)");

                switch (adminOrClient)
                {
                    case "a":
                        adminChangeList = true;
                        break;

                    case "k":
                        klientChoiceProduct = true;
                        Console.WriteLine();
                        Console.WriteLine("Enter your account balance:");
                        klientMoney = int.Parse(Console.ReadLine());
                        summ = 0;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("You entered the wrong answer!");
                        break;
                }

                //Administrator work cycle
                while (adminChangeList)
                {
                    string answerToChangeAdminList = Library.GetDataQuestionST("Do you want to change the list of products? (Y/N)");

                    switch (answerToChangeAdminList)
                    {
                        //Change the list of products
                        case "y":
                            
                            string answerToAddOrRemove = Library.GetDataQuestionST("Do you want to add/remove grocery? (A/R)");

                            switch (answerToAddOrRemove)
                            {
                                //Add a new product
                                case "a":
                                    Grocery.PrintGroceryList(groceryList);

                                    int newGroceryID = groceryList.Count + 1;

                                    string newName = Library.GetDataQuestionST("Write the name of the product:");

                                    int newPrice = Library.GetDataQuestionIN("Enter a new product price:");

                                    int newQuantityInStock = Library.GetDataQuestionIN("Enter a new product quantity:");

                                    if (Grocery.CheckNewGrocery(groceryList, ref newName))
                                    {
                                        Console.WriteLine("This product is already on the list!");

                                        Grocery.PrintGroceryList(groceryList);
                                    }

                                    else
                                    {
                                        newName = Char.ToUpper(newName[0]) + newName.Substring(1);

                                        groceryList.Add(Grocery.GroceryFormation(newGroceryID, newName, newPrice, newQuantityInStock));

                                        Grocery.PrintGroceryList(groceryList);
                                    }
                                    break;

                                //Remove a product
                                case "r":
                                    Grocery.PrintGroceryList(groceryList);

                                    groceryList.RemoveAt(Library.GetDataQuestionIN("Enter product number:") - 1);

                                    Grocery.SortingGroceryList(groceryList);
                                    Grocery.PrintGroceryList(groceryList);
                                    break;
                                default:
                                    Console.WriteLine();
                                    Console.WriteLine("You entered the wrong answer!");
                                    break;
                            }
                            break;

                        case "n":
                            adminChangeList = false;
                            break;

                        default:
                            Console.WriteLine();
                            Console.WriteLine("You entered the wrong answer!");
                            break;
                    }

                }

                //Cart selection cycle
                while (klientChoiceProduct)
                {
                    Console.WriteLine();
                    Console.WriteLine($"You have selected products for the amount: {summ}. You have left: {klientMoney - summ}");

                    string answerToChangeKlienList = Library.GetDataQuestionST("Do you want to change the list of products in cart? (Y/N)");

                    switch(answerToChangeKlienList)
                    {
                        case "y":
                                                
                            int sumProduct;
                            int productNumber;

                            string addToBasket = Library.GetDataQuestionST("Do you want to add/remove a product to your cart? (A/R)");

                            switch (addToBasket)
                            {
                                //Add product
                                case "a":


                                    Console.WriteLine();

                                    for (int i = 0; i < groceryList.Count; i++)
                                    {
                                        Console.WriteLine($"{i + 1}.{groceryList[i]} / {priceList[i]}");
                                    }

                                    Console.WriteLine();
                                    Console.WriteLine("Enter product number:");
                                    productNumber = int.Parse(Console.ReadLine()) - 1;

                                    Console.WriteLine();
                                    Console.WriteLine("Enter quantity:");
                                    int productQuantity = int.Parse(Console.ReadLine());

                                    sumProduct = productQuantity * priceList[productNumber];

                                    summ += sumProduct;

                                    //klientProductList.Add(groceryList[productNumber]);
                                    klientQuantityList.Add(productQuantity);
                                    klientSumList.Add(sumProduct);

                                    break;
                                //Remove product
                                case 2:
                                    Console.WriteLine();

                                    for (int i = 0; i < klientProductList.Count; i++)
                                    {
                                        Console.WriteLine($"{i + 1}.{klientProductList[i]} / {klientQuantityList[i]} - {klientSumList[i]}");
                                    }

                                    Console.WriteLine();
                                    Console.WriteLine("Enter product number:");
                                    productNumber = int.Parse(Console.ReadLine()) - 1;

                                    summ -= klientSumList[productNumber];

                                    klientProductList.RemoveAt(productNumber);
                                    klientQuantityList.RemoveAt(productNumber);
                                    klientSumList.RemoveAt(productNumber);

                                    break;

                                //error
                                default:
                                    Console.WriteLine();
                                    Console.WriteLine("You entered the wrong answer.");
                                    break;
                            }
                            break;

                        case "n":
                            klientChoiceProduct = false;
                            productBasket = true;
                            break;

                        default:
                            break;
                    }



                    

                    

                    
                }

                while (productBasket)
                {
                    if (klientMoney > summ)
                    {
                        Console.WriteLine();
                        Console.WriteLine("You have selected the following products.");
                        Console.WriteLine();

                        for (int i = 0; i < klientProductList.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}.{klientProductList[i]} / {klientQuantityList[i]} - {klientSumList[i]}");
                        }

                        Console.WriteLine($"Total: {summ}");

                        productBasket = false;

                        Console.WriteLine("Buy? If yes - enter 1, if no - 0.");
                        int buy = int.Parse(Console.ReadLine());

                        switch (buy)
                        {
                            case 0:
                                klientChoiceProduct = true;
                                break;

                            case 1:
                                Console.WriteLine();
                                Console.WriteLine("You bought the following products.");
                                Console.WriteLine();
                                for (int i = 0; i < klientProductList.Count; i++)
                                {
                                    Console.WriteLine($"{i + 1}.{klientProductList[i]} / {klientQuantityList[i]} - {klientSumList[i]}");
                                }

                                Console.WriteLine($"Total: {summ}");
                                Console.WriteLine();
                                Console.WriteLine($"Your change: {klientMoney - summ}.");

                                terminalOperation = false;
                                break;


                            //error
                            default:
                                Console.WriteLine();
                                Console.WriteLine("You entered the wrong answer.");
                                break;
                        }
                    }

                    else
                    {
                        Console.WriteLine("You don't have enough money!");
                        productBasket = false;
                        klientChoiceProduct = true;
                    }
                }
            }
            
        }
    }
}





