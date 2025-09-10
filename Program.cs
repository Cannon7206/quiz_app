using System.Runtime.Serialization;

namespace Program
{
    class Quiz
    {
        static void Main()
        {
            Quiz PG = new();
            int input;
            bool running = true;
            while (running)
            {
                input = Console.Read();
                switch (input)
                {
                    case 1:
                        Console.WriteLine("1. Start Quiz!");
                        PG.Test();
                        break;
                    case 2:
                        Console.WriteLine("2. Close Program!");
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Option!");
                        break;
                }
            }
        }
        public void Test()
        {
            bool run = true;
            int i = 1;
            string[] res;
            int input;
            Console.WriteLine("Starting Quiz!!");
            Console.WriteLine("Answer by typing in 1, 2, 3, or 4");
            while (run)
            {
                if (QuestionList(i)[1] == "end")
                {
                    run = false;
                }
                else
                {
                    res = QuestionList(i);
                    PrintQ(res);
                    input = Console.Read();
                    Check(res[6], input);
                }
            }
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
        public static void Check(string a, int b)
        {
            if (b > 0 && b <= 4)
            {
                string x = Convert.ToString(b);
                if (x == a)
                {
                    Console.WriteLine("Correct Answer!");
                }
                else
                {
                    Console.WriteLine("Incorrect Answer!");
                }
            }
            else
            {
                Console.WriteLine("Invalid Option");
            }
        }
        public static void PrintQ(string[] list)
        {
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}