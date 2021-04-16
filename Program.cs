using System;

namespace VKI.LineFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            var parser = new ArgumentParser(args);
            LineFinder.СopyLinesToFile(parser.InputFileName, parser.OutputFileName, parser.LinesNumbers);
            Console.ReadKey();
        }
    }
}
