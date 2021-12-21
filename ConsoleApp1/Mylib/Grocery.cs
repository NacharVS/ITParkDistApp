using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Mylib
{
    class Grocery
    {
        int groceryID;
        string name;
        int price;
        int quantityInStock;

        public static Grocery GroceryFormation(int groceryID, string name, int price, int quantityInStock)
        {
            Grocery grocery = new Grocery();
            grocery.groceryID = groceryID;
            grocery.name = name;
            grocery.price = price;
            grocery.quantityInStock = quantityInStock;

            return grocery;
        }

        public static void  GetGroceryList(List<Grocery> grocery)
        {
            GroceryFormation(1, "Bread", 26, 75);

            List<Grocery> groceryList = new List<Grocery>();

            groceryList.Add(GroceryFormation(1, "Bread", 26, 75));
            groceryList.Add(GroceryFormation(2, "Egg", 7, 65));
            groceryList.Add(GroceryFormation(3, "Milk", 60, 61));
            groceryList.Add(GroceryFormation(4, "Cheese", 450, 42));
            groceryList.Add(GroceryFormation(5, "Butter", 120, 99));
            groceryList.Add(GroceryFormation(6, "Potatoes", 42, 47));
            groceryList.Add(GroceryFormation(7, "Carrots", 35, 55));
            groceryList.Add(GroceryFormation(8, "Onions", 30, 77));
            groceryList.Add(GroceryFormation(9, "Cabbage", 45, 80));
        }

        public static void PrintGroceryList(List<Grocery> groceryList)
        {
            Console.WriteLine();
            for (int i = 0; i < groceryList.Count; i++)
            {
                Console.WriteLine($"{groceryList[i].groceryID}.  {groceryList[i].name} / {groceryList[i].price} / {groceryList[i].quantityInStock}");
            }
        }

        public static bool CheckNewGrocery(List<Grocery> groceryList, ref string newName)
        {
            newName = newName.ToLower();

            for (int i = 0; i < groceryList.Count; i++)
            {
                string bufferName = groceryList[i].name.ToLower();

                if (newName == bufferName)
                {
                    return true;
                }
            }
            newName = Char.ToUpper(newName[0]) + newName.Substring(1);
            return false;
        }
    }
}
