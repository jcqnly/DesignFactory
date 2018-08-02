using DesignFactory.Classes.Report;
using DesignFactory.Classes.Report.Parts;
using DesignFactory.Classes.Resume.Parts;
using System;

namespace DesignFactory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Documents();
            Console.ReadLine();
        }

        public static void Documents()
        {
            Preface preface = new Preface();
            Console.WriteLine($"'{preface.Name}' is the Preface.");
            Console.WriteLine($"It has {preface.NumberOfPages} pages");
            Console.WriteLine($"{preface.Name} has {preface.NumberOfSources} sources,");
            Console.WriteLine($"and it was written in the {preface.Style} style.");
            Console.WriteLine("--------------------------------------------------");

            Conclusion conclusion = new Conclusion();
            Console.WriteLine($"'{conclusion.Name}' is the conclusion.");
            Console.WriteLine($"It has {conclusion.NumberOfPages} pages");
            Console.WriteLine($"{conclusion.Name} has {conclusion.NumberOfSources} sources,");
            Console.WriteLine($"and it was written in the {conclusion.Style} style.");
            Console.WriteLine("--------------------------------------------------");

            Bibliography bibliography = new Bibliography();
            Console.WriteLine($"'{bibliography.Name}' is the bibliography.");
            Console.WriteLine($"It has {bibliography.NumberOfPages} pages");
            Console.WriteLine($"{bibliography.Name} has {bibliography.NumberOfSources} sources,");
            Console.WriteLine($"and it was written in the {bibliography.Style} style.");
            Console.WriteLine("--------------------------------------------------");

            CoverLetter CL = new CoverLetter();
            Console.WriteLine($"{CL.PersonName} is applying for {CL.JobType} jobs and is their cover letter done? {CL.Complete}!");
            Console.WriteLine("--------------------------------------------------");

            ProfessionalReferences PR = new ProfessionalReferences();
            Console.WriteLine($"{PR.PersonName} is applying for {PR.JobType} jobs and is their cover letter done? {PR.Complete}!");
            Console.WriteLine("--------------------------------------------------");

            WorkHistory WH = new WorkHistory();
            Console.WriteLine($"{WH.PersonName} is applying for {WH.JobType} jobs and is their cover letter done? {WH.Complete}!");
        }
    }
}
