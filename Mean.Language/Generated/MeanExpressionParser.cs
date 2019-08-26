/*
 * WARNING: this file has been generated by
 * Hime Parser Generator 3.4.0.0
 */
using System.Collections.Generic;
using Hime.Redist;
using Hime.Redist.Parsers;

namespace Mean.Language.Generated
{
	/// <summary>
	/// Represents a parser
	/// </summary>
	internal class MeanExpressionParser : RNGLRParser
	{
		/// <summary>
		/// The automaton for this parser
		/// </summary>
		private static readonly RNGLRAutomaton commonAutomaton = RNGLRAutomaton.Find(typeof(MeanExpressionParser), "MeanExpressionParser.bin");
		/// <summary>
		/// Contains the constant IDs for the variables and virtuals in this parser
		/// </summary>
		public class ID
		{
			/// <summary>
			/// The unique identifier for variable identifier
			/// </summary>
			public const int VariableIdentifier = 0x0018;
			/// <summary>
			/// The unique identifier for variable tupleIndex
			/// </summary>
			public const int VariableTupleIndex = 0x0019;
			/// <summary>
			/// The unique identifier for variable literal
			/// </summary>
			public const int VariableLiteral = 0x001A;
			/// <summary>
			/// The unique identifier for variable type
			/// </summary>
			public const int VariableType = 0x001B;
			/// <summary>
			/// The unique identifier for variable name
			/// </summary>
			public const int VariableName = 0x0020;
			/// <summary>
			/// The unique identifier for variable genericArgs
			/// </summary>
			public const int VariableGenericArgs = 0x0021;
			/// <summary>
			/// The unique identifier for variable genericArgsTypes
			/// </summary>
			public const int VariableGenericArgsTypes = 0x0022;
			/// <summary>
			/// The unique identifier for variable genericArgsBindings
			/// </summary>
			public const int VariableGenericArgsBindings = 0x0023;
			/// <summary>
			/// The unique identifier for variable genericArgsBinding
			/// </summary>
			public const int VariableGenericArgsBinding = 0x0024;
			/// <summary>
			/// The unique identifier for variable list<name, __T0001>
			/// </summary>
			public const int VariableListNameT0001 = 0x0025;
			/// <summary>
			/// The unique identifier for variable list<genericArgsBinding, __T0001>
			/// </summary>
			public const int VariableListGenericArgsBindingT0001 = 0x0027;
			/// <summary>
			/// The unique identifier for variable primaryExpression
			/// </summary>
			public const int VariablePrimaryExpression = 0x0029;
			/// <summary>
			/// The unique identifier for variable postfixExpression
			/// </summary>
			public const int VariablePostfixExpression = 0x002A;
			/// <summary>
			/// The unique identifier for variable unaryExpression
			/// </summary>
			public const int VariableUnaryExpression = 0x002B;
			/// <summary>
			/// The unique identifier for variable mulExpression
			/// </summary>
			public const int VariableMulExpression = 0x002C;
			/// <summary>
			/// The unique identifier for variable addExpression
			/// </summary>
			public const int VariableAddExpression = 0x002D;
			/// <summary>
			/// The unique identifier for variable shiftExpression
			/// </summary>
			public const int VariableShiftExpression = 0x002E;
			/// <summary>
			/// The unique identifier for variable equalityExpression
			/// </summary>
			public const int VariableEqualityExpression = 0x002F;
			/// <summary>
			/// The unique identifier for variable bitAndExpression
			/// </summary>
			public const int VariableBitAndExpression = 0x0030;
			/// <summary>
			/// The unique identifier for variable bitXorExpression
			/// </summary>
			public const int VariableBitXorExpression = 0x0031;
			/// <summary>
			/// The unique identifier for variable bitOrExpression
			/// </summary>
			public const int VariableBitOrExpression = 0x0032;
			/// <summary>
			/// The unique identifier for variable andExpression
			/// </summary>
			public const int VariableAndExpression = 0x0033;
			/// <summary>
			/// The unique identifier for variable orExpression
			/// </summary>
			public const int VariableOrExpression = 0x0034;
			/// <summary>
			/// The unique identifier for variable conditionalExpression
			/// </summary>
			public const int VariableConditionalExpression = 0x0035;
			/// <summary>
			/// The unique identifier for variable withoutBlockExpression
			/// </summary>
			public const int VariableWithoutBlockExpression = 0x0036;
			/// <summary>
			/// The unique identifier for variable expression
			/// </summary>
			public const int VariableExpression = 0x0037;
			/// <summary>
			/// The unique identifier for variable withBlockExpression
			/// </summary>
			public const int VariableWithBlockExpression = 0x0038;
			/// <summary>
			/// The unique identifier for variable blockExpression
			/// </summary>
			public const int VariableBlockExpression = 0x0039;
			/// <summary>
			/// The unique identifier for variable sloppyList<expression, __T0001>
			/// </summary>
			public const int VariableSloppyListExpressionT0001 = 0x003D;
			/// <summary>
			/// The unique identifier for virtual flist
			/// </summary>
			public const int VirtualFlist = 0x003C;
			/// <summary>
			/// The unique identifier for virtual iselect
			/// </summary>
			public const int VirtualIselect = 0x003F;
			/// <summary>
			/// The unique identifier for virtual tselect
			/// </summary>
			public const int VirtualTselect = 0x0042;
			/// <summary>
			/// The unique identifier for virtual mselect
			/// </summary>
			public const int VirtualMselect = 0x0044;
			/// <summary>
			/// The unique identifier for virtual negOp
			/// </summary>
			public const int VirtualNegOp = 0x0045;
			/// <summary>
			/// The unique identifier for virtual posOp
			/// </summary>
			public const int VirtualPosOp = 0x0047;
			/// <summary>
			/// The unique identifier for virtual notOp
			/// </summary>
			public const int VirtualNotOp = 0x0049;
			/// <summary>
			/// The unique identifier for virtual mulOp
			/// </summary>
			public const int VirtualMulOp = 0x004B;
			/// <summary>
			/// The unique identifier for virtual divOp
			/// </summary>
			public const int VirtualDivOp = 0x004D;
			/// <summary>
			/// The unique identifier for virtual remOp
			/// </summary>
			public const int VirtualRemOp = 0x004F;
			/// <summary>
			/// The unique identifier for virtual modOp
			/// </summary>
			public const int VirtualModOp = 0x0051;
			/// <summary>
			/// The unique identifier for virtual addOp
			/// </summary>
			public const int VirtualAddOp = 0x0053;
			/// <summary>
			/// The unique identifier for virtual subOp
			/// </summary>
			public const int VirtualSubOp = 0x0054;
			/// <summary>
			/// The unique identifier for virtual shlOp
			/// </summary>
			public const int VirtualShlOp = 0x0055;
			/// <summary>
			/// The unique identifier for virtual shrOp
			/// </summary>
			public const int VirtualShrOp = 0x0057;
			/// <summary>
			/// The unique identifier for virtual eqOp
			/// </summary>
			public const int VirtualEqOp = 0x0059;
			/// <summary>
			/// The unique identifier for virtual neOp
			/// </summary>
			public const int VirtualNeOp = 0x005B;
			/// <summary>
			/// The unique identifier for virtual ltOp
			/// </summary>
			public const int VirtualLtOp = 0x005D;
			/// <summary>
			/// The unique identifier for virtual ltleOp
			/// </summary>
			public const int VirtualLtleOp = 0x005E;
			/// <summary>
			/// The unique identifier for virtual ltltOp
			/// </summary>
			public const int VirtualLtltOp = 0x0060;
			/// <summary>
			/// The unique identifier for virtual leOp
			/// </summary>
			public const int VirtualLeOp = 0x0061;
			/// <summary>
			/// The unique identifier for virtual leleOp
			/// </summary>
			public const int VirtualLeleOp = 0x0062;
			/// <summary>
			/// The unique identifier for virtual leltOp
			/// </summary>
			public const int VirtualLeltOp = 0x0063;
			/// <summary>
			/// The unique identifier for virtual gtOp
			/// </summary>
			public const int VirtualGtOp = 0x0064;
			/// <summary>
			/// The unique identifier for virtual gtgeOp
			/// </summary>
			public const int VirtualGtgeOp = 0x0065;
			/// <summary>
			/// The unique identifier for virtual gtgtOp
			/// </summary>
			public const int VirtualGtgtOp = 0x0067;
			/// <summary>
			/// The unique identifier for virtual geOp
			/// </summary>
			public const int VirtualGeOp = 0x0068;
			/// <summary>
			/// The unique identifier for virtual gegeOp
			/// </summary>
			public const int VirtualGegeOp = 0x0069;
			/// <summary>
			/// The unique identifier for virtual gegtOp
			/// </summary>
			public const int VirtualGegtOp = 0x006A;
			/// <summary>
			/// The unique identifier for virtual andOp
			/// </summary>
			public const int VirtualAndOp = 0x006B;
			/// <summary>
			/// The unique identifier for virtual xorOp
			/// </summary>
			public const int VirtualXorOp = 0x006D;
			/// <summary>
			/// The unique identifier for virtual orOp
			/// </summary>
			public const int VirtualOrOp = 0x006F;
			/// <summary>
			/// The unique identifier for virtual andThenOp
			/// </summary>
			public const int VirtualAndThenOp = 0x0071;
			/// <summary>
			/// The unique identifier for virtual orElseOp
			/// </summary>
			public const int VirtualOrElseOp = 0x0073;
			/// <summary>
			/// The unique identifier for virtual iff
			/// </summary>
			public const int VirtualIff = 0x0075;
		}
		/// <summary>
		/// The collection of variables matched by this parser
		/// </summary>
		/// <remarks>
		/// The variables are in an order consistent with the automaton,
		/// so that variable indices in the automaton can be used to retrieve the variables in this table
		/// </remarks>
		private static readonly Symbol[] variables = {
			new Symbol(0x0018, "identifier"), 
			new Symbol(0x0019, "tupleIndex"), 
			new Symbol(0x001A, "literal"), 
			new Symbol(0x001B, "type"), 
			new Symbol(0x0020, "name"), 
			new Symbol(0x0021, "genericArgs"), 
			new Symbol(0x0022, "genericArgsTypes"), 
			new Symbol(0x0023, "genericArgsBindings"), 
			new Symbol(0x0024, "genericArgsBinding"), 
			new Symbol(0x0025, "list<name, __T0001>"), 
			new Symbol(0x0026, "__V15"), 
			new Symbol(0x0027, "list<genericArgsBinding, __T0001>"), 
			new Symbol(0x0028, "__V17"), 
			new Symbol(0x0029, "primaryExpression"), 
			new Symbol(0x002A, "postfixExpression"), 
			new Symbol(0x002B, "unaryExpression"), 
			new Symbol(0x002C, "mulExpression"), 
			new Symbol(0x002D, "addExpression"), 
			new Symbol(0x002E, "shiftExpression"), 
			new Symbol(0x002F, "equalityExpression"), 
			new Symbol(0x0030, "bitAndExpression"), 
			new Symbol(0x0031, "bitXorExpression"), 
			new Symbol(0x0032, "bitOrExpression"), 
			new Symbol(0x0033, "andExpression"), 
			new Symbol(0x0034, "orExpression"), 
			new Symbol(0x0035, "conditionalExpression"), 
			new Symbol(0x0036, "withoutBlockExpression"), 
			new Symbol(0x0037, "expression"), 
			new Symbol(0x0038, "withBlockExpression"), 
			new Symbol(0x0039, "blockExpression"), 
			new Symbol(0x003D, "sloppyList<expression, __T0001>"), 
			new Symbol(0x003E, "__V62"), 
			new Symbol(0x007A, "__VAxiom") };
		/// <summary>
		/// The collection of virtuals matched by this parser
		/// </summary>
		/// <remarks>
		/// The virtuals are in an order consistent with the automaton,
		/// so that virtual indices in the automaton can be used to retrieve the virtuals in this table
		/// </remarks>
		private static readonly Symbol[] virtuals = {
			new Symbol(0x003C, "flist"), 
			new Symbol(0x003F, "iselect"), 
			new Symbol(0x0042, "tselect"), 
			new Symbol(0x0044, "mselect"), 
			new Symbol(0x0045, "negOp"), 
			new Symbol(0x0047, "posOp"), 
			new Symbol(0x0049, "notOp"), 
			new Symbol(0x004B, "mulOp"), 
			new Symbol(0x004D, "divOp"), 
			new Symbol(0x004F, "remOp"), 
			new Symbol(0x0051, "modOp"), 
			new Symbol(0x0053, "addOp"), 
			new Symbol(0x0054, "subOp"), 
			new Symbol(0x0055, "shlOp"), 
			new Symbol(0x0057, "shrOp"), 
			new Symbol(0x0059, "eqOp"), 
			new Symbol(0x005B, "neOp"), 
			new Symbol(0x005D, "ltOp"), 
			new Symbol(0x005E, "ltleOp"), 
			new Symbol(0x0060, "ltltOp"), 
			new Symbol(0x0061, "leOp"), 
			new Symbol(0x0062, "leleOp"), 
			new Symbol(0x0063, "leltOp"), 
			new Symbol(0x0064, "gtOp"), 
			new Symbol(0x0065, "gtgeOp"), 
			new Symbol(0x0067, "gtgtOp"), 
			new Symbol(0x0068, "geOp"), 
			new Symbol(0x0069, "gegeOp"), 
			new Symbol(0x006A, "gegtOp"), 
			new Symbol(0x006B, "andOp"), 
			new Symbol(0x006D, "xorOp"), 
			new Symbol(0x006F, "orOp"), 
			new Symbol(0x0071, "andThenOp"), 
			new Symbol(0x0073, "orElseOp"), 
			new Symbol(0x0075, "iff") };
		/// <summary>
		/// Initializes a new instance of the parser
		/// </summary>
		/// <param name="lexer">The input lexer</param>
		public MeanExpressionParser(MeanExpressionLexer lexer) : base (commonAutomaton, variables, virtuals, null, lexer) { }

		/// <summary>
		/// Visitor interface
		/// </summary>
		public class Visitor
		{
			public virtual void OnTerminalSeparator(ASTNode node) {}
			public virtual void OnTerminalIdentifier(ASTNode node) {}
			public virtual void OnTerminalIntegerLiteral(ASTNode node) {}
			public virtual void OnTerminalFloatLiteral(ASTNode node) {}
			public virtual void OnTerminalBoolLiteral(ASTNode node) {}
			public virtual void OnVariableIdentifier(ASTNode node) {}
			public virtual void OnVariableTupleIndex(ASTNode node) {}
			public virtual void OnVariableLiteral(ASTNode node) {}
			public virtual void OnVariableType(ASTNode node) {}
			public virtual void OnVariableName(ASTNode node) {}
			public virtual void OnVariableGenericArgs(ASTNode node) {}
			public virtual void OnVariableGenericArgsTypes(ASTNode node) {}
			public virtual void OnVariableGenericArgsBindings(ASTNode node) {}
			public virtual void OnVariableGenericArgsBinding(ASTNode node) {}
			public virtual void OnVariableListNameT0001(ASTNode node) {}
			public virtual void OnVariableListGenericArgsBindingT0001(ASTNode node) {}
			public virtual void OnVariablePrimaryExpression(ASTNode node) {}
			public virtual void OnVariablePostfixExpression(ASTNode node) {}
			public virtual void OnVariableUnaryExpression(ASTNode node) {}
			public virtual void OnVariableMulExpression(ASTNode node) {}
			public virtual void OnVariableAddExpression(ASTNode node) {}
			public virtual void OnVariableShiftExpression(ASTNode node) {}
			public virtual void OnVariableEqualityExpression(ASTNode node) {}
			public virtual void OnVariableBitAndExpression(ASTNode node) {}
			public virtual void OnVariableBitXorExpression(ASTNode node) {}
			public virtual void OnVariableBitOrExpression(ASTNode node) {}
			public virtual void OnVariableAndExpression(ASTNode node) {}
			public virtual void OnVariableOrExpression(ASTNode node) {}
			public virtual void OnVariableConditionalExpression(ASTNode node) {}
			public virtual void OnVariableWithoutBlockExpression(ASTNode node) {}
			public virtual void OnVariableExpression(ASTNode node) {}
			public virtual void OnVariableWithBlockExpression(ASTNode node) {}
			public virtual void OnVariableBlockExpression(ASTNode node) {}
			public virtual void OnVariableSloppyListExpressionT0001(ASTNode node) {}
			public virtual void OnVirtualFlist(ASTNode node) {}
			public virtual void OnVirtualIselect(ASTNode node) {}
			public virtual void OnVirtualTselect(ASTNode node) {}
			public virtual void OnVirtualMselect(ASTNode node) {}
			public virtual void OnVirtualNegOp(ASTNode node) {}
			public virtual void OnVirtualPosOp(ASTNode node) {}
			public virtual void OnVirtualNotOp(ASTNode node) {}
			public virtual void OnVirtualMulOp(ASTNode node) {}
			public virtual void OnVirtualDivOp(ASTNode node) {}
			public virtual void OnVirtualRemOp(ASTNode node) {}
			public virtual void OnVirtualModOp(ASTNode node) {}
			public virtual void OnVirtualAddOp(ASTNode node) {}
			public virtual void OnVirtualSubOp(ASTNode node) {}
			public virtual void OnVirtualShlOp(ASTNode node) {}
			public virtual void OnVirtualShrOp(ASTNode node) {}
			public virtual void OnVirtualEqOp(ASTNode node) {}
			public virtual void OnVirtualNeOp(ASTNode node) {}
			public virtual void OnVirtualLtOp(ASTNode node) {}
			public virtual void OnVirtualLtleOp(ASTNode node) {}
			public virtual void OnVirtualLtltOp(ASTNode node) {}
			public virtual void OnVirtualLeOp(ASTNode node) {}
			public virtual void OnVirtualLeleOp(ASTNode node) {}
			public virtual void OnVirtualLeltOp(ASTNode node) {}
			public virtual void OnVirtualGtOp(ASTNode node) {}
			public virtual void OnVirtualGtgeOp(ASTNode node) {}
			public virtual void OnVirtualGtgtOp(ASTNode node) {}
			public virtual void OnVirtualGeOp(ASTNode node) {}
			public virtual void OnVirtualGegeOp(ASTNode node) {}
			public virtual void OnVirtualGegtOp(ASTNode node) {}
			public virtual void OnVirtualAndOp(ASTNode node) {}
			public virtual void OnVirtualXorOp(ASTNode node) {}
			public virtual void OnVirtualOrOp(ASTNode node) {}
			public virtual void OnVirtualAndThenOp(ASTNode node) {}
			public virtual void OnVirtualOrElseOp(ASTNode node) {}
			public virtual void OnVirtualIff(ASTNode node) {}
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
				case 0x0007: visitor.OnTerminalSeparator(node); break;
				case 0x0014: visitor.OnTerminalIdentifier(node); break;
				case 0x0015: visitor.OnTerminalIntegerLiteral(node); break;
				case 0x0016: visitor.OnTerminalFloatLiteral(node); break;
				case 0x0017: visitor.OnTerminalBoolLiteral(node); break;
				case 0x0018: visitor.OnVariableIdentifier(node); break;
				case 0x0019: visitor.OnVariableTupleIndex(node); break;
				case 0x001A: visitor.OnVariableLiteral(node); break;
				case 0x001B: visitor.OnVariableType(node); break;
				case 0x0020: visitor.OnVariableName(node); break;
				case 0x0021: visitor.OnVariableGenericArgs(node); break;
				case 0x0022: visitor.OnVariableGenericArgsTypes(node); break;
				case 0x0023: visitor.OnVariableGenericArgsBindings(node); break;
				case 0x0024: visitor.OnVariableGenericArgsBinding(node); break;
				case 0x0025: visitor.OnVariableListNameT0001(node); break;
				case 0x0027: visitor.OnVariableListGenericArgsBindingT0001(node); break;
				case 0x0029: visitor.OnVariablePrimaryExpression(node); break;
				case 0x002A: visitor.OnVariablePostfixExpression(node); break;
				case 0x002B: visitor.OnVariableUnaryExpression(node); break;
				case 0x002C: visitor.OnVariableMulExpression(node); break;
				case 0x002D: visitor.OnVariableAddExpression(node); break;
				case 0x002E: visitor.OnVariableShiftExpression(node); break;
				case 0x002F: visitor.OnVariableEqualityExpression(node); break;
				case 0x0030: visitor.OnVariableBitAndExpression(node); break;
				case 0x0031: visitor.OnVariableBitXorExpression(node); break;
				case 0x0032: visitor.OnVariableBitOrExpression(node); break;
				case 0x0033: visitor.OnVariableAndExpression(node); break;
				case 0x0034: visitor.OnVariableOrExpression(node); break;
				case 0x0035: visitor.OnVariableConditionalExpression(node); break;
				case 0x0036: visitor.OnVariableWithoutBlockExpression(node); break;
				case 0x0037: visitor.OnVariableExpression(node); break;
				case 0x0038: visitor.OnVariableWithBlockExpression(node); break;
				case 0x0039: visitor.OnVariableBlockExpression(node); break;
				case 0x003D: visitor.OnVariableSloppyListExpressionT0001(node); break;
				case 0x003C: visitor.OnVirtualFlist(node); break;
				case 0x003F: visitor.OnVirtualIselect(node); break;
				case 0x0042: visitor.OnVirtualTselect(node); break;
				case 0x0044: visitor.OnVirtualMselect(node); break;
				case 0x0045: visitor.OnVirtualNegOp(node); break;
				case 0x0047: visitor.OnVirtualPosOp(node); break;
				case 0x0049: visitor.OnVirtualNotOp(node); break;
				case 0x004B: visitor.OnVirtualMulOp(node); break;
				case 0x004D: visitor.OnVirtualDivOp(node); break;
				case 0x004F: visitor.OnVirtualRemOp(node); break;
				case 0x0051: visitor.OnVirtualModOp(node); break;
				case 0x0053: visitor.OnVirtualAddOp(node); break;
				case 0x0054: visitor.OnVirtualSubOp(node); break;
				case 0x0055: visitor.OnVirtualShlOp(node); break;
				case 0x0057: visitor.OnVirtualShrOp(node); break;
				case 0x0059: visitor.OnVirtualEqOp(node); break;
				case 0x005B: visitor.OnVirtualNeOp(node); break;
				case 0x005D: visitor.OnVirtualLtOp(node); break;
				case 0x005E: visitor.OnVirtualLtleOp(node); break;
				case 0x0060: visitor.OnVirtualLtltOp(node); break;
				case 0x0061: visitor.OnVirtualLeOp(node); break;
				case 0x0062: visitor.OnVirtualLeleOp(node); break;
				case 0x0063: visitor.OnVirtualLeltOp(node); break;
				case 0x0064: visitor.OnVirtualGtOp(node); break;
				case 0x0065: visitor.OnVirtualGtgeOp(node); break;
				case 0x0067: visitor.OnVirtualGtgtOp(node); break;
				case 0x0068: visitor.OnVirtualGeOp(node); break;
				case 0x0069: visitor.OnVirtualGegeOp(node); break;
				case 0x006A: visitor.OnVirtualGegtOp(node); break;
				case 0x006B: visitor.OnVirtualAndOp(node); break;
				case 0x006D: visitor.OnVirtualXorOp(node); break;
				case 0x006F: visitor.OnVirtualOrOp(node); break;
				case 0x0071: visitor.OnVirtualAndThenOp(node); break;
				case 0x0073: visitor.OnVirtualOrElseOp(node); break;
				case 0x0075: visitor.OnVirtualIff(node); break;
			}
		}
	}
}
