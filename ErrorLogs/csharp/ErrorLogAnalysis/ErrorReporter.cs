using System;
using System.Collections.Generic;
using System.Linq;

public class ErrorReporter
{
    private readonly List<Error> _errors;

    public ErrorReporter(List<Error> errors)
    {
        _errors = errors;
    }

    public int ErrorCount => _errors.Count;

    public List<string> TopErrorMessages(int count)
    {
        return _errors
            .GroupBy(e => $"{e.ExceptionName}: {e.Message}")
            .OrderByDescending(g => g.Count())
            .Take(count)
            .Select(g => $"{g.Count()}: {g.Key}")
            .ToList();
    }

    public List<string> TopMethodSignatures(int count, bool includeSystem = false)
    {
        return _errors
            .SelectMany(e => e.Stacktrace)
            .Where(st => includeSystem || !st.ClassName.Contains("System"))
            .GroupBy(st => st.ToString())
            .OrderByDescending(g => g.Count())
            .Take(count)
            .Select(g => $"{g.Count()}: {g.Key}")
            .ToList();
    }

    public List<(int, int)> ErrorCountByHour()
    {
        var countByHour = _errors
            .GroupBy(e => e.Datetime.Hour)
            .ToDictionary(g => g.Key, g => g.Count());

        return Enumerable.Range(0, 24)
            .Select(h => (h, countByHour.GetValueOrDefault(h)))
            .ToList();
    }
}
