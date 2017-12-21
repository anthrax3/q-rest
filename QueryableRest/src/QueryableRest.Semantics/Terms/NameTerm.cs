﻿using System.Linq.Expressions;

namespace QRest.Core.Terms
{
    public class NameTerm : ITerm
    {
        public ITerm Next { get; set; }
        public string Name { get; set; }        

        public Expression CreateExpression(Expression prev, ParameterExpression root, QueryContext context)
        {
            context.NamedExpressions.Add(Name, prev);
            return prev;
        }
    }
}