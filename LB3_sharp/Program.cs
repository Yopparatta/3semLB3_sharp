using System;

namespace LB3_sharp
{

    class Account
    {
        private double money;
        private string name;
        private string birthDate;
        private int pin;

        Account(string name, string birthDate,int pin,double money)
        {
            this.name = name;
            this.birthDate = birthDate;
            this.pin = pin;
            this.money = money;
            }

        void withdraw(double money, int pin)
        {
            if (pin == this.pin)
            {
                this.money -= money;
            }
            else
            {
                Console.WriteLine("Неверный пин-код. Операция отменена");
            }
        }
        void deposit(double money, int pin)
        {
            if (pin == this.pin)
            {
                this.money += money;
            }
            else
            {
                Console.WriteLine("Неверный пинкод. Операция отменена");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
