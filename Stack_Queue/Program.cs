using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stk = new Stack();

            stk.push(70);
            stk.push(30);
            stk.push(56);
            stk.DisplayAll();
            stk.Count();
            Console.WriteLine();
            stk.pop();
            stk.DisplayAll();
            stk.Count();

            Console.ReadLine();


        }
    }
}
