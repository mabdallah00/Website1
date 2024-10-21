using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Website1
{
    // Base class
     class PartyStore
    {
        // Properties
        public string Product { get; set; }
        public string Contact { get; set; }
        public string Location { get; set; }
        public int Price { get; set; }
        public string PhoneNumber { get; set; }

        // Constructor 
        public PartyStore (string product, string contact, string location, int price, string phonenumber)
        {
            Product = product;
            Contact = contact;
            Location = location;
            Price = price;
            PhoneNumber = phonenumber;
        }

        // Methods
        public void Read(int numPrice)
        {
            if (numPrice > Price)
            {
                Console.WriteLine($"You've read the price for all products, all {Price} price!");
            }
            else
            {
                Console.WriteLine($"You've read {numPrice} price of {Product}.");
            }
        }

        public string GetSummary()
        {
            return $"{Product} by {Price}, Contact by {Contact}, Location: {Location}, {PhoneNumber} phonenumber.";
        }
    }

    // Container Application
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the Book class 
            PartyStore myProduct = new PartyStore("Party Supplies", "Saieda the Party Store", "Chicago", 5-1000, "773-123-4567");

            // Print the Properties 
            Console.WriteLine("PartyStore Properties:");
            Console.WriteLine($"Product: {myProduct.Product}");
            Console.WriteLine($"Contact: {myProduct.Contact}");
            Console.WriteLine($"Location: {myProduct.Location}");
            Console.WriteLine($"Price: {myProduct.Price}");
            Console.WriteLine($"PhoneNumber: {myProduct.PhoneNumber}");

            // Call the Methods 

            myProduct.Read(50);
            Console.WriteLine(myProduct.GetSummary());

            Console.ReadLine();
        }
    }


}
