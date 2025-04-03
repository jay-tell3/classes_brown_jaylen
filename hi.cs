using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace classes_brown_jaylen
{//makes the class
    internal class hi
    {
        //makes a method that can be called useing the class and method name
        public void welcome()
        {//says hi
            Console.WriteLine("hi person");
        }
        //makes a method that can be called useing the class and method name
        public static void Hello(string name)
        {//says hello and the users username varable input
         Console.WriteLine($"Hello {name}");
        }
    }
}
