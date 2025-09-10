using System;

namespace Program
{
    class Quiz
    {
        static void Main()
        {
            Test();
        }
        public static void Test()
        {
            string[] res;
            string input;
            int correct = 0;
            int total = 0;
            Console.WriteLine("Starting Quiz!!");
            Console.WriteLine("Answer by typing in 1, 2, 3, or 4");
            for (int i = 1; i <= 10;)
            {
                res = QuestionList(i);
                PrintQ(res);
                input = Console.ReadLine() + "";
                if (input == "1" || input == "2" || input == "3" || input == "4")
                {
                    bool a = Check(res[5], input);
                    total++;
                    if (a)
                    {
                        correct++;
                    }
                    i++;
                }
                else
                {
                    Console.WriteLine("Invalid Respone!");
                }
            }
            Console.WriteLine("Score: ", correct, "/", total, "");

        }

        public static string[] QuestionList(int number)
        {
            string[] res;
            res = number switch
            {
                1 => ["Question 1: ", "1.", "2.", "3.", "4.", "1"],
                2 => ["Question 2: ", "1.", "2.", "3.", "4.", "2"],
                3 => ["Question 3: ", "1.", "2.", "3.", "4.", "4"],
                4 => ["Question 4: ", "1.", "2.", "3.", "4.", "3"],
                5 => ["Question 5: ", "1.", "2.", "3.", "4.", "2"],
                6 => ["Question 6: ", "1.", "2.", "3.", "4.", "1"],
                7 => ["Question 7: ", "1.", "2.", "3.", "4.", "2"],
                8 => ["Question 8: ", "1.", "2.", "3.", "4.", "3"],
                9 => ["Question 9: ", "1.", "2.", "3.", "4.", "4"],
                10 => ["Question 10: ", "1.", "2.", "3.", "4.", "2"],
                _ => ["end"],
            };
            return res;
        }
        public static bool Check(string a, string b)
        {
            string x = Convert.ToString(b);
            if (x == a)
            {
                Console.WriteLine("Correct Answer!");
                return true;
            }
            else
            {
                Console.WriteLine("Incorrect Answer!");
                return false;
            }
        }
        public static void PrintQ(string[] list)
        {
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}