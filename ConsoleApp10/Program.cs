using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("                PRODUCT MART BILLING MECHANISM                     ");
                Console.Write("Mart Name: ");
                string e;
                e = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Do you want to login through:");
                Console.WriteLine("1.Admin");
                Console.WriteLine("2.User");
                Console.WriteLine();
                int b;
                b = Convert.ToInt32(Console.ReadLine());
                if (b == 1)
                {
                    string p;
                    Console.Write("password:");
                    p = Console.ReadLine();
                    Console.WriteLine("your id: admin ");
                    Console.WriteLine("password: " + p);
                    Console.WriteLine();
                    Console.WriteLine("you need to reset your password");
                    string p1;
                    Console.Write("Enter new password: ");
                    p1 = Console.ReadLine();
                    if (p != p1)
                    {
                        Console.WriteLine(p1 + " is new password");
                        Console.WriteLine();
                        Console.WriteLine("LOGIN");
                        Console.WriteLine("your id: admin ");
                        Console.WriteLine("password: " + p1);
                        Console.WriteLine();
                        Console.WriteLine("                     WELCOME TO ADMIN DASHBOARD                    ");
                        Console.WriteLine("Do you want create products");
                        Console.WriteLine("1.yes");
                        Console.WriteLine("2.no");
                        int c;
                        c = Convert.ToInt32(Console.ReadLine());
                        if (c == 1)
                        {
                            Console.Write("How many products do you need:");
                            int d;
                            d = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();
                            Console.WriteLine();
                            string[] items = new string[d];
                            int[] cost = new int[d];
                            for (int i = 0; i < d; i++)
                            {


                                Console.Write(" item " + i + " is:");
                                items[i] = Console.ReadLine();
                                Console.Write(" cost " + i + " is:");
                                cost[i] = Convert.ToInt32(Console.ReadLine());

                            }
                            Console.WriteLine();
                            for (int i = 0; i < d; i++)
                            {
                                Console.WriteLine(" " + (items[i]) + "       :   " + (cost[i]));
                            }
                        }
                        else
                        {
                            Console.WriteLine("        THANKYOU       ");
                        }
                    }

                }
                else
                {
                    Console.WriteLine("             USER LOGIN                   ");
                    Console.WriteLine("The available products are:");
                    Console.WriteLine("1.Chocolates      : 10/-");
                    Console.WriteLine("2.Bis packet      : 30/-");
                    Console.WriteLine("3.lolypop         : 5/-");
                    Console.WriteLine("4.kurukure        : 10/-");
                    Console.WriteLine("5.Bingo           : 10/-");
                    string[] items = { "Chocolate", "Bis packet", "lolypop", "kurukure", "Bingo" };
                    int[] cost = { 10, 30, 5, 10, 10 };

                    Console.Write("No.of items to be taken:");
                    int f;
                    f = Convert.ToInt32(Console.ReadLine());
                    if (f != 0)
                    {



                        int[] k = new int[f];
                        for (int m = 0; k.Length > m; m++)
                        {

                            Console.WriteLine("Please select the items index number:");
                            k[m] = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("");

                        }

                        for (int m = 0; k.Length > m; m++)
                        {
                            Console.WriteLine("the items are :" + items[k[m]]);
                            Console.WriteLine("the costs are :" + cost[k[m]]);
                        }
                        double totalBill = 0;
                        bool continueShopping = true;
                        while (continueShopping)
                        {
                            Console.Write("Enter the price of the item or 0 to exit: ");
                            double price = Convert.ToDouble(Console.ReadLine());
                            if (price == 0)
                            {
                                continueShopping = false;

                            }
                            else
                            {
                                totalBill += price;
                            }


                        }
                        Console.WriteLine();
                        Console.WriteLine("      BILLING           ");
                        Console.WriteLine("Name        :NIHARIKA");
                        Console.WriteLine("ID          :NIHARIKA_0727");
                        Console.WriteLine("Contact no. :9392456727");
                        Console.WriteLine("Total bill  :" + totalBill);





                    }


                }
        }
    }
}
