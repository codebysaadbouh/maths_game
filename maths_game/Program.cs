using System;

namespace maths_game
{
    class Program
    {

        static bool poserQuestion(int min_number, int max_number)
        {
            Random rand = new Random();
            int a = rand.Next(min_number, max_number++);
            int b = rand.Next(min_number, max_number++);
            int op = rand.Next(1, 3);
            int result = 0;





            int response_int = 0;
            // bool response_bool; 
            while (true)
            {
                if (op == 1) // addition
                {
                    result = a + b;
                    Console.Write($"{a} + {b} = ");
                }
                else
                {
                    result = a - b;
                    Console.Write($"{a} - {b} = ");
                }

                string response_str = Console.ReadLine();

                try
                {
                    response_int = int.Parse(response_str);

                    if (response_int == result)
                    {
                        return true;
                    }

                    return false;
                }
                catch
                {
                    Console.WriteLine("ERREUR : vous devez rentrer un nombre !");
                }
            }



        }


        static void Main(string[] args)
        {
            const int MIN_NUMBER = 1;
            const int MAX_NUMBER = 10;
            const int NB_QUESTION = 6;
            float moyenne = NB_QUESTION / 2f;
            int nb_score = 0;

            for (int q = 1; q <= NB_QUESTION; q++)
            {
                Console.WriteLine();
                Console.WriteLine($"Qestion n°{q}/{NB_QUESTION}");
                Console.WriteLine();

                bool reponse = poserQuestion(MIN_NUMBER, MAX_NUMBER);

                if (reponse)
                {
                    Console.WriteLine();
                    Console.WriteLine("Bonne réponse !");
                    nb_score++;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Mauvaise réponse !");
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Score : {nb_score}/{NB_QUESTION}");
            Console.WriteLine();

            if (nb_score == 0)
            {
                Console.WriteLine("Révisez vos maths ! travailez !");
            }
            else if (nb_score == NB_QUESTION)
            {
                Console.WriteLine("Excellent !");
            }
            else if (nb_score > moyenne)
            {
                Console.WriteLine("Pas mal !");
            }
            if (nb_score <= moyenne)
            {
                Console.WriteLine("Peut mieux faire !");
            }



        }
    }
}
