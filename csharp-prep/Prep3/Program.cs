using System;

namespace Prep3
{
    class MainClass
    {

        public static int getMagicNumber( )
        {
            return (new Random()).Next(1, 20);
        }




        public static int getNumber(int Attempts) {
            int number = 0;
            while (number == 0) {
                try
                {
                    if(Attempts>0)    Console.Write("(Attemps {0}) What is the magic number?", Attempts+1);
                    else            Console.Write("What is the magic number?");
                    number = Convert.ToInt16(Console.ReadLine());
                }
                catch (Exception myexception)
                {

                    Console.Write("Invalid number, please try again! ({0})", myexception.Data);
                }


            }//end whele
            return number;
        }//end of  int getNumber() 


        public static bool getNextGame()
        {
            string result = "";
            while ( 
                    result.Trim().ToUpper().IndexOf("Y")<0 &&
                    result.Trim().ToUpper().IndexOf("N") < 0
                          
            )
            {
                try
                {
                    Console.Write("Do you want a new game? (Y/N)");
                    result = Console.ReadLine().ToUpper();

                }
                catch (Exception myexception)
                {

                    Console.Write("Invalid answer, please try again! ({0})" , myexception.Data);
                }


            }//end whele
            if (result == "Y") return true;

            return false;
        }//end of  int getNumber() 





        public static void Main(string[] args)
        {

            while (true)
            {
                Console.Clear();

                bool result_of_game = false;
                Console.WriteLine("\nWelcome to the game of guess a magic number\n\nYou have 3 chances to guess the number\n\nThe number is between 1 and 20\n\n\n");
                int times = 0;
                int magicNumber = getMagicNumber();


                do {

                  
                    //   Console.WriteLine("magic={0}", magicNumber);
                    int attempt = getNumber(times);
                    //  Console.WriteLine("attempt={0}", attempt);


                    if(attempt == magicNumber)
                    {
                        result_of_game = true;
                        break;
                    }



 
                    times++;
                } while (times < 3);

                if (result_of_game) Console.WriteLine("Congratulation!!!!! "); 
                else Console.WriteLine("I'm sorry, you'll win next time!");

                if (!getNextGame()) break;

            }//end of  WHILE 0
        }//end of main

    }// end of  class MainClass

}//end of namespace Prep3