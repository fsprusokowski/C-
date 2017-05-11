using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Classes
{
     public abstract class Worker
    {
        public void Working()
        {
            Console.WriteLine(PunchTheCardIn());
            Console.WriteLine(DoWork());
            Console.WriteLine(PunchTheCardOut());
        }

        private string PunchTheCardIn()
        {
            return "Clock in";
        }

        private string PunchTheCardOut()
        {
            return "Clock out";
        }


        public abstract string DoWork();
    }
}
