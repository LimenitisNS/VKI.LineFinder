using System;
using System.Linq;
using System.IO;

namespace VKI.LineFinder
{
    class LineFinder
    {
        public LineFinder(ArgumentParser arguments)
        {
            this.arguments = arguments;
        }

        public void ExtractLines()
        {
            // validation
            if (!File.Exists(arguments.InputFileName))
            {
                throw new ArgumentException($"File is not exist: {arguments.InputFileName}");
            }

            // extraction
            using (StreamReader reader = File.OpenText(arguments.InputFileName))
            {
                using (StreamWriter writer = File.CreateText(arguments.OutputFileName))
                {
                    string line;
                    int counter = 1;

                    while (!reader.EndOfStream)
                    {
                        line = reader.ReadLine();

                        if (arguments.LinesNumbers.Contains(counter))
                        {
                            writer.WriteLine(line);
                        }

                        counter++;
                    }
                }
            }
        }

        private ArgumentParser arguments;
    }
}