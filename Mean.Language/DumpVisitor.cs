using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Hime.Redist;

namespace Mean.Language
{
    internal class DumpVisitor : Generated.MeanVisitor
    {
        private int level = 0;

        private void Dump(ASTNode node)
        {
            Console.WriteLine($"{new string(' ', level * 4)} {node}");
        }

        public override void OnTerminalBoolLiteral(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnTerminalFloatLiteral(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnTerminalIdentifier(ASTNode node)
        {
            Dump(node);
            //Debug.Assert(false);
        }

        public override void OnTerminalIntegerLiteral(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnTerminalSeparator(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVariableAddExpression(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVariableAndExpression(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVariableBitAndExpression(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVariableBitOrExpression(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVariableBitXorExpression(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVariableBlockExpression(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVariableBoolLiteral(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVariableConditionalExpression(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVariableEqualityExpression(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVariableExpression(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVariableFloatLiteral(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVariableGenericArgs(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVariableGenericArgsBinding(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVariableGenericArgsBindings(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVariableGenericArgsTypes(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVariableIdentifier(ASTNode node)
        {
            //Debug.Assert(false);
        }

        public override void OnVariableIntegerLiteral(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVariableListGenericArgsBindingT0001(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVariableListNameT0001(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVariableLiteral(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVariableMulExpression(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVariableName(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVariableNumberLiteral(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVariableOrExpression(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVariableUnit(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVariableUnitItem(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVariablePostfixExpression(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVariablePrimaryExpression(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVariableNamespace(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVariableNamespaceItem(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVariableShiftExpression(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVariableSloppyListExpressionT0001(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVariableTupleIndex(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVariableType(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVariableUnaryExpression(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVariableWithBlockExpression(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVariableWithoutBlockExpression(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVirtualAddOp(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVirtualAndOp(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVirtualAndThenOp(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVirtualDivOp(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVirtualEqOp(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVirtualFlist(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVirtualGegeOp(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVirtualGegtOp(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVirtualGeOp(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVirtualGtgeOp(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVirtualGtgtOp(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVirtualGtOp(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVirtualIff(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVirtualIselect(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVirtualLeleOp(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVirtualLeltOp(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVirtualLeOp(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVirtualLtleOp(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVirtualLtltOp(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVirtualLtOp(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVirtualModOp(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVirtualMselect(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVirtualMulOp(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVirtualNegOp(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVirtualNeOp(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVirtualNotOp(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVirtualOrElseOp(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVirtualOrOp(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVirtualPosOp(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVirtualRemOp(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVirtualShlOp(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVirtualShrOp(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVirtualSubOp(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVirtualTselect(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVirtualXorOp(ASTNode node)
        {
            Debug.Assert(false);
        }

        public override void OnVariableFunction(ASTNode node)
        {
            base.OnVariableFunction(node);
        }
    }
}
