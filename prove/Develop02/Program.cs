using System;

class Program
{
    static void Main(string[] args)
    {
        bool condition = false;

        Journal myJournal = new Journal();

        while (condition == false)
        {
            Console.WriteLine("Welcome to the Journal");
            Console.WriteLine("1. Write\n2.Display\n3.Load\n4.Save\n5.Quit");
            Console.WriteLine();
            string answer = Convert.ToString(Console.ReadLine());
            Console.WriteLine();

            if (answer == "1")
            {
                myJournal.AddEntry();
            }
            else if (answer == "2")
            {
                myJournal.DisplayJournal();
            }
            else if (answer == "3")
            {
                Console.WriteLine("Please Enter Journal File: ");
                Console.Write(">");
                string myFile = Console.ReadLine();
                myJournal.LoadEntries(myFile);
            }
            else if (answer == "4")
            {
                Console.WriteLine("Name of file to save to: ");
                Console.Write(">");
                string myFile = Console.ReadLine();
                myJournal.SaveEntries(myFile);
            }
            else if (answer == "5")
            {
                break;
            }
            else
            {
                Console.WriteLine("ERROR: INVALID INPUT");
            }
        }
    }
}