
//Console.WriteLine("Hello, World!");

Board quoteboard = new Board();

Source source = new Source("None Were with Him","https://www.churchofjesuschrist.org");
//Console.WriteLine(source.Stringify());
Quote holland = new Quote("Jeffery R Holland","Because jesus walked such a long, lonely path utterly alone, we do not have to.", source);
//Console.WriteLine(holland.GetQuote());
quoteboard.AddQuote(holland);
quoteboard.AddQuote(new Quote("Paul","God hath not given us the spirit of fear; but of power, and of love, and of a sound mind.", new Source("2 Timothy 1:7")));
quoteboard.AddQuote(new Quote("Sister Elaine S. Dalton", "Work hard to achieve your dreams. Don't let discouragement or mistakes delay you.", new Source("How to Dare Great Things", "https://www.churchofjesuschrist.org/study/new-era/2012/03/how-to-dare-great-things?lang=eng")));
quoteboard.AddQuote(new Quote("Alma","If ye have faith ye hope for thingswhich are not seen, which are true.", new Source("Alma 32:21")));
quoteboard.AddQuote(new Quote("Alma","Counsel with the lord in all thy doings, and he will direct thee for good.",new Source("Alma 37:37")));
quoteboard.AddQuote(new Quote("Alma","Live in thanksgiving Daily.", new Source("Alma 34:38")));

Menu _menu = new Menu(quoteboard);
_menu.Display();
