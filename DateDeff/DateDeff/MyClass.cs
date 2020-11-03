using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateDeff
{
    static class MyClass
    {
        public static int DaysDifference(string Date)
        {
            TimeSpan span = DateTime.Today.Subtract(DateTime.Parse(Date));
            return Convert.ToInt32(span.Days.ToString());
        }
    }
}
