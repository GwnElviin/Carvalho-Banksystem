using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarvalhoBanks
{
    class bankingSystem
    {
        string logTransactions;
          
        public string send(ref string bankBalance, string accountName, string amountSend, string accountReceiveName)
        {
            int newBalance = Convert.ToInt32(bankBalance);
            int newAmount = Convert.ToInt32(amountSend);

            int minus = newBalance - newAmount;
            bankBalance = Convert.ToString(minus);
            Console.WriteLine($"{amountSend} has been send to {accountReceiveName}");
            logTransaction(ref bankBalance, accountName, $"has send ${amountSend} to {accountReceiveName}");
            return $"{ amountSend} has been send to { accountReceiveName}\n new balance is {minus}";

        }

        public string withdraw(ref string balance, string accountName, string amountOut)
        {
            int newBalance = Convert.ToInt32(balance);
            int newAmount = Convert.ToInt32(amountOut);

            int minus = newBalance - newAmount;

            balance = Convert.ToString(minus);
            logTransaction(ref balance, accountName, $"has withdrawn ${amountOut}");
            return $"new balance is {minus}";
        }

        public string deposit(ref string balance, string accountName, string amountIn)
        {
            int newBalance = Convert.ToInt32(balance);
            int newAmount = Convert.ToInt32(amountIn);

            int plus = newBalance + newAmount;
            balance = Convert.ToString(plus);
            logTransaction(ref balance, accountName, $"has deposit ${amountIn}");

            return $"new balance is {plus}";
        }

        public string checkBalance()
        {
            return showTransactions();
        }

        public void logTransaction(ref string balance, string accountName, string action)
        {
            logTransactions += $"{accountName} {action} \n {accountName}'s new balance is {balance}\n";
            //return $"account balance for {accountName} is: ${balance}";
        }

        public string showTransactions()
        {
            return logTransactions;
        }

    }
}
