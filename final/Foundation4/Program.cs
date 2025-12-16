using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime date = DateTime.Now;
        int duration = 30;
        List<Activity> myList = new List<Activity>();

        Running myRun = new Running(date,duration,30);
        Cycling myBike = new Cycling(date,duration,2);
        Swimming mySwim = new Swimming(date,duration,50);

        myList.Add(myRun);
        myList.Add(myBike);
        myList.Add(mySwim);

        foreach (Activity item in myList)
        {
            string summary = item.getSummary();
            Console.WriteLine(summary);
        }
    }
}