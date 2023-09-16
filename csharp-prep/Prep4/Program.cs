using System;
using System.Collections.Generic;

namespace Prep4
{
    class MainClass
    {

        public static void processIntegers(ref List<int> data,
            ref int sum ,
            ref double averange,
            ref int largeNumber,
            ref int smalPositive
          )
        {



            data.Sort();
            largeNumber = Int16.MinValue;
            smalPositive = Int16.MaxValue;
            double summary = 0;
            foreach(int a in data)
            {
                summary += Convert.ToDouble(a);
                if (a > largeNumber) largeNumber = a;
                if (a < smalPositive && a>0) smalPositive = a;

            }
            double div = 1;
            if (data.Count > 0) div = data.Count;
            averange = summary / div;
            sum = Convert.ToInt16(summary);





        }//end of process

        public static int getNumber( )
        {
            int number = Int16.MaxValue;
            while (number == Int16.MaxValue)
            {
                try
                {

                        Console.Write("Enter number:");

                     
                   
                     number = Convert.ToInt16(Console.ReadLine());
                }
                catch (Exception myexception)
                {

                    Console.Write("Invalid number, please try again! ({0})", myexception.Data);
                }


            }//end whele
            return number;
        }//end of  int getNumber() 




        public static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Enter a list of numbers, (type 0 when finished)?");
            List<int> myList = new List<int>();
            while (true)
            {

                int mynumber = getNumber();
                if(mynumber == 0) break;
                myList.Add(mynumber);


            }//end while true

            int sum=0;
            double averange = 0;
            int largeNumber = 0;
            int smalPositive = 0;

            processIntegers(ref myList,
            ref sum,
            ref averange,
            ref largeNumber,
            ref smalPositive
          );

            Console.WriteLine("WriteThe sum is: {0}", sum);
            Console.WriteLine("The average is: {0}", averange);


            Console.WriteLine("The largest number is:  {0}", largeNumber);
            Console.WriteLine("The smallest positive number is: {0}", smalPositive);
            Console.WriteLine("The sorted list is:");
            foreach ( int ordened in myList)
            {
                Console.WriteLine("{0}", ordened);

            }




        }//end void main
    }// end of mainclass

}
