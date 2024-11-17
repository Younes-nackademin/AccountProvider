using System;
using System.Collections.Generic;
using AccountProvider.Domain.Models;

namespace AccountProvider.Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            List<Product> varukorg = new List<Product>();

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("Välkommen till AccountProvider!");
                Console.WriteLine("1. Visa användarinformation");
                Console.WriteLine("2. Visa produktinformation");
                Console.WriteLine("3. Lägg till produkt i varukorgen");
                Console.WriteLine("4. Visa varukorg");
                Console.WriteLine("5. Visa orderhistorik");
                Console.WriteLine("6. Avsluta");
                Console.Write("Välj ett alternativ: ");

                var choice = Console.ReadLine();

                // Hanterar användarens val.
                switch (choice)
                {
                    case "1":
                        VisaAnvändarinformation();
                        break;

                    case "2":
                        VisaProduktinformation();
                        break;

                    case "3":
                        LäggTillProduktIVarukorgen(varukorg);
                        break;

                    case "4":
                        VisaVarukorg(varukorg);
                        break;

                    case "5":
                        VisaOrderhistorik();
                        break;

                    case "6":
                        exit = true;
                        Console.WriteLine("Avslutar programmet...");
                        break;

                    default:
                        Console.WriteLine("Ogiltigt val. Tryck på valfri tangent för att försöka igen.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        // Visar information om användare.
        static void VisaAnvändarinformation()
        {
            var user = new User { Id = 1, Username = "TestUser", Email = "test@example.com" };
            Console.WriteLine($"ID: {user.Id}, Användarnamn: {user.Username}, E-post: {user.Email}");
            Console.WriteLine("Tryck på valfri tangent för att återgå till menyn.");
            Console.ReadKey();
        }

        // Visar information om produkt.
        static void VisaProduktinformation()
        {
            var product = new Product { Id = 1, Name = "Product A", Price = 100, Description = "Description of Product A" };
            Console.WriteLine($"ID: {product.Id}, Namn: {product.Name}, Pris: {product.Price}, Beskrivning: {product.Description}");
            Console.WriteLine("Tryck på valfri tangent för att återgå till menyn.");
            Console.ReadKey();
        }

        // Lägger till en vara i varukorgen.
        static void LäggTillProduktIVarukorgen(List<Product> varukorg)
        {
            var product = new Product { Id = 1, Name = "Product A", Price = 100, Description = "Description of Product A" };
            varukorg.Add(product);
            Console.WriteLine($"{product.Name} har lagts till i varukorgen.");
            Console.WriteLine("Tryck på valfri tangent för att återgå till menyn.");
            Console.ReadKey();
        }

        // Visar produkter i varukorgen.
        static void VisaVarukorg(List<Product> varukorg)
        {
            Console.WriteLine("\nDin varukorg:");
            if (varukorg.Count == 0)
            {
                Console.WriteLine("Varukorgen är tom.");
            }
            else
            {
                foreach (var item in varukorg)
                {
                    Console.WriteLine($"Produkt: {item.Name}, Pris: {item.Price}");
                }
            }
            Console.WriteLine("Tryck på valfri tangent för att återgå till menyn.");
            Console.ReadKey();
        }

        // Visar orderhistorik.
        static void VisaOrderhistorik()
        {
            var order = new Order { Id = 1, UserId = 1, ProductName = "Product A", Status = "Completed" };
            Console.WriteLine($"Order ID: {order.Id}, Produkt: {order.ProductName}, Status: {order.Status}");
            Console.WriteLine("Tryck på valfri tangent för att återgå till menyn.");
            Console.ReadKey();
        }
    }
}
