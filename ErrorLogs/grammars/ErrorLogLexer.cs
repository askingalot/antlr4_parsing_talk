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

using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.2")]
[System.CLSCompliant(false)]
public partial class ErrorLogLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, NULL=2, DASHES=3, DOT=4, COMMA=5, AMP=6, TICK=7, DASH=8, STAR=9, 
		BANG=10, GT=11, LT=12, SINGLE_QUOTE=13, DOUBLE_QUOTE=14, BACK_SLASH=15, 
		SLASH=16, SEMI=17, QUESTION=18, PIPE=19, AT_SIGN=20, PERCENT=21, DOLLAR=22, 
		L_PAREN=23, R_PAREN=24, L_BRACKET=25, R_BRACKET=26, L_BRACE=27, R_BRACE=28, 
		COLON=29, EQUAL=30, NUMBER=31, MONTH=32, AM_PM=33, EXCEPTION_TYPE_LABEL=34, 
		ERROR_LABEL=35, STACK_TRACE_LABEL=36, INNNER_EXCEPTION_LABEL=37, IDENTIFIER=38, 
		EOL=39, WS=40;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "NULL", "DASHES", "DOT", "COMMA", "AMP", "TICK", "DASH", "STAR", 
		"BANG", "GT", "LT", "SINGLE_QUOTE", "DOUBLE_QUOTE", "BACK_SLASH", "SLASH", 
		"SEMI", "QUESTION", "PIPE", "AT_SIGN", "PERCENT", "DOLLAR", "L_PAREN", 
		"R_PAREN", "L_BRACKET", "R_BRACKET", "L_BRACE", "R_BRACE", "COLON", "EQUAL", 
		"NUMBER", "MONTH", "AM_PM", "EXCEPTION_TYPE_LABEL", "ERROR_LABEL", "STACK_TRACE_LABEL", 
		"INNNER_EXCEPTION_LABEL", "IDENTIFIER", "EOL", "WS"
	};


	public ErrorLogLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public ErrorLogLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'at'", "'NULL'", "'----------------------'", "'.'", "','", "'&'", 
		"'`'", "'-'", "'*'", "'!'", "'>'", "'<'", "'''", "'\"'", "'\\'", "'/'", 
		"';'", "'?'", "'|'", "'@'", "'%'", "'$'", "'('", "')'", "'['", "']'", 
		"'{'", "'}'", "':'", "'='", null, null, null, "'Exception Type:'", "'Error:'", 
		"'Stack Trace:'", "'*** Inner Exception ***'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, "NULL", "DASHES", "DOT", "COMMA", "AMP", "TICK", "DASH", "STAR", 
		"BANG", "GT", "LT", "SINGLE_QUOTE", "DOUBLE_QUOTE", "BACK_SLASH", "SLASH", 
		"SEMI", "QUESTION", "PIPE", "AT_SIGN", "PERCENT", "DOLLAR", "L_PAREN", 
		"R_PAREN", "L_BRACKET", "R_BRACKET", "L_BRACE", "R_BRACE", "COLON", "EQUAL", 
		"NUMBER", "MONTH", "AM_PM", "EXCEPTION_TYPE_LABEL", "ERROR_LABEL", "STACK_TRACE_LABEL", 
		"INNNER_EXCEPTION_LABEL", "IDENTIFIER", "EOL", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "ErrorLog.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static ErrorLogLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '*', '\x12A', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', 
		'\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', '\x4', '\xE', 
		'\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', '\x10', '\t', '\x10', '\x4', 
		'\x11', '\t', '\x11', '\x4', '\x12', '\t', '\x12', '\x4', '\x13', '\t', 
		'\x13', '\x4', '\x14', '\t', '\x14', '\x4', '\x15', '\t', '\x15', '\x4', 
		'\x16', '\t', '\x16', '\x4', '\x17', '\t', '\x17', '\x4', '\x18', '\t', 
		'\x18', '\x4', '\x19', '\t', '\x19', '\x4', '\x1A', '\t', '\x1A', '\x4', 
		'\x1B', '\t', '\x1B', '\x4', '\x1C', '\t', '\x1C', '\x4', '\x1D', '\t', 
		'\x1D', '\x4', '\x1E', '\t', '\x1E', '\x4', '\x1F', '\t', '\x1F', '\x4', 
		' ', '\t', ' ', '\x4', '!', '\t', '!', '\x4', '\"', '\t', '\"', '\x4', 
		'#', '\t', '#', '\x4', '$', '\t', '$', '\x4', '%', '\t', '%', '\x4', '&', 
		'\t', '&', '\x4', '\'', '\t', '\'', '\x4', '(', '\t', '(', '\x4', ')', 
		'\t', ')', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x4', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x5', '\x3', '\x5', '\x3', '\x6', '\x3', 
		'\x6', '\x3', '\a', '\x3', '\a', '\x3', '\b', '\x3', '\b', '\x3', '\t', 
		'\x3', '\t', '\x3', '\n', '\x3', '\n', '\x3', '\v', '\x3', '\v', '\x3', 
		'\f', '\x3', '\f', '\x3', '\r', '\x3', '\r', '\x3', '\xE', '\x3', '\xE', 
		'\x3', '\xF', '\x3', '\xF', '\x3', '\x10', '\x3', '\x10', '\x3', '\x11', 
		'\x3', '\x11', '\x3', '\x12', '\x3', '\x12', '\x3', '\x13', '\x3', '\x13', 
		'\x3', '\x14', '\x3', '\x14', '\x3', '\x15', '\x3', '\x15', '\x3', '\x16', 
		'\x3', '\x16', '\x3', '\x17', '\x3', '\x17', '\x3', '\x18', '\x3', '\x18', 
		'\x3', '\x19', '\x3', '\x19', '\x3', '\x1A', '\x3', '\x1A', '\x3', '\x1B', 
		'\x3', '\x1B', '\x3', '\x1C', '\x3', '\x1C', '\x3', '\x1D', '\x3', '\x1D', 
		'\x3', '\x1E', '\x3', '\x1E', '\x3', '\x1F', '\x3', '\x1F', '\x3', ' ', 
		'\x6', ' ', '\xAA', '\n', ' ', '\r', ' ', '\xE', ' ', '\xAB', '\x3', '!', 
		'\x3', '!', '\x3', '!', '\x3', '!', '\x3', '!', '\x3', '!', '\x3', '!', 
		'\x3', '!', '\x3', '!', '\x3', '!', '\x3', '!', '\x3', '!', '\x3', '!', 
		'\x3', '!', '\x3', '!', '\x3', '!', '\x3', '!', '\x3', '!', '\x3', '!', 
		'\x3', '!', '\x3', '!', '\x3', '!', '\x3', '!', '\x3', '!', '\x3', '!', 
		'\x3', '!', '\x3', '!', '\x3', '!', '\x3', '!', '\x3', '!', '\x3', '!', 
		'\x3', '!', '\x3', '!', '\x3', '!', '\x3', '!', '\x3', '!', '\x5', '!', 
		'\xD2', '\n', '!', '\x3', '\"', '\x3', '\"', '\x3', '\"', '\x3', '\"', 
		'\x5', '\"', '\xD8', '\n', '\"', '\x3', '#', '\x3', '#', '\x3', '#', '\x3', 
		'#', '\x3', '#', '\x3', '#', '\x3', '#', '\x3', '#', '\x3', '#', '\x3', 
		'#', '\x3', '#', '\x3', '#', '\x3', '#', '\x3', '#', '\x3', '#', '\x3', 
		'#', '\x3', '$', '\x3', '$', '\x3', '$', '\x3', '$', '\x3', '$', '\x3', 
		'$', '\x3', '$', '\x3', '%', '\x3', '%', '\x3', '%', '\x3', '%', '\x3', 
		'%', '\x3', '%', '\x3', '%', '\x3', '%', '\x3', '%', '\x3', '%', '\x3', 
		'%', '\x3', '%', '\x3', '%', '\x3', '&', '\x3', '&', '\x3', '&', '\x3', 
		'&', '\x3', '&', '\x3', '&', '\x3', '&', '\x3', '&', '\x3', '&', '\x3', 
		'&', '\x3', '&', '\x3', '&', '\x3', '&', '\x3', '&', '\x3', '&', '\x3', 
		'&', '\x3', '&', '\x3', '&', '\x3', '&', '\x3', '&', '\x3', '&', '\x3', 
		'&', '\x3', '&', '\x3', '&', '\x3', '\'', '\x3', '\'', '\a', '\'', '\x118', 
		'\n', '\'', '\f', '\'', '\xE', '\'', '\x11B', '\v', '\'', '\x3', '(', 
		'\x5', '(', '\x11E', '\n', '(', '\x3', '(', '\x3', '(', '\x5', '(', '\x122', 
		'\n', '(', '\x3', ')', '\x6', ')', '\x125', '\n', ')', '\r', ')', '\xE', 
		')', '\x126', '\x3', ')', '\x3', ')', '\x2', '\x2', '*', '\x3', '\x3', 
		'\x5', '\x4', '\a', '\x5', '\t', '\x6', '\v', '\a', '\r', '\b', '\xF', 
		'\t', '\x11', '\n', '\x13', '\v', '\x15', '\f', '\x17', '\r', '\x19', 
		'\xE', '\x1B', '\xF', '\x1D', '\x10', '\x1F', '\x11', '!', '\x12', '#', 
		'\x13', '%', '\x14', '\'', '\x15', ')', '\x16', '+', '\x17', '-', '\x18', 
		'/', '\x19', '\x31', '\x1A', '\x33', '\x1B', '\x35', '\x1C', '\x37', '\x1D', 
		'\x39', '\x1E', ';', '\x1F', '=', ' ', '?', '!', '\x41', '\"', '\x43', 
		'#', '\x45', '$', 'G', '%', 'I', '&', 'K', '\'', 'M', '(', 'O', ')', 'Q', 
		'*', '\x3', '\x2', '\x6', '\x3', '\x2', '\x32', ';', '\x5', '\x2', '\x43', 
		'\\', '\x61', '\x61', '\x63', '|', '\x6', '\x2', '\x32', ';', '\x43', 
		'\\', '\x61', '\x61', '\x63', '|', '\x4', '\x2', '\v', '\v', '\"', '\"', 
		'\x2', '\x13A', '\x2', '\x3', '\x3', '\x2', '\x2', '\x2', '\x2', '\x5', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\a', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\t', '\x3', '\x2', '\x2', '\x2', '\x2', '\v', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\r', '\x3', '\x2', '\x2', '\x2', '\x2', '\xF', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x11', '\x3', '\x2', '\x2', '\x2', '\x2', '\x13', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x15', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x17', '\x3', '\x2', '\x2', '\x2', '\x2', '\x19', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x1B', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1D', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x1F', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'!', '\x3', '\x2', '\x2', '\x2', '\x2', '#', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '%', '\x3', '\x2', '\x2', '\x2', '\x2', '\'', '\x3', '\x2', '\x2', 
		'\x2', '\x2', ')', '\x3', '\x2', '\x2', '\x2', '\x2', '+', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '-', '\x3', '\x2', '\x2', '\x2', '\x2', '/', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x31', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x33', '\x3', '\x2', '\x2', '\x2', '\x2', '\x35', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x37', '\x3', '\x2', '\x2', '\x2', '\x2', '\x39', '\x3', 
		'\x2', '\x2', '\x2', '\x2', ';', '\x3', '\x2', '\x2', '\x2', '\x2', '=', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '?', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x41', '\x3', '\x2', '\x2', '\x2', '\x2', '\x43', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x45', '\x3', '\x2', '\x2', '\x2', '\x2', 'G', '\x3', '\x2', 
		'\x2', '\x2', '\x2', 'I', '\x3', '\x2', '\x2', '\x2', '\x2', 'K', '\x3', 
		'\x2', '\x2', '\x2', '\x2', 'M', '\x3', '\x2', '\x2', '\x2', '\x2', 'O', 
		'\x3', '\x2', '\x2', '\x2', '\x2', 'Q', '\x3', '\x2', '\x2', '\x2', '\x3', 
		'S', '\x3', '\x2', '\x2', '\x2', '\x5', 'V', '\x3', '\x2', '\x2', '\x2', 
		'\a', '[', '\x3', '\x2', '\x2', '\x2', '\t', 'r', '\x3', '\x2', '\x2', 
		'\x2', '\v', 't', '\x3', '\x2', '\x2', '\x2', '\r', 'v', '\x3', '\x2', 
		'\x2', '\x2', '\xF', 'x', '\x3', '\x2', '\x2', '\x2', '\x11', 'z', '\x3', 
		'\x2', '\x2', '\x2', '\x13', '|', '\x3', '\x2', '\x2', '\x2', '\x15', 
		'~', '\x3', '\x2', '\x2', '\x2', '\x17', '\x80', '\x3', '\x2', '\x2', 
		'\x2', '\x19', '\x82', '\x3', '\x2', '\x2', '\x2', '\x1B', '\x84', '\x3', 
		'\x2', '\x2', '\x2', '\x1D', '\x86', '\x3', '\x2', '\x2', '\x2', '\x1F', 
		'\x88', '\x3', '\x2', '\x2', '\x2', '!', '\x8A', '\x3', '\x2', '\x2', 
		'\x2', '#', '\x8C', '\x3', '\x2', '\x2', '\x2', '%', '\x8E', '\x3', '\x2', 
		'\x2', '\x2', '\'', '\x90', '\x3', '\x2', '\x2', '\x2', ')', '\x92', '\x3', 
		'\x2', '\x2', '\x2', '+', '\x94', '\x3', '\x2', '\x2', '\x2', '-', '\x96', 
		'\x3', '\x2', '\x2', '\x2', '/', '\x98', '\x3', '\x2', '\x2', '\x2', '\x31', 
		'\x9A', '\x3', '\x2', '\x2', '\x2', '\x33', '\x9C', '\x3', '\x2', '\x2', 
		'\x2', '\x35', '\x9E', '\x3', '\x2', '\x2', '\x2', '\x37', '\xA0', '\x3', 
		'\x2', '\x2', '\x2', '\x39', '\xA2', '\x3', '\x2', '\x2', '\x2', ';', 
		'\xA4', '\x3', '\x2', '\x2', '\x2', '=', '\xA6', '\x3', '\x2', '\x2', 
		'\x2', '?', '\xA9', '\x3', '\x2', '\x2', '\x2', '\x41', '\xD1', '\x3', 
		'\x2', '\x2', '\x2', '\x43', '\xD7', '\x3', '\x2', '\x2', '\x2', '\x45', 
		'\xD9', '\x3', '\x2', '\x2', '\x2', 'G', '\xE9', '\x3', '\x2', '\x2', 
		'\x2', 'I', '\xF0', '\x3', '\x2', '\x2', '\x2', 'K', '\xFD', '\x3', '\x2', 
		'\x2', '\x2', 'M', '\x115', '\x3', '\x2', '\x2', '\x2', 'O', '\x121', 
		'\x3', '\x2', '\x2', '\x2', 'Q', '\x124', '\x3', '\x2', '\x2', '\x2', 
		'S', 'T', '\a', '\x63', '\x2', '\x2', 'T', 'U', '\a', 'v', '\x2', '\x2', 
		'U', '\x4', '\x3', '\x2', '\x2', '\x2', 'V', 'W', '\a', 'P', '\x2', '\x2', 
		'W', 'X', '\a', 'W', '\x2', '\x2', 'X', 'Y', '\a', 'N', '\x2', '\x2', 
		'Y', 'Z', '\a', 'N', '\x2', '\x2', 'Z', '\x6', '\x3', '\x2', '\x2', '\x2', 
		'[', '\\', '\a', '/', '\x2', '\x2', '\\', ']', '\a', '/', '\x2', '\x2', 
		']', '^', '\a', '/', '\x2', '\x2', '^', '_', '\a', '/', '\x2', '\x2', 
		'_', '`', '\a', '/', '\x2', '\x2', '`', '\x61', '\a', '/', '\x2', '\x2', 
		'\x61', '\x62', '\a', '/', '\x2', '\x2', '\x62', '\x63', '\a', '/', '\x2', 
		'\x2', '\x63', '\x64', '\a', '/', '\x2', '\x2', '\x64', '\x65', '\a', 
		'/', '\x2', '\x2', '\x65', '\x66', '\a', '/', '\x2', '\x2', '\x66', 'g', 
		'\a', '/', '\x2', '\x2', 'g', 'h', '\a', '/', '\x2', '\x2', 'h', 'i', 
		'\a', '/', '\x2', '\x2', 'i', 'j', '\a', '/', '\x2', '\x2', 'j', 'k', 
		'\a', '/', '\x2', '\x2', 'k', 'l', '\a', '/', '\x2', '\x2', 'l', 'm', 
		'\a', '/', '\x2', '\x2', 'm', 'n', '\a', '/', '\x2', '\x2', 'n', 'o', 
		'\a', '/', '\x2', '\x2', 'o', 'p', '\a', '/', '\x2', '\x2', 'p', 'q', 
		'\a', '/', '\x2', '\x2', 'q', '\b', '\x3', '\x2', '\x2', '\x2', 'r', 's', 
		'\a', '\x30', '\x2', '\x2', 's', '\n', '\x3', '\x2', '\x2', '\x2', 't', 
		'u', '\a', '.', '\x2', '\x2', 'u', '\f', '\x3', '\x2', '\x2', '\x2', 'v', 
		'w', '\a', '(', '\x2', '\x2', 'w', '\xE', '\x3', '\x2', '\x2', '\x2', 
		'x', 'y', '\a', '\x62', '\x2', '\x2', 'y', '\x10', '\x3', '\x2', '\x2', 
		'\x2', 'z', '{', '\a', '/', '\x2', '\x2', '{', '\x12', '\x3', '\x2', '\x2', 
		'\x2', '|', '}', '\a', ',', '\x2', '\x2', '}', '\x14', '\x3', '\x2', '\x2', 
		'\x2', '~', '\x7F', '\a', '#', '\x2', '\x2', '\x7F', '\x16', '\x3', '\x2', 
		'\x2', '\x2', '\x80', '\x81', '\a', '@', '\x2', '\x2', '\x81', '\x18', 
		'\x3', '\x2', '\x2', '\x2', '\x82', '\x83', '\a', '>', '\x2', '\x2', '\x83', 
		'\x1A', '\x3', '\x2', '\x2', '\x2', '\x84', '\x85', '\a', ')', '\x2', 
		'\x2', '\x85', '\x1C', '\x3', '\x2', '\x2', '\x2', '\x86', '\x87', '\a', 
		'$', '\x2', '\x2', '\x87', '\x1E', '\x3', '\x2', '\x2', '\x2', '\x88', 
		'\x89', '\a', '^', '\x2', '\x2', '\x89', ' ', '\x3', '\x2', '\x2', '\x2', 
		'\x8A', '\x8B', '\a', '\x31', '\x2', '\x2', '\x8B', '\"', '\x3', '\x2', 
		'\x2', '\x2', '\x8C', '\x8D', '\a', '=', '\x2', '\x2', '\x8D', '$', '\x3', 
		'\x2', '\x2', '\x2', '\x8E', '\x8F', '\a', '\x41', '\x2', '\x2', '\x8F', 
		'&', '\x3', '\x2', '\x2', '\x2', '\x90', '\x91', '\a', '~', '\x2', '\x2', 
		'\x91', '(', '\x3', '\x2', '\x2', '\x2', '\x92', '\x93', '\a', '\x42', 
		'\x2', '\x2', '\x93', '*', '\x3', '\x2', '\x2', '\x2', '\x94', '\x95', 
		'\a', '\'', '\x2', '\x2', '\x95', ',', '\x3', '\x2', '\x2', '\x2', '\x96', 
		'\x97', '\a', '&', '\x2', '\x2', '\x97', '.', '\x3', '\x2', '\x2', '\x2', 
		'\x98', '\x99', '\a', '*', '\x2', '\x2', '\x99', '\x30', '\x3', '\x2', 
		'\x2', '\x2', '\x9A', '\x9B', '\a', '+', '\x2', '\x2', '\x9B', '\x32', 
		'\x3', '\x2', '\x2', '\x2', '\x9C', '\x9D', '\a', ']', '\x2', '\x2', '\x9D', 
		'\x34', '\x3', '\x2', '\x2', '\x2', '\x9E', '\x9F', '\a', '_', '\x2', 
		'\x2', '\x9F', '\x36', '\x3', '\x2', '\x2', '\x2', '\xA0', '\xA1', '\a', 
		'}', '\x2', '\x2', '\xA1', '\x38', '\x3', '\x2', '\x2', '\x2', '\xA2', 
		'\xA3', '\a', '\x7F', '\x2', '\x2', '\xA3', ':', '\x3', '\x2', '\x2', 
		'\x2', '\xA4', '\xA5', '\a', '<', '\x2', '\x2', '\xA5', '<', '\x3', '\x2', 
		'\x2', '\x2', '\xA6', '\xA7', '\a', '?', '\x2', '\x2', '\xA7', '>', '\x3', 
		'\x2', '\x2', '\x2', '\xA8', '\xAA', '\t', '\x2', '\x2', '\x2', '\xA9', 
		'\xA8', '\x3', '\x2', '\x2', '\x2', '\xAA', '\xAB', '\x3', '\x2', '\x2', 
		'\x2', '\xAB', '\xA9', '\x3', '\x2', '\x2', '\x2', '\xAB', '\xAC', '\x3', 
		'\x2', '\x2', '\x2', '\xAC', '@', '\x3', '\x2', '\x2', '\x2', '\xAD', 
		'\xAE', '\a', 'L', '\x2', '\x2', '\xAE', '\xAF', '\a', '\x63', '\x2', 
		'\x2', '\xAF', '\xD2', '\a', 'p', '\x2', '\x2', '\xB0', '\xB1', '\a', 
		'H', '\x2', '\x2', '\xB1', '\xB2', '\a', 'g', '\x2', '\x2', '\xB2', '\xD2', 
		'\a', '\x64', '\x2', '\x2', '\xB3', '\xB4', '\a', 'O', '\x2', '\x2', '\xB4', 
		'\xB5', '\a', '\x63', '\x2', '\x2', '\xB5', '\xD2', '\a', 't', '\x2', 
		'\x2', '\xB6', '\xB7', '\a', '\x43', '\x2', '\x2', '\xB7', '\xB8', '\a', 
		'r', '\x2', '\x2', '\xB8', '\xD2', '\a', 't', '\x2', '\x2', '\xB9', '\xBA', 
		'\a', 'O', '\x2', '\x2', '\xBA', '\xBB', '\a', '\x63', '\x2', '\x2', '\xBB', 
		'\xD2', '\a', '{', '\x2', '\x2', '\xBC', '\xBD', '\a', 'L', '\x2', '\x2', 
		'\xBD', '\xBE', '\a', 'w', '\x2', '\x2', '\xBE', '\xD2', '\a', 'p', '\x2', 
		'\x2', '\xBF', '\xC0', '\a', 'L', '\x2', '\x2', '\xC0', '\xC1', '\a', 
		'w', '\x2', '\x2', '\xC1', '\xD2', '\a', 'n', '\x2', '\x2', '\xC2', '\xC3', 
		'\a', '\x43', '\x2', '\x2', '\xC3', '\xC4', '\a', 'w', '\x2', '\x2', '\xC4', 
		'\xD2', '\a', 'i', '\x2', '\x2', '\xC5', '\xC6', '\a', 'U', '\x2', '\x2', 
		'\xC6', '\xC7', '\a', 'g', '\x2', '\x2', '\xC7', '\xD2', '\a', 'r', '\x2', 
		'\x2', '\xC8', '\xC9', '\a', 'Q', '\x2', '\x2', '\xC9', '\xCA', '\a', 
		'\x65', '\x2', '\x2', '\xCA', '\xD2', '\a', 'v', '\x2', '\x2', '\xCB', 
		'\xCC', '\a', 'P', '\x2', '\x2', '\xCC', '\xCD', '\a', 'q', '\x2', '\x2', 
		'\xCD', '\xD2', '\a', 'x', '\x2', '\x2', '\xCE', '\xCF', '\a', '\x46', 
		'\x2', '\x2', '\xCF', '\xD0', '\a', 'g', '\x2', '\x2', '\xD0', '\xD2', 
		'\a', '\x65', '\x2', '\x2', '\xD1', '\xAD', '\x3', '\x2', '\x2', '\x2', 
		'\xD1', '\xB0', '\x3', '\x2', '\x2', '\x2', '\xD1', '\xB3', '\x3', '\x2', 
		'\x2', '\x2', '\xD1', '\xB6', '\x3', '\x2', '\x2', '\x2', '\xD1', '\xB9', 
		'\x3', '\x2', '\x2', '\x2', '\xD1', '\xBC', '\x3', '\x2', '\x2', '\x2', 
		'\xD1', '\xBF', '\x3', '\x2', '\x2', '\x2', '\xD1', '\xC2', '\x3', '\x2', 
		'\x2', '\x2', '\xD1', '\xC5', '\x3', '\x2', '\x2', '\x2', '\xD1', '\xC8', 
		'\x3', '\x2', '\x2', '\x2', '\xD1', '\xCB', '\x3', '\x2', '\x2', '\x2', 
		'\xD1', '\xCE', '\x3', '\x2', '\x2', '\x2', '\xD2', '\x42', '\x3', '\x2', 
		'\x2', '\x2', '\xD3', '\xD4', '\a', '\x43', '\x2', '\x2', '\xD4', '\xD8', 
		'\a', 'O', '\x2', '\x2', '\xD5', '\xD6', '\a', 'R', '\x2', '\x2', '\xD6', 
		'\xD8', '\a', 'O', '\x2', '\x2', '\xD7', '\xD3', '\x3', '\x2', '\x2', 
		'\x2', '\xD7', '\xD5', '\x3', '\x2', '\x2', '\x2', '\xD8', '\x44', '\x3', 
		'\x2', '\x2', '\x2', '\xD9', '\xDA', '\a', 'G', '\x2', '\x2', '\xDA', 
		'\xDB', '\a', 'z', '\x2', '\x2', '\xDB', '\xDC', '\a', '\x65', '\x2', 
		'\x2', '\xDC', '\xDD', '\a', 'g', '\x2', '\x2', '\xDD', '\xDE', '\a', 
		'r', '\x2', '\x2', '\xDE', '\xDF', '\a', 'v', '\x2', '\x2', '\xDF', '\xE0', 
		'\a', 'k', '\x2', '\x2', '\xE0', '\xE1', '\a', 'q', '\x2', '\x2', '\xE1', 
		'\xE2', '\a', 'p', '\x2', '\x2', '\xE2', '\xE3', '\a', '\"', '\x2', '\x2', 
		'\xE3', '\xE4', '\a', 'V', '\x2', '\x2', '\xE4', '\xE5', '\a', '{', '\x2', 
		'\x2', '\xE5', '\xE6', '\a', 'r', '\x2', '\x2', '\xE6', '\xE7', '\a', 
		'g', '\x2', '\x2', '\xE7', '\xE8', '\a', '<', '\x2', '\x2', '\xE8', '\x46', 
		'\x3', '\x2', '\x2', '\x2', '\xE9', '\xEA', '\a', 'G', '\x2', '\x2', '\xEA', 
		'\xEB', '\a', 't', '\x2', '\x2', '\xEB', '\xEC', '\a', 't', '\x2', '\x2', 
		'\xEC', '\xED', '\a', 'q', '\x2', '\x2', '\xED', '\xEE', '\a', 't', '\x2', 
		'\x2', '\xEE', '\xEF', '\a', '<', '\x2', '\x2', '\xEF', 'H', '\x3', '\x2', 
		'\x2', '\x2', '\xF0', '\xF1', '\a', 'U', '\x2', '\x2', '\xF1', '\xF2', 
		'\a', 'v', '\x2', '\x2', '\xF2', '\xF3', '\a', '\x63', '\x2', '\x2', '\xF3', 
		'\xF4', '\a', '\x65', '\x2', '\x2', '\xF4', '\xF5', '\a', 'm', '\x2', 
		'\x2', '\xF5', '\xF6', '\a', '\"', '\x2', '\x2', '\xF6', '\xF7', '\a', 
		'V', '\x2', '\x2', '\xF7', '\xF8', '\a', 't', '\x2', '\x2', '\xF8', '\xF9', 
		'\a', '\x63', '\x2', '\x2', '\xF9', '\xFA', '\a', '\x65', '\x2', '\x2', 
		'\xFA', '\xFB', '\a', 'g', '\x2', '\x2', '\xFB', '\xFC', '\a', '<', '\x2', 
		'\x2', '\xFC', 'J', '\x3', '\x2', '\x2', '\x2', '\xFD', '\xFE', '\a', 
		',', '\x2', '\x2', '\xFE', '\xFF', '\a', ',', '\x2', '\x2', '\xFF', '\x100', 
		'\a', ',', '\x2', '\x2', '\x100', '\x101', '\a', '\"', '\x2', '\x2', '\x101', 
		'\x102', '\a', 'K', '\x2', '\x2', '\x102', '\x103', '\a', 'p', '\x2', 
		'\x2', '\x103', '\x104', '\a', 'p', '\x2', '\x2', '\x104', '\x105', '\a', 
		'g', '\x2', '\x2', '\x105', '\x106', '\a', 't', '\x2', '\x2', '\x106', 
		'\x107', '\a', '\"', '\x2', '\x2', '\x107', '\x108', '\a', 'G', '\x2', 
		'\x2', '\x108', '\x109', '\a', 'z', '\x2', '\x2', '\x109', '\x10A', '\a', 
		'\x65', '\x2', '\x2', '\x10A', '\x10B', '\a', 'g', '\x2', '\x2', '\x10B', 
		'\x10C', '\a', 'r', '\x2', '\x2', '\x10C', '\x10D', '\a', 'v', '\x2', 
		'\x2', '\x10D', '\x10E', '\a', 'k', '\x2', '\x2', '\x10E', '\x10F', '\a', 
		'q', '\x2', '\x2', '\x10F', '\x110', '\a', 'p', '\x2', '\x2', '\x110', 
		'\x111', '\a', '\"', '\x2', '\x2', '\x111', '\x112', '\a', ',', '\x2', 
		'\x2', '\x112', '\x113', '\a', ',', '\x2', '\x2', '\x113', '\x114', '\a', 
		',', '\x2', '\x2', '\x114', 'L', '\x3', '\x2', '\x2', '\x2', '\x115', 
		'\x119', '\t', '\x3', '\x2', '\x2', '\x116', '\x118', '\t', '\x4', '\x2', 
		'\x2', '\x117', '\x116', '\x3', '\x2', '\x2', '\x2', '\x118', '\x11B', 
		'\x3', '\x2', '\x2', '\x2', '\x119', '\x117', '\x3', '\x2', '\x2', '\x2', 
		'\x119', '\x11A', '\x3', '\x2', '\x2', '\x2', '\x11A', 'N', '\x3', '\x2', 
		'\x2', '\x2', '\x11B', '\x119', '\x3', '\x2', '\x2', '\x2', '\x11C', '\x11E', 
		'\a', '\xF', '\x2', '\x2', '\x11D', '\x11C', '\x3', '\x2', '\x2', '\x2', 
		'\x11D', '\x11E', '\x3', '\x2', '\x2', '\x2', '\x11E', '\x11F', '\x3', 
		'\x2', '\x2', '\x2', '\x11F', '\x122', '\a', '\f', '\x2', '\x2', '\x120', 
		'\x122', '\a', '\xF', '\x2', '\x2', '\x121', '\x11D', '\x3', '\x2', '\x2', 
		'\x2', '\x121', '\x120', '\x3', '\x2', '\x2', '\x2', '\x122', 'P', '\x3', 
		'\x2', '\x2', '\x2', '\x123', '\x125', '\t', '\x5', '\x2', '\x2', '\x124', 
		'\x123', '\x3', '\x2', '\x2', '\x2', '\x125', '\x126', '\x3', '\x2', '\x2', 
		'\x2', '\x126', '\x124', '\x3', '\x2', '\x2', '\x2', '\x126', '\x127', 
		'\x3', '\x2', '\x2', '\x2', '\x127', '\x128', '\x3', '\x2', '\x2', '\x2', 
		'\x128', '\x129', '\b', ')', '\x2', '\x2', '\x129', 'R', '\x3', '\x2', 
		'\x2', '\x2', '\n', '\x2', '\xAB', '\xD1', '\xD7', '\x119', '\x11D', '\x121', 
		'\x126', '\x3', '\b', '\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}