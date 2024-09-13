namespace Task_01_Calcolatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string? primoNumero = Console.ReadLine();
            //string? secondoNumero = Console.ReadLine();

            //Console.WriteLine("Benvenuto nella Calcolatrice!\nInserisci il primo numero.");                                   TEST
            //    Console.ReadLine(primoNumero);

            //Console.WriteLine("Inserisci il secondo numero.");
            //    Console.ReadLine(secondoNumero);

            //Console.WriteLine(primoNumero + secondoNumero);

            //----------------------------------------------------------------------------------------------//

            Console.WriteLine("Benvenuto nella Calcolatrice! Che tipo di operazione vuoi fare?\nPuoi scegliere fra i seguenti simboli:\n" +
                "Addizione: +\n" +
                "Sottrazione: -\n" +
                "Moltiplicazione: *\n" +
                "Divisione /");
            string? operazione = Console.ReadLine();

            if (operazione is not null && operazione.Equals("+"))
            {
                Console.WriteLine("Inserisci il primo numero.");
                double numA = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Inserisci il secondo numero.");
                double numB = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(numA + numB + " è il risultato della somma dei due numeri che hai scelto.");
            }
                else
                {
                if (operazione is not null && operazione.Equals("-"))
                {
                    Console.WriteLine("Inserisci il primo numero.");
                    double numA = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Inserisci il secondo numero.");
                    double numB = Convert.ToDouble(Console.ReadLine());

                    //Console.WriteLine(numA - numB - " è il risultato della sottrazione dei due numeri che hai scelto."); sbagliato (?)
                    Console.WriteLine($"numA - numB - "+"è il risultato della sottrazione dei due numeri che hai scelto.");
                }
                else
                {
                    if (operazione is not null && operazione.Equals("*"))
                    {
                        Console.WriteLine("Inserisci il primo numero.");
                        double numA = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Inserisci il secondo numero.");
                        double numB = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine(numA* numB * "è il risultato della moltiplic dei due numeri che hai scelto.");
                    }
                    else
                    {
                        if (operazione is not null && operazione.Equals("/"))
                        {
                            Console.WriteLine("Inserisci il primo numero.");
                            double numA = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Inserisci il secondo numero.");
                            double numB = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine(numA / numB / "è il risultato della sottrazione dei due numeri che hai scelto.");
                        }
                    }
                }
                }

        }
    }
}
