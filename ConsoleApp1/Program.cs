using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Constant c = new Constant();
            string t = c.Pi();
            Console.Out.WriteLine("Our String: ");
            Console.Out.WriteLine(t);
            Console.Out.Write("Write length of palindrom: ");
            Palindroms p = new Palindroms();
            int l;
            if (Int32.TryParse(Console.In.ReadLine(), out int o))
            {
                l = o;
            }
            else
            {
                l = 5;
            }
            List<string> list = p.GetPalindroms(t, l);
            foreach (string x in list)
            {
                Console.Out.WriteLine((list.IndexOf(x)+ 1) +": "+ x);
            }
            if (list.Count > 0)
            {
                Console.Out.WriteLine("Smallest: " + p.GetSmalest(list));
            }
            Console.In.Read();
        }

        
    }
}
