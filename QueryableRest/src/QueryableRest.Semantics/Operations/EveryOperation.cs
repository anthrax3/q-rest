﻿using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace QRest.Core.Operations
{
    public class EveryOperation : IOperation
    {
        public Expression CreateExpression(Expression last, ParameterExpression root, IReadOnlyList<Expression> arguments, QueryContext context)
        {
            if (arguments.Count < 1)
                throw new ExpressionCreationException();

            var body = arguments.Aggregate((e1, e2) => { return Expression.AndAlso(e1, e2); });

            return body;
        }

        public Expression GetArgumentsRoot(Expression context)
        {
            return context;
        }
    }
}