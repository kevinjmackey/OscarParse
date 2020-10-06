using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using uast;
namespace DV.Oscar
{
    public class ParseOscarFile
    {
        private uast.UastNode _ast;
        public uast.UastNode Ast { get => _ast; set => _ast = value; }

        private bool StartsWithInclude(string line)
        {
            return (line.Trim().ToLower().StartsWith("#include ")) ? true : false;
        }
        private string ProcessFile(string line)
        {
            string[] words = line.Trim().Split(" ");
            return (words.Length > 1) ? ReadFile(words[1]) : "";
        }
        private string ReadFile(string filepath)
        {
            StringBuilder sb = new StringBuilder();
            if (File.Exists(filepath))
            {
                IEnumerable<String> textLines = File.ReadLines(filepath);
                foreach (string line in textLines)
                {
                    if (StartsWithInclude(line))
                    {
                        sb.Append(ProcessFile(line));
                    }
                    else
                    {
                        sb.Append(line);
                        sb.Append(System.Environment.NewLine);
                    }
                }
            }
            else
            {
                System.Console.WriteLine($"File: {filepath} not found!");
            }
            return sb.ToString();
        }
        public bool ParseFile(string filePath, bool displayMetadata)
        {
            bool result = false;
            ICharStream chars = CharStreams.fromstring(ReadFile(filePath));
            DVOscarLexer lexer = new DVOscarLexer(chars);
            CommonTokenStream stream = new CommonTokenStream(lexer);
            DVOscarParser parser = new DVOscarParser(stream);

            var tree = parser.dvoscar_file();
            DVOscarVisitor visitor = new DVOscarVisitor();
            visitor.DvoFile = Path.GetFileName(filePath);
            bool tf = visitor.Visit(tree);
            _ast = visitor.UastTree;

            if (displayMetadata == true)
            {
                System.Console.WriteLine($"File Contents: \n{ReadFile(filePath)}");
            }
            return result;
        }
        public void DumpAst(string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                UastNode.Dumps(_ast).CopyTo(fs);
                fs.Flush();
            }
        }
    }
}
