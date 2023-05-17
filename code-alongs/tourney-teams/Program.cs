// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



Player neymar = new Player("Neymar jr.",10,"Forward");

Player kobe = new Player("Kobe Bryant", 24);
kobe.SetPosition("Shooting Guard");



Team awesomeSauce = new Team("Awesome Sauce");
awesomeSauce.AddPlayer(kobe);
awesomeSauce.AddPlayer(neymar);



awesomeSauce.AddWin();
awesomeSauce.AddWin();
awesomeSauce.AddWin();
awesomeSauce.AddWin();
awesomeSauce.AddWin();
awesomeSauce.AddWin();
awesomeSauce.AddLoss();
awesomeSauce.DisplayRoster();