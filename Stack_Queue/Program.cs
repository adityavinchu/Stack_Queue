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
           

            
            Console.WriteLine("--------------Stack--------------");
            stk.push(70);
            stk.push(30);
            stk.push(56);
            stk.DisplayAll();

            Console.WriteLine(" \n total nodes"+stk.Count());
            Console.WriteLine();
            stk.pop();
            stk.DisplayAll();
            Console.WriteLine("\n total nodes"+stk.Count()+"\n");
            
            

            Console.WriteLine("--------------Queue--------------\n");
            Queue que = new Queue();

            que.Enqueue(70);
            que.Enqueue(30);
            que.Enqueue(56);
            que.DisplayAll();
            Console.WriteLine("\n total nodes: " + que.Count()+"\n");
            Console.WriteLine();

            que.Dequeue();
            que.DisplayAll();
            Console.WriteLine("\n total nodes" + que.Count() + "\n");

            Console.ReadLine();


        }
    }
}
