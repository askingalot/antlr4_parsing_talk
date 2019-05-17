using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ErrorCollector
{
    private List<Error> _errors = new List<Error>();

    public void PushErrorDateTime(DateTime dateTime)
    {
        _errors.Add(new Error { Datetime = dateTime });
    }

    public void PushExceptionName(string exceptionName)
    {
        _errors.Last().ExceptionName = exceptionName;
    }

    public void PushErrorMessage(string message)
    {
        _errors.Last().Message = message;
    }

    public void PushStackFrameClass(string className)
    {
        var frame = new StackFrame();
        frame.ClassName = className;
        _errors.Last().AddStackFrame(frame);
    }

    public void PushStackFrameMethod(string methodName)
    {
        _errors.Last().Stacktrace.Last().MethodName = methodName;
    }

    public void pushStackFrameParameter(string typeName, string parameterName)
    {
        var param = new MethodParameter(typeName, parameterName);
        _errors.Last().Stacktrace.Last().Parameters.Add(param);
    }

    public ErrorReporter GetReporter()
    {
        return new ErrorReporter(_errors);
    }
}

public class Error
{
    public string Message { get; set; }
    public string ExceptionName { get; set; }

    public DateTime Datetime { get; set; }


    private readonly List<StackFrame> _stacktrace;
    public IEnumerable<StackFrame> Stacktrace => _stacktrace;

    public Error()
    {
        _stacktrace = new List<StackFrame>();
    }

    public void AddStackFrame(StackFrame frame)
    {
        _stacktrace.Add(frame);
    }
}

public class StackFrame
{
    public string ClassName { get; set; }
    public string MethodName { get; set; }
    public List<MethodParameter> Parameters { get; } = new List<MethodParameter>();

    public override string ToString()
    {
        return $"{ClassName}.{MethodName} ({string.Join(", ", Parameters)})";
    }
}

public class MethodParameter
{
    public string TypeName { get; }
    public string ParameterName { get; }

    public MethodParameter(string typeName, string parameterName)
    {
        TypeName = typeName;
        ParameterName = parameterName;
    }

    public override string ToString()
    {
        return $"{TypeName} {ParameterName}";
    }
}