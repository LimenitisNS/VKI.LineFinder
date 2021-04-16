using System;
using System.Linq;
using System.IO;

namespace VKI.LineFinder
{
    class LineFinder
    {
        public static void СopyLinesToFile(string inputFile, string outputFile, int[] lineNumbers)
        {
            if(File.Exists(inputFile))
            {
                using (StreamReader sr = File.OpenText(inputFile))
                {
                    using (StreamWriter sw = File.CreateText(outputFile))
                    {
                        string line;
                        int counter = 1;

                        while ((line = sr.ReadLine()) != null)
                        {
                            if (lineNumbers.Contains(counter))
                            {
                                Console.WriteLine("line: " + line);
                                sw.WriteLine(line);
                            }

                            ++counter;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine($"Файла {inputFile} не существует или указан не верный путь");
            }
        }
    }
}
