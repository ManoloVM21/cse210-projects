using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();

        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2025;


        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Software Assistant";
        job2._startYear = 2016;
        job2._endYear = 2019;

        Resume presume = new Resume();
        presume._name = "Joseph Gardner";
        presume._jobs.Add(job1);
        presume._jobs.Add(job2);
        Console.WriteLine(presume._jobs[0]._jobTitle);
        presume.Display();

    }
}