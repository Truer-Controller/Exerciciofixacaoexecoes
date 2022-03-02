using Exerciciofixacaoexecoes.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exerciciofixacaoexecoes.Entities
{
    class Account
    {
        public int NumberAccount { get; set; }

        public string HolderAccount { get; set; }

        public double BalanceAccount { get; set; }

        public double WithdrawLimit { get; set; }

        public Account()
        {
        }

        public Account(int numberAccount, string holderAccount, double balanceAccount, double withdrawLimit)
        {
            NumberAccount = numberAccount;
            HolderAccount = holderAccount;
            BalanceAccount = balanceAccount;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            BalanceAccount += amount;
        }

        public void WithDraw(double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new DomainException("Você está tentando sacar um valor maior do que o seu limite de saque!!");
            }

            if (amount > BalanceAccount)
            {
                throw new DomainException("Você está tentando sacar um valor maior do que o seu saldo atual!");
            }

            BalanceAccount -= amount;
        }
    }
}
