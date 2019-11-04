using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Customerpurchase
{
    class Program
    {

        static void Main(String[] args)
        {
            Program p = new Program();
            Custo custo = new Custo();

            l1:
            Console.WriteLine("What do you want to do>\n1-View Customer data\n2-New Customer");
            int a = int.Parse(Console.ReadLine());
            

            switch(a)
            {
                case 1:
                    custo.dispcustomer();
                    break;
                case 2:
                    custo.insertcustomer();

                    break;
                default:
                    Console.WriteLine("Wrong choice");
                    break;

            }
            Console.WriteLine("Do you want to continue?\n1-yes\n 2-no");
            int f = int.Parse(Console.ReadLine());
            if (f == 1)
                goto l1;
            else
                Console.WriteLine("Bye");


        }
        
    }
}
