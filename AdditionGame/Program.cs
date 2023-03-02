using System;

namespace AdditionGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nAddition Game\n");

            //difficulty level
            int difficulty = 0;
            while (difficulty < 1 || difficulty > 3)
            {
                Console.WriteLine("Enter Level 1, 2, 3: ");
                if (!int.TryParse(Console.ReadLine(), out difficulty)) {
                    Console.WriteLine("Error: Invalid input!");
                    difficulty = 0;
                } else if (difficulty < 1 || difficulty > 3) {
                    Console.WriteLine("Error: Invalid input!");
                }
            }
            //number of questions (func)
            int numOfQuestions = GetNumOfQuestions();
            Console.WriteLine();

            int correctAnswers = 0;
            for (int i = 1; i <= numOfQuestions; i++) {
                //generate question
                int x = GenerateNumbers(difficulty);
                int y = GenerateNumbers(difficulty);
                int answer = x + y;
                //print question
                Console.WriteLine($"{x} + {y} = ");
                //prompt for answer (3 tries)
                bool isCorrect = false;
                for (int j = 1; j <= 3 && !isCorrect; j++) {
                    if (int.TryParse(Console.ReadLine(), out int userAnswer)) {
                        if (userAnswer == answer) {
                            Console.WriteLine("CORRECT!!!\n");
                            correctAnswers++;
                            isCorrect = true;
                            
                        } else {
                            Console.WriteLine($"WRONG!!! {j} out of 3 tries used\n"); 
                        }
                    } else {
                        Console.WriteLine($"WRONG!!! {j} out of 3 tries used\n");
                    }
                }
                if (!isCorrect) {
                    Console.WriteLine($"Correct Answer: {answer}");
                }

            }

            //output score and percentage 
            double percentage = ((double)correctAnswers / numOfQuestions) * 100;
            Console.WriteLine($"You got {correctAnswers} out of {numOfQuestions} questions correct: {percentage:F2}%");

        }

        static int GetNumOfQuestions() {
            int num = 0;
            while (num < 1 || num > 10) {
                Console.WriteLine("\nEnter number of questions to ask: 1 to 10");
                if (!int.TryParse(Console.ReadLine(), out num)) {
                    Console.WriteLine("ERROR: Please enter an integer value between 1 and 10.");
                } else if (num < 1 || num > 10) {
                    Console.WriteLine("ERROR: Please enter an integer value between 1 and 10.");
                } 
            }
            return num;
        }

        static int GenerateNumbers(int difficulty) {
            int minValue = 0;
            int maxValue = 0;

            switch (difficulty)
            {
                case 1:
                    minValue = 0;
                    maxValue = 9;
                    break;
                case 2:
                    minValue = 10;
                    maxValue = 99;
                    break;
                case 3:
                    minValue = 100;
                    maxValue = 999;
                    break;
            }
            Random random = new Random();
            return random.Next(minValue, maxValue + 1);
        }
    }
}
        
    

