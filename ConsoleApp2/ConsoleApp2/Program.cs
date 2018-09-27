using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {


        
            tipoCuenta();        
            Console.ReadKey();
        }
        public static void tipoCuenta()
        {
            Console.WriteLine("1. Para cuenta de credito o 2 para cuenta de debito");
            string x = Console.ReadLine();
            decimal opc = decimal.Parse(x);
            if (opc==1)
            {
                venderCredito();
            }
            else if (opc == 2)
            {

                venderDebito();
            }
         
            decimal monto = decimal.Parse(x);
        }
        public static void venderCredito()
        {
            Credito c = new Credito()
            {

                Monto = 0,
                TipoCuenta = "credito"
            };

            printReport(c);
            Console.WriteLine("Monto A retirar");
            string x = Console.ReadLine();
            int monto = int.Parse(x);
            c.Monto = c.Monto - monto;
            Console.WriteLine("Su nuevo saldo es"+c.Monto);
           

        }
        public static void venderDebito()
        {
            Debito d = new Debito()
            {
                Monto = 1000,
                TipoCuenta = "debito",


            };
            printReport(d);
            Console.WriteLine("Monto A retirar");
            string x = Console.ReadLine();
            int monto = int.Parse(x);
            if (monto > d.Monto)    
            {
                Console.WriteLine("El monto sobrepasa al de su cuenta");
            }
            else
            {
                d.Monto = d.Monto - monto;
                Console.WriteLine("Su nuevo saldo es" + d.Monto);
            }
          
        }


        public static void printReport(Cuenta cuenta)
        {
            Console.WriteLine(cuenta.GetSummary());
        }
    }
}
