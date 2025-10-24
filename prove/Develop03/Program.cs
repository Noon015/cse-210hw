using System;

class Program
{
    static void Main(string[] args)
    {
        Refrence myRef = new Refrence("Isaiah", 5, 20);
        string scriptureText = "Woe unto them that call evil good and good evil; that put darkness for light and light for darkness; that call bitter sweet, and sweet bitter";
        Scripture myScripture = new Scripture(scriptureText, myRef);
        Console.Clear();
        while (true)
        {
            Console.WriteLine(myScripture.DisplayScripture());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type quit to exit");
            string answer = Console.ReadLine();

            if (answer == "quit")
            {
                break;
            }
            else if (string.IsNullOrWhiteSpace(answer))
            {
                if (myScripture.AllWordsHidden() == false)
                {
                    myScripture.HideScripture();
                }
                else if (myScripture.AllWordsHidden())
                {
                    break;
                }
            }
            Console.Clear();
        }
    }
}