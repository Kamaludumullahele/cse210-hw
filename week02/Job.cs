using System;
public class Job
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_company}, {_jobTitle}, From: {_startYear}, to: {_endYear}");
    }
}