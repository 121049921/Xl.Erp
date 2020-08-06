using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Xl.Common
{
    public class SqlBuilderExpression
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="exp">表达式</param>
        /// <param name=" isAppendTalbeName">是否添加表名</param>
        /// <returns></returns>
        public static string ResolveExpression(Expression exp, bool isAppendTalbeName = false)
        {
            Expression expression = exp;

            if (exp is LambdaExpression)
            {
                LambdaExpression lambdaExpression = exp as LambdaExpression;
                return ResolveExpression(lambdaExpression.Body,  isAppendTalbeName);
            }
            string expressionName = expression.GetType().Name;



            if (expression is ConditionalExpression)
            {

            }
            if (expression is MemberExpression)
            {
                MemberExpression memberExpression = expression as MemberExpression;
                var tempExp = memberExpression.Expression;
                if (tempExp != null)
                {
                    if (tempExp is BinaryExpression)
                    {

                    }
                    if (tempExp is MemberInitExpression)
                    {

                    }
                    if (tempExp is UnaryExpression)
                    {

                    }
                    if (tempExp is LambdaExpression)
                    {

                    }
                    if (tempExp is ConstantExpression)
                    {

                        UnaryExpression unaryExpression = Expression.Convert(memberExpression, memberExpression.Type);
                        var value = Expression.Lambda(unaryExpression).Compile().DynamicInvoke();

                        value = ReflectionHelper.ChangeValue(memberExpression.Type, value, SqlType.Sql);
                        return value.ToString();


                    }
                    if (tempExp is NewExpression)
                    {

                    }
                    //if (tempExp is ParameterExpression)
                    //{
                    //    ParameterExpression parameterExpression = tempExp as ParameterExpression;
                    //    return parameterExpression.Name;


                    //}
                    if (tempExp is ListInitExpression)
                    {

                    }
                    if (tempExp is DefaultExpression)
                    {

                    }
                    if (tempExp is DynamicExpression)
                    {

                    }
                    if (tempExp is MemberExpression)
                    {
                        UnaryExpression unaryExpression = Expression.Convert(memberExpression, memberExpression.Type);
                        var value = Expression.Lambda(unaryExpression).Compile().DynamicInvoke();
                        value = ReflectionHelper.ChangeValue(memberExpression.Type, value, SqlType.Sql);
                        return value.ToString();

                    }
                    if (tempExp is MethodCallExpression)
                    {

                    }
                    else
                    {
                        if ( isAppendTalbeName)
                        {
                         return $"{ memberExpression.Expression.Type.Name}.{ memberExpression.Member.Name}";//解析on的时候要加表名

                        }
                        else
                        {
                            return memberExpression.Member.Name;
                        }
                    }

                }
                else
                {
                    if (Type.GetTypeCode(memberExpression.Type) == TypeCode.DateTime)
                    {

                        if (memberExpression.Member.ReflectedType.Equals(typeof(DateTime)))
                        {
                            Type type = memberExpression.Member.ReflectedType;
                            PropertyInfo propertyInfo = type.GetProperty(memberExpression.Member.Name, BindingFlags.Static | BindingFlags.Public);
                            object value;
                            if (propertyInfo != null)
                            {
                                value = propertyInfo.GetValue(null);
                                return ReflectionHelper.ChangeValue(propertyInfo.PropertyType, value, SqlType.Sql).ToString();
                            }
                            else
                            {
                                FieldInfo field = type.GetField(memberExpression.Member.Name, BindingFlags.Static | BindingFlags.Public);
                                value = field.GetValue(null);
                                return ReflectionHelper.ChangeValue(field.FieldType, value, SqlType.Sql).ToString();
                            }

                        }

                    }
                }

                return memberExpression.Member.Name;//直接取字段名称

            }
            if (expression is BinaryExpression)//二元
            {
                BinaryExpression binaryExpression = expression as BinaryExpression;
                Expression leftExpression = binaryExpression.Left;
                Expression rigthExpression = binaryExpression.Right;
                string left = ResolveExpression(leftExpression,  isAppendTalbeName);
                string rigth = ResolveExpression(rigthExpression,  isAppendTalbeName);
                string nodeTpe = GetNodeType(binaryExpression.NodeType);
                return $"{left} {nodeTpe} {rigth}";
            }
            if (expression is LabelExpression)
            {

            }
            if (expression is ParameterExpression)
            {

                ParameterExpression parameterExpression = expression as ParameterExpression;
                return parameterExpression.Name;


            }
            if (expression is MethodCallExpression)
            {
                MethodCallExpression methodCallExpression = expression as MethodCallExpression;
                var leftExp = methodCallExpression.Object;
                string left = ResolveExpression(leftExp);
                var arguent = methodCallExpression.Arguments.FirstOrDefault();
                string methodName = methodCallExpression.Method.Name;
                switch (methodName)
                {
                    case "Contains":
                        return $"CHARINDEX ('{arguent}','{left}')";

                }
                throw new Exception($"暂不支持这种写法{methodName}");
            }
            if (expression is MemberInitExpression)
            {

            }
            if (expression is ConstantExpression)
            {
                ConstantExpression constantExpression = expression as ConstantExpression;
                var objValue = ReflectionHelper.ChangeValue(constantExpression.Type, constantExpression.Value, SqlType.Sql);
                return objValue.ToString();

            }
            if (expression is UnaryExpression)
            {
                UnaryExpression unaryExpression = expression as UnaryExpression;
                if (unaryExpression.Operand != null)
                {
                    return ResolveExpression((unaryExpression.Operand as Expression),  isAppendTalbeName);
                }
                else
                {
                    var value = Expression.Lambda(expression).Compile().DynamicInvoke();
                    var objValue = ReflectionHelper.ChangeValue(expression.Type, value, SqlType.Sql);
                    return objValue.ToString();
                }
            }
            if (expression is NewArrayExpression)//解析数组
            {
                StringBuilder sqlOn = new StringBuilder();
                NewArrayExpression newArrayExpression = expression as NewArrayExpression;
                ReadOnlyCollection<Expression> expressions = newArrayExpression.Expressions;
                foreach (var itemExpression in expressions)
                {
                    var temp = ResolveExpression(itemExpression,  isAppendTalbeName);
                    sqlOn.AppendLine(temp);
                }
                return sqlOn.ToString();

            }
            return string.Empty;
        }
       

        private static string GetNodeType(ExpressionType expressionType)
        {
            switch (expressionType)
            {
                case ExpressionType.Add:
                    break;
                case ExpressionType.AddChecked:
                    break;
                case ExpressionType.And:
                    return " & ";
                case ExpressionType.AndAlso:
                    return " And ";
                case ExpressionType.ArrayLength:
                    break;
                case ExpressionType.ArrayIndex:
                    break;
                case ExpressionType.Call:
                    break;
                case ExpressionType.Coalesce:
                    break;
                case ExpressionType.Conditional:
                    break;
                case ExpressionType.Constant:
                    break;
                case ExpressionType.Convert:
                    break;
                case ExpressionType.ConvertChecked:
                    break;
                case ExpressionType.Divide:
                    break;
                case ExpressionType.Equal:
                    return " = ";
                case ExpressionType.ExclusiveOr:
                    break;
                case ExpressionType.GreaterThan:
                    break;
                case ExpressionType.GreaterThanOrEqual:
                    break;
                case ExpressionType.Invoke:
                    break;
                case ExpressionType.Lambda:
                    break;
                case ExpressionType.LeftShift:
                    break;
                case ExpressionType.LessThan:
                    break;
                case ExpressionType.LessThanOrEqual:
                    break;
                case ExpressionType.ListInit:
                    break;
                case ExpressionType.MemberAccess:
                    break;
                case ExpressionType.MemberInit:
                    break;
                case ExpressionType.Modulo:
                    break;
                case ExpressionType.Multiply:
                    break;
                case ExpressionType.MultiplyChecked:
                    break;
                case ExpressionType.Negate:
                    break;
                case ExpressionType.UnaryPlus:
                    break;
                case ExpressionType.NegateChecked:
                    break;
                case ExpressionType.New:
                    break;
                case ExpressionType.NewArrayInit:
                    break;
                case ExpressionType.NewArrayBounds:
                    break;
                case ExpressionType.Not:
                    break;
                case ExpressionType.NotEqual:
                    break;
                case ExpressionType.Or:
                    break;
                case ExpressionType.OrElse:

                    return " Or ";
                case ExpressionType.Parameter:
                    break;
                case ExpressionType.Power:
                    break;
                case ExpressionType.Quote:
                    break;
                case ExpressionType.RightShift:
                    break;
                case ExpressionType.Subtract:
                    break;
                case ExpressionType.SubtractChecked:
                    break;
                case ExpressionType.TypeAs:
                    break;
                case ExpressionType.TypeIs:
                    break;
                case ExpressionType.Assign:
                    break;
                case ExpressionType.Block:
                    break;
                case ExpressionType.DebugInfo:
                    break;
                case ExpressionType.Decrement:
                    break;
                case ExpressionType.Dynamic:
                    break;
                case ExpressionType.Default:
                    break;
                case ExpressionType.Extension:
                    break;
                case ExpressionType.Goto:
                    break;
                case ExpressionType.Increment:
                    break;
                case ExpressionType.Index:
                    break;
                case ExpressionType.Label:
                    break;
                case ExpressionType.RuntimeVariables:
                    break;
                case ExpressionType.Loop:
                    break;
                case ExpressionType.Switch:
                    break;
                case ExpressionType.Throw:
                    break;
                case ExpressionType.Try:
                    break;
                case ExpressionType.Unbox:
                    break;
                case ExpressionType.AddAssign:
                    break;
                case ExpressionType.AndAssign:
                    break;
                case ExpressionType.DivideAssign:
                    break;
                case ExpressionType.ExclusiveOrAssign:
                    break;
                case ExpressionType.LeftShiftAssign:
                    break;
                case ExpressionType.ModuloAssign:
                    break;
                case ExpressionType.MultiplyAssign:
                    break;
                case ExpressionType.OrAssign:
                    break;
                case ExpressionType.PowerAssign:
                    break;
                case ExpressionType.RightShiftAssign:
                    break;
                case ExpressionType.SubtractAssign:
                    break;
                case ExpressionType.AddAssignChecked:
                    break;
                case ExpressionType.MultiplyAssignChecked:
                    break;
                case ExpressionType.SubtractAssignChecked:
                    break;
                case ExpressionType.PreIncrementAssign:
                    break;
                case ExpressionType.PreDecrementAssign:
                    break;
                case ExpressionType.PostIncrementAssign:
                    break;
                case ExpressionType.PostDecrementAssign:
                    break;
                case ExpressionType.TypeEqual:
                    break;
                case ExpressionType.OnesComplement:
                    break;
                case ExpressionType.IsTrue:
                    break;
                case ExpressionType.IsFalse:
                    break;
                default:
                    break;
            }
            return string.Empty;
        }
    }

}
