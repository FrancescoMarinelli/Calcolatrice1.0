using System;

namespace LibrerieOperazioni
{
    public class Operazioni
    {
        public static double Numero()
        {
            Console.Write("inserisci un numero: ");
            double n = double.Parse(Console.ReadLine());
            return n;
        }

        public static double? LibrerieOperazioni(double n1, double n2)
        {

            double? risultato = null;
            Console.WriteLine("1=somma, 2=differenza, 3=moltiplicazione, 4=divisione");
            Console.WriteLine("seleziona l'operazione ");
            string str = Console.ReadLine();
            switch (str)
            {
                case "A":
                case "Somma":
                    risultato = n1 + n2;
                    break;
                case "B":
                case "Differenza":
                    risultato = n1 - n2;
                    break;
                case "C":
                case "Moltiplicazione":
                    risultato = n1 * n2;
                    break;
                case "D":
                case "Divisione":
                    risultato = n1 / n2;
                    break;
                default:
                    Console.WriteLine("errore non hai eseguito nessuna operazione");
                    break;
            }
            return risultato;
        }
    }
}

