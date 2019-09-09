using System;
using System.Collections.Generic;
using System.Text;
using banking;

namespace Exercise_1
{
    class service
    {
        string accountName;
        string bankBalance;
        bankings bank = new bankings();

        public string start()
        {
           

            Console.WriteLine("service started");
            Console.WriteLine("Please enter your bank account name?");
            accountName = Console.ReadLine();

            Console.WriteLine("Amount of money in bank?");
            bankBalance = Console.ReadLine();

            chooseBankAction();

            

            return accountName;
        }

        public void loginBank(string accountName1, string accountBalance)
        {
            accountName = accountName1;

            
            bankBalance = accountBalance;

            Console.WriteLine("logged in the bank");
        }

        public void chooseBankAction()
        {
            Console.WriteLine("Do you want to withdraw(1), deposit(2), sendmoney(3) or checkbalance(4) choose one");
            string bankOption = Console.ReadLine();

            

            bank.bankOptions(bankOption, ref bankBalance, accountName);

            bankingFinished();
            
        }

        public void bankingFinished()
        {
            Console.WriteLine("Are you finished? (yes, no)");
            string finishedOption = Console.ReadLine();

            if (finishedOption == "yes")
            {

                Console.WriteLine("Thank you bye");

            }
            else
            {
                chooseBankAction();
            }
        }
        
    }
}
