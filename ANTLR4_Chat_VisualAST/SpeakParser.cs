//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Speak.g4 by ANTLR 4.7.1

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

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.1")]
[System.CLSCompliant(false)]
public partial class SpeakParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		SAYS=1, WORD=2, TEXT=3, WHITESPACE=4, NEWLINE=5, WS=6;
	public const int
		RULE_chat = 0, RULE_line = 1, RULE_name = 2, RULE_opinion = 3, RULE_compileUnit = 4;
	public static readonly string[] ruleNames = {
		"chat", "line", "name", "opinion", "compileUnit"
	};

	private static readonly string[] _LiteralNames = {
		null, null, null, null, null, null, "' '"
	};
	private static readonly string[] _SymbolicNames = {
		null, "SAYS", "WORD", "TEXT", "WHITESPACE", "NEWLINE", "WS"
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

	public override string GrammarFileName { get { return "Speak.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static SpeakParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public SpeakParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public SpeakParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}
	public partial class ChatContext : ParserRuleContext {
		public LineContext[] line() {
			return GetRuleContexts<LineContext>();
		}
		public LineContext line(int i) {
			return GetRuleContext<LineContext>(i);
		}
		public ITerminalNode Eof() { return GetToken(SpeakParser.Eof, 0); }
		public ChatContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_chat; } }
		public override void EnterRule(IParseTreeListener listener) {
			ISpeakListener typedListener = listener as ISpeakListener;
			if (typedListener != null) typedListener.EnterChat(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISpeakListener typedListener = listener as ISpeakListener;
			if (typedListener != null) typedListener.ExitChat(this);
		}
	}

	[RuleVersion(0)]
	public ChatContext chat() {
		ChatContext _localctx = new ChatContext(Context, State);
		EnterRule(_localctx, 0, RULE_chat);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 10; line();
			State = 11; line();
			State = 12; Match(Eof);
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

	public partial class LineContext : ParserRuleContext {
		public NameContext name() {
			return GetRuleContext<NameContext>(0);
		}
		public ITerminalNode SAYS() { return GetToken(SpeakParser.SAYS, 0); }
		public OpinionContext opinion() {
			return GetRuleContext<OpinionContext>(0);
		}
		public ITerminalNode NEWLINE() { return GetToken(SpeakParser.NEWLINE, 0); }
		public LineContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_line; } }
		public override void EnterRule(IParseTreeListener listener) {
			ISpeakListener typedListener = listener as ISpeakListener;
			if (typedListener != null) typedListener.EnterLine(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISpeakListener typedListener = listener as ISpeakListener;
			if (typedListener != null) typedListener.ExitLine(this);
		}
	}

	[RuleVersion(0)]
	public LineContext line() {
		LineContext _localctx = new LineContext(Context, State);
		EnterRule(_localctx, 2, RULE_line);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 14; name();
			State = 15; Match(SAYS);
			State = 16; opinion();
			State = 17; Match(NEWLINE);
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

	public partial class NameContext : ParserRuleContext {
		public ITerminalNode WORD() { return GetToken(SpeakParser.WORD, 0); }
		public NameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_name; } }
		public override void EnterRule(IParseTreeListener listener) {
			ISpeakListener typedListener = listener as ISpeakListener;
			if (typedListener != null) typedListener.EnterName(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISpeakListener typedListener = listener as ISpeakListener;
			if (typedListener != null) typedListener.ExitName(this);
		}
	}

	[RuleVersion(0)]
	public NameContext name() {
		NameContext _localctx = new NameContext(Context, State);
		EnterRule(_localctx, 4, RULE_name);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 19; Match(WORD);
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

	public partial class OpinionContext : ParserRuleContext {
		public ITerminalNode TEXT() { return GetToken(SpeakParser.TEXT, 0); }
		public OpinionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_opinion; } }
		public override void EnterRule(IParseTreeListener listener) {
			ISpeakListener typedListener = listener as ISpeakListener;
			if (typedListener != null) typedListener.EnterOpinion(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISpeakListener typedListener = listener as ISpeakListener;
			if (typedListener != null) typedListener.ExitOpinion(this);
		}
	}

	[RuleVersion(0)]
	public OpinionContext opinion() {
		OpinionContext _localctx = new OpinionContext(Context, State);
		EnterRule(_localctx, 6, RULE_opinion);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 21; Match(TEXT);
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

	public partial class CompileUnitContext : ParserRuleContext {
		public ITerminalNode Eof() { return GetToken(SpeakParser.Eof, 0); }
		public CompileUnitContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_compileUnit; } }
		public override void EnterRule(IParseTreeListener listener) {
			ISpeakListener typedListener = listener as ISpeakListener;
			if (typedListener != null) typedListener.EnterCompileUnit(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISpeakListener typedListener = listener as ISpeakListener;
			if (typedListener != null) typedListener.ExitCompileUnit(this);
		}
	}

	[RuleVersion(0)]
	public CompileUnitContext compileUnit() {
		CompileUnitContext _localctx = new CompileUnitContext(Context, State);
		EnterRule(_localctx, 8, RULE_compileUnit);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 23; Match(Eof);
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
		'\x5964', '\x3', '\b', '\x1C', '\x4', '\x2', '\t', '\x2', '\x4', '\x3', 
		'\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', '\x5', '\x4', 
		'\x6', '\t', '\x6', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x4', '\x3', '\x4', '\x3', '\x5', '\x3', '\x5', '\x3', '\x6', 
		'\x3', '\x6', '\x3', '\x6', '\x2', '\x2', '\a', '\x2', '\x4', '\x6', '\b', 
		'\n', '\x2', '\x2', '\x2', '\x16', '\x2', '\f', '\x3', '\x2', '\x2', '\x2', 
		'\x4', '\x10', '\x3', '\x2', '\x2', '\x2', '\x6', '\x15', '\x3', '\x2', 
		'\x2', '\x2', '\b', '\x17', '\x3', '\x2', '\x2', '\x2', '\n', '\x19', 
		'\x3', '\x2', '\x2', '\x2', '\f', '\r', '\x5', '\x4', '\x3', '\x2', '\r', 
		'\xE', '\x5', '\x4', '\x3', '\x2', '\xE', '\xF', '\a', '\x2', '\x2', '\x3', 
		'\xF', '\x3', '\x3', '\x2', '\x2', '\x2', '\x10', '\x11', '\x5', '\x6', 
		'\x4', '\x2', '\x11', '\x12', '\a', '\x3', '\x2', '\x2', '\x12', '\x13', 
		'\x5', '\b', '\x5', '\x2', '\x13', '\x14', '\a', '\a', '\x2', '\x2', '\x14', 
		'\x5', '\x3', '\x2', '\x2', '\x2', '\x15', '\x16', '\a', '\x4', '\x2', 
		'\x2', '\x16', '\a', '\x3', '\x2', '\x2', '\x2', '\x17', '\x18', '\a', 
		'\x5', '\x2', '\x2', '\x18', '\t', '\x3', '\x2', '\x2', '\x2', '\x19', 
		'\x1A', '\a', '\x2', '\x2', '\x3', '\x1A', '\v', '\x3', '\x2', '\x2', 
		'\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}