using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Xl.Model;

namespace Xl.Common
{


    public class JoinType
    {
        public const string InnerJoin = " Inner Join";
        public const string LeftJoin = "  Left  Join ";

    }

    public class Sql
    {
        internal Sql()
        {
            ColumnNames = new List<string>();
            TableNames = new List<string>();
        }
        public List<string> TableNames { get; set; }
        public List<string> ColumnNames { get; set; }
        public string Where { get; set; }
        public string Commandtext { get; set; }
    }
    public class SqlBuilder
    {

        public static Sql Insert<TModel>(TModel model) where TModel : class, new()
        {
            Sql sql = new Sql();
            string tableName = model.GetType().Name;
            PropertyInfo[] ps = model.GetType().GetProperties();
            List<string> colunms = new List<string>();
            List<object> values = new List<object>();
            foreach (var p in ps)
            {
                //跳过主健
                if (p.PropertyType.Name.Equals("Id", StringComparison.OrdinalIgnoreCase))
                {
                    continue;
                }
                if (p.PropertyType.IsArray)
                {
                    continue;
                }
                if (p.PropertyType.IsGenericType)
                {
                    continue;
                }
                if (p.PropertyType.IsGenericTypeDefinition)
                {
                    var colunmName = p.PropertyType.GetGenericArguments().FirstOrDefault().Name;
                    colunms.Add("[" + colunmName + "]");
                    var objValue = ReflectionHelper.ChangeValue(p, p.GetValue(model));
                    values.Add(objValue);
                }
                else
                {
                    var colunmName = p.Name;
                    colunms.Add("[" + colunmName + "]");
                    var objValue = ReflectionHelper.ChangeValue(p, p.GetValue(model));
                    values.Add(objValue);
                }
            }

            if (colunms.Any() && values.Any())
            {
                var tempColunms = string.Join(",", colunms);
                var tempValues = string.Join(",", colunms);
                string text = $"INSERT  INTO  [{tableName}] {tempColunms} values({tempValues}";
                sql.ColumnNames = colunms;
                sql.Commandtext = text;
                sql.TableNames = new List<string>() { tableName };
                sql.Where = string.Empty;
                return sql;
            }
            return new Sql();
        }

        public static Sql Update<TModel>(TModel model, Expression<Func<TModel, bool>> exp) where TModel : class, new()
        {
            Sql sql = new Sql();
            string tableName = model.GetType().Name;
            var ps = model.GetType().GetProperties();
            StringBuilder text = new StringBuilder();
            text.Append($"UPDATE {tableName} SET ");


            foreach (var p in ps)
            {
                //跳过主健
                if (p.PropertyType.Name.Equals("Id", StringComparison.OrdinalIgnoreCase))
                {
                    continue;
                }
                if (p.PropertyType.IsArray)
                {
                    continue;
                }
                if (p.PropertyType.IsGenericType)
                {
                    continue;
                }
                if (p.PropertyType.IsGenericTypeDefinition)
                {

                    var objValue = ReflectionHelper.ChangeValue(p, p.GetValue(model));
                    var colunmName = p.PropertyType.GetGenericArguments().FirstOrDefault().Name;
                    sql.ColumnNames.Add(colunmName);
                    text.Append($"[{colunmName}] = {objValue}");
                }
                else
                {

                    var objValue = ReflectionHelper.ChangeValue(p, p.GetValue(model));
                    var colunmName = p.Name;
                    text.Append($"[{colunmName}] = {objValue}");
                }
            }
            if (exp != null)
            {
                text.Append("WHERE ");
                string whereStr = SqlBuilderExpression.ResolveExpression(exp);
                if (string.IsNullOrEmpty(whereStr))
                {
                    throw new ArgumentNullException($"解析{nameof(exp)} 出错");
                }

                text.Append(whereStr);
                sql.Where = whereStr;
                sql.TableNames = new List<string>() { tableName };
                sql.Commandtext = text.ToString();
            }
            return sql;
        }

        public static Sql Delete<TModel>(Expression<Func<TModel, bool>> exp) where TModel : class, new()
        {
            Sql sql = new Sql();
            string tableName = typeof(TModel).Name;

            StringBuilder text = new StringBuilder();
            text.Append($"DELETE {tableName}");
            if (exp != null)
            {
                text.Append("WHERE ");
                string whereStr = SqlBuilderExpression.ResolveExpression(exp);
                if (string.IsNullOrEmpty(whereStr))
                {
                    throw new ArgumentNullException($"解析{nameof(exp)} 出错");
                }

                text.Append(whereStr);
                sql.Where = whereStr;
                sql.TableNames = new List<string>() { tableName };
                sql.Commandtext = text.ToString();
            }
            return sql;
        }





        public static Sql GetMax<TModel, TColunmType>(Expression<Func<TModel, TColunmType>> exp) where TModel : class, new()
        {
            Sql sql = new Sql();
            string tableName = typeof(TModel).Name;

            if (exp == null)
            {
                throw new ArgumentNullException(nameof(exp));
            }
            string maxColumnName = SqlBuilderExpression.ResolveExpression(exp);
            StringBuilder text = new StringBuilder();
            text.AppendLine($"SELECT MAX({maxColumnName})  FROM [{tableName}]  ");
            sql.Commandtext = text.ToString();
            return sql;

        }

        public static Sql GetMin<TModel, TColunmType>(Expression<Func<TModel, TColunmType>> exp) where TModel : class, new()
        {
            Sql sql = new Sql();
            string tableName = typeof(TModel).Name;
            if (exp == null)
            {
                throw new ArgumentNullException(nameof(exp));
            }
            string maxColumnName = SqlBuilderExpression.ResolveExpression(exp);
            StringBuilder text = new StringBuilder();
            text.AppendLine($"SELECT Min({maxColumnName}) FROM [{tableName}] ");
            sql.Commandtext = text.ToString();
            return sql;
        }

        public static Sql GetFirst<TModel>(QueryExpression<TModel> query) where TModel : class, new()
        {
            Sql sql = new Sql();
            var selectSql = Find<TModel>(1);
            StringBuilder text = new StringBuilder();
            text.AppendLine(selectSql);
            text.AppendLine(query.StringWhere.ToString());
            sql.Where = query.StringWhere.ToString();
            sql.Commandtext = text.ToString();
            return sql;
        }
        public static Sql GetFirst<TModel>(Expression<Func<TModel, bool>> exp) where TModel : class, new()
        {
            Sql sql = new Sql();
            var selectSql = Find<TModel>(1);
            StringBuilder text = new StringBuilder();
            text.AppendLine(selectSql);
            if (exp == null)
            {
                throw new ArgumentNullException($"{nameof(exp)} ");
            }
            StringBuilder where = new StringBuilder();
            where.AppendLine("WHERE 1= 1");
            where.AppendLine(SqlBuilderExpression.ResolveExpression(exp));
            if (string.IsNullOrEmpty(where.ToString()))
            {
                throw new ArgumentNullException($"解析{nameof(exp)} 出错");

            }
            text.AppendLine(where.ToString());
            sql.Commandtext = text.ToString();
            sql.Where = where.ToString();
            return sql;
        }
        /// <summary>
        /// 一表,视图
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <param name="exp"></param>
        /// <returns></returns>
        public static Sql GetList<TModel>(Expression<Func<TModel, bool>> exp) where TModel : class, new()
        {
            Sql sql = new Sql();
            var selectSql = Find<TModel>(1);
            StringBuilder text = new StringBuilder();
            text.AppendLine(selectSql);
            if (exp == null)
            {
                throw new ArgumentNullException($"{nameof(exp)} ");
            }
            StringBuilder where = new StringBuilder();
            where.AppendLine("WHERE 1= 1");
            where.AppendLine(SqlBuilderExpression.ResolveExpression(exp));
            if (string.IsNullOrEmpty(where.ToString()))
            {
                throw new ArgumentNullException($"解析{nameof(exp)} 出错");

            }
            text.AppendLine(where.ToString());
            sql.Commandtext = text.ToString();
            sql.Where = where.ToString();
            return sql;
        }



        /// <summary>
        /// 一表,视图
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <param name="exp"></param>
        /// <returns></returns>
        public static Sql GetList<TModel>(QueryExpression<TModel> query) where TModel : class, new()
        {
            Sql sql = new Sql();
            var selectSql = Find<TModel>(1);
            StringBuilder text = new StringBuilder();
            text.AppendLine(selectSql);
            if (query == null)
            {
                throw new ArgumentNullException($"{nameof(query)} ");
            }
            text.AppendLine(query.StringWhere.ToString());
            sql.Commandtext = text.ToString();
            sql.Where = query.StringWhere.ToString();
            return sql;
        }
        /// <summary>
        /// 二表查询
        /// </summary>
        /// <typeparam name="TModel1"></typeparam>
        /// <typeparam name="TModel2"></typeparam>
        /// <param name="exp"></param>
        /// <param name="query"></param>
        /// <returns></returns>
        public static Sql GetList<TModel1, TModel2,QueryParams>(Expression<Func<TModel1, TModel2, object[]>> exp, QueryExpression<QueryParams> query)
        {
            return Find(exp);

        }
        /// <summary>
        /// 三表查询
        /// </summary>
        /// <typeparam name="TModel1"></typeparam>
        /// <typeparam name="TModel2"></typeparam>
        /// <typeparam name="TModel3"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="exp"></param>
        /// <returns></returns>
        public static Sql GetList<TModel1, TModel2, TModel3, QueryParams>(Expression<Func<TModel1, TModel2, TModel3, object[]>> exp, QueryExpression<QueryParams> query)
        {
            return Find(exp);

        }


        //单表,视图
        private static string Find<TModel>(int pageSize = 1) where TModel : class, new()
        {

            string tableName = typeof(TModel).Name;
            var ps = typeof(TModel).GetProperties();
            StringBuilder sql = new StringBuilder();
            List<string> colunms = new List<string>();
            foreach (var p in ps)
            {

                if (p.PropertyType.IsArray)
                {
                    continue;
                }
                if (p.PropertyType.IsGenericType)
                {
                    continue;
                }
                if (p.PropertyType.IsGenericTypeDefinition)
                {
                    var colunmName = p.PropertyType.GetGenericArguments().FirstOrDefault().Name;
                    colunms.Add("[" + colunmName + "]");

                }
                else
                {
                    var colunmName = p.Name;
                    colunms.Add("[" + colunmName + "]");

                }
            }
            if (colunms.Any())
            {
                string tempColumns = string.Join(",", colunms);
                sql.AppendLine($"SELECT ");
                if (pageSize == 1)
                {
                    sql.AppendLine($"TOP  {pageSize} ");
                }
                else
                {
                    sql.AppendLine($"TOP  {int.MaxValue} ");
                }
                sql.AppendLine($" {tempColumns}  FROM [{tableName}] ");
            }


            return sql.ToString();
        }
        //多表
        private static Sql Find(Expression exp)
        {
            Sql sql = new Sql();
            StringBuilder text = new StringBuilder();
            text.AppendLine("SELECT ");
            if (exp == null)
            {
                throw new Exception(nameof(exp));
            }
            List<string> tableNames = new List<string>();
            if (exp is LambdaExpression)
            {
                LambdaExpression lambdaExpression = exp as LambdaExpression;

                List<ParameterExpression> parameterExpressions = lambdaExpression.Parameters.ToList();
                if (parameterExpressions == null)
                {
                    throw new Exception(nameof(parameterExpressions));
                }
                var index = 0;
                foreach (var parameterExpression in parameterExpressions)
                {
                    if (index == parameterExpressions.Count - 1)
                    {
                        text.AppendLine($"{parameterExpression.Type.Name}.* ");
                    }
                    else
                    {
                        text.AppendLine($"{parameterExpression.Type.Name}.*, ");
                    }
                    index++;
                    sql.ColumnNames.Add($"{parameterExpression.Type.Name}.*, ");
                }
                text.AppendLine($"FROM   [{parameterExpressions.FirstOrDefault().Type.Name }] AS   {parameterExpressions.FirstOrDefault().Type.Name }");
                sql.TableNames.Add(parameterExpressions.FirstOrDefault().Type.Name);
                //条件
                string on = SqlBuilderExpression.ResolveExpression(exp, isAppendTalbeName: true);
                List<string> onSplits = on.Split(new string[] { "\r\n" }, StringSplitOptions.None)?.ToList();
                var talbleNameIndex = 1;
                for (int i = 0; i < onSplits.Count; i++)
                {
                    if (onSplits[i].Equals(JoinType.InnerJoin) || onSplits[i].Equals(JoinType.LeftJoin))
                    {
                        onSplits[i] = $"{onSplits[i]}  {parameterExpressions[talbleNameIndex].Type.Name} On";
                        sql.TableNames.Add(parameterExpressions[talbleNameIndex].Type.Name);
                        talbleNameIndex++;
                    }
                }
                text.AppendLine(string.Join(" ", onSplits));
                sql.Commandtext = text.ToString();
                return sql;

            }
            else
            {
                throw new Exception("不是 LambdaExpression表达式,无法解析");
            }
        }
    }


    public static class SqlExtension
    {
        public static Sql Where<TModel>(this Sql sql, QueryExpression<TModel> query)
        {
            StringBuilder tempSql = new StringBuilder();
            tempSql.AppendLine(sql.Commandtext);
            if (query == null)
            {
                throw new ArgumentNullException($"{nameof(query)} ");
            }
            sql.Where = query.StringWhere.ToString();
            sql.Commandtext = tempSql.AppendLine(query.StringWhere.ToString()).ToString();
            return sql;

        }
        public static Sql Select<TSource, TResult>(this Sql sql, object columns)
        {
            if (columns!=null)
            {
               // columns.
            }
            sql.ColumnNames = new List<string>();
            return sql;
              
        }
    }
}
