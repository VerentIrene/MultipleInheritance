using System;
using System.Collections.Generic;
using System.Text;

namespace MultipleInheritance
{
    class Photocopy : IPhotocopy
    {
        public virtual void Copy(){
            Console.WriteLine("Super Class's Copy Function");
        }
    }
}
