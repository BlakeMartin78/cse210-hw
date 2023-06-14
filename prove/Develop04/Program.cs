using System;

class Program
{
    static void Main(string[] args)
    {
        int response = 0;
        while(response != 4)
        {
            
            Console.Clear();
            Console.WriteLine("\n Mindfulness Program\n");
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflection activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            
            Console.Write(" >");
            response = int.Parse(Console.ReadLine() ?? String.Empty);
            

            Breathing breath = new Breathing();
            Reflection reflect = new Reflection();
            Listing list = new Listing();

            switch (response)
            {
                case 1:
                    
                    breath.RunActivity();
                    break;

                case 2:
                    
                    reflect.RunActivity();
                    break;

                case 3:
                
                    list.RunActivity();
                    break;

                case 4:
                    Environment.Exit(0);
                    break;

                    
            }
            
        }
    }

    
}
