using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17
{
    class Program
    {
        static void Main(string[] args)
        {

            BankAccount<int> baInt = new BankAccount<int>(1, "Владимир Ильич Ленин", 0);
            BankAccount<string> baSrting = new BankAccount<string>("007", "Бонд Джеймс Бондович", 100.01);

            baInt.GetInfo();
            baSrting.GetInfo();

            Console.ReadKey();

        }
    }
}
