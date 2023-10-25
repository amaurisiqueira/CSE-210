using System;

class Program
{
    static void Main(string[] args)
    {
        //simple assignment
        Assignment assignment = new("Samuel Bennet", "Multiplication");
        assignment.GetSummary();
        // mathAssignment
        MathAssignment mathAssign = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        mathAssign.GetHomeworksList();
        // writing 
        WriteAssignment writeAssign = new("Mary Waters", "European History", "The Causes of World War II by Mary Waters");
        writeAssign.GetWritingInformation();

    }
}