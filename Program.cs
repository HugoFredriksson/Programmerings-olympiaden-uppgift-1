using System;

namespace sak
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int returnValue = random.Next(1, 1000);
            int Guess = 0;
            int count = 0;

            Console.WriteLine("Jag förstod inte några frågor eftersom jag inte riktigt har programmerat på ett år så jag gjorde det här istället för det var enklare. :-)");

            Console.WriteLine("Skriv ett number mellan 1 och 1000 och försök gissa det tal datorn har genererat");

            while (Guess != returnValue)
                {
                
                string line = Console.ReadLine();
                 
                if (!int.TryParse(line, out Guess))
                    Console.WriteLine("Inte en Integer, Grrrr");
                
                else {
                    count++;
                    
                    if (Guess < returnValue)
                        {
                            Console.WriteLine("Datorns tal är högre än " + Guess + ". Försök igen");
                        }
                    
                        if (Guess > returnValue)
                            {
                                Console.WriteLine("Datorns tal är mindre än " + Guess + ". Försök igen");
                            }

                    }
                }

                Console.WriteLine("Najs, talet var " + returnValue + " och du tog " + count + " försök på dig att gissa rätt svar!");
        }
    }
}