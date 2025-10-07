using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Programmer";
        job1._company = "Microsoft";
        job1._startYear = 2001;
        job1._endYear = 2023;


        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "McDonalds";
        job2._startYear = 2023;
        job2._endYear = 2025;
    }
}