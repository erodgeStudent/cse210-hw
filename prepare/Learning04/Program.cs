using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
        var name1="\nSamuel Bennett";
        var top1 = "Multiplication";
        Assignment a1 = new Assignment(name1, top1);
        Console.WriteLine(a1.GetSummary());


        var name2="\nRoberto Rodriguez";
        var top2 = "Fractions";
        var section2 = "7.3";
        var problems2 = "9-19";
        MathAssignment a2 = new MathAssignment(name2, top2, section2, problems2);
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        var name3 = "\nMary Waters";
        var top3 = "European History";
        var title = "The Causes of World War II";
        WritingAssignment a3 = new WritingAssignment(name3, top3, title);
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}