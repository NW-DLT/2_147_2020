using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateDeff
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = MyClass.DaysDifference(Console.ReadLine());
            Console.WriteLine(a);
            Console.WriteLine("Years:{0} Months:{1} Days:{2}", a / 365, (a % 365) / 30, a % 30);
            Console.ReadLine();
        }
    }
}
