using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        Console.WriteLine("Resume");
        
        //create job 1
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;
        //assign job2 object
        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2019;
        job2._endYear = 2020;

        Resume resume = new Resume();
        resume._name = "Emery Rodziewicz";

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();


        

    }
}


//resume class keeps trakc of person's name and list of their jobs.
//shows name first, followed by displaying each one of the jobs.