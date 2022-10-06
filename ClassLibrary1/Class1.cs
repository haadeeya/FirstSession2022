using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public Class1()
        {
            var xx = GetValue();
            Console.WriteLine(xx);
            var xx1 = Console.ReadLine();
        }

        private static int GetValue()
        {
            return 5;
        }
    }
}
