using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula24Excessoes.ExercicioFixaçao
{
    public class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }


        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }
        public void Deposit(double amount)
        {
            if(amount <= 0)
            {
                throw new DomainException("Deposit error: amount is invalid");
            }
            Balance += amount;
        }
        public void Withdraw(double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new DomainException("Withdraw error: The amount exceeds withdraw limit");
            }
            if (amount > Balance)
            {
                throw new DomainException("Withdraw error: not enough balance");
            }
            Balance -= amount;
        }

    }
}