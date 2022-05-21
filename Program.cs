using System;


namespace ExamTestProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------WELCOME TO THE CLASS TEST PROGRAM---------------\n\n");
            RegexProb prob = new RegexProb();

            PerfectNumber pr = new PerfectNumber();

            ReverseNumber rev = new ReverseNumber();

            int[] intArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6 };
            char[] charArray = { 'P', 'R', 'A', 'F', 'U', 'L' };

            GenericExample generic = new GenericExample();
            generic.getGen(intArray);
            generic.getGen(doubleArray);
            generic.getGen(charArray);
            
        }
    }
}
