//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from grammar/CSV.g4 by ANTLR 4.7.2

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
/// <see cref="CSVParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.2")]
[System.CLSCompliant(false)]
public interface ICSVListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSVParser.csvFile"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCsvFile([NotNull] CSVParser.CsvFileContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSVParser.csvFile"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCsvFile([NotNull] CSVParser.CsvFileContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSVParser.hdr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterHdr([NotNull] CSVParser.HdrContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSVParser.hdr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitHdr([NotNull] CSVParser.HdrContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSVParser.row"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRow([NotNull] CSVParser.RowContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSVParser.row"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRow([NotNull] CSVParser.RowContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSVParser.field"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterField([NotNull] CSVParser.FieldContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSVParser.field"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitField([NotNull] CSVParser.FieldContext context);
}
