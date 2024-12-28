using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleProjectLearing
{
    public class InsufficientFundException : Exception
    {
        public decimal Deficit
        {
            get;
            set;
        }
        public InsufficientFundException(): base()
        {
        }

        public InsufficientFundException(string message) : base(message)
        {
        }

        public InsufficientFundException(string message, Exception innerException) : base(message, innerException)
        {

        }

        public InsufficientFundException(decimal deficit)
        {
            Deficit = deficit;
        }
        public override string Message =>
             $"{base.Message} Could not withdraw due to a deficit of {Deficit:C}";
    }
    public class Account
    {

        private decimal balance;
        public decimal Balance => balance;

        public Account(decimal initialBalance = 0)
        {
            if (initialBalance < 0)
            {
                throw new ArgumentOutOfRangeException($"The {nameof(initialBalance)} must be zero or positive.");
            }
            balance = initialBalance;
        }

        public Account Withdraw(decimal amount)
        {
            if (amount > Balance)
            {
                var deficit = amount - Balance;
                throw new InsufficientFundException(deficit);

            }

            balance -= amount;
            return this;
        }
        public Account Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }
            balance += amount;
            return this;
        }
    }

    //public class Program
    //{
    //    public static void Main(string[] args)
    //    {

    //        var account = new Account(100);
    //        try
    //        {
    //            account.Withdraw(200);
    //        }
    //        catch (InsufficientFundException ex)
    //        {
    //            WriteLine(ex.Message);
    //        }
    //        catch (Exception ex)
    //        {
    //            WriteLine(ex.Message);
    //        }

    //        ReadLine();
    //    }
    //}


}

