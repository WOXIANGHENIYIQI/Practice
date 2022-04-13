using Nito.AsyncEx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Practice
{
    /// <summary>
    /// 锁
    /// </summary>
    public class Lock
    {
        static int balance;
        Random r = new Random();
        /// <summary>
        /// 红包金额
        /// </summary>
        /// <param name="initial"></param>
        public Lock(int initial)
        {
            balance = initial;
        }
        #region lock 同步锁
        public void LockTesc()
        {
            Thread[] threads = new Thread[10];
            Lock acc = new Lock(10);
            for (int i = 0; i < threads.Length; i++)
            {
                Thread t = new Thread(new ThreadStart(acc.DoTransactions));
                threads[i] = t;
            }
            for (int i = 0; i < threads.Length; i++)
            {
                threads[i].Start();
            }
        }
        void Withdraw(int amount)
        {
            lock (this)
            {
                if (balance == 0)
                {
                    Console.WriteLine("以抢完！");
                    //throw new Exception("以抢完!");
                }
                else
                {
                    Console.WriteLine("抢之前:  " + balance);
                    Console.WriteLine("抢到数据: -" + amount);
                    balance = balance - amount;
                    Console.WriteLine("抢之后:  " + balance);
                    Console.WriteLine();
                }
            }
        }
        public void DoTransactions()
        {
            for (int i = 0; i < 1; i++)
            {
                Withdraw(1);
            }
        }
        #endregion
        #region AsyncLock 异步锁

        /// <summary>
        /// 
        /// </summary>
        /// <param name="NumberOfPeople">抢红包人数</param>
        /// <param name="number">红包个数</param>
        //public void AsyncLockTesc(int NumberOfPeople, int number)
        public void AsyncLockTesc()
        {
            Lock acc = new Lock(100);//通过构造函数给变量赋值，相当于100红包
            Thread[] threads = new Thread[100];//创建100个线程模拟100人抢100元红包
            for (int i = 0; i < threads.Length; i++)
            {
                Thread t = new Thread(() =>
                {
                    DoTransactions("线程" + i + ":").Wait();
                });
                threads[i] = t;
            }
            for (int i = 0; i < threads.Length; i++)//开启线程
            {
                threads[i].Start();
            }
        }

        public static AsyncLock asyncLock = new AsyncLock();
        public static async Task<string> Withdraw(string name, int amount)
        {
            using (await asyncLock.LockAsync())
            {
                if (balance <= 0)
                {
                    Console.WriteLine(name + "没有抢到红包已经抢完！");
                }
                else
                {
                    if (balance < amount)
                    {
                        amount = balance;
                        balance = 0;
                        Console.WriteLine(name + "抢到" + amount + "元，红包剩余:" + balance);
                    }
                    else
                    {
                        balance = balance - amount;
                        Console.WriteLine(name + "抢到" + amount + "元，红包剩余:" + balance);
                    }

                }
                return "";
            }

        }
        public static async Task<string> DoTransactions(string name)
        {
            Random r = new Random();
            int a = r.Next(0,10);
            await Withdraw(name,a);
            return "";
        }
        #endregion

    }
}
