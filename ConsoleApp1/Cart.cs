using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Cart
    {
        int cartID;
        string name;
        int price;
        int cost;
        int quantity;
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

        public static Grocery CartFormation(int cartID, string name, int quantity, int cost)
        {
            Grocery cart = new Grocery();
            cart.cartID = cartID;
            cart.name = name;
            cart.quantity = quantity;
            cart.cost = cost;

            return cart;
        }

        public static List<Grocery> GetGroceryList(List<Grocery> groceryList)
        {
            groceryList.Add(GroceryFormation(1, "Bread", 26, 75));
            groceryList.Add(GroceryFormation(2, "Egg", 7, 65));
            groceryList.Add(GroceryFormation(3, "Milk", 60, 61));
            groceryList.Add(GroceryFormation(4, "Cheese", 450, 42));
            groceryList.Add(GroceryFormation(5, "Butter", 120, 99));
            groceryList.Add(GroceryFormation(6, "Potatoe", 42, 47));
            groceryList.Add(GroceryFormation(7, "Carrots", 35, 55));
            groceryList.Add(GroceryFormation(8, "Onions", 30, 77));
            groceryList.Add(GroceryFormation(9, "Cabbage", 45, 80));

            return groceryList;
        }

        public static void PrintGroceryList(List<Grocery> groceryList)
        {
            Console.WriteLine();
            for (int i = 0; i < groceryList.Count; i++)
            {
                Console.WriteLine($"{groceryList[i].groceryID}.\t{groceryList[i].name}\t{groceryList[i].price}\t{groceryList[i].quantityInStock}");
            }
        }

        public static void PrintCartList(List<Grocery> cartList)
        {
            Console.WriteLine();
            for (int i = 0; i < cartList.Count; i++)
            {
                Console.WriteLine($"{cartList[i].cartID}.\t{cartList[i].name}\t{cartList[i].quantity}\t{cartList[i].cost}");
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

        public static void SortingGroceryList(List<Grocery> groceryList)
        {
            for (int i = 0; i < groceryList.Count; i++)
            {
                groceryList[i].groceryID = i + 1;
            }
        }
    }
}
