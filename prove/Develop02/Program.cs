using System;
using System.IO;

class Program
{
    
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        Menu menu = new Menu(myJournal);

        menu.Display();
    }
}