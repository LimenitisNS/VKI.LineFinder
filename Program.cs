using System;

namespace VKI.LineFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var resolvedArgs = new ArgumentParser(args);
                var finder = new LineFinder(resolvedArgs);

                finder.ExtractLines();

                Console.ReadKey();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }
    }
}
