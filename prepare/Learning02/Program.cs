using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Developer";
        job1._startYear = 2010;
        job1._endYear = 2014;

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Developer";
        job2._startYear = 2014;
        job2._endYear = 2018;

        Resume resume1 = new Resume();
        resume1._name = "Teaguer Chubak";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.Display();
    }
}