using System;

class Program
{
    static void Main(string[] args)
    {

        string userinput;

        bool cancontinue = true;

        Scripture scripture = new Scripture();

        do
        {   Console.Clear();
            scripture.DisplayScripture();

            Console.WriteLine("Press Enter to contuinue or type 'quit' to exit.");

            userinput = Console.ReadLine();

            cancontinue = scripture.HideWords(3);
        } while (userinput != "quit" && cancontinue);
        

       
        
    }
}