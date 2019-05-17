// Generated from grammars/ErrorLog.g4 by ANTLR 4.7.2
import org.antlr.v4.runtime.atn.*;
import org.antlr.v4.runtime.dfa.DFA;
import org.antlr.v4.runtime.*;
import org.antlr.v4.runtime.misc.*;
import org.antlr.v4.runtime.tree.*;
import java.util.List;
import java.util.Iterator;
import java.util.ArrayList;

@SuppressWarnings({"all", "warnings", "unchecked", "unused", "cast"})
public class ErrorLogParser extends Parser {
	static { RuntimeMetaData.checkVersion("4.7.2", RuntimeMetaData.VERSION); }

	protected static final DFA[] _decisionToDFA;
	protected static final PredictionContextCache _sharedContextCache =
		new PredictionContextCache();
	public static final int
		T__0=1, NULL=2, DASHES=3, DOT=4, COMMA=5, AMP=6, TICK=7, DASH=8, STAR=9, 
		BANG=10, GT=11, LT=12, SINGLE_QUOTE=13, DOUBLE_QUOTE=14, BACK_SLASH=15, 
		SLASH=16, SEMI=17, QUESTION=18, PIPE=19, AT_SIGN=20, PERCENT=21, DOLLAR=22, 
		L_PAREN=23, R_PAREN=24, L_BRACKET=25, R_BRACKET=26, L_BRACE=27, R_BRACE=28, 
		COLON=29, EQUAL=30, NUMBER=31, MONTH=32, AM_PM=33, EXCEPTION_TYPE_LABEL=34, 
		ERROR_LABEL=35, STACK_TRACE_LABEL=36, INNNER_EXCEPTION_LABEL=37, IDENTIFIER=38, 
		EOL=39, WS=40;
	public static final int
		RULE_logfile = 0, RULE_line = 1, RULE_logline = 2, RULE_datetime = 3, 
		RULE_day = 4, RULE_year = 5, RULE_hour = 6, RULE_minute = 7, RULE_skip_to_error_label = 8, 
		RULE_skip_to_exception_type = 9, RULE_exception_type = 10, RULE_error_and_stacktrace = 11, 
		RULE_error_message = 12, RULE_stack_trace = 13, RULE_method_signature = 14, 
		RULE_class_name = 15, RULE_method_name = 16, RULE_argument_list = 17, 
		RULE_type = 18;
	private static String[] makeRuleNames() {
		return new String[] {
			"logfile", "line", "logline", "datetime", "day", "year", "hour", "minute", 
			"skip_to_error_label", "skip_to_exception_type", "exception_type", "error_and_stacktrace", 
			"error_message", "stack_trace", "method_signature", "class_name", "method_name", 
			"argument_list", "type"
		};
	}
	public static final String[] ruleNames = makeRuleNames();

	private static String[] makeLiteralNames() {
		return new String[] {
			null, "'at'", "'NULL'", "'----------------------'", "'.'", "','", "'&'", 
			"'`'", "'-'", "'*'", "'!'", "'>'", "'<'", "'''", "'\"'", "'\\'", "'/'", 
			"';'", "'?'", "'|'", "'@'", "'%'", "'$'", "'('", "')'", "'['", "']'", 
			"'{'", "'}'", "':'", "'='", null, null, null, "'Exception Type:'", "'Error:'", 
			"'Stack Trace:'", "'*** Inner Exception ***'"
		};
	}
	private static final String[] _LITERAL_NAMES = makeLiteralNames();
	private static String[] makeSymbolicNames() {
		return new String[] {
			null, null, "NULL", "DASHES", "DOT", "COMMA", "AMP", "TICK", "DASH", 
			"STAR", "BANG", "GT", "LT", "SINGLE_QUOTE", "DOUBLE_QUOTE", "BACK_SLASH", 
			"SLASH", "SEMI", "QUESTION", "PIPE", "AT_SIGN", "PERCENT", "DOLLAR", 
			"L_PAREN", "R_PAREN", "L_BRACKET", "R_BRACKET", "L_BRACE", "R_BRACE", 
			"COLON", "EQUAL", "NUMBER", "MONTH", "AM_PM", "EXCEPTION_TYPE_LABEL", 
			"ERROR_LABEL", "STACK_TRACE_LABEL", "INNNER_EXCEPTION_LABEL", "IDENTIFIER", 
			"EOL", "WS"
		};
	}
	private static final String[] _SYMBOLIC_NAMES = makeSymbolicNames();
	public static final Vocabulary VOCABULARY = new VocabularyImpl(_LITERAL_NAMES, _SYMBOLIC_NAMES);

	/**
	 * @deprecated Use {@link #VOCABULARY} instead.
	 */
	@Deprecated
	public static final String[] tokenNames;
	static {
		tokenNames = new String[_SYMBOLIC_NAMES.length];
		for (int i = 0; i < tokenNames.length; i++) {
			tokenNames[i] = VOCABULARY.getLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = VOCABULARY.getSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}
	}

	@Override
	@Deprecated
	public String[] getTokenNames() {
		return tokenNames;
	}

	@Override

	public Vocabulary getVocabulary() {
		return VOCABULARY;
	}

	@Override
	public String getGrammarFileName() { return "ErrorLog.g4"; }

	@Override
	public String[] getRuleNames() { return ruleNames; }

	@Override
	public String getSerializedATN() { return _serializedATN; }

	@Override
	public ATN getATN() { return _ATN; }

	public ErrorLogParser(TokenStream input) {
		super(input);
		_interp = new ParserATNSimulator(this,_ATN,_decisionToDFA,_sharedContextCache);
	}

	public static class LogfileContext extends ParserRuleContext {
		public TerminalNode EOF() { return getToken(ErrorLogParser.EOF, 0); }
		public List<LineContext> line() {
			return getRuleContexts(LineContext.class);
		}
		public LineContext line(int i) {
			return getRuleContext(LineContext.class,i);
		}
		public LogfileContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_logfile; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof ErrorLogListener ) ((ErrorLogListener)listener).enterLogfile(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof ErrorLogListener ) ((ErrorLogListener)listener).exitLogfile(this);
		}
	}

	public final LogfileContext logfile() throws RecognitionException {
		LogfileContext _localctx = new LogfileContext(_ctx, getState());
		enterRule(_localctx, 0, RULE_logfile);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(41);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while (_la==NULL || _la==DASHES) {
				{
				{
				setState(38);
				line();
				}
				}
				setState(43);
				_errHandler.sync(this);
				_la = _input.LA(1);
			}
			setState(44);
			match(EOF);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class LineContext extends ParserRuleContext {
		public TerminalNode NULL() { return getToken(ErrorLogParser.NULL, 0); }
		public LoglineContext logline() {
			return getRuleContext(LoglineContext.class,0);
		}
		public TerminalNode EOL() { return getToken(ErrorLogParser.EOL, 0); }
		public LineContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_line; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof ErrorLogListener ) ((ErrorLogListener)listener).enterLine(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof ErrorLogListener ) ((ErrorLogListener)listener).exitLine(this);
		}
	}

	public final LineContext line() throws RecognitionException {
		LineContext _localctx = new LineContext(_ctx, getState());
		enterRule(_localctx, 2, RULE_line);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(48);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case NULL:
				{
				setState(46);
				match(NULL);
				}
				break;
			case DASHES:
				{
				setState(47);
				logline();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			setState(51);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (_la==EOL) {
				{
				setState(50);
				match(EOL);
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class LoglineContext extends ParserRuleContext {
		public TerminalNode DASHES() { return getToken(ErrorLogParser.DASHES, 0); }
		public DatetimeContext datetime() {
			return getRuleContext(DatetimeContext.class,0);
		}
		public Skip_to_error_labelContext skip_to_error_label() {
			return getRuleContext(Skip_to_error_labelContext.class,0);
		}
		public TerminalNode EXCEPTION_TYPE_LABEL() { return getToken(ErrorLogParser.EXCEPTION_TYPE_LABEL, 0); }
		public Exception_typeContext exception_type() {
			return getRuleContext(Exception_typeContext.class,0);
		}
		public Skip_to_exception_typeContext skip_to_exception_type() {
			return getRuleContext(Skip_to_exception_typeContext.class,0);
		}
		public TerminalNode ERROR_LABEL() { return getToken(ErrorLogParser.ERROR_LABEL, 0); }
		public Error_and_stacktraceContext error_and_stacktrace() {
			return getRuleContext(Error_and_stacktraceContext.class,0);
		}
		public LoglineContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_logline; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof ErrorLogListener ) ((ErrorLogListener)listener).enterLogline(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof ErrorLogListener ) ((ErrorLogListener)listener).exitLogline(this);
		}
	}

	public final LoglineContext logline() throws RecognitionException {
		LoglineContext _localctx = new LoglineContext(_ctx, getState());
		enterRule(_localctx, 4, RULE_logline);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(53);
			match(DASHES);
			setState(54);
			datetime();
			setState(55);
			skip_to_error_label();
			setState(56);
			match(EXCEPTION_TYPE_LABEL);
			setState(57);
			exception_type();
			setState(58);
			skip_to_exception_type();
			setState(59);
			match(ERROR_LABEL);
			setState(60);
			error_and_stacktrace();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class DatetimeContext extends ParserRuleContext {
		public TerminalNode MONTH() { return getToken(ErrorLogParser.MONTH, 0); }
		public DayContext day() {
			return getRuleContext(DayContext.class,0);
		}
		public YearContext year() {
			return getRuleContext(YearContext.class,0);
		}
		public HourContext hour() {
			return getRuleContext(HourContext.class,0);
		}
		public TerminalNode COLON() { return getToken(ErrorLogParser.COLON, 0); }
		public MinuteContext minute() {
			return getRuleContext(MinuteContext.class,0);
		}
		public TerminalNode AM_PM() { return getToken(ErrorLogParser.AM_PM, 0); }
		public DatetimeContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_datetime; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof ErrorLogListener ) ((ErrorLogListener)listener).enterDatetime(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof ErrorLogListener ) ((ErrorLogListener)listener).exitDatetime(this);
		}
	}

	public final DatetimeContext datetime() throws RecognitionException {
		DatetimeContext _localctx = new DatetimeContext(_ctx, getState());
		enterRule(_localctx, 6, RULE_datetime);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(62);
			match(MONTH);
			setState(63);
			day();
			setState(64);
			year();
			setState(65);
			hour();
			setState(66);
			match(COLON);
			setState(67);
			minute();
			setState(68);
			match(AM_PM);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class DayContext extends ParserRuleContext {
		public TerminalNode NUMBER() { return getToken(ErrorLogParser.NUMBER, 0); }
		public DayContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_day; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof ErrorLogListener ) ((ErrorLogListener)listener).enterDay(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof ErrorLogListener ) ((ErrorLogListener)listener).exitDay(this);
		}
	}

	public final DayContext day() throws RecognitionException {
		DayContext _localctx = new DayContext(_ctx, getState());
		enterRule(_localctx, 8, RULE_day);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(70);
			match(NUMBER);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class YearContext extends ParserRuleContext {
		public TerminalNode NUMBER() { return getToken(ErrorLogParser.NUMBER, 0); }
		public YearContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_year; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof ErrorLogListener ) ((ErrorLogListener)listener).enterYear(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof ErrorLogListener ) ((ErrorLogListener)listener).exitYear(this);
		}
	}

	public final YearContext year() throws RecognitionException {
		YearContext _localctx = new YearContext(_ctx, getState());
		enterRule(_localctx, 10, RULE_year);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(72);
			match(NUMBER);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class HourContext extends ParserRuleContext {
		public TerminalNode NUMBER() { return getToken(ErrorLogParser.NUMBER, 0); }
		public HourContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_hour; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof ErrorLogListener ) ((ErrorLogListener)listener).enterHour(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof ErrorLogListener ) ((ErrorLogListener)listener).exitHour(this);
		}
	}

	public final HourContext hour() throws RecognitionException {
		HourContext _localctx = new HourContext(_ctx, getState());
		enterRule(_localctx, 12, RULE_hour);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(74);
			match(NUMBER);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class MinuteContext extends ParserRuleContext {
		public TerminalNode NUMBER() { return getToken(ErrorLogParser.NUMBER, 0); }
		public MinuteContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_minute; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof ErrorLogListener ) ((ErrorLogListener)listener).enterMinute(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof ErrorLogListener ) ((ErrorLogListener)listener).exitMinute(this);
		}
	}

	public final MinuteContext minute() throws RecognitionException {
		MinuteContext _localctx = new MinuteContext(_ctx, getState());
		enterRule(_localctx, 14, RULE_minute);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(76);
			match(NUMBER);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Skip_to_error_labelContext extends ParserRuleContext {
		public List<TerminalNode> ERROR_LABEL() { return getTokens(ErrorLogParser.ERROR_LABEL); }
		public TerminalNode ERROR_LABEL(int i) {
			return getToken(ErrorLogParser.ERROR_LABEL, i);
		}
		public Skip_to_error_labelContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_skip_to_error_label; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof ErrorLogListener ) ((ErrorLogListener)listener).enterSkip_to_error_label(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof ErrorLogListener ) ((ErrorLogListener)listener).exitSkip_to_error_label(this);
		}
	}

	public final Skip_to_error_labelContext skip_to_error_label() throws RecognitionException {
		Skip_to_error_labelContext _localctx = new Skip_to_error_labelContext(_ctx, getState());
		enterRule(_localctx, 16, RULE_skip_to_error_label);
		int _la;
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			setState(79); 
			_errHandler.sync(this);
			_alt = 1+1;
			do {
				switch (_alt) {
				case 1+1:
					{
					{
					setState(78);
					_la = _input.LA(1);
					if ( _la <= 0 || (_la==ERROR_LABEL) ) {
					_errHandler.recoverInline(this);
					}
					else {
						if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
						_errHandler.reportMatch(this);
						consume();
					}
					}
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				setState(81); 
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,3,_ctx);
			} while ( _alt!=1 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER );
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Skip_to_exception_typeContext extends ParserRuleContext {
		public List<TerminalNode> EXCEPTION_TYPE_LABEL() { return getTokens(ErrorLogParser.EXCEPTION_TYPE_LABEL); }
		public TerminalNode EXCEPTION_TYPE_LABEL(int i) {
			return getToken(ErrorLogParser.EXCEPTION_TYPE_LABEL, i);
		}
		public Skip_to_exception_typeContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_skip_to_exception_type; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof ErrorLogListener ) ((ErrorLogListener)listener).enterSkip_to_exception_type(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof ErrorLogListener ) ((ErrorLogListener)listener).exitSkip_to_exception_type(this);
		}
	}

	public final Skip_to_exception_typeContext skip_to_exception_type() throws RecognitionException {
		Skip_to_exception_typeContext _localctx = new Skip_to_exception_typeContext(_ctx, getState());
		enterRule(_localctx, 18, RULE_skip_to_exception_type);
		int _la;
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			setState(84); 
			_errHandler.sync(this);
			_alt = 1+1;
			do {
				switch (_alt) {
				case 1+1:
					{
					{
					setState(83);
					_la = _input.LA(1);
					if ( _la <= 0 || (_la==EXCEPTION_TYPE_LABEL) ) {
					_errHandler.recoverInline(this);
					}
					else {
						if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
						_errHandler.reportMatch(this);
						consume();
					}
					}
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				setState(86); 
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,4,_ctx);
			} while ( _alt!=1 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER );
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Exception_typeContext extends ParserRuleContext {
		public Class_nameContext class_name() {
			return getRuleContext(Class_nameContext.class,0);
		}
		public Exception_typeContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_exception_type; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof ErrorLogListener ) ((ErrorLogListener)listener).enterException_type(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof ErrorLogListener ) ((ErrorLogListener)listener).exitException_type(this);
		}
	}

	public final Exception_typeContext exception_type() throws RecognitionException {
		Exception_typeContext _localctx = new Exception_typeContext(_ctx, getState());
		enterRule(_localctx, 20, RULE_exception_type);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(88);
			class_name();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Error_and_stacktraceContext extends ParserRuleContext {
		public Error_messageContext error_message() {
			return getRuleContext(Error_messageContext.class,0);
		}
		public TerminalNode STACK_TRACE_LABEL() { return getToken(ErrorLogParser.STACK_TRACE_LABEL, 0); }
		public Stack_traceContext stack_trace() {
			return getRuleContext(Stack_traceContext.class,0);
		}
		public List<TerminalNode> INNNER_EXCEPTION_LABEL() { return getTokens(ErrorLogParser.INNNER_EXCEPTION_LABEL); }
		public TerminalNode INNNER_EXCEPTION_LABEL(int i) {
			return getToken(ErrorLogParser.INNNER_EXCEPTION_LABEL, i);
		}
		public Error_and_stacktraceContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_error_and_stacktrace; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof ErrorLogListener ) ((ErrorLogListener)listener).enterError_and_stacktrace(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof ErrorLogListener ) ((ErrorLogListener)listener).exitError_and_stacktrace(this);
		}
	}

	public final Error_and_stacktraceContext error_and_stacktrace() throws RecognitionException {
		Error_and_stacktraceContext _localctx = new Error_and_stacktraceContext(_ctx, getState());
		enterRule(_localctx, 22, RULE_error_and_stacktrace);
		int _la;
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			setState(90);
			error_message();
			setState(91);
			match(STACK_TRACE_LABEL);
			setState(92);
			stack_trace();
			setState(101);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while (_la==INNNER_EXCEPTION_LABEL) {
				{
				{
				setState(93);
				match(INNNER_EXCEPTION_LABEL);
				setState(95); 
				_errHandler.sync(this);
				_alt = 1+1;
				do {
					switch (_alt) {
					case 1+1:
						{
						{
						setState(94);
						matchWildcard();
						}
						}
						break;
					default:
						throw new NoViableAltException(this);
					}
					setState(97); 
					_errHandler.sync(this);
					_alt = getInterpreter().adaptivePredict(_input,5,_ctx);
				} while ( _alt!=1 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER );
				}
				}
				setState(103);
				_errHandler.sync(this);
				_la = _input.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Error_messageContext extends ParserRuleContext {
		public List<TerminalNode> STACK_TRACE_LABEL() { return getTokens(ErrorLogParser.STACK_TRACE_LABEL); }
		public TerminalNode STACK_TRACE_LABEL(int i) {
			return getToken(ErrorLogParser.STACK_TRACE_LABEL, i);
		}
		public Error_messageContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_error_message; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof ErrorLogListener ) ((ErrorLogListener)listener).enterError_message(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof ErrorLogListener ) ((ErrorLogListener)listener).exitError_message(this);
		}
	}

	public final Error_messageContext error_message() throws RecognitionException {
		Error_messageContext _localctx = new Error_messageContext(_ctx, getState());
		enterRule(_localctx, 24, RULE_error_message);
		int _la;
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			setState(105); 
			_errHandler.sync(this);
			_alt = 1+1;
			do {
				switch (_alt) {
				case 1+1:
					{
					{
					setState(104);
					_la = _input.LA(1);
					if ( _la <= 0 || (_la==STACK_TRACE_LABEL) ) {
					_errHandler.recoverInline(this);
					}
					else {
						if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
						_errHandler.reportMatch(this);
						consume();
					}
					}
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				setState(107); 
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,7,_ctx);
			} while ( _alt!=1 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER );
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Stack_traceContext extends ParserRuleContext {
		public List<Method_signatureContext> method_signature() {
			return getRuleContexts(Method_signatureContext.class);
		}
		public Method_signatureContext method_signature(int i) {
			return getRuleContext(Method_signatureContext.class,i);
		}
		public Stack_traceContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_stack_trace; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof ErrorLogListener ) ((ErrorLogListener)listener).enterStack_trace(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof ErrorLogListener ) ((ErrorLogListener)listener).exitStack_trace(this);
		}
	}

	public final Stack_traceContext stack_trace() throws RecognitionException {
		Stack_traceContext _localctx = new Stack_traceContext(_ctx, getState());
		enterRule(_localctx, 26, RULE_stack_trace);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(111); 
			_errHandler.sync(this);
			_la = _input.LA(1);
			do {
				{
				{
				setState(109);
				match(T__0);
				setState(110);
				method_signature();
				}
				}
				setState(113); 
				_errHandler.sync(this);
				_la = _input.LA(1);
			} while ( _la==T__0 );
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Method_signatureContext extends ParserRuleContext {
		public Class_nameContext class_name() {
			return getRuleContext(Class_nameContext.class,0);
		}
		public TerminalNode DOT() { return getToken(ErrorLogParser.DOT, 0); }
		public Method_nameContext method_name() {
			return getRuleContext(Method_nameContext.class,0);
		}
		public Argument_listContext argument_list() {
			return getRuleContext(Argument_listContext.class,0);
		}
		public Method_signatureContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_method_signature; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof ErrorLogListener ) ((ErrorLogListener)listener).enterMethod_signature(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof ErrorLogListener ) ((ErrorLogListener)listener).exitMethod_signature(this);
		}
	}

	public final Method_signatureContext method_signature() throws RecognitionException {
		Method_signatureContext _localctx = new Method_signatureContext(_ctx, getState());
		enterRule(_localctx, 28, RULE_method_signature);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(115);
			class_name();
			setState(116);
			match(DOT);
			setState(117);
			method_name();
			setState(118);
			argument_list();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Class_nameContext extends ParserRuleContext {
		public List<TerminalNode> IDENTIFIER() { return getTokens(ErrorLogParser.IDENTIFIER); }
		public TerminalNode IDENTIFIER(int i) {
			return getToken(ErrorLogParser.IDENTIFIER, i);
		}
		public List<TerminalNode> DOT() { return getTokens(ErrorLogParser.DOT); }
		public TerminalNode DOT(int i) {
			return getToken(ErrorLogParser.DOT, i);
		}
		public Class_nameContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_class_name; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof ErrorLogListener ) ((ErrorLogListener)listener).enterClass_name(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof ErrorLogListener ) ((ErrorLogListener)listener).exitClass_name(this);
		}
	}

	public final Class_nameContext class_name() throws RecognitionException {
		Class_nameContext _localctx = new Class_nameContext(_ctx, getState());
		enterRule(_localctx, 30, RULE_class_name);
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			setState(124);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,9,_ctx);
			while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					setState(120);
					match(IDENTIFIER);
					setState(121);
					match(DOT);
					}
					} 
				}
				setState(126);
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,9,_ctx);
			}
			setState(127);
			match(IDENTIFIER);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Method_nameContext extends ParserRuleContext {
		public TerminalNode IDENTIFIER() { return getToken(ErrorLogParser.IDENTIFIER, 0); }
		public Method_nameContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_method_name; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof ErrorLogListener ) ((ErrorLogListener)listener).enterMethod_name(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof ErrorLogListener ) ((ErrorLogListener)listener).exitMethod_name(this);
		}
	}

	public final Method_nameContext method_name() throws RecognitionException {
		Method_nameContext _localctx = new Method_nameContext(_ctx, getState());
		enterRule(_localctx, 32, RULE_method_name);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(129);
			match(IDENTIFIER);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Argument_listContext extends ParserRuleContext {
		public TerminalNode L_PAREN() { return getToken(ErrorLogParser.L_PAREN, 0); }
		public TerminalNode R_PAREN() { return getToken(ErrorLogParser.R_PAREN, 0); }
		public List<TypeContext> type() {
			return getRuleContexts(TypeContext.class);
		}
		public TypeContext type(int i) {
			return getRuleContext(TypeContext.class,i);
		}
		public List<TerminalNode> IDENTIFIER() { return getTokens(ErrorLogParser.IDENTIFIER); }
		public TerminalNode IDENTIFIER(int i) {
			return getToken(ErrorLogParser.IDENTIFIER, i);
		}
		public List<TerminalNode> COMMA() { return getTokens(ErrorLogParser.COMMA); }
		public TerminalNode COMMA(int i) {
			return getToken(ErrorLogParser.COMMA, i);
		}
		public Argument_listContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_argument_list; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof ErrorLogListener ) ((ErrorLogListener)listener).enterArgument_list(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof ErrorLogListener ) ((ErrorLogListener)listener).exitArgument_list(this);
		}
	}

	public final Argument_listContext argument_list() throws RecognitionException {
		Argument_listContext _localctx = new Argument_listContext(_ctx, getState());
		enterRule(_localctx, 34, RULE_argument_list);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(131);
			match(L_PAREN);
			setState(143);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (_la==IDENTIFIER) {
				{
				setState(132);
				type();
				setState(133);
				match(IDENTIFIER);
				setState(140);
				_errHandler.sync(this);
				_la = _input.LA(1);
				while (_la==COMMA) {
					{
					{
					setState(134);
					match(COMMA);
					setState(135);
					type();
					setState(136);
					match(IDENTIFIER);
					}
					}
					setState(142);
					_errHandler.sync(this);
					_la = _input.LA(1);
				}
				}
			}

			setState(145);
			match(R_PAREN);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class TypeContext extends ParserRuleContext {
		public TerminalNode IDENTIFIER() { return getToken(ErrorLogParser.IDENTIFIER, 0); }
		public TerminalNode AMP() { return getToken(ErrorLogParser.AMP, 0); }
		public TerminalNode TICK() { return getToken(ErrorLogParser.TICK, 0); }
		public TerminalNode NUMBER() { return getToken(ErrorLogParser.NUMBER, 0); }
		public TerminalNode L_BRACKET() { return getToken(ErrorLogParser.L_BRACKET, 0); }
		public TerminalNode R_BRACKET() { return getToken(ErrorLogParser.R_BRACKET, 0); }
		public TypeContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_type; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof ErrorLogListener ) ((ErrorLogListener)listener).enterType(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof ErrorLogListener ) ((ErrorLogListener)listener).exitType(this);
		}
	}

	public final TypeContext type() throws RecognitionException {
		TypeContext _localctx = new TypeContext(_ctx, getState());
		enterRule(_localctx, 36, RULE_type);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(147);
			match(IDENTIFIER);
			setState(153);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case AMP:
				{
				setState(148);
				match(AMP);
				}
				break;
			case TICK:
				{
				setState(149);
				match(TICK);
				setState(150);
				match(NUMBER);
				}
				break;
			case L_BRACKET:
				{
				setState(151);
				match(L_BRACKET);
				setState(152);
				match(R_BRACKET);
				}
				break;
			case IDENTIFIER:
				break;
			default:
				break;
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static final String _serializedATN =
		"\3\u608b\ua72a\u8133\ub9ed\u417c\u3be7\u7786\u5964\3*\u009e\4\2\t\2\4"+
		"\3\t\3\4\4\t\4\4\5\t\5\4\6\t\6\4\7\t\7\4\b\t\b\4\t\t\t\4\n\t\n\4\13\t"+
		"\13\4\f\t\f\4\r\t\r\4\16\t\16\4\17\t\17\4\20\t\20\4\21\t\21\4\22\t\22"+
		"\4\23\t\23\4\24\t\24\3\2\7\2*\n\2\f\2\16\2-\13\2\3\2\3\2\3\3\3\3\5\3\63"+
		"\n\3\3\3\5\3\66\n\3\3\4\3\4\3\4\3\4\3\4\3\4\3\4\3\4\3\4\3\5\3\5\3\5\3"+
		"\5\3\5\3\5\3\5\3\5\3\6\3\6\3\7\3\7\3\b\3\b\3\t\3\t\3\n\6\nR\n\n\r\n\16"+
		"\nS\3\13\6\13W\n\13\r\13\16\13X\3\f\3\f\3\r\3\r\3\r\3\r\3\r\6\rb\n\r\r"+
		"\r\16\rc\7\rf\n\r\f\r\16\ri\13\r\3\16\6\16l\n\16\r\16\16\16m\3\17\3\17"+
		"\6\17r\n\17\r\17\16\17s\3\20\3\20\3\20\3\20\3\20\3\21\3\21\7\21}\n\21"+
		"\f\21\16\21\u0080\13\21\3\21\3\21\3\22\3\22\3\23\3\23\3\23\3\23\3\23\3"+
		"\23\3\23\7\23\u008d\n\23\f\23\16\23\u0090\13\23\5\23\u0092\n\23\3\23\3"+
		"\23\3\24\3\24\3\24\3\24\3\24\3\24\5\24\u009c\n\24\3\24\6SXcm\2\25\2\4"+
		"\6\b\n\f\16\20\22\24\26\30\32\34\36 \"$&\2\5\3\2%%\3\2$$\3\2&&\2\u0099"+
		"\2+\3\2\2\2\4\62\3\2\2\2\6\67\3\2\2\2\b@\3\2\2\2\nH\3\2\2\2\fJ\3\2\2\2"+
		"\16L\3\2\2\2\20N\3\2\2\2\22Q\3\2\2\2\24V\3\2\2\2\26Z\3\2\2\2\30\\\3\2"+
		"\2\2\32k\3\2\2\2\34q\3\2\2\2\36u\3\2\2\2 ~\3\2\2\2\"\u0083\3\2\2\2$\u0085"+
		"\3\2\2\2&\u0095\3\2\2\2(*\5\4\3\2)(\3\2\2\2*-\3\2\2\2+)\3\2\2\2+,\3\2"+
		"\2\2,.\3\2\2\2-+\3\2\2\2./\7\2\2\3/\3\3\2\2\2\60\63\7\4\2\2\61\63\5\6"+
		"\4\2\62\60\3\2\2\2\62\61\3\2\2\2\63\65\3\2\2\2\64\66\7)\2\2\65\64\3\2"+
		"\2\2\65\66\3\2\2\2\66\5\3\2\2\2\678\7\5\2\289\5\b\5\29:\5\22\n\2:;\7$"+
		"\2\2;<\5\26\f\2<=\5\24\13\2=>\7%\2\2>?\5\30\r\2?\7\3\2\2\2@A\7\"\2\2A"+
		"B\5\n\6\2BC\5\f\7\2CD\5\16\b\2DE\7\37\2\2EF\5\20\t\2FG\7#\2\2G\t\3\2\2"+
		"\2HI\7!\2\2I\13\3\2\2\2JK\7!\2\2K\r\3\2\2\2LM\7!\2\2M\17\3\2\2\2NO\7!"+
		"\2\2O\21\3\2\2\2PR\n\2\2\2QP\3\2\2\2RS\3\2\2\2ST\3\2\2\2SQ\3\2\2\2T\23"+
		"\3\2\2\2UW\n\3\2\2VU\3\2\2\2WX\3\2\2\2XY\3\2\2\2XV\3\2\2\2Y\25\3\2\2\2"+
		"Z[\5 \21\2[\27\3\2\2\2\\]\5\32\16\2]^\7&\2\2^g\5\34\17\2_a\7\'\2\2`b\13"+
		"\2\2\2a`\3\2\2\2bc\3\2\2\2cd\3\2\2\2ca\3\2\2\2df\3\2\2\2e_\3\2\2\2fi\3"+
		"\2\2\2ge\3\2\2\2gh\3\2\2\2h\31\3\2\2\2ig\3\2\2\2jl\n\4\2\2kj\3\2\2\2l"+
		"m\3\2\2\2mn\3\2\2\2mk\3\2\2\2n\33\3\2\2\2op\7\3\2\2pr\5\36\20\2qo\3\2"+
		"\2\2rs\3\2\2\2sq\3\2\2\2st\3\2\2\2t\35\3\2\2\2uv\5 \21\2vw\7\6\2\2wx\5"+
		"\"\22\2xy\5$\23\2y\37\3\2\2\2z{\7(\2\2{}\7\6\2\2|z\3\2\2\2}\u0080\3\2"+
		"\2\2~|\3\2\2\2~\177\3\2\2\2\177\u0081\3\2\2\2\u0080~\3\2\2\2\u0081\u0082"+
		"\7(\2\2\u0082!\3\2\2\2\u0083\u0084\7(\2\2\u0084#\3\2\2\2\u0085\u0091\7"+
		"\31\2\2\u0086\u0087\5&\24\2\u0087\u008e\7(\2\2\u0088\u0089\7\7\2\2\u0089"+
		"\u008a\5&\24\2\u008a\u008b\7(\2\2\u008b\u008d\3\2\2\2\u008c\u0088\3\2"+
		"\2\2\u008d\u0090\3\2\2\2\u008e\u008c\3\2\2\2\u008e\u008f\3\2\2\2\u008f"+
		"\u0092\3\2\2\2\u0090\u008e\3\2\2\2\u0091\u0086\3\2\2\2\u0091\u0092\3\2"+
		"\2\2\u0092\u0093\3\2\2\2\u0093\u0094\7\32\2\2\u0094%\3\2\2\2\u0095\u009b"+
		"\7(\2\2\u0096\u009c\7\b\2\2\u0097\u0098\7\t\2\2\u0098\u009c\7!\2\2\u0099"+
		"\u009a\7\33\2\2\u009a\u009c\7\34\2\2\u009b\u0096\3\2\2\2\u009b\u0097\3"+
		"\2\2\2\u009b\u0099\3\2\2\2\u009b\u009c\3\2\2\2\u009c\'\3\2\2\2\17+\62"+
		"\65SXcgms~\u008e\u0091\u009b";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}