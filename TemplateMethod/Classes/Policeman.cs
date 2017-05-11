using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Classes
{
    public class Policeman : Worker
    {
        public override string DoWork()
        {
            return "Patrolling";
        }
    }
}
