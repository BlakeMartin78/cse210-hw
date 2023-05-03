using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning02 World!");
        Job job1 = new Job();
        job1._jobTitle = "Fry Cook";
        job1._company = "McDonalds";
        job1._startYear = 1984;
        job1._endYear = 2014; // inputs values for the first job
        //job1.Display();
    
        Job job2 = new Job();
        job2._jobTitle = "Sandwich Artist";
        job2._company = "Subway";
        job2._startYear = 2018;
        job2._endYear = 2019; // inputs values for the second job

        Resume theResumeInQuestion = new Resume();
        theResumeInQuestion._name = "Joe Schmo";
        theResumeInQuestion._jobs.Add(job1);
        theResumeInQuestion._jobs.Add(job2); //sets the resume name and adds the job to the resume class in question

        theResumeInQuestion.Display();

    }
}