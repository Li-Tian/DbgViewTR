using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbgViewTR
{
    class Program
    {
        static void Main(string[] args)
        {
            TR.Enter();
            doSomething();
            TR.Exit();
        }

        static int doSomething()
        {
            TR.Enter();
            TR.Log("Do something.");
            return TR.Exit(1);
        }
    }
}
