using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Cuenta
    {
        public int Monto { get; set; }
        public string TipoCuenta { get; set; }

        public virtual string GetSummary()
        {
            return string.Format("{0}{1}", Monto, TipoCuenta);
        }
    }
}
