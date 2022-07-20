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
            // Uses additional Tools functionality set up by Codecademy (unseen)
            Tools.SetUpInputStream(entry);

            // Type your code below
            // QUESTIONS
            string[] questions = {
                "Is blue the same colour as red?",
                "Is your name Mary Poppins?",
                "Does a rainbow have 9 colours?",
                "Does 2 + 3 = 5?"
            };

            // ANSWERS
            bool[] answers = {
                false,
                false,
                false,
                true
            };

            bool[] responses = new bool[questions.Length];

            if (questions.Length != answers.Length) {
                Console.WriteLine("Warning: The number of answers is not the same as the number of questions!");
            }

            // ASKING QUESTIONS
            int askingIndex = 0;
            foreach (string question in questions) {
                string input;
                bool isBool;
                bool inputBool;

                Console.WriteLine(questions[askingIndex]);
                Console.WriteLine("True or False?");
                input = Console.ReadLine();

                isBool = Boolean.TryParse(input, out inputBool);
                // VALIDATING INPUT
                while (!isBool) {
                    Console.WriteLine("Please respond with 'True' or 'False'.");
                    input = Console.ReadLine();
                    isBool = Boolean.TryParse(input, out inputBool);
                }
                responses[askingIndex] = inputBool;
                askingIndex ++;
            }

            // Checking responses accurately recorded
            // foreach (bool response in responses) {
            //     Console.WriteLine(response);
            // }

            // SCORING
            int scoringIndex = 0;
            int score = 0;
            foreach(bool answer in answers) {
                bool userResponse = responses[scoringIndex];
                Console.WriteLine($"{scoringIndex + 1}. Input: {userResponse} | Answer: {answer}");
                
                if (userResponse == answer) {
                    score ++;
                }
                scoringIndex ++;
            }

            Console.WriteLine($"You got {score} out of {answers.Length} correct!");
        

        } // Main
    } // Program
} // TrueOrFalse

