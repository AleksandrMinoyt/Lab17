using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17
{
    public class BankAccount<T>
    {
        private T _number;
        private double _balance;
        private string _fio;


        public BankAccount(T Number, string FIO, double Balance)
        {
            _number = Number;
            _fio = FIO;
            _balance = Balance;
        }

        public void SetAccount(T Number, string FIO, double Balance)
        {
            _number = Number;
            _fio = FIO;
            _balance = Balance;   
        }
        public void GetInfo()
        {
            Console.WriteLine("Счёт №{0}\n  Владелец: {1}, Баланс: {2:f2}\n", _number,_fio,_balance);
        }


    }
}
