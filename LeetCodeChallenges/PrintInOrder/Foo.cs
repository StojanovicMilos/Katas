using System;
using System.Threading;

namespace PrintInOrder
{
    //https://leetcode.com/problems/print-in-order/
    public class Foo
    {
        private static readonly Semaphore _second = new Semaphore(0, 1);
        private static readonly Semaphore _third = new Semaphore(0, 1);

        public Foo()
        {
        }

        public void First(Action printFirst)
        {
            // printFirst() outputs "first". Do not change or remove this line.
            printFirst();
            _second.Release();
        }

        public void Second(Action printSecond)
        {
            _second.WaitOne();
            // printSecond() outputs "second". Do not change or remove this line.
            printSecond();
            _third.Release();
        }

        public void Third(Action printThird)
        {
            _third.WaitOne();
            // printThird() outputs "third". Do not change or remove this line.
            printThird();
        }
    }
}
