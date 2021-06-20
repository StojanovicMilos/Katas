using System;
using System.Threading;

namespace PrintFooBarAlternately
{
    //https://leetcode.com/problems/print-foobar-alternately/
    public class FooBar
    {
        private int n;
        private Semaphore _foo;
        private Semaphore _bar;

        public FooBar(int n)
        {
            this.n = n;
            _foo = new Semaphore(1, 1);
            _bar = new Semaphore(0, 1);
        }

        public void Foo(Action printFoo)
        {

            for (int i = 0; i < n; i++)
            {
                _foo.WaitOne();
                // printFoo() outputs "foo". Do not change or remove this line.
                printFoo();
                _bar.Release();
            }
        }

        public void Bar(Action printBar)
        {

            for (int i = 0; i < n; i++)
            {
                _bar.WaitOne();
                // printBar() outputs "bar". Do not change or remove this line.
                printBar();
                _foo.Release();
            }
        }
    }
}
