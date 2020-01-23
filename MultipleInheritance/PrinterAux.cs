using System;
using System.Collections.Generic;
using System.Text;

namespace MultipleInheritance
{
    class PrinterAux : Printer
    {
        MyAnotherPrinter myAnotherPrinter;

        void Print();

        static implicit operator MyAnotherPrinter(PrinterAux printerAux)
        {
            return printerAux.myAnotherPrinter;
        }
    }
}
