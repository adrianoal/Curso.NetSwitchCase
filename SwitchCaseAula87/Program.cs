using System;

namespace SwitchCaseAula87
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um numero de 1 a 7 para saber o dia da semana: ");
            int x = int.Parse(Console.ReadLine());
            string day;
            Console.WriteLine();

            // Essa solucao substitui os "if else" encadeados:

            switch (x)
            {
                case 1:
                    day = "Sunday";
                    break;
                case 2:
                    day = "Monday";
                    break;

                case 3:
                    day = "Tuesday";
                    break;

                case 4:
                    day = "Wednesday";
                    break;

                case 5:
                    day = "Thursday";
                    break;

                case 6:
                    day = "Friday";
                    break;

                case 7:
                    day = "Saturday";
                    break;

                default:
                    day = "Invalid Value";
                    break;

            }
            Console.WriteLine("Day: " + day);

        }
    }
}
