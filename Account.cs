using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AccountApp
{
    internal class Account
    {
        private const int TRANSIT_NUMBER = 314;

        private static int nextAccountNumber;
        public readonly string Number;

        public double Balance
        {
            get; private set; 
        }

        public List<string> Names
        {
            get; private set;
        }

        static Account()
        {
            nextAccountNumber = 10000;
        }

        private Account(string number, string name, double balance)
        {
            Number = number;
            Balance = balance;
            Names = new List<string>();
            Names.Add(name);
        }

        public static Account CreateAccount(string name, double balance = 500)
        {
            string temp_number = $"AC-{TRANSIT_NUMBER}-{nextAccountNumber}";
            nextAccountNumber++;
            return new Account(temp_number, name, balance);
        }

        public override string ToString()
        {
            return $"[{Number}] {string.Join(", ", Names)} {Balance:c}";
        }

        public void Deposit(double Amount){Balance += Amount;}

        public void Withdraw(double Amount){Balance -= Amount;}

        public void AddName(string Name) {Names.Add(Name);}
    }
}
