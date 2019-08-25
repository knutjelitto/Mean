using Hime.Redist;

namespace Mean.Language.Generated
{
	internal class MeanVisitor
	{
		public void Visit(ParseResult result)
		{
			VisitASTNode(result.Root);
		}

		protected virtual void VisitASTNode(ASTNode node)
		{
			switch(node.Symbol.ID)
			{
				case 0x0007: OnTerminalSeparator(node); break;
				case 0x0014: OnTerminalIdentifier(node); break;
				case 0x0015: OnTerminalIntegerLiteral(node); break;
				case 0x0016: OnTerminalFloatLiteral(node); break;
				case 0x0017: OnTerminalBoolLiteral(node); break;
				case 0x005A: OnVariableIdentifier(node); break;
				case 0x005B: OnVariableIntegerLiteral(node); break;
				case 0x005C: OnVariableTupleIndex(node); break;
				case 0x005D: OnVariableFloatLiteral(node); break;
				case 0x005E: OnVariableNumberLiteral(node); break;
				case 0x005F: OnVariableBoolLiteral(node); break;
				case 0x0060: OnVariableLiteral(node); break;
				case 0x0061: OnVariableType(node); break;
				case 0x0062: OnVariableName(node); break;
				case 0x0063: OnVariableGenericArgs(node); break;
				case 0x0064: OnVariableGenericArgsTypes(node); break;
				case 0x0065: OnVariableGenericArgsBindings(node); break;
				case 0x0066: OnVariableGenericArgsBinding(node); break;
				case 0x0067: OnVariableListNameT0001(node); break;
				case 0x0069: OnVariableListGenericArgsBindingT0001(node); break;
				case 0x006B: OnVariablePrimaryExpression(node); break;
				case 0x006C: OnVariablePostfixExpression(node); break;
				case 0x006D: OnVariableUnaryExpression(node); break;
				case 0x006E: OnVariableMulExpression(node); break;
				case 0x006F: OnVariableAddExpression(node); break;
				case 0x0070: OnVariableShiftExpression(node); break;
				case 0x0071: OnVariableEqualityExpression(node); break;
				case 0x0072: OnVariableBitAndExpression(node); break;
				case 0x0073: OnVariableBitXorExpression(node); break;
				case 0x0074: OnVariableBitOrExpression(node); break;
				case 0x0075: OnVariableAndExpression(node); break;
				case 0x0076: OnVariableOrExpression(node); break;
				case 0x0077: OnVariableConditionalExpression(node); break;
				case 0x0078: OnVariableWithoutBlockExpression(node); break;
				case 0x0079: OnVariableExpression(node); break;
				case 0x007A: OnVariableWithBlockExpression(node); break;
				case 0x007B: OnVariableBlockExpression(node); break;
				case 0x007C: OnVariableSloppyListExpressionT0001(node); break;
				case 0x007E: OnVariableUnit(node); break;
				case 0x007F: OnVariableUnitItem(node); break;
				case 0x0080: OnVariableNamespace(node); break;
				case 0x0081: OnVariableNamespaceItem(node); break;
				case 0x0082: OnVariableFunction(node); break;
				case 0x0037: OnVirtualFlist(node); break;
				case 0x0038: OnVirtualIselect(node); break;
				case 0x0039: OnVirtualTselect(node); break;
				case 0x003A: OnVirtualMselect(node); break;
				case 0x003B: OnVirtualNegOp(node); break;
				case 0x003C: OnVirtualPosOp(node); break;
				case 0x003D: OnVirtualNotOp(node); break;
				case 0x003E: OnVirtualMulOp(node); break;
				case 0x003F: OnVirtualDivOp(node); break;
				case 0x0040: OnVirtualRemOp(node); break;
				case 0x0041: OnVirtualModOp(node); break;
				case 0x0042: OnVirtualAddOp(node); break;
				case 0x0043: OnVirtualSubOp(node); break;
				case 0x0044: OnVirtualShlOp(node); break;
				case 0x0045: OnVirtualShrOp(node); break;
				case 0x0046: OnVirtualEqOp(node); break;
				case 0x0047: OnVirtualNeOp(node); break;
				case 0x0048: OnVirtualLtOp(node); break;
				case 0x0049: OnVirtualLtleOp(node); break;
				case 0x004A: OnVirtualLtltOp(node); break;
				case 0x004B: OnVirtualLeOp(node); break;
				case 0x004C: OnVirtualLeleOp(node); break;
				case 0x004D: OnVirtualLeltOp(node); break;
				case 0x004E: OnVirtualGtOp(node); break;
				case 0x004F: OnVirtualGtgeOp(node); break;
				case 0x0050: OnVirtualGtgtOp(node); break;
				case 0x0051: OnVirtualGeOp(node); break;
				case 0x0052: OnVirtualGegeOp(node); break;
				case 0x0053: OnVirtualGegtOp(node); break;
				case 0x0054: OnVirtualAndOp(node); break;
				case 0x0055: OnVirtualXorOp(node); break;
				case 0x0056: OnVirtualOrOp(node); break;
				case 0x0057: OnVirtualAndThenOp(node); break;
				case 0x0058: OnVirtualOrElseOp(node); break;
				case 0x0059: OnVirtualIff(node); break;
			}
		}

		protected virtual void VisitASTChildren(ASTNode node)
		{
			for (var i = 0; i < node.Children.Count; i++)
			{
				VisitASTNode(node.Children[i]);
			}
		}

		public virtual void OnTerminalSeparator(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnTerminalIdentifier(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnTerminalIntegerLiteral(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnTerminalFloatLiteral(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnTerminalBoolLiteral(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnVariableIdentifier(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnVariableIntegerLiteral(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnVariableTupleIndex(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnVariableFloatLiteral(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnVariableNumberLiteral(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnVariableBoolLiteral(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnVariableLiteral(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnVariableType(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnVariableName(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnVariableGenericArgs(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnVariableGenericArgsTypes(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnVariableGenericArgsBindings(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnVariableGenericArgsBinding(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnVariableListNameT0001(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnVariableListGenericArgsBindingT0001(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnVariablePrimaryExpression(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnVariablePostfixExpression(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnVariableUnaryExpression(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnVariableMulExpression(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnVariableAddExpression(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnVariableShiftExpression(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnVariableEqualityExpression(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnVariableBitAndExpression(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnVariableBitXorExpression(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnVariableBitOrExpression(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnVariableAndExpression(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnVariableOrExpression(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnVariableConditionalExpression(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnVariableWithoutBlockExpression(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnVariableExpression(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnVariableWithBlockExpression(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnVariableBlockExpression(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnVariableSloppyListExpressionT0001(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnVariableUnit(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnVariableUnitItem(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnVariableNamespace(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnVariableNamespaceItem(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnVariableFunction(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnVirtualFlist(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnVirtualIselect(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnVirtualTselect(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnVirtualMselect(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnVirtualNegOp(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnVirtualPosOp(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnVirtualNotOp(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnVirtualMulOp(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnVirtualDivOp(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnVirtualRemOp(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnVirtualModOp(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnVirtualAddOp(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnVirtualSubOp(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnVirtualShlOp(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnVirtualShrOp(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnVirtualEqOp(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnVirtualNeOp(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnVirtualLtOp(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnVirtualLtleOp(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnVirtualLtltOp(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnVirtualLeOp(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnVirtualLeleOp(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnVirtualLeltOp(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnVirtualGtOp(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnVirtualGtgeOp(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnVirtualGtgtOp(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnVirtualGeOp(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnVirtualGegeOp(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnVirtualGegtOp(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnVirtualAndOp(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnVirtualXorOp(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnVirtualOrOp(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnVirtualAndThenOp(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnVirtualOrElseOp(ASTNode node)
		{
			VisitASTChildren(node);
		}
		public virtual void OnVirtualIff(ASTNode node)
		{
			VisitASTChildren(node);
		}
	}
}
