//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from ErrorLog.g4 by ANTLR 4.7.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419


using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IErrorLogListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.2")]
[System.CLSCompliant(false)]
public partial class ErrorLogBaseListener : IErrorLogListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="ErrorLogParser.logfile"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLogfile([NotNull] ErrorLogParser.LogfileContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ErrorLogParser.logfile"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLogfile([NotNull] ErrorLogParser.LogfileContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="ErrorLogParser.line"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLine([NotNull] ErrorLogParser.LineContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ErrorLogParser.line"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLine([NotNull] ErrorLogParser.LineContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="ErrorLogParser.logline"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLogline([NotNull] ErrorLogParser.LoglineContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ErrorLogParser.logline"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLogline([NotNull] ErrorLogParser.LoglineContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="ErrorLogParser.datetime"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDatetime([NotNull] ErrorLogParser.DatetimeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ErrorLogParser.datetime"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDatetime([NotNull] ErrorLogParser.DatetimeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="ErrorLogParser.day"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDay([NotNull] ErrorLogParser.DayContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ErrorLogParser.day"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDay([NotNull] ErrorLogParser.DayContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="ErrorLogParser.year"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterYear([NotNull] ErrorLogParser.YearContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ErrorLogParser.year"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitYear([NotNull] ErrorLogParser.YearContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="ErrorLogParser.hour"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterHour([NotNull] ErrorLogParser.HourContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ErrorLogParser.hour"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitHour([NotNull] ErrorLogParser.HourContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="ErrorLogParser.minute"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMinute([NotNull] ErrorLogParser.MinuteContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ErrorLogParser.minute"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMinute([NotNull] ErrorLogParser.MinuteContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="ErrorLogParser.skip_to_exception_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSkip_to_exception_type([NotNull] ErrorLogParser.Skip_to_exception_typeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ErrorLogParser.skip_to_exception_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSkip_to_exception_type([NotNull] ErrorLogParser.Skip_to_exception_typeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="ErrorLogParser.skip_to_error_label"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSkip_to_error_label([NotNull] ErrorLogParser.Skip_to_error_labelContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ErrorLogParser.skip_to_error_label"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSkip_to_error_label([NotNull] ErrorLogParser.Skip_to_error_labelContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="ErrorLogParser.exception_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterException_type([NotNull] ErrorLogParser.Exception_typeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ErrorLogParser.exception_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitException_type([NotNull] ErrorLogParser.Exception_typeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="ErrorLogParser.error_and_stacktrace"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterError_and_stacktrace([NotNull] ErrorLogParser.Error_and_stacktraceContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ErrorLogParser.error_and_stacktrace"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitError_and_stacktrace([NotNull] ErrorLogParser.Error_and_stacktraceContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="ErrorLogParser.error_message"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterError_message([NotNull] ErrorLogParser.Error_messageContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ErrorLogParser.error_message"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitError_message([NotNull] ErrorLogParser.Error_messageContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="ErrorLogParser.stack_trace"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStack_trace([NotNull] ErrorLogParser.Stack_traceContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ErrorLogParser.stack_trace"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStack_trace([NotNull] ErrorLogParser.Stack_traceContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="ErrorLogParser.method_signature"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMethod_signature([NotNull] ErrorLogParser.Method_signatureContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ErrorLogParser.method_signature"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMethod_signature([NotNull] ErrorLogParser.Method_signatureContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="ErrorLogParser.class_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterClass_name([NotNull] ErrorLogParser.Class_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ErrorLogParser.class_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitClass_name([NotNull] ErrorLogParser.Class_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="ErrorLogParser.method_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMethod_name([NotNull] ErrorLogParser.Method_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ErrorLogParser.method_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMethod_name([NotNull] ErrorLogParser.Method_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="ErrorLogParser.parameter_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParameter_list([NotNull] ErrorLogParser.Parameter_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ErrorLogParser.parameter_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParameter_list([NotNull] ErrorLogParser.Parameter_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="ErrorLogParser.type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterType([NotNull] ErrorLogParser.TypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ErrorLogParser.type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitType([NotNull] ErrorLogParser.TypeContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}
