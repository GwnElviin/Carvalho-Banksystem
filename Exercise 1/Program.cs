using System; 
using banking;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new service();
            string a = service.start();

            //Console.WriteLine(a);

            var tt = new bankings();

            //string b = tt.pay();

            //Console.WriteLine(b);

        }
    }
}
