using System;

namespace LB3_sharp
{

    class Account
    {
        private double money;

        public Account(double money)
        {
            this.money = money;
        }

        public void withdraw(double money)
        {
                this.money -= money;
        }
        public void deposit(double money)
        {
                this.money += money;
        }
        public void show()
        {
            Console.WriteLine("Money: {0}",this.money);
        }

         public double moneyget()
        {
            return money;
        }
        public void moneyput(double _money)
        {
            money += _money;
        }
    }
    class Program
    {

        static int splitLine(string str)
        {
            for (int i=0; i < str.Length; i++)
            {
                if (str[i] == ' ') return i;
            }
            return 0;
        }


        static void Main(string[] args)
        {
            Account user = new Account(0);
            double money;
            string oper;
            int count;
            while (true) {
                Console.WriteLine("Введите тип операции и сумму (дробная часть отделяется запятой)");
                oper = Console.ReadLine();
                if (oper == "exit")
                {
                    Environment.Exit(0);
                }
                count = splitLine(oper);
                money = Convert.ToDouble(oper.Substring(count + 1));
                oper = oper.Substring(0, count);
                switch (oper) {
                    case "withdraw":
                        //user.withdraw(money);
                        //user.show();
                        user.moneyput(-money);
                        Console.WriteLine("Money: {0}",user.moneyget());
                        break;
                    case "deposit":
                        //user.deposit(money);
                        //user.show();
                        user.moneyput(money);
                        Console.WriteLine("Money: {0}", user.moneyget());
                        break;
                    default:
                        Console.WriteLine("Такой операции не существует");
                        break;


                } 
            }
        }
    }
}
