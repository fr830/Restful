﻿using System;
using System.Linq.Expressions;
using Remotion.Linq.Parsing.ExpressionTreeVisitors;
using Restful.Data.Oracle.CommandBuilders;
using Restful.Data.Oracle.Visitors;
using System.Collections.Generic;
using Restful.Linq;

namespace Restful.Data.Oracle.Linq
{
    public class OracleInsertable<T> : IInsertable<T>
    {
        private readonly Type elementType;
        private readonly IDictionary<MemberExpression, object> properties;
        private readonly IInsertProvider provider;

        public OracleInsertable( IInsertProvider provider )
        {
            this.provider = provider;
            this.elementType = typeof( T );
            this.properties = new Dictionary<MemberExpression, object>();
        }

        public OracleInsertable( IInsertProvider provider, Type elementType )
        {
            this.provider = provider;
            this.elementType = elementType;
            this.properties = new Dictionary<MemberExpression, object>();
        }

        #region IInsertable implementation

        public Type ElementType
        {
            get
            {
                return this.elementType;
            }
        }

        public IDictionary<MemberExpression, object> Properties
        {
            get
            {
                return this.properties;
            }
        }


        public IInsertProvider Provider
        {
            get
            {
                return this.provider;
            }
        }

        #endregion
    }
}
