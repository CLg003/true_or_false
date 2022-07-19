using System;

namespace TrueOrFalse
{
    class Program
    {
            static void Main(string[] args)
        {
            // Do not edit these lines
            Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
            string entry = Console.ReadLine();
            Tools.SetUpInputStream(entry);

            // Type your code below
            string[] questions = {
                "Is blue the same colour as red?",
                "Is your name Mary Poppins?",
                "Does a rainbow have 9 colours?"
                "Does 2 + 3 = 5?"
            }

            bool[] answers = {
                false,
                false,
                false,
                true
            }

            bool[] responses = new bool[questions.Length];

            if (questions.Length != answers.Length) {
                Console.WriteLine("Warning: The number of answers is not the same as the number of questions!");
            }
        }
    }
}
