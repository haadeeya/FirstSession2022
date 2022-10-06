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


        }
    }
}
