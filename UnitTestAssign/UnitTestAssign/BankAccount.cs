﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLib
{
    public class BankAccount
    {
        private double balance;

        public BankAccount()
        {
            balance = 0;
        }

        public BankAccount(int startBal)
        {
            balance = startBal;
        }

        public int getBalance()
        {
            return balance;
        }

        // Withdraws money from account.  
        // Return true if withdrawl successful, false if amt is negative or would overdraw account (do not perform transaction in those cases)
        public bool withdraw(int amt)
        {
            if (amt >= 0  && amt<balance)
            {
                balance = balance - amt;
                return true;
            }
            else
                return false;
        }

        // Deposits amt into acocunt.  Returns true is operation successful, false otherwise.
        public bool deposit(int amt)
        {
            int initBal = balance;
            balance = balance + amt;
            if (initBal != balance)
                return true;
            else
                return false;
        }
    }
}
