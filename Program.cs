using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to X-mart");
            shopping(0);
        }

        public static void shopping(double total_amount)
        {


            Console.WriteLine("Press 1 for shopping");
            Console.WriteLine("Press 0 for exit");

            int decision = int.Parse(Console.ReadLine());



            if (decision == 0)
            {
                Console.WriteLine("Your total amount is " + total_amount + ". " + "Visit again");
                return;

            }

            else if (decision == 1)
            {
                Console.WriteLine("Items available for shopping");
                Console.WriteLine("Jeans @ 599 only");
                Console.WriteLine("T-shirts @ 399 only");
                Console.WriteLine("Hoodies @ 899 only");

                Console.WriteLine("Press j to add a Jeans to cart");
                Console.WriteLine("Press t to add a T_shirt to cart");
                Console.WriteLine("Press h to add a Hoodie to cart");

                string itemchoice = Console.ReadLine();
                double item_price = 0;

                        if (itemchoice == "j")
                        {
                            item_price = 599;
                            Console.WriteLine("Jeans added to cart.");
                        }
                        else if (itemchoice == "t")
                        {
                            item_price = 399;
                            Console.WriteLine("T-shirt added to cart.");
                        }
                        else if (itemchoice == "h")
                        {
                            item_price = 899;
                            Console.WriteLine("Hoodie added to cart.");
                        }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                double new_total = total_amount + item_price;
                Console.WriteLine("Current total is " + new_total);

                shopping(new_total);


            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
                shopping(total_amount);
            }




        }
    }
}
