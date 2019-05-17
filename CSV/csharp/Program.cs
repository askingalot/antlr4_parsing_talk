using System;
using System.IO;
using System.Linq;

using Antlr4.Runtime;
using Antlr4.Runtime.Tree;


class Program
{
    static void Main(string[] args)
    {
        var input = File.ReadAllText(args[0]);

        var charStream = CharStreams.fromstring(input);
        var lexer = new CSVLexer(charStream);
        var tokens = new CommonTokenStream(lexer);

        var parser = new CSVParser(tokens);
        var walker = new ParseTreeWalker();
        var listener = new CsvListener();

        walker.Walk(listener, parser.csvFile());

        foreach (var rec in listener.Records) {
            foreach (var header in listener.Header) {
                Console.WriteLine($"{header}: {rec[header]}");
            }
            Console.WriteLine();
        }
    }
}
