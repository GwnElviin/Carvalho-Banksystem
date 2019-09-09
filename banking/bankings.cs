using System;

namespace banking
{
    public class bankings
    {
        string logTransactions;

        public void bankOptions(string chosenOption, ref string bankBalance, string accountName)
        {
            switch (chosenOption)
            {
                case "withdraw":
                case "1":

                    Console.WriteLine($"{accountName} how much do you want to withdraw?");
                    string amountOut = Console.ReadLine();
                    Console.WriteLine(withdraw(ref bankBalance, amountOut, accountName));

                    break;
                case "deposit":
                case "2":
                    Console.WriteLine($"{accountName} how much do you want to deposit?");
                    string amountIn = Console.ReadLine();
                    Console.WriteLine(deposit(ref bankBalance, amountIn, accountName));

                    break;
                case "sendMoney":
                case "3":
                    Console.WriteLine($"To who do you want to send money ?");
                    string accountReceive = Console.ReadLine();
                    Console.WriteLine($"How much do you want to send to {accountReceive} ?");
                    string amountSend = Console.ReadLine();
                    Console.WriteLine(sendMoney(ref bankBalance, accountReceive, amountSend, accountName));

                    break;
                case "checkbalance":
                case "4":
                    Console.WriteLine($"{logTransactions}");//checkBalance(ref bankBalance, accountName)

                    break;
                default:
                    Console.WriteLine($"{chosenOption} option not found try again");
                    break;
            }
        }

        

        public string sendMoney(ref string bankBalance, string accountReceiver, string amountSend, string accountSender)
        {
            int newBalance = Convert.ToInt32(bankBalance);
            int newAmount = Convert.ToInt32(amountSend);

            int minus = newBalance - newAmount;
            bankBalance = Convert.ToString(minus);
            Console.WriteLine($"{amountSend} has been send to {accountReceiver}");
            logTransaction(ref bankBalance, accountSender, $"has send ${amountSend} to {accountReceiver}");
            return $"new balance is {minus}";
            
        }

        public string withdraw(ref string balance, string amountOut, string accountSender)
        {
            int newBalance = Convert.ToInt32(balance);
            int newAmount = Convert.ToInt32(amountOut);

            int minus = newBalance - newAmount;
            
            balance = Convert.ToString(minus);
            logTransaction(ref balance, accountSender, $"has withdrawn ${amountOut}");
            return $"new balance is {minus}";
        }

        public string deposit(ref string balance, string amountIn, string accountSender)
        {
            int newBalance = Convert.ToInt32(balance);
            int newAmount = Convert.ToInt32(amountIn);

            int plus = newBalance + newAmount;
            balance = Convert.ToString(plus);
            logTransaction(ref balance, accountSender, $"has deposit ${amountIn}");
            
            return $"new balance is {plus}";
        }

        public string checkBalance(ref string balance, string accountName)
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

        static void Main(string[] args)
        {
             


        }
        
    }
}
