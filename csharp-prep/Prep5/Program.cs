using System;

class Program
{

    static void DisplayWelcome() {
        Console.WriteLine("Welcome to the Program!");
    }// -----------------------

   // static void  - Asks for and returns the user's name (as a string)
   public static string PromptUserName()
    {
        string result = "";
        while (
                result.Trim().Length<2
        )
        {
            try
            {
                Console.Write("Please enter your name: ");
                result = Console.ReadLine().Trim();

            }
            catch (Exception myexception)
            {

                Console.Write("Invalid answer, please try again! ({0})", myexception.Data);
            }


        }//end whele
  
        return result;
    }//end of  int getNumber() 



    public static int PromptUserNumber()
    {
        int number = 0;
        while (number == 0)
        {
            try
            {
                Console.Write("Please enter your favorite number:");
                number = Convert.ToInt16(Console.ReadLine());
            }
            catch (Exception myexception)
            {

                Console.Write("Invalid number, please try again! ({0})", myexception.Data);
            }


        }//end whele
        return number;
    }//end of  int getNumber() 


    public static int SquareNumber(int a)
    {
        return a * a;
    }

    public static void DisplayResult(string name, int number)
    {
        Console.WriteLine("{0}, the square of your number is {1}", name , number);
    }


 


    static void Main(string[] args)
    {

        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        DisplayResult(name, SquareNumber (number));

    }
}