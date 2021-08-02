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
            int result = a + b; 


            int response_int = 0;
            // bool response_bool; 
            while (true)
            {
                Console.Write($"{a} + {b} = ");
                string response_str = Console.ReadLine();

                try
                {
                    response_int = int.Parse(response_str);
                    // response_bool = response_int == result;
                    if (response_int == result)
                    {
                        // Console.WriteLine("Bonne réponse");
                        return true; 
                    }
                    /**
                         else
                        {
                            Console.WriteLine("Mauvaise réponse"); 
                        }
                     */

                    return false; 
                }
                catch
                {
                    Console.WriteLine("ERREUR : vous devez rentrer un nombre !");
                }
            }

            // Console.WriteLine(response_bool); 
            // return response_bool;

        }
       
        
        static void Main(string[] args)
        {
            const int MIN_NUMBER = 1;
            const int MAX_NUMBER = 30;

            bool reponse = poserQuestion(MIN_NUMBER, MAX_NUMBER);

            if (reponse)
            {
                Console.WriteLine("Bonne réponse");
            }
            else
            {
                Console.WriteLine("Mauvaise réponse");
            }

        }
    }
}
