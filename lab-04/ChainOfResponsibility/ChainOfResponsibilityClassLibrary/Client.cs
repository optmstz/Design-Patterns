using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityClassLibrary
{
    public class Client
    {
        public static void ClientCode(AbstractHandler handler)
        {
            while (true)
            {
                Console.WriteLine("Please select the type of support you need:");
                Console.WriteLine("1. General Inquiry");
                Console.WriteLine("2. Technical Support");
                Console.WriteLine("3. Billing Support");
                Console.WriteLine("4. Account Support");
                Console.WriteLine("5. Exit");

                var choice = Console.ReadLine();
                string request;

                switch (choice)
                {
                    case "1":
                        request = "General Inquiry";
                        break;
                    case "2":
                        request = "Technical Support";
                        break;
                    case "3":
                        request = "Billing Support";
                        break;
                    case "4":
                        request = "Account Support";
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        continue;
                }

                var result = handler.Handle(request);

                if (result != null)
                {
                    Console.WriteLine($"   {result}");
                    break;
                }
                else
                {
                    Console.WriteLine($"   {request} was not handled. Please try again.");
                }
            }
        }
    }
}
