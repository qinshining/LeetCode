using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1114.按序打印
{
    /* 我们提供了一个类：
     * public class Foo
     * {       
     * public void one() { print("one"); }
     * public void two() { print("two"); }
     * public void three() { print("three"); }
     * }
     * 三个不同的线程将会共用一个 Foo实例。
     * 
     * 线程 A 将会调用 one() 方法
     * 线程 B 将会调用two() 方法
     * 线程 C 将会调用 three() 方法
     * 请设计修改程序，以确保two() 方法在 one() 方法之后被执行，three() 方法在 two() 方法之后被执行。
     * 
     * */
    public class Solution
    {
        public void ThreadStart()
        {
            Foo foo = new Foo();

            Task.Factory.StartNew(() => foo.Third(foo.Three));
            Task.Factory.StartNew(() => foo.Second(foo.Two));
            Task.Factory.StartNew(() => foo.First(foo.One));
        }
    }

    public class Foo
    {
        public Foo()
        {

        }

        public void One() { Console.WriteLine("one"); }
        public void Two() { Console.WriteLine("two"); }
        public void Three() { Console.WriteLine("three"); }

        private AutoResetEvent secondReset = new AutoResetEvent(false);
        private AutoResetEvent thirdReset = new AutoResetEvent(false);

        public void First(Action printFirst)
        {

            // printFirst() outputs "first". Do not change or remove this line.
            printFirst();
            secondReset.Set();
        }

        public void Second(Action printSecond)
        {
            secondReset.WaitOne();
            // printSecond() outputs "second". Do not change or remove this line.
            printSecond();
            thirdReset.Set();
        }

        public void Third(Action printThird)
        {
            thirdReset.WaitOne();
            // printThird() outputs "third". Do not change or remove this line.
            printThird();
        }
    }
}
