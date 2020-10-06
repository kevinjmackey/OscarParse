using System;
using System.IO;
using CommandLine;
namespace DV.Oscar
{
    public class Options
    {
        [Option('i', "input", Required = true, HelpText = "The file to parse")]
        public string InputFile { get; set; }
        [Option('o', "output", Required = false, HelpText = "The parsed output file")]
        public string OutputFile { get; set; }
        [Option('d', "display", Required = false, Default = false, HelpText = "Display the Oscar metadata")]
        public bool Display { get; set; }
    }
    class ParseOscar
    {
        static void Main(string[] args)
        {
            string inputFile = "";
            string outputFile = "";
            bool displayMetadata = false;
            Parser.Default.ParseArguments<Options>(args)
                    .WithParsed<Options>(o =>
                    {
                        inputFile = o.InputFile;
                        outputFile = (o.OutputFile != null) ? o.OutputFile : "";
                        displayMetadata = o.Display;
                    });

            if (!File.Exists(inputFile))
            {
                Console.WriteLine($"File {inputFile} does not exist");
                System.Environment.Exit(0);
            }
            if (outputFile.Length == 0)
            {
                string outputDir = $"{Path.GetDirectoryName(Path.GetFullPath(inputFile))}{Path.DirectorySeparatorChar.ToString()}";
                outputFile = $"{outputDir}{Path.GetFileNameWithoutExtension(inputFile)}.json";
            }
            System.Console.WriteLine($"Input file: {inputFile} \nOutput File: {outputFile}");
            ParseOscarFile p = new ParseOscarFile();
            p.ParseFile(inputFile, displayMetadata);
            p.DumpAst(outputFile);
            p = null;
        }
    }
}
