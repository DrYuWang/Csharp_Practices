using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_ofStuct_FavoriteFood
{
    class Program
    {

        // Write a method that receives a customer name, cutomers list and orders list. The method returns food item(s) that the given customer has ordered. For example, 
        // if the method recieves "Naruto", it should returns "Miso Chashu Ramen".
        struct Order
        {
            public List<string> FoodItems;
            public int customerId;
            public bool toStay;
            public int orderID;
        }
        struct Customer
        {
            public string Name;
            public int customerId;
        }

        static void Main(string[] args)
        {
            var naruto = new Customer() { Name = "Naruto", customerId = 1 }; // Miso Chashu
            var goku = new Customer() { Name = "Goku", customerId = 2 };   // Rice Dragon Ball
            var ryuk = new Customer() { Name = "Ryuk", customerId = 3 };   // Ryuk: Apples
            List<Customer> customers = new List<Customer> { naruto, goku, ryuk, new Customer() { Name = "Kamran", customerId = -1 } };

            List<Order> orders = new List<Order>()
            {
                new Order() {customerId = 1, FoodItems = new List<string>(){"Miso Chashu Ramen"}, orderID = 1,  toStay = true },
                new Order() {customerId = 2 , FoodItems = new List<string>() {"Rice Dragon Ball"}, orderID = 2,  toStay = true },
                new Order() {customerId = 3, FoodItems = new List<string>() {"Apples"}, orderID = 3,  toStay = false }
            };

            var favoriteFoods = GetFoodItems("Naruto", customers, orders);
            for (int i = 0; i < favoriteFoods.Count; i++)
            {
                Console.WriteLine(favoriteFoods[i]);
            }
        }
        static List<String> GetFoodItems(string customernames, List<Customer> customers, List<Order> orders)
        {
            List<String> foods= new List<string>();
            for (int i = 0; i < customers.Count; i++)
            {
                if (customernames == customers[i].Name)
                {
                    for (int j = 0; i < orders.Count; j++)
                    {
                        if (customers[i].customerId == orders[j].customerId)
                        { foods.AddRange(orders[j].FoodItems) } 
                    }
                }

            }
            return foods;
        }            
    }
}
