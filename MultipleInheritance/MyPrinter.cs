using System;
using System.Collections.Generic;
using System.Text;

namespace MultipleInheritance
{
    class MyPrinter : Printer, IPhotocopy, IScanner
    {
        public void Copy()
        {
            Console.WriteLine("Sub Class's Copy Function");
        }

        public void Scan()
        {
            Console.WriteLine("Sub Class's Scan Function");
        }

        public override void Print()
        {
            base.Print();
        }
    }
}
