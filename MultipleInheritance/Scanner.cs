using System;
using System.Collections.Generic;
using System.Text;

namespace MultipleInheritance
{
    class Scanner : IScanner
    {
        public virtual void Scan()
        {
            Console.WriteLine("Super Class's Scan Function");
        }
    }
}
