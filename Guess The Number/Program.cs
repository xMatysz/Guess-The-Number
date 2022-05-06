using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main()
        {
            bool correctAnswer = false;

            Random random = new Random();
            int randomNumber = random.Next(1,100);

            ColorMessage("Witaj w grze \"Zgadnij liczbę!\"", ConsoleColor.Yellow);
            ColorMessage("\nPodaj liczbę z przedziału 1..100", ConsoleColor.Red);

            do
            {
                var input = Console.ReadLine();

                if (int.TryParse(input, out var number))
                {
                    if (number == randomNumber)
                    {
                        ColorMessage("Udało się zgadnąć liczbę!!", ConsoleColor.Green);
                        correctAnswer = true;
                    }
                    else if (number < 1 || number > 100)
                        ColorMessage("Wprowadzona liczba jest spoza przedziału", ConsoleColor.Red);
                    else if (number > randomNumber)
                        ColorMessage("Wylosowana liczba jest mniejsza", ConsoleColor.Red);
                    else
                        ColorMessage("Wylosowana liczba jest większa", ConsoleColor.Red);
                }
                else
                    ColorMessage("Wprowadzona wartość nie jest liczbą całkowitą", ConsoleColor.Red);


            } while (!correctAnswer);
                
            
        }
        /// <summary>
        /// Metoda wypisująca w konsoli podany tekst w podanym kolorze
        /// </summary>
        /// <param name="input"></param>
        /// <param name="color"></param>
        static void ColorMessage(string input, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(input);
            Console.ResetColor();
        }
    }
}