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
            TR.enter();
            doSomething();
            TR.exit();
        }

        static int doSomething()
        {
            TR.enter();
            TR.log("Do something.");
            return TR.exit(1);
        }
    }
}
