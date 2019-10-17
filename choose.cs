using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assingment1
{
    class choose
    {
        double sum;
        public choose()
        {
            
        }
        public void hey()
        {
            Console.WriteLine("Your total purchase till now is:" + sum);
            int b;
            Console.WriteLine("\nDo you want to add more items?\n1-Yes\n2-No");
            b = int.Parse(Console.ReadLine());
            if (b == 1)
            {
                lol();
            }
            else
            {
                Console.WriteLine("Your total purchase till now is:" + sum);
                Console.WriteLine("Thank you for buying from here.Have a nice day.");
            }

        }
        public void lol()
        {
            int a;
            Console.WriteLine("Enter your product choice\n1-Iphone:Rs.90000\n2-Oneplus:Rs.30000\n3-Redmi:Rs.250000\n4-Samsung:Rs.20000\n5-LG:Rs.15000");

            a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    int price = 90000;
                    int qty;
                    double total;
                    Console.WriteLine("IPhone is choosen\n");
                    Console.WriteLine("Enter the quantity\n");
                    qty = int.Parse(Console.ReadLine());
                    total = qty * price;
                    sum = sum + total;
                    hey();
                    break;
                case 2:
                    price = 30000;
                    Console.WriteLine("One plus is choosen\n");
                    Console.WriteLine("Enter the quantity\n");
                    qty = int.Parse(Console.ReadLine());
                    total = qty * price;
                    sum = sum + total;
                    hey();
                    break;
                case 3:
                    price = 25000;
                    Console.WriteLine("Redmi is choosen\n");
                    Console.WriteLine("Enter the quantity\n");
                    qty = int.Parse(Console.ReadLine());
                    total = qty * price;
                    sum = sum + total;
                    hey();
                    break;
                case 4:
                    price = 20000;
                    Console.WriteLine("Samsung is choosen\n");
                    Console.WriteLine("Enter the quantity\n");
                    qty = int.Parse(Console.ReadLine());
                    total = qty * price;
                    sum = sum + total;
                    hey();
                    break;
                case 5:
                    price = 15000;
                    Console.WriteLine("LG is choosen\n");
                    Console.WriteLine("Enter the quantity\n");
                    qty = int.Parse(Console.ReadLine());
                    total = qty * price;
                    sum = sum + total;
                    hey();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
        static void Main(string[] args)
        {
            choose cho = new choose();
            cho.lol();
            

            


        }
    }
}
