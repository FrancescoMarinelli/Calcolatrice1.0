using System;
using LibrerieOperazioni;

namespace Calc1
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = Operazioni.Numero();
            double n2 = Operazioni.Numero();
            double? risultato = Operazioni.LibrerieOperazioni(n1, n2);
            Console.WriteLine($"{risultato}");
        }
    }
}



