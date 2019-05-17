using System;
using System.Linq;

public class ErrorLogListener : ErrorLogBaseListener
{
    public ErrorCollector Collector { get; } = new ErrorCollector();

    public override void ExitDatetime(ErrorLogParser.DatetimeContext context)
    {
        var (month, day, year, hour, minute, ampm) =
            (context.MONTH().GetText(), context.day().GetText(), context.year().GetText(),
             context.hour().GetText(), context.minute().GetText(), context.AM_PM().GetText());

        var dateTime = DateTime.Parse($"{month} {day} {year}, {hour}:{minute} {ampm}");

        Collector.PushErrorDateTime(dateTime);
    }

    public override void ExitException_type(ErrorLogParser.Exception_typeContext context)
    {
        Collector.PushExceptionName(context.GetText());
    }

    public override void ExitError_message(ErrorLogParser.Error_messageContext context)
    {
        var message = context
            .children
            .Select(c => c.GetText())
            .Aggregate((msg, txt) => IsAlphaNum(txt) ? $"{msg} {txt}" : $"{msg}{txt}");

        Collector.PushErrorMessage(message);
    }

    public override void ExitMethod_signature(ErrorLogParser.Method_signatureContext context)
    {
        var className = string.Join(".",
            context.class_name().IDENTIFIER().Select(id => id.GetText()));
        Collector.PushStackFrameClass(className);

        var methodName = context.method_name().IDENTIFIER().GetText();
        Collector.PushStackFrameMethod(methodName);

        var paramList = context.parameter_list();
        var typeNames = paramList.type().Select(t => t.GetText());
        var paramNames = paramList.IDENTIFIER().Select(i => i.GetText());
        foreach (var (typeName, paramName) in typeNames.Zip(paramNames, (t, p) => (t, p)))
        {
            Collector.pushStackFrameParameter(typeName, paramName);
        }
    }

    private bool IsAlphaNum(string s)
    {
        return s.All(ch => char.IsLetterOrDigit(ch));
    }
}