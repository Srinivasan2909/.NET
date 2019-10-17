using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankrecord
{
    class Record
    {
        public void records()
        {



        }
    }
    class banks
    {
        public int acno;
        public string acname;
        public int atm_pin;
        public double opening_balance;
        public double deposit_amount;
        public double withdrawl_amount;
        public double balance;
        public int choice;
        public void hii(banks[] ba, int i)
        {
            Console.WriteLine("What do you want to do>\n 1-Check balance\n 2-Deposit Amount\n3-Withdraw Amount\n");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("You have chosen to check balance");
                    Console.WriteLine("Your balance is" + ba[i].balance + "\n");
                    Console.WriteLine("Thank you for using the ATM service");
                    break;
                case 2:
                    Console.WriteLine("You have chosen to deposit amount\n");
                    Console.WriteLine("Enter the amount to be deposited\n");
                    ba[i].deposit_amount = int.Parse(Console.ReadLine());
                    Console.WriteLine("Your deposit of Rs." + ba[i].deposit_amount + "is successful\n");
                    ba[i].balance = (ba[i].balance + ba[i].deposit_amount) - ba[i].withdrawl_amount;
                    Console.WriteLine("Your balance is" + ba[i].balance + "\n");
                    Console.WriteLine("Thank you for using the ATM service");
                    break;
                case 3:
                    Console.WriteLine("You have chosen for withdrawl\n");
                    Console.WriteLine("Enter the amount you want to withdraw");
                    ba[i].withdrawl_amount = int.Parse(Console.ReadLine());
                    if (ba[i].withdrawl_amount > ba[i].balance)
                    {
                        Console.WriteLine("Insufficient money in the account\n");
                        Console.WriteLine("Your balance is :" + ba[i].balance);
                    }
                    else
                    {
                        ba[i].balance = ba[i].balance - ba[i].withdrawl_amount;
                        Console.WriteLine("Your balance is" + ba[i].balance + "\n");
                        Console.WriteLine("Thank you for using the ATM service");

                    }
                    break;

            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            banks[] ba = new banks[10];
            banks bb = new banks();
            ba[0] = new banks { acno = 10401011, acname = "sam", atm_pin = 101, opening_balance = 500, deposit_amount = 0, withdrawl_amount = 0, balance = 500 };
            ba[1] = new banks { acno = 10401012, acname = "Tom", atm_pin = 102, opening_balance = 500, deposit_amount = 0, withdrawl_amount = 0, balance = 500 };
            ba[2] = new banks { acno = 10401013, acname = "Mike", atm_pin = 103, opening_balance = 500, deposit_amount = 0, withdrawl_amount = 0, balance = 500 };
            ba[3] = new banks { acno = 10401014, acname = "Messi", atm_pin = 104, opening_balance = 500, deposit_amount = 0, withdrawl_amount = 0, balance = 500 };
            ba[4] = new banks { acno = 10401015, acname = "Bernado", atm_pin = 105, opening_balance = 500, deposit_amount = 0, withdrawl_amount = 0, balance = 500 };
            ba[5] = new banks { acno = 10401016, acname = "ronaldo", atm_pin = 106, opening_balance = 500, deposit_amount = 0, withdrawl_amount = 0, balance = 500 };
            ba[6] = new banks { acno = 10401017, acname = "Bale", atm_pin = 107, opening_balance = 500, deposit_amount = 0, withdrawl_amount = 0, balance = 500 };
            ba[7] = new banks { acno = 10401018, acname = "Kroos", atm_pin = 108, opening_balance = 500, deposit_amount = 0, withdrawl_amount = 0, balance = 500 };
            ba[8] = new banks { acno = 10401019, acname = "Modric", atm_pin = 109, opening_balance = 500, deposit_amount = 0, withdrawl_amount = 0, balance = 500 };
            ba[9] = new banks { acno = 10401010, acname = "Toure", atm_pin = 110, opening_balance = 500, deposit_amount = 0, withdrawl_amount = 0, balance = 500 };
            Console.WriteLine("Enter your ATM pin");
            int a = int.Parse(Console.ReadLine());
            int i = (a % 100) - 1;
            if (a > 100 && a < 111)
            {


                Console.WriteLine("\nAccount number is\n" + ba[i].acno + "\nAccount name is:\n" + ba[i].acname + "\nBalance is:\n" + ba[i].balance);

            }
            else
            {

                Console.WriteLine("Wrong atm pin.You are a cheater! \n Remove card and try again");
            }
            bb.hii(ba, i);

        }

    }

}
