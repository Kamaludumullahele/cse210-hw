using System;
using System.Threading.Tasks.Dataflow;
using System.Collections.Generic;







class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2020;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Software Developer";
        job2._startYear = 2019;
        job2._endYear = 2022;


        Resume resume = new Resume();
        resume._name = "Allan Smith";
        resume._jobs = new List<Job> { job1, job2 };
        resume.DisplayResume();

    }

}