﻿using System;
using System.Linq.Expressions;

namespace QRest.Core.Expressions
{
    class NamedExpression : Expression
    {
        public static readonly ExpressionType NamedExpressionType = (ExpressionType)100;

        public NamedExpression(Expression expression, string name)
        {
            Expression = expression;
            Name = name;
        }

        public Expression Expression { get; }
        public string Name { get; }

        public override ExpressionType NodeType => NamedExpressionType;
        public override Type Type => Expression.Type;

        public override Expression Reduce() => Expression;
        public override bool CanReduce => true;
    }
}
