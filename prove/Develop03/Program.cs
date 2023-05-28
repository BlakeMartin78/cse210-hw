using System;

class Program
{
    static void Main(string[] args)
    {
        Reference scriptReference = new Reference("Doctrine & Covenants",36,6);
        Scripture dnc6 = new Scripture(scriptReference, "Look unto me in every thought; doubt not, fear not.");
        string quitCheck = "";
        Console.WriteLine("To continue, press enter. To quit, type Quit.");
        
        int firstTime = 0;
        
        while ((quitCheck.ToUpper() != "QUIT") && (dnc6.isAllHidden() != true))
        {
        
            if (firstTime == 0) // This if/else exists purely to skip the first instance, it's kinda ugly though.
            {
                firstTime++;
            }
            else
            {
                dnc6.HideRandomWord();
            }

            dnc6.Display();
            quitCheck = Console.ReadLine();
            
            Console.Clear();
        }
    }
}