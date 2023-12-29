using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec29Console
{
    public interface Sbi
    {
        bool Deposit(double amount);
        bool Withdraw(double amount);
        string CheckBalance();
        void BankFun();
        
    }
    public class SavingAccount:Sbi {
        private double balance=0;
        private readonly double DayDrawLimit = 10000;
        private double TodayDrawAmount = 0;

        public string CheckBalance()
        {
            Console.WriteLine("Account Type : Saving SBI");
            Console.WriteLine("Your Available Balance : " + balance + "\n");
            return "Continue..";
        }
        public bool Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Minimun WithDraw Amount is 100 ");
                return false;
            }
            else if(balance < amount) {
            Console.WriteLine("Insufficient Balance \n"+ "Your Available Balance : "+balance);
            return false;
            }
            else if((TodayDrawAmount+amount) > DayDrawLimit)
            {
                Console.WriteLine("You Reached your daily Withdraw limit try after 24hrs");
                return false;
            }
            else
            {
                Console.WriteLine("Thanks for using SBI Withdraw Function");
                balance -= amount;
                TodayDrawAmount += amount;
                Console.WriteLine("Account Type : Saving SBI");
                Console.WriteLine("Amount Withdraw : "+amount);
                Console.WriteLine("Available Balance : "+balance);
                return true;
            }

        }

        public bool Deposit(double amount)
        {
            balance = balance + amount;
            Console.WriteLine("Account Type : Saving SBI");
            Console.WriteLine("Amount Deposit : "+ amount);
            Console.WriteLine("Available Balance : "+ balance);
            return true;

        }
        public void BankFun()
        {
            Console.WriteLine("Select Your Banking Service :\n1 => Check Balance\n2 => Deposit Amount\n3 => WithDraw Amount");
            int n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    {
                        CheckBalance(); break;
                    }
                case 2:
                    {
                        Console.WriteLine("\nEnter Amount To Deposit");
                        double amt = Convert.ToDouble(Console.ReadLine());
                        Deposit(amt);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("\nEnter Amount To Withdraw");
                        double amt = Convert.ToDouble(Console.ReadLine());
                        Withdraw(amt);
                        break;
                    }
                default: { break; }
            }
        }
    }
    public class CurrentAccount : Sbi
    {
        private double balance=0;
        private readonly double DayDrawLimit = 5000;
        private double TodayDrawAmount = 0;

        public string CheckBalance()
        {
            Console.WriteLine("Account Type : Current SBI");
            Console.WriteLine("Your Available Balance : " + balance + "\n");
            return "Continue..";
        }
        public bool Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Minimun WithDraw Amount is 100 ");
                return false;
            }
            else if (balance < amount)
            {
                Console.WriteLine("Insufficient Balance \n" + "Your Available Balance : " + balance);
                return false;
            }
            else if ((TodayDrawAmount + amount) > DayDrawLimit)
            {
                Console.WriteLine("You Reached your daily Withdraw limit try after 24hrs");
                return false;
            }
            else
            {
                Console.WriteLine("Thanks for using SBI Withdraw Function");
                balance -= amount;
                TodayDrawAmount += amount;
                Console.WriteLine("Account Type : Current SBI");
                Console.WriteLine("Amount Withdraw : " + amount);
                Console.WriteLine("Available Balance : " + balance);
                return true;
            }

        }

        public bool Deposit(double amount)
        {
            balance = balance + amount;
            Console.WriteLine("Account Type : Current SBI");
            Console.WriteLine("Amount Deposit : " + amount);
            Console.WriteLine("Available Balance : " + balance);
            return true;

        }
        public void BankFun()
        {
            Console.WriteLine("\nSelect Your Banking Service :\n1 => Check Balance\n2 => Deposit Amount\n3 => WithDraw Amount");
            int n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    {
                        CheckBalance(); 
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("\nEnter Amount To Deposit");
                        double amt = Convert.ToDouble(Console.ReadLine());
                        Deposit(amt);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("\nEnter Amount To Withdraw");
                        double amt = Convert.ToDouble(Console.ReadLine());
                        Withdraw(amt);
                        break;
                    }
                default: { break; }
            }
        }
    }
    internal class InterfaceClass
    {
        public InterfaceClass() {
            Console.WriteLine("\nWelcome To SBI Banking Function!\nSelect Your Account Type:\n1 => Saving Account\n2 => Current Account");
        }
        static void Main(string[] args)
        {
            Sbi sa = new SavingAccount();
            Sbi ca=new CurrentAccount();
            bool always = true;
            while (always)
            {
                InterfaceClass i= new InterfaceClass();
                int a = Convert.ToInt32(Console.ReadLine());
                if (a == 1)
                {
                    sa.BankFun();
                    always = true;
                }
                else if (a == 2)
                {
                    ca.BankFun();
                    always = true;
                }
                else
                {
                    Console.WriteLine("Select Correct Options !!!");
                    always = true;
                }
            }

        }

    }
}
