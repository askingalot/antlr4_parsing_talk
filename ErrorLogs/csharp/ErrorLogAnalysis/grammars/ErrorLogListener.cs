//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from grammars/ErrorLog.g4 by ANTLR 4.7.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="ErrorLogParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.2")]
[System.CLSCompliant(false)]
public interface IErrorLogListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="ErrorLogParser.logfile"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLogfile([NotNull] ErrorLogParser.LogfileContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ErrorLogParser.logfile"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLogfile([NotNull] ErrorLogParser.LogfileContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ErrorLogParser.line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLine([NotNull] ErrorLogParser.LineContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ErrorLogParser.line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLine([NotNull] ErrorLogParser.LineContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ErrorLogParser.logline"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLogline([NotNull] ErrorLogParser.LoglineContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ErrorLogParser.logline"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLogline([NotNull] ErrorLogParser.LoglineContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ErrorLogParser.datetime"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDatetime([NotNull] ErrorLogParser.DatetimeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ErrorLogParser.datetime"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDatetime([NotNull] ErrorLogParser.DatetimeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ErrorLogParser.day"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDay([NotNull] ErrorLogParser.DayContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ErrorLogParser.day"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDay([NotNull] ErrorLogParser.DayContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ErrorLogParser.year"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterYear([NotNull] ErrorLogParser.YearContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ErrorLogParser.year"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitYear([NotNull] ErrorLogParser.YearContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ErrorLogParser.hour"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterHour([NotNull] ErrorLogParser.HourContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ErrorLogParser.hour"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitHour([NotNull] ErrorLogParser.HourContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ErrorLogParser.minute"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMinute([NotNull] ErrorLogParser.MinuteContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ErrorLogParser.minute"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMinute([NotNull] ErrorLogParser.MinuteContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ErrorLogParser.skip_to_exception_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSkip_to_exception_type([NotNull] ErrorLogParser.Skip_to_exception_typeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ErrorLogParser.skip_to_exception_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSkip_to_exception_type([NotNull] ErrorLogParser.Skip_to_exception_typeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ErrorLogParser.skip_to_error_label"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSkip_to_error_label([NotNull] ErrorLogParser.Skip_to_error_labelContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ErrorLogParser.skip_to_error_label"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSkip_to_error_label([NotNull] ErrorLogParser.Skip_to_error_labelContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ErrorLogParser.exception_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterException_type([NotNull] ErrorLogParser.Exception_typeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ErrorLogParser.exception_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitException_type([NotNull] ErrorLogParser.Exception_typeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ErrorLogParser.error_and_stacktrace"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterError_and_stacktrace([NotNull] ErrorLogParser.Error_and_stacktraceContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ErrorLogParser.error_and_stacktrace"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitError_and_stacktrace([NotNull] ErrorLogParser.Error_and_stacktraceContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ErrorLogParser.error_message"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterError_message([NotNull] ErrorLogParser.Error_messageContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ErrorLogParser.error_message"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitError_message([NotNull] ErrorLogParser.Error_messageContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ErrorLogParser.stack_trace"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStack_trace([NotNull] ErrorLogParser.Stack_traceContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ErrorLogParser.stack_trace"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStack_trace([NotNull] ErrorLogParser.Stack_traceContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ErrorLogParser.method_signature"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMethod_signature([NotNull] ErrorLogParser.Method_signatureContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ErrorLogParser.method_signature"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMethod_signature([NotNull] ErrorLogParser.Method_signatureContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ErrorLogParser.class_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClass_name([NotNull] ErrorLogParser.Class_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ErrorLogParser.class_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClass_name([NotNull] ErrorLogParser.Class_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ErrorLogParser.method_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMethod_name([NotNull] ErrorLogParser.Method_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ErrorLogParser.method_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMethod_name([NotNull] ErrorLogParser.Method_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ErrorLogParser.parameter_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParameter_list([NotNull] ErrorLogParser.Parameter_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ErrorLogParser.parameter_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParameter_list([NotNull] ErrorLogParser.Parameter_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ErrorLogParser.type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterType([NotNull] ErrorLogParser.TypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ErrorLogParser.type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitType([NotNull] ErrorLogParser.TypeContext context);
}
