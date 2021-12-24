using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Mylib
{
    class Admin
    {
        public List<Product> productList = new List<Product>();

        public void GetStartProductList()
        {
            AddNewProduct("Bread", 26, 75);
            AddNewProduct("Egg", 7, 65);
            AddNewProduct("Milk", 60, 61);
            AddNewProduct("Cheese", 450, 42);
            AddNewProduct("Butter", 120, 99);
            AddNewProduct("Potatoe", 42, 47);
            AddNewProduct("Carrots", 35, 55);
            AddNewProduct("Onions", 30, 77);
            AddNewProduct("Cabbage", 45, 80);
        }

        public void AddNewProduct(string newName, double newPrice, double newQuantityInStock)
        {
            productList.Add(new Product(newName, newPrice, newQuantityInStock));
        }

        public void RemoveProduct(int index)
        {
            if (index < productList.Count())
            {
                productList.RemoveAt(index - 1);
                PrintProductList();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("You entered the wrong number!");
            }
        }

        public void PrintProductList()
        {
            Console.WriteLine();
            for (int i = 0; i < productList.Count; i++)
            {
                Console.Write($"{i + 1}.\t");
                productList[i].PrintProduct();
            }
        }

        public void CheckNewProduct(string newName, double newPrice, double newQuantityInStock)
        {
            bool flag;
            
            newName = newName.ToLower();

            for (int i = 0; i < productList.Count; i++)
            {
                string bufferName = productList[i].name.ToLower();

                if (newName == bufferName)
                {
                    flag =  true;
                }
            }
            newName = Char.ToUpper(newName[0]) + newName.Substring(1);
            flag = false;

            if (flag)
            {
                Console.WriteLine("This product is already on the list!");

                PrintProductList();
            }

            else
            {
                newName = Char.ToUpper(newName[0]) + newName.Substring(1);

                AddNewProduct(newName, newPrice, newQuantityInStock);

                PrintProductList();
            }















            
        }
    }
}
