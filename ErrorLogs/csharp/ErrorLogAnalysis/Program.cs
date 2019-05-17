using System;
using System.IO;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length == 0 || !File.Exists(args[0]))
        {
            Console.WriteLine("You did it wrong...Gimme a file!");
            Environment.Exit(1);
        }

        var input = File.ReadAllText(args[0]);

        var stream = CharStreams.fromstring(input);
        var lexer = new ErrorLogLexer(stream);
        var tokens = new CommonTokenStream(lexer);

        var parser = new ErrorLogParser(tokens);

        var walker = new ParseTreeWalker();
        var listener = new ErrorLogListener();

        walker.Walk(listener, parser.logfile());
        var reporter = listener.Collector.GetReporter();

        Console.WriteLine($"Error Count: {reporter.ErrorCount}");

        var top = 10;
        Console.WriteLine($"\nTop {top} Errors");
        reporter.TopErrorMessages(top)
                .ForEach(Console.WriteLine);

        Console.WriteLine($"\nTop {top} Method Signatures");
        reporter.TopMethodSignatures(top, includeSystem: false)
                .ForEach(Console.WriteLine);

        Console.WriteLine("\nError Count per Hour");
        var countByHour = reporter.ErrorCountByHour();
        var halfSize = countByHour.Count / 2;
        for (var i = 0; i < halfSize; i++)
        {
            var (hour, count) = countByHour[i];
            Console.Write($"{hour:00}: {count:00}    ");

            (hour, count) = countByHour[i + halfSize];
            Console.WriteLine($"{hour:00}: {count:00}");
        }
    }
}
