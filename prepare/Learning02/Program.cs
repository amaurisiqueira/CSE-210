using System;
using Learning02;
class Program
{
    static void Main(string[] args)
    {
 

        Job job0 = new Job();
        job0._jobTitle="Software Engineer" ;
        job0._company="Microsoft";
        job0._startYear = 2019;
        job0._endYear = 2022;

        Job job1 = new Job();
        job1._jobTitle = "Manager";
        job1._company = "Apple";
        job1._startYear = 2022;
        job1._endYear = 2023;


      //  job0.Display();

        Resume myresume = new Resume();
        myresume._name = "Allison Rose";
        myresume.add(job0);
        myresume.add(job1);

        myresume.Display();

    }
}