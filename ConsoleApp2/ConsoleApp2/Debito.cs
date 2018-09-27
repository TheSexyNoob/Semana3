using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Debito:Cuenta
    {

        public override string GetSummary()
        {
            return base.GetSummary()  ;
        }
    }
}
