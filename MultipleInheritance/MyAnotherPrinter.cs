using System;
using System.Collections.Generic;
using System.Text;

namespace MultipleInheritance
{
    class MyAnotherPrinter
    {
        PrinterAux printerAux;
        ScannerAux scannerAux;

        public void Print()
        {
            printerAux.Print();
        }

        static implicit operator Printer(MyAnotherPrinter myAnotherPrinter)
        {
            return myAnotherPrinter.printerAux;
        }
        static implicit operator Scanner(MyAnotherPrinter myAnotherPrinter)
        {
            return myAnotherPrinter.scannerAux;
        }
    }
}
