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

using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.2")]
[System.CLSCompliant(false)]
public partial class CSVParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, TEXT=4, STRING=5;
	public const int
		RULE_csvFile = 0, RULE_hdr = 1, RULE_row = 2, RULE_field = 3;
	public static readonly string[] ruleNames = {
		"csvFile", "hdr", "row", "field"
	};

	private static readonly string[] _LiteralNames = {
		null, "','", "'\r'", "'\n'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, "TEXT", "STRING"
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

	public override string GrammarFileName { get { return "CSV.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static CSVParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public CSVParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public CSVParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	public partial class CsvFileContext : ParserRuleContext {
		public HdrContext hdr() {
			return GetRuleContext<HdrContext>(0);
		}
		public RowContext[] row() {
			return GetRuleContexts<RowContext>();
		}
		public RowContext row(int i) {
			return GetRuleContext<RowContext>(i);
		}
		public CsvFileContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_csvFile; } }
		public override void EnterRule(IParseTreeListener listener) {
			ICSVListener typedListener = listener as ICSVListener;
			if (typedListener != null) typedListener.EnterCsvFile(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ICSVListener typedListener = listener as ICSVListener;
			if (typedListener != null) typedListener.ExitCsvFile(this);
		}
	}

	[RuleVersion(0)]
	public CsvFileContext csvFile() {
		CsvFileContext _localctx = new CsvFileContext(Context, State);
		EnterRule(_localctx, 0, RULE_csvFile);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 8; hdr();
			State = 10;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			do {
				{
				{
				State = 9; row();
				}
				}
				State = 12;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			} while ( (((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2) | (1L << TEXT) | (1L << STRING))) != 0) );
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class HdrContext : ParserRuleContext {
		public RowContext row() {
			return GetRuleContext<RowContext>(0);
		}
		public HdrContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_hdr; } }
		public override void EnterRule(IParseTreeListener listener) {
			ICSVListener typedListener = listener as ICSVListener;
			if (typedListener != null) typedListener.EnterHdr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ICSVListener typedListener = listener as ICSVListener;
			if (typedListener != null) typedListener.ExitHdr(this);
		}
	}

	[RuleVersion(0)]
	public HdrContext hdr() {
		HdrContext _localctx = new HdrContext(Context, State);
		EnterRule(_localctx, 2, RULE_hdr);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 14; row();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class RowContext : ParserRuleContext {
		public FieldContext[] field() {
			return GetRuleContexts<FieldContext>();
		}
		public FieldContext field(int i) {
			return GetRuleContext<FieldContext>(i);
		}
		public RowContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_row; } }
		public override void EnterRule(IParseTreeListener listener) {
			ICSVListener typedListener = listener as ICSVListener;
			if (typedListener != null) typedListener.EnterRow(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ICSVListener typedListener = listener as ICSVListener;
			if (typedListener != null) typedListener.ExitRow(this);
		}
	}

	[RuleVersion(0)]
	public RowContext row() {
		RowContext _localctx = new RowContext(Context, State);
		EnterRule(_localctx, 4, RULE_row);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 16; field();
			State = 21;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==T__0) {
				{
				{
				State = 17; Match(T__0);
				State = 18; field();
				}
				}
				State = 23;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 25;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==T__1) {
				{
				State = 24; Match(T__1);
				}
			}

			State = 27; Match(T__2);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class FieldContext : ParserRuleContext {
		public ITerminalNode TEXT() { return GetToken(CSVParser.TEXT, 0); }
		public ITerminalNode STRING() { return GetToken(CSVParser.STRING, 0); }
		public FieldContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_field; } }
		public override void EnterRule(IParseTreeListener listener) {
			ICSVListener typedListener = listener as ICSVListener;
			if (typedListener != null) typedListener.EnterField(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ICSVListener typedListener = listener as ICSVListener;
			if (typedListener != null) typedListener.ExitField(this);
		}
	}

	[RuleVersion(0)]
	public FieldContext field() {
		FieldContext _localctx = new FieldContext(Context, State);
		EnterRule(_localctx, 6, RULE_field);
		try {
			State = 32;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case TEXT:
				EnterOuterAlt(_localctx, 1);
				{
				State = 29; Match(TEXT);
				}
				break;
			case STRING:
				EnterOuterAlt(_localctx, 2);
				{
				State = 30; Match(STRING);
				}
				break;
			case T__0:
			case T__1:
			case T__2:
				EnterOuterAlt(_localctx, 3);
				{
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x3', '\a', '%', '\x4', '\x2', '\t', '\x2', '\x4', '\x3', '\t', 
		'\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', '\x5', '\x3', '\x2', 
		'\x3', '\x2', '\x6', '\x2', '\r', '\n', '\x2', '\r', '\x2', '\xE', '\x2', 
		'\xE', '\x3', '\x3', '\x3', '\x3', '\x3', '\x4', '\x3', '\x4', '\x3', 
		'\x4', '\a', '\x4', '\x16', '\n', '\x4', '\f', '\x4', '\xE', '\x4', '\x19', 
		'\v', '\x4', '\x3', '\x4', '\x5', '\x4', '\x1C', '\n', '\x4', '\x3', '\x4', 
		'\x3', '\x4', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x5', '\x5', 
		'#', '\n', '\x5', '\x3', '\x5', '\x2', '\x2', '\x6', '\x2', '\x4', '\x6', 
		'\b', '\x2', '\x2', '\x2', '%', '\x2', '\n', '\x3', '\x2', '\x2', '\x2', 
		'\x4', '\x10', '\x3', '\x2', '\x2', '\x2', '\x6', '\x12', '\x3', '\x2', 
		'\x2', '\x2', '\b', '\"', '\x3', '\x2', '\x2', '\x2', '\n', '\f', '\x5', 
		'\x4', '\x3', '\x2', '\v', '\r', '\x5', '\x6', '\x4', '\x2', '\f', '\v', 
		'\x3', '\x2', '\x2', '\x2', '\r', '\xE', '\x3', '\x2', '\x2', '\x2', '\xE', 
		'\f', '\x3', '\x2', '\x2', '\x2', '\xE', '\xF', '\x3', '\x2', '\x2', '\x2', 
		'\xF', '\x3', '\x3', '\x2', '\x2', '\x2', '\x10', '\x11', '\x5', '\x6', 
		'\x4', '\x2', '\x11', '\x5', '\x3', '\x2', '\x2', '\x2', '\x12', '\x17', 
		'\x5', '\b', '\x5', '\x2', '\x13', '\x14', '\a', '\x3', '\x2', '\x2', 
		'\x14', '\x16', '\x5', '\b', '\x5', '\x2', '\x15', '\x13', '\x3', '\x2', 
		'\x2', '\x2', '\x16', '\x19', '\x3', '\x2', '\x2', '\x2', '\x17', '\x15', 
		'\x3', '\x2', '\x2', '\x2', '\x17', '\x18', '\x3', '\x2', '\x2', '\x2', 
		'\x18', '\x1B', '\x3', '\x2', '\x2', '\x2', '\x19', '\x17', '\x3', '\x2', 
		'\x2', '\x2', '\x1A', '\x1C', '\a', '\x4', '\x2', '\x2', '\x1B', '\x1A', 
		'\x3', '\x2', '\x2', '\x2', '\x1B', '\x1C', '\x3', '\x2', '\x2', '\x2', 
		'\x1C', '\x1D', '\x3', '\x2', '\x2', '\x2', '\x1D', '\x1E', '\a', '\x5', 
		'\x2', '\x2', '\x1E', '\a', '\x3', '\x2', '\x2', '\x2', '\x1F', '#', '\a', 
		'\x6', '\x2', '\x2', ' ', '#', '\a', '\a', '\x2', '\x2', '!', '#', '\x3', 
		'\x2', '\x2', '\x2', '\"', '\x1F', '\x3', '\x2', '\x2', '\x2', '\"', ' ', 
		'\x3', '\x2', '\x2', '\x2', '\"', '!', '\x3', '\x2', '\x2', '\x2', '#', 
		'\t', '\x3', '\x2', '\x2', '\x2', '\x6', '\xE', '\x17', '\x1B', '\"',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
