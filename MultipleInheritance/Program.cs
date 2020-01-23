using System;

namespace MultipleInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            MyPrinter myPrinter = new MyPrinter();

            myPrinter.Print();
            myPrinter.Copy();
            myPrinter.Scan();
        }
    }
}
