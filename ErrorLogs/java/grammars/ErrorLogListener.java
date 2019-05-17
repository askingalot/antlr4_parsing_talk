// Generated from grammars/ErrorLog.g4 by ANTLR 4.7.2
import org.antlr.v4.runtime.tree.ParseTreeListener;

/**
 * This interface defines a complete listener for a parse tree produced by
 * {@link ErrorLogParser}.
 */
public interface ErrorLogListener extends ParseTreeListener {
	/**
	 * Enter a parse tree produced by {@link ErrorLogParser#logfile}.
	 * @param ctx the parse tree
	 */
	void enterLogfile(ErrorLogParser.LogfileContext ctx);
	/**
	 * Exit a parse tree produced by {@link ErrorLogParser#logfile}.
	 * @param ctx the parse tree
	 */
	void exitLogfile(ErrorLogParser.LogfileContext ctx);
	/**
	 * Enter a parse tree produced by {@link ErrorLogParser#line}.
	 * @param ctx the parse tree
	 */
	void enterLine(ErrorLogParser.LineContext ctx);
	/**
	 * Exit a parse tree produced by {@link ErrorLogParser#line}.
	 * @param ctx the parse tree
	 */
	void exitLine(ErrorLogParser.LineContext ctx);
	/**
	 * Enter a parse tree produced by {@link ErrorLogParser#logline}.
	 * @param ctx the parse tree
	 */
	void enterLogline(ErrorLogParser.LoglineContext ctx);
	/**
	 * Exit a parse tree produced by {@link ErrorLogParser#logline}.
	 * @param ctx the parse tree
	 */
	void exitLogline(ErrorLogParser.LoglineContext ctx);
	/**
	 * Enter a parse tree produced by {@link ErrorLogParser#datetime}.
	 * @param ctx the parse tree
	 */
	void enterDatetime(ErrorLogParser.DatetimeContext ctx);
	/**
	 * Exit a parse tree produced by {@link ErrorLogParser#datetime}.
	 * @param ctx the parse tree
	 */
	void exitDatetime(ErrorLogParser.DatetimeContext ctx);
	/**
	 * Enter a parse tree produced by {@link ErrorLogParser#day}.
	 * @param ctx the parse tree
	 */
	void enterDay(ErrorLogParser.DayContext ctx);
	/**
	 * Exit a parse tree produced by {@link ErrorLogParser#day}.
	 * @param ctx the parse tree
	 */
	void exitDay(ErrorLogParser.DayContext ctx);
	/**
	 * Enter a parse tree produced by {@link ErrorLogParser#year}.
	 * @param ctx the parse tree
	 */
	void enterYear(ErrorLogParser.YearContext ctx);
	/**
	 * Exit a parse tree produced by {@link ErrorLogParser#year}.
	 * @param ctx the parse tree
	 */
	void exitYear(ErrorLogParser.YearContext ctx);
	/**
	 * Enter a parse tree produced by {@link ErrorLogParser#hour}.
	 * @param ctx the parse tree
	 */
	void enterHour(ErrorLogParser.HourContext ctx);
	/**
	 * Exit a parse tree produced by {@link ErrorLogParser#hour}.
	 * @param ctx the parse tree
	 */
	void exitHour(ErrorLogParser.HourContext ctx);
	/**
	 * Enter a parse tree produced by {@link ErrorLogParser#minute}.
	 * @param ctx the parse tree
	 */
	void enterMinute(ErrorLogParser.MinuteContext ctx);
	/**
	 * Exit a parse tree produced by {@link ErrorLogParser#minute}.
	 * @param ctx the parse tree
	 */
	void exitMinute(ErrorLogParser.MinuteContext ctx);
	/**
	 * Enter a parse tree produced by {@link ErrorLogParser#skip_to_error_label}.
	 * @param ctx the parse tree
	 */
	void enterSkip_to_error_label(ErrorLogParser.Skip_to_error_labelContext ctx);
	/**
	 * Exit a parse tree produced by {@link ErrorLogParser#skip_to_error_label}.
	 * @param ctx the parse tree
	 */
	void exitSkip_to_error_label(ErrorLogParser.Skip_to_error_labelContext ctx);
	/**
	 * Enter a parse tree produced by {@link ErrorLogParser#skip_to_exception_type}.
	 * @param ctx the parse tree
	 */
	void enterSkip_to_exception_type(ErrorLogParser.Skip_to_exception_typeContext ctx);
	/**
	 * Exit a parse tree produced by {@link ErrorLogParser#skip_to_exception_type}.
	 * @param ctx the parse tree
	 */
	void exitSkip_to_exception_type(ErrorLogParser.Skip_to_exception_typeContext ctx);
	/**
	 * Enter a parse tree produced by {@link ErrorLogParser#exception_type}.
	 * @param ctx the parse tree
	 */
	void enterException_type(ErrorLogParser.Exception_typeContext ctx);
	/**
	 * Exit a parse tree produced by {@link ErrorLogParser#exception_type}.
	 * @param ctx the parse tree
	 */
	void exitException_type(ErrorLogParser.Exception_typeContext ctx);
	/**
	 * Enter a parse tree produced by {@link ErrorLogParser#error_and_stacktrace}.
	 * @param ctx the parse tree
	 */
	void enterError_and_stacktrace(ErrorLogParser.Error_and_stacktraceContext ctx);
	/**
	 * Exit a parse tree produced by {@link ErrorLogParser#error_and_stacktrace}.
	 * @param ctx the parse tree
	 */
	void exitError_and_stacktrace(ErrorLogParser.Error_and_stacktraceContext ctx);
	/**
	 * Enter a parse tree produced by {@link ErrorLogParser#error_message}.
	 * @param ctx the parse tree
	 */
	void enterError_message(ErrorLogParser.Error_messageContext ctx);
	/**
	 * Exit a parse tree produced by {@link ErrorLogParser#error_message}.
	 * @param ctx the parse tree
	 */
	void exitError_message(ErrorLogParser.Error_messageContext ctx);
	/**
	 * Enter a parse tree produced by {@link ErrorLogParser#stack_trace}.
	 * @param ctx the parse tree
	 */
	void enterStack_trace(ErrorLogParser.Stack_traceContext ctx);
	/**
	 * Exit a parse tree produced by {@link ErrorLogParser#stack_trace}.
	 * @param ctx the parse tree
	 */
	void exitStack_trace(ErrorLogParser.Stack_traceContext ctx);
	/**
	 * Enter a parse tree produced by {@link ErrorLogParser#method_signature}.
	 * @param ctx the parse tree
	 */
	void enterMethod_signature(ErrorLogParser.Method_signatureContext ctx);
	/**
	 * Exit a parse tree produced by {@link ErrorLogParser#method_signature}.
	 * @param ctx the parse tree
	 */
	void exitMethod_signature(ErrorLogParser.Method_signatureContext ctx);
	/**
	 * Enter a parse tree produced by {@link ErrorLogParser#class_name}.
	 * @param ctx the parse tree
	 */
	void enterClass_name(ErrorLogParser.Class_nameContext ctx);
	/**
	 * Exit a parse tree produced by {@link ErrorLogParser#class_name}.
	 * @param ctx the parse tree
	 */
	void exitClass_name(ErrorLogParser.Class_nameContext ctx);
	/**
	 * Enter a parse tree produced by {@link ErrorLogParser#method_name}.
	 * @param ctx the parse tree
	 */
	void enterMethod_name(ErrorLogParser.Method_nameContext ctx);
	/**
	 * Exit a parse tree produced by {@link ErrorLogParser#method_name}.
	 * @param ctx the parse tree
	 */
	void exitMethod_name(ErrorLogParser.Method_nameContext ctx);
	/**
	 * Enter a parse tree produced by {@link ErrorLogParser#argument_list}.
	 * @param ctx the parse tree
	 */
	void enterArgument_list(ErrorLogParser.Argument_listContext ctx);
	/**
	 * Exit a parse tree produced by {@link ErrorLogParser#argument_list}.
	 * @param ctx the parse tree
	 */
	void exitArgument_list(ErrorLogParser.Argument_listContext ctx);
	/**
	 * Enter a parse tree produced by {@link ErrorLogParser#type}.
	 * @param ctx the parse tree
	 */
	void enterType(ErrorLogParser.TypeContext ctx);
	/**
	 * Exit a parse tree produced by {@link ErrorLogParser#type}.
	 * @param ctx the parse tree
	 */
	void exitType(ErrorLogParser.TypeContext ctx);
}