using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Aggregate
{
    class Program
    {
        static void Main(string[] args)
        {
            //存款 
            double myBalance = 100.0;

            //提款的額度
            int[] withdrawItems = { 20, 10, 40, 50, 10, 70, 30 };

            double balance = withdrawItems.Aggregate(myBalance, (originbalance, nextWithdrawal) => 
            {
                Console.WriteLine("originbalance: {0}, nextWithdrawal: {1}",
                    originbalance, nextWithdrawal);
                Console.WriteLine("Withdrawal status: {0}", (nextWithdrawal <= originbalance) ? "OK" : "FAILED");

                //若存款餘額不夠時，不會扣除，否則扣除提款額度。
                return ((nextWithdrawal <= originbalance) ? (originbalance - nextWithdrawal) : originbalance);
            });

            //顯示最終的存款數
            Console.WriteLine("Ending balance: {0}", balance);
            Console.Read();
        }
    }
}
