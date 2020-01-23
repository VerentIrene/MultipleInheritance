using System;
using System.Collections.Generic;
using System.Text;

namespace MultipleInheritance
{
    class ScannerAux : Scanner
    {
        MyAnotherPrinter myAnotherPrinter;

        public override void Scan()
        {
            base.Scan();
        }

        static implicit operator MyAnotherPrinter(ScannerAux scannerAux)
        {
            return scannerAux.myAnotherPrinter;
        }
    }
}
