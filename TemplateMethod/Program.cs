using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethod.Classes;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var policeman = new Policeman();
            var programmer = new Programmer();

            Console.WriteLine("The Policeman Go to Work");
            policeman.Working();

            Console.WriteLine("The Programmer Go to Work");
            programmer.Working();
            Console.ReadKey();
        }
    }
}
