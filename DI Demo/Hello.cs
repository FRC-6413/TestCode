using System;
using System.Collections.Generic;
using System.Text;

namespace DI_Demo
{
    public class Hello : IFoo
    {
        public int AddSomething(int x, int y)
        {
            return x + y;
        }

        public int DivideSomething(int x, int y)
        {
            return x / y;
        }

    }
}
