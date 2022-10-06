using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FirstSession
{

    internal class Program
    {
        static void Main(string[] args)
        {

            DisplayCategory category = new DisplayCategory();
            category.Start();
            Console.ReadKey();

            //Employee employee1 = new Employee();
            //employee1.Name = "Jane Doe";

            //Employee employee2 = employee1;
            //employee2.Name = "James Doe";

            //Employee employee3 = new Employee();
            //employee3.Name = "James Doe";

            //Console.WriteLine(employee1.Name);
            //if(employee1.Name == employee2.Name)
            //{
            //    Console.WriteLine("True");
            //}
            //else
            //{
            //    Console.WriteLine("False");
            //}
            //Console.WriteLine("Value: ");
            //var value = int.Parse(Console.ReadLine());
            //string msg = string.Empty;

            //msg = value < 10 ? "Value less than 10" : value < 15 ? "Value between 10 and 15": "Value greater than 15";

            //Console.WriteLine(msg);

            //    var inputs = new List<int>() { 2, 3, 5, 6, 7, 9, 10 };

            //    Console.WriteLine("Enter '1' for sum of even numbers only");
            //    var choice = int.Parse(Console.ReadLine());

            //    bool even = false;

            //    even = choice == 1 ? true : false;

            //    var total = Sum(inputs, even);

            //    Console.WriteLine(total);

            //    Console.ReadKey();
            //}

            //public static int Sum(List<int> input, bool even)
            //{
            //    var total = 0;
            //    foreach (var i in input)
            //    {
            //        if(even)
            //        {
            //            total += i;
            //        }

            //    }
            //    return total;
            //}


        }
    }
}
