// Generated from grammars/ErrorLog.g4 by ANTLR 4.7.2
import org.antlr.v4.runtime.Lexer;
import org.antlr.v4.runtime.CharStream;
import org.antlr.v4.runtime.Token;
import org.antlr.v4.runtime.TokenStream;
import org.antlr.v4.runtime.*;
import org.antlr.v4.runtime.atn.*;
import org.antlr.v4.runtime.dfa.DFA;
import org.antlr.v4.runtime.misc.*;

@SuppressWarnings({"all", "warnings", "unchecked", "unused", "cast"})
public class ErrorLogLexer extends Lexer {
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
	public static String[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static String[] modeNames = {
		"DEFAULT_MODE"
	};

	private static String[] makeRuleNames() {
		return new String[] {
			"T__0", "NULL", "DASHES", "DOT", "COMMA", "AMP", "TICK", "DASH", "STAR", 
			"BANG", "GT", "LT", "SINGLE_QUOTE", "DOUBLE_QUOTE", "BACK_SLASH", "SLASH", 
			"SEMI", "QUESTION", "PIPE", "AT_SIGN", "PERCENT", "DOLLAR", "L_PAREN", 
			"R_PAREN", "L_BRACKET", "R_BRACKET", "L_BRACE", "R_BRACE", "COLON", "EQUAL", 
			"NUMBER", "MONTH", "AM_PM", "EXCEPTION_TYPE_LABEL", "ERROR_LABEL", "STACK_TRACE_LABEL", 
			"INNNER_EXCEPTION_LABEL", "IDENTIFIER", "EOL", "WS"
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


	public ErrorLogLexer(CharStream input) {
		super(input);
		_interp = new LexerATNSimulator(this,_ATN,_decisionToDFA,_sharedContextCache);
	}

	@Override
	public String getGrammarFileName() { return "ErrorLog.g4"; }

	@Override
	public String[] getRuleNames() { return ruleNames; }

	@Override
	public String getSerializedATN() { return _serializedATN; }

	@Override
	public String[] getChannelNames() { return channelNames; }

	@Override
	public String[] getModeNames() { return modeNames; }

	@Override
	public ATN getATN() { return _ATN; }

	public static final String _serializedATN =
		"\3\u608b\ua72a\u8133\ub9ed\u417c\u3be7\u7786\u5964\2*\u012a\b\1\4\2\t"+
		"\2\4\3\t\3\4\4\t\4\4\5\t\5\4\6\t\6\4\7\t\7\4\b\t\b\4\t\t\t\4\n\t\n\4\13"+
		"\t\13\4\f\t\f\4\r\t\r\4\16\t\16\4\17\t\17\4\20\t\20\4\21\t\21\4\22\t\22"+
		"\4\23\t\23\4\24\t\24\4\25\t\25\4\26\t\26\4\27\t\27\4\30\t\30\4\31\t\31"+
		"\4\32\t\32\4\33\t\33\4\34\t\34\4\35\t\35\4\36\t\36\4\37\t\37\4 \t \4!"+
		"\t!\4\"\t\"\4#\t#\4$\t$\4%\t%\4&\t&\4\'\t\'\4(\t(\4)\t)\3\2\3\2\3\2\3"+
		"\3\3\3\3\3\3\3\3\3\3\4\3\4\3\4\3\4\3\4\3\4\3\4\3\4\3\4\3\4\3\4\3\4\3\4"+
		"\3\4\3\4\3\4\3\4\3\4\3\4\3\4\3\4\3\4\3\4\3\5\3\5\3\6\3\6\3\7\3\7\3\b\3"+
		"\b\3\t\3\t\3\n\3\n\3\13\3\13\3\f\3\f\3\r\3\r\3\16\3\16\3\17\3\17\3\20"+
		"\3\20\3\21\3\21\3\22\3\22\3\23\3\23\3\24\3\24\3\25\3\25\3\26\3\26\3\27"+
		"\3\27\3\30\3\30\3\31\3\31\3\32\3\32\3\33\3\33\3\34\3\34\3\35\3\35\3\36"+
		"\3\36\3\37\3\37\3 \6 \u00aa\n \r \16 \u00ab\3!\3!\3!\3!\3!\3!\3!\3!\3"+
		"!\3!\3!\3!\3!\3!\3!\3!\3!\3!\3!\3!\3!\3!\3!\3!\3!\3!\3!\3!\3!\3!\3!\3"+
		"!\3!\3!\3!\3!\5!\u00d2\n!\3\"\3\"\3\"\3\"\5\"\u00d8\n\"\3#\3#\3#\3#\3"+
		"#\3#\3#\3#\3#\3#\3#\3#\3#\3#\3#\3#\3$\3$\3$\3$\3$\3$\3$\3%\3%\3%\3%\3"+
		"%\3%\3%\3%\3%\3%\3%\3%\3%\3&\3&\3&\3&\3&\3&\3&\3&\3&\3&\3&\3&\3&\3&\3"+
		"&\3&\3&\3&\3&\3&\3&\3&\3&\3&\3\'\3\'\7\'\u0118\n\'\f\'\16\'\u011b\13\'"+
		"\3(\5(\u011e\n(\3(\3(\5(\u0122\n(\3)\6)\u0125\n)\r)\16)\u0126\3)\3)\2"+
		"\2*\3\3\5\4\7\5\t\6\13\7\r\b\17\t\21\n\23\13\25\f\27\r\31\16\33\17\35"+
		"\20\37\21!\22#\23%\24\'\25)\26+\27-\30/\31\61\32\63\33\65\34\67\359\36"+
		";\37= ?!A\"C#E$G%I&K\'M(O)Q*\3\2\6\3\2\62;\5\2C\\aac|\6\2\62;C\\aac|\4"+
		"\2\13\13\"\"\2\u013a\2\3\3\2\2\2\2\5\3\2\2\2\2\7\3\2\2\2\2\t\3\2\2\2\2"+
		"\13\3\2\2\2\2\r\3\2\2\2\2\17\3\2\2\2\2\21\3\2\2\2\2\23\3\2\2\2\2\25\3"+
		"\2\2\2\2\27\3\2\2\2\2\31\3\2\2\2\2\33\3\2\2\2\2\35\3\2\2\2\2\37\3\2\2"+
		"\2\2!\3\2\2\2\2#\3\2\2\2\2%\3\2\2\2\2\'\3\2\2\2\2)\3\2\2\2\2+\3\2\2\2"+
		"\2-\3\2\2\2\2/\3\2\2\2\2\61\3\2\2\2\2\63\3\2\2\2\2\65\3\2\2\2\2\67\3\2"+
		"\2\2\29\3\2\2\2\2;\3\2\2\2\2=\3\2\2\2\2?\3\2\2\2\2A\3\2\2\2\2C\3\2\2\2"+
		"\2E\3\2\2\2\2G\3\2\2\2\2I\3\2\2\2\2K\3\2\2\2\2M\3\2\2\2\2O\3\2\2\2\2Q"+
		"\3\2\2\2\3S\3\2\2\2\5V\3\2\2\2\7[\3\2\2\2\tr\3\2\2\2\13t\3\2\2\2\rv\3"+
		"\2\2\2\17x\3\2\2\2\21z\3\2\2\2\23|\3\2\2\2\25~\3\2\2\2\27\u0080\3\2\2"+
		"\2\31\u0082\3\2\2\2\33\u0084\3\2\2\2\35\u0086\3\2\2\2\37\u0088\3\2\2\2"+
		"!\u008a\3\2\2\2#\u008c\3\2\2\2%\u008e\3\2\2\2\'\u0090\3\2\2\2)\u0092\3"+
		"\2\2\2+\u0094\3\2\2\2-\u0096\3\2\2\2/\u0098\3\2\2\2\61\u009a\3\2\2\2\63"+
		"\u009c\3\2\2\2\65\u009e\3\2\2\2\67\u00a0\3\2\2\29\u00a2\3\2\2\2;\u00a4"+
		"\3\2\2\2=\u00a6\3\2\2\2?\u00a9\3\2\2\2A\u00d1\3\2\2\2C\u00d7\3\2\2\2E"+
		"\u00d9\3\2\2\2G\u00e9\3\2\2\2I\u00f0\3\2\2\2K\u00fd\3\2\2\2M\u0115\3\2"+
		"\2\2O\u0121\3\2\2\2Q\u0124\3\2\2\2ST\7c\2\2TU\7v\2\2U\4\3\2\2\2VW\7P\2"+
		"\2WX\7W\2\2XY\7N\2\2YZ\7N\2\2Z\6\3\2\2\2[\\\7/\2\2\\]\7/\2\2]^\7/\2\2"+
		"^_\7/\2\2_`\7/\2\2`a\7/\2\2ab\7/\2\2bc\7/\2\2cd\7/\2\2de\7/\2\2ef\7/\2"+
		"\2fg\7/\2\2gh\7/\2\2hi\7/\2\2ij\7/\2\2jk\7/\2\2kl\7/\2\2lm\7/\2\2mn\7"+
		"/\2\2no\7/\2\2op\7/\2\2pq\7/\2\2q\b\3\2\2\2rs\7\60\2\2s\n\3\2\2\2tu\7"+
		".\2\2u\f\3\2\2\2vw\7(\2\2w\16\3\2\2\2xy\7b\2\2y\20\3\2\2\2z{\7/\2\2{\22"+
		"\3\2\2\2|}\7,\2\2}\24\3\2\2\2~\177\7#\2\2\177\26\3\2\2\2\u0080\u0081\7"+
		"@\2\2\u0081\30\3\2\2\2\u0082\u0083\7>\2\2\u0083\32\3\2\2\2\u0084\u0085"+
		"\7)\2\2\u0085\34\3\2\2\2\u0086\u0087\7$\2\2\u0087\36\3\2\2\2\u0088\u0089"+
		"\7^\2\2\u0089 \3\2\2\2\u008a\u008b\7\61\2\2\u008b\"\3\2\2\2\u008c\u008d"+
		"\7=\2\2\u008d$\3\2\2\2\u008e\u008f\7A\2\2\u008f&\3\2\2\2\u0090\u0091\7"+
		"~\2\2\u0091(\3\2\2\2\u0092\u0093\7B\2\2\u0093*\3\2\2\2\u0094\u0095\7\'"+
		"\2\2\u0095,\3\2\2\2\u0096\u0097\7&\2\2\u0097.\3\2\2\2\u0098\u0099\7*\2"+
		"\2\u0099\60\3\2\2\2\u009a\u009b\7+\2\2\u009b\62\3\2\2\2\u009c\u009d\7"+
		"]\2\2\u009d\64\3\2\2\2\u009e\u009f\7_\2\2\u009f\66\3\2\2\2\u00a0\u00a1"+
		"\7}\2\2\u00a18\3\2\2\2\u00a2\u00a3\7\177\2\2\u00a3:\3\2\2\2\u00a4\u00a5"+
		"\7<\2\2\u00a5<\3\2\2\2\u00a6\u00a7\7?\2\2\u00a7>\3\2\2\2\u00a8\u00aa\t"+
		"\2\2\2\u00a9\u00a8\3\2\2\2\u00aa\u00ab\3\2\2\2\u00ab\u00a9\3\2\2\2\u00ab"+
		"\u00ac\3\2\2\2\u00ac@\3\2\2\2\u00ad\u00ae\7L\2\2\u00ae\u00af\7c\2\2\u00af"+
		"\u00d2\7p\2\2\u00b0\u00b1\7H\2\2\u00b1\u00b2\7g\2\2\u00b2\u00d2\7d\2\2"+
		"\u00b3\u00b4\7O\2\2\u00b4\u00b5\7c\2\2\u00b5\u00d2\7t\2\2\u00b6\u00b7"+
		"\7C\2\2\u00b7\u00b8\7r\2\2\u00b8\u00d2\7t\2\2\u00b9\u00ba\7O\2\2\u00ba"+
		"\u00bb\7c\2\2\u00bb\u00d2\7{\2\2\u00bc\u00bd\7L\2\2\u00bd\u00be\7w\2\2"+
		"\u00be\u00d2\7p\2\2\u00bf\u00c0\7L\2\2\u00c0\u00c1\7w\2\2\u00c1\u00d2"+
		"\7n\2\2\u00c2\u00c3\7C\2\2\u00c3\u00c4\7w\2\2\u00c4\u00d2\7i\2\2\u00c5"+
		"\u00c6\7U\2\2\u00c6\u00c7\7g\2\2\u00c7\u00d2\7r\2\2\u00c8\u00c9\7Q\2\2"+
		"\u00c9\u00ca\7e\2\2\u00ca\u00d2\7v\2\2\u00cb\u00cc\7P\2\2\u00cc\u00cd"+
		"\7q\2\2\u00cd\u00d2\7x\2\2\u00ce\u00cf\7F\2\2\u00cf\u00d0\7g\2\2\u00d0"+
		"\u00d2\7e\2\2\u00d1\u00ad\3\2\2\2\u00d1\u00b0\3\2\2\2\u00d1\u00b3\3\2"+
		"\2\2\u00d1\u00b6\3\2\2\2\u00d1\u00b9\3\2\2\2\u00d1\u00bc\3\2\2\2\u00d1"+
		"\u00bf\3\2\2\2\u00d1\u00c2\3\2\2\2\u00d1\u00c5\3\2\2\2\u00d1\u00c8\3\2"+
		"\2\2\u00d1\u00cb\3\2\2\2\u00d1\u00ce\3\2\2\2\u00d2B\3\2\2\2\u00d3\u00d4"+
		"\7C\2\2\u00d4\u00d8\7O\2\2\u00d5\u00d6\7R\2\2\u00d6\u00d8\7O\2\2\u00d7"+
		"\u00d3\3\2\2\2\u00d7\u00d5\3\2\2\2\u00d8D\3\2\2\2\u00d9\u00da\7G\2\2\u00da"+
		"\u00db\7z\2\2\u00db\u00dc\7e\2\2\u00dc\u00dd\7g\2\2\u00dd\u00de\7r\2\2"+
		"\u00de\u00df\7v\2\2\u00df\u00e0\7k\2\2\u00e0\u00e1\7q\2\2\u00e1\u00e2"+
		"\7p\2\2\u00e2\u00e3\7\"\2\2\u00e3\u00e4\7V\2\2\u00e4\u00e5\7{\2\2\u00e5"+
		"\u00e6\7r\2\2\u00e6\u00e7\7g\2\2\u00e7\u00e8\7<\2\2\u00e8F\3\2\2\2\u00e9"+
		"\u00ea\7G\2\2\u00ea\u00eb\7t\2\2\u00eb\u00ec\7t\2\2\u00ec\u00ed\7q\2\2"+
		"\u00ed\u00ee\7t\2\2\u00ee\u00ef\7<\2\2\u00efH\3\2\2\2\u00f0\u00f1\7U\2"+
		"\2\u00f1\u00f2\7v\2\2\u00f2\u00f3\7c\2\2\u00f3\u00f4\7e\2\2\u00f4\u00f5"+
		"\7m\2\2\u00f5\u00f6\7\"\2\2\u00f6\u00f7\7V\2\2\u00f7\u00f8\7t\2\2\u00f8"+
		"\u00f9\7c\2\2\u00f9\u00fa\7e\2\2\u00fa\u00fb\7g\2\2\u00fb\u00fc\7<\2\2"+
		"\u00fcJ\3\2\2\2\u00fd\u00fe\7,\2\2\u00fe\u00ff\7,\2\2\u00ff\u0100\7,\2"+
		"\2\u0100\u0101\7\"\2\2\u0101\u0102\7K\2\2\u0102\u0103\7p\2\2\u0103\u0104"+
		"\7p\2\2\u0104\u0105\7g\2\2\u0105\u0106\7t\2\2\u0106\u0107\7\"\2\2\u0107"+
		"\u0108\7G\2\2\u0108\u0109\7z\2\2\u0109\u010a\7e\2\2\u010a\u010b\7g\2\2"+
		"\u010b\u010c\7r\2\2\u010c\u010d\7v\2\2\u010d\u010e\7k\2\2\u010e\u010f"+
		"\7q\2\2\u010f\u0110\7p\2\2\u0110\u0111\7\"\2\2\u0111\u0112\7,\2\2\u0112"+
		"\u0113\7,\2\2\u0113\u0114\7,\2\2\u0114L\3\2\2\2\u0115\u0119\t\3\2\2\u0116"+
		"\u0118\t\4\2\2\u0117\u0116\3\2\2\2\u0118\u011b\3\2\2\2\u0119\u0117\3\2"+
		"\2\2\u0119\u011a\3\2\2\2\u011aN\3\2\2\2\u011b\u0119\3\2\2\2\u011c\u011e"+
		"\7\17\2\2\u011d\u011c\3\2\2\2\u011d\u011e\3\2\2\2\u011e\u011f\3\2\2\2"+
		"\u011f\u0122\7\f\2\2\u0120\u0122\7\17\2\2\u0121\u011d\3\2\2\2\u0121\u0120"+
		"\3\2\2\2\u0122P\3\2\2\2\u0123\u0125\t\5\2\2\u0124\u0123\3\2\2\2\u0125"+
		"\u0126\3\2\2\2\u0126\u0124\3\2\2\2\u0126\u0127\3\2\2\2\u0127\u0128\3\2"+
		"\2\2\u0128\u0129\b)\2\2\u0129R\3\2\2\2\n\2\u00ab\u00d1\u00d7\u0119\u011d"+
		"\u0121\u0126\3\b\2\2";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}