using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Expert
{
    class Program
    {
        static void Main(string[] args)
        {
            #region INTSTACK
            IntStack s = new IntStack(3);

            s.Push(1);
            Console.WriteLine(s.Top);
            s.Push(2);
            Console.WriteLine(s.Top);
            s.Push(3);
            Console.WriteLine(s.Top);
            Console.WriteLine("Nothing\n", new string('=', 8));
            try
            {
                s.Push(4);
            }
            catch (StackOverFlowException e)
            {
                Console.WriteLine("We try to push one more element.\n");
                Console.WriteLine(e.Message);
            }
            #endregion

            #region GENSTACK
            GenStack<string> g = new GenStack<string>(3);

            g.Push("one");
            Console.WriteLine(g.Top);
            g.Push("two");
            Console.WriteLine(g.Top);
            g.Push("three");
            Console.WriteLine(g.Top);

            try
            {
                g.Push("four");
            }
            catch (StackOverFlowException e)
            {
                Console.WriteLine("We try to push one more element.\n");
                Console.WriteLine(e.Message);
            }
            #endregion

            GenStack<ClassRoom> g1 = new GenStack<ClassRoom>(2);
            g1.Push(new ClassRoom() { ClassCount = 31, ClassName = "12/P" });
            Console.WriteLine("\nLegfelső elem:" + g1.Top);
            Console.ReadLine(); // or Console.ReadKey();
        }
    }
}
