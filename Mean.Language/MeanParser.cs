/*
 * WARNING: this file has been generated by
 * Hime Parser Generator 3.4.0.0
 */
using System.Collections.Generic;
using Hime.Redist;
using Hime.Redist.Parsers;

namespace Mean.Language
{
	/// <summary>
	/// Represents a parser
	/// </summary>
	internal class MeanParser : LRkParser
	{
		/// <summary>
		/// The automaton for this parser
		/// </summary>
		private static readonly LRkAutomaton commonAutomaton = LRkAutomaton.Find(typeof(MeanParser), "MeanParser.bin");
		/// <summary>
		/// Contains the constant IDs for the variables and virtuals in this parser
		/// </summary>
		public class ID
		{
			/// <summary>
			/// The unique identifier for variable primary_expression
			/// </summary>
			public const int VariablePrimaryExpression = 0x000C;
			/// <summary>
			/// The unique identifier for variable exp_factor
			/// </summary>
			public const int VariableExpFactor = 0x000D;
			/// <summary>
			/// The unique identifier for variable exp_term
			/// </summary>
			public const int VariableExpTerm = 0x000E;
			/// <summary>
			/// The unique identifier for variable expression
			/// </summary>
			public const int VariableExpression = 0x000F;
		}
		/// <summary>
		/// The collection of variables matched by this parser
		/// </summary>
		/// <remarks>
		/// The variables are in an order consistent with the automaton,
		/// so that variable indices in the automaton can be used to retrieve the variables in this table
		/// </remarks>
		private static readonly Symbol[] variables = {
			new Symbol(0x000C, "primary_expression"), 
			new Symbol(0x000D, "exp_factor"), 
			new Symbol(0x000E, "exp_term"), 
			new Symbol(0x000F, "expression"), 
			new Symbol(0x0016, "__VAxiom") };
		/// <summary>
		/// The collection of virtuals matched by this parser
		/// </summary>
		/// <remarks>
		/// The virtuals are in an order consistent with the automaton,
		/// so that virtual indices in the automaton can be used to retrieve the virtuals in this table
		/// </remarks>
		private static readonly Symbol[] virtuals = {
 };
		/// <summary>
		/// Initializes a new instance of the parser
		/// </summary>
		/// <param name="lexer">The input lexer</param>
		public MeanParser(MeanLexer lexer) : base (commonAutomaton, variables, virtuals, null, lexer) { }

		/// <summary>
		/// Visitor interface
		/// </summary>
		public class Visitor
		{
			public virtual void OnTerminalNewLine(ASTNode node) {}
			public virtual void OnTerminalWhiteSpace(ASTNode node) {}
			public virtual void OnTerminalCommentLine(ASTNode node) {}
			public virtual void OnTerminalCommentBlock(ASTNode node) {}
			public virtual void OnTerminalIdentifier(ASTNode node) {}
			public virtual void OnTerminalInteger(ASTNode node) {}
			public virtual void OnTerminalReal(ASTNode node) {}
			public virtual void OnTerminalNumber(ASTNode node) {}
			public virtual void OnTerminalSeparator(ASTNode node) {}
			public virtual void OnVariablePrimaryExpression(ASTNode node) {}
			public virtual void OnVariableExpFactor(ASTNode node) {}
			public virtual void OnVariableExpTerm(ASTNode node) {}
			public virtual void OnVariableExpression(ASTNode node) {}
		}

		/// <summary>
		/// Walk the AST using a visitor
		/// </summary>
		public static void Visit(ParseResult result, Visitor visitor)
		{
			VisitASTNode(result.Root, visitor);
		}

		/// <summary>
		/// Walk the AST using a visitor
		/// </summary>
		public static void VisitASTNode(ASTNode node, Visitor visitor)
		{
			for (int i = 0; i < node.Children.Count; i++)
				VisitASTNode(node.Children[i], visitor);
			switch(node.Symbol.ID)
			{
				case 0x0003: visitor.OnTerminalNewLine(node); break;
				case 0x0004: visitor.OnTerminalWhiteSpace(node); break;
				case 0x0005: visitor.OnTerminalCommentLine(node); break;
				case 0x0006: visitor.OnTerminalCommentBlock(node); break;
				case 0x0007: visitor.OnTerminalIdentifier(node); break;
				case 0x0008: visitor.OnTerminalInteger(node); break;
				case 0x0009: visitor.OnTerminalReal(node); break;
				case 0x000A: visitor.OnTerminalNumber(node); break;
				case 0x000B: visitor.OnTerminalSeparator(node); break;
				case 0x000C: visitor.OnVariablePrimaryExpression(node); break;
				case 0x000D: visitor.OnVariableExpFactor(node); break;
				case 0x000E: visitor.OnVariableExpTerm(node); break;
				case 0x000F: visitor.OnVariableExpression(node); break;
			}
		}
	}
}
