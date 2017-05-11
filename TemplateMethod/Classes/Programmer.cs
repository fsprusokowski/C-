using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Classes
{
    public class Programmer : Worker
    {
        public override string DoWork()
        {
            return "Coding";
        }
    }
}
