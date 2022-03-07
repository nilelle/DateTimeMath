using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeMath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);
            Console.WriteLine(DateTime.Now.Millisecond);
            Console.WriteLine(DateTime.Now.Month);

            Console.WriteLine(Math.Sin(1));
            Console.WriteLine(Math.Exp(4));
            Console.WriteLine(Math.Pow(2,4));
            Console.WriteLine(Math.Sqrt(36));

            Console.ReadKey();  
        }
    }
}
