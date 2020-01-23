using System;
using System.Collections.Generic;
using System.Text;

namespace MultipleInheritance
{
    class Printer : IPrinter
    {
        public virtual void Print(){
            Console.WriteLine("Super Class's Print Function");
        }
    }
}
