using System;

class Program
{
    static void Main(string[] args)
    {
        Lecture lecture = new Lecture("Space and why it's the final frontier","James Kirk gives a lecture about space",new DateTime(2023, 8, 1,13,30,0),new Address("42 Wallaby Way","Sydney","New South Wales", "Australia"), "James Kirk",400);
        lecture.ShowShortDescription();
        Console.WriteLine("");
        Console.WriteLine("");
        lecture.ShowStandardDetails();
        Console.WriteLine("");
        Console.WriteLine("");

        lecture.ShowFullDetails();
        Console.WriteLine();
        Rsvp rsvp = new Rsvp("Timmy's Bday Party", "A birthday party for timmy", new DateTime(2023, 7,29,16,0,0),new Address("1600 Pennsylvania Avenue","Washington","District of Columbia", "Usa"),"thisisanemail@gmail.com");
        rsvp.ShowShortDescription();
        Console.WriteLine();
        rsvp.ShowFullDetails();
        Console.WriteLine();
        rsvp.ShowStandardDetails();


        Outdoor outdoor = new Outdoor("Concert", "Jeff Williams is hosting a concert", new DateTime(2023, 8, 19, 18, 23, 55), new Address("1600 Pennsylvania Avenue","Washington","District of Columbia", "Usa"), "Sunny weather");
        outdoor.ShowShortDescription();
        Console.WriteLine();
        outdoor.ShowFullDetails();
        Console.WriteLine();
        outdoor.ShowStandardDetails();

    }
}