// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Book mistborn = new Book("Mistborn: The Final Empire", "Brandon Sanderson");
Book eragon = new Book("Eragon","Christopher Paolini");


mistborn.Display();
Console.WriteLine(mistborn.IsAvailable());
eragon.Display();
Console.WriteLine(mistborn.IsAvailable());