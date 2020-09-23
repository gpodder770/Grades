using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak("Hello! This is a Gradebook porgram");

            GradeBook book = new GradeBook();
            book.AddGrade(43);
            book.AddGrade(91.56f);
            book.AddGrade(77);

            GradeStatistics stats = book.ComputeStatistics();

            Console.WriteLine(stats.AvgGrade);
            Console.WriteLine(stats.HighestGrade);
            Console.WriteLine(stats.LowestGrade);
        }
    }
}
