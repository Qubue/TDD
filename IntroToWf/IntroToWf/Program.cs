using System;
using System.Linq;
using System.Activities;
using System.Activities.Statements;

namespace IntroToWf
{

    class Program
    {
        static void Main(string[] args)
        {
            OutputToConsole("Hello", "World");
            OutputToConsoleWF("Hello", "wf");

            //Activity workflow1 = new Workflow1();
            //WorkflowInvoker.Invoke(workflow1);
            Console.ReadKey();
        }

        private static void OutputToConsoleWF(string p, string p_2)
        {
            var s = new Sequence
            {
                Activities =
            {
                new WriteLine {Text=p },
                new WriteLine {Text=p_2 }
            }    
            };
            WorkflowInvoker.Invoke(s);
        }

        public static void OutputToConsole(string p,string p_2)
        {
            Console.WriteLine(p);
            Console.WriteLine(p_2);
        }
    }
}
