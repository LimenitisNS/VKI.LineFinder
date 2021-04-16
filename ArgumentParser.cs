using System.Linq;

namespace VKI.LineFinder
{
    public class ArgumentParser
    {
        private string inputFileName;
        private string outputFileName;
        private int[] linesNumbers;

        public ArgumentParser(string[] args)
        {
            inputFileName = args[0];
            outputFileName = args[1];

            var rawLines = args.Skip(2).ToArray();

            linesNumbers = ResolveLineNumbers(rawLines);
        }

        public string InputFileName => inputFileName;
        public string OutputFileName => outputFileName;
        public int[] LinesNumbers => linesNumbers;

        private int[] ResolveLineNumbers(string[] rawLines)
        {
            var list = new int[rawLines.Length];

            for (int i = 0; i < rawLines.Length; i++)
            {
                list[i] = int.Parse(rawLines[i]);
            }

            return list;
        }
    }
}
