using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarvalhoBanks
{
    class service
    {
        string accountName;
        string bankBalance;

        
        public void loginBank(string accountName1, string accountBalance)
        {
            accountName = accountName1;


            bankBalance = accountBalance;

            Console.WriteLine($"logged in the bank {accountName} {bankBalance}");
        }
    }
}
