using System;
using System.Collections.Generic;
using System.Text;

namespace DI_Demo
{
    public class Foo : IFoo
    {
        public int AddSomething(int x, int y)
        {
            return x * y;
        }

    }
}
