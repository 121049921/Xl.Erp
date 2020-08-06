using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Xl.Common
{


    public class QueryExpression<TModel> : Sinleton<QueryExpression<TModel>>
    {
        public static string @where = " Where 1 = 1";
        internal StringBuilder StringWhere { get; set; } = null;
        public QueryExpression<TModel> True()
        {
            if (StringWhere == null)
            {
                StringWhere = new StringBuilder();
            }
            else
            {
                StringWhere.Clear();
            }
            StringWhere.AppendLine(@where);
            return this;
        }
        public QueryExpression<TModel> Add(Expression<Func<TModel, bool>> exp)
        {
            if (StringWhere.ToString().Substring(0, @where.Length) != where)
            {
                throw new Exception($"调用Add之前先调用 {nameof(True)} 方法 ");
            }
            StringWhere.AppendLine($" And  {SqlBuilderExpression.ResolveExpression(exp, isAppendTalbeName: true)}");
            return this;

        }
        public QueryExpression<TModel> Or(Expression<Func<TModel, bool>> exp)
        {
            if (StringWhere.ToString().Substring(0, @where.Length) != where)
            {
                throw new Exception($"调用Add之前先调用 {nameof(True)} 方法 ");
            }
            StringWhere.AppendLine($" Or  {SqlBuilderExpression.ResolveExpression(exp, isAppendTalbeName: true)}");
            return this;

        }


        public QueryExpression<TModel> Append(QueryExpression<TModel> rigth)
        {

            StringWhere.AppendLine(@where);
            return this;

        }

    }

}
