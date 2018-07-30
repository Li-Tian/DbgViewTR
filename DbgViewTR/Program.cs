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
            DoSomething();
            IndentContext ic = TR.SaveContextAndShuffle();
            Task t = DoSomethingAsync();
            TR.RestoreContext(ic);
            TR.Log(t.Id);
            Task t2 = Task.Run(() => DoSomething());
            TR.Log(t.Id);
            t.Wait();
            t2.Wait();
            TR.Exit();
        }

        static int DoSomething()
        {
            TR.Enter();
            TR.Log("Do something.");
            return TR.Exit(1);
        }

        static async Task DoSomethingAsync()
        {
            TR.Enter();
            IndentContext ic = TR.SaveContextAndShuffle();
            await Task.Run(()=>{
                TR.Enter();
                TR.Log("Do something async.");
                TR.Exit();
            });
            TR.RestoreContext(ic);
            TR.Log();
            TR.Exit();
        }
    }
}
