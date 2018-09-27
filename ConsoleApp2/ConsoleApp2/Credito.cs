using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Credito:Cuenta
    {

        public override string GetSummary()
        {
            return base.GetSummary()  ;
        }
    }
}
