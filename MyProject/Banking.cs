using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    public class Banking
    {
        public string name;
        public int balance;
        public int withdrawamount;
        public int depositamount;

        public Banking()
        { }

        public Banking(string nm, int bal, int wdamnt, int dptamnt)
        {
            this.name = nm;
            this.balance = bal;
            this.withdrawamount = wdamnt;
            this.depositamount = dptamnt;
        }

        public string TakeName()
        {
            Console.WriteLine("Enter Your Name");
            string customer_name = Console.ReadLine();
            Console.WriteLine("Hello " + customer_name);
            return customer_name;
        }

        public int DepositMoney(int name)
        {
            Console.WriteLine("Enter the Deposit Amount");
            depositamount = Convert.ToInt32(Console.ReadLine());
            balance = balance + depositamount;
            Console.WriteLine("Rs. " + depositamount + " Deposited. " + "New Balance = " + balance);
            return balance;
            
        }

        public int WithdrawMoney(int name)
        {
            Console.WriteLine("Enter the Withdraw Amount");
            withdrawamount = Convert.ToInt32(Console.ReadLine());
            if (withdrawamount >= balance)
            {
                Console.WriteLine("Withdraw amount can not exceed account balance");
                Console.WriteLine("Enter an amount less than " + balance);
            }
            else
            {
                balance = balance - withdrawamount;
            }
            Console.WriteLine("Rs. " + withdrawamount + " Withdrawn. " + "New Balance = " + balance);
            return balance;
        }

    }
}
