using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Xl.Common
{
    public enum SqlType
    {
        Sql = 1,
        Other = 2,
    }
    public class ReflectionHelper
    {
        public static object ChangeValue(PropertyInfo p, object value, SqlType sqlType = SqlType.Sql)
        {

            return ChangeValue(p.PropertyType, value, sqlType);

        }
        public static object ChangeValue(Type type, object value, SqlType sqlType = SqlType.Sql)
        {
            object realValue = null;

            if (type.BaseType.Equals(typeof(Enum)))
            {
                return value.ToString();
            }
            var typeCode = Type.GetTypeCode(type);

            switch (typeCode)
            {
                case TypeCode.Empty:

                    break;
                case TypeCode.Object:
                    realValue = Convert.ChangeType(value, TypeCode.String);
                    break;
                case TypeCode.DBNull:
                    break;
                case TypeCode.Boolean:
                    if (sqlType == SqlType.Sql)
                    {
                        bool tempValue = (bool)value;
                        return tempValue ? 1 : 0;
                    }
                    break;
                case TypeCode.Char:
                    break;
                case TypeCode.SByte:
                    break;
                case TypeCode.Byte:
                    break;
                case TypeCode.Int16:
                    realValue = Convert.ToInt16(value);
                    break;
                case TypeCode.UInt16:
                    realValue = Convert.ToInt16(value);
                    break;
                case TypeCode.Int32:
                    realValue = Convert.ToInt32(value);
                    break;
                case TypeCode.UInt32:
                    realValue = Convert.ToUInt32(value);
                    break;
                case TypeCode.Int64:
                    realValue = Convert.ToInt64(value);
                    break;
                case TypeCode.UInt64:
                    realValue = Convert.ToUInt64(value);
                    break;
                case TypeCode.Single:
                    realValue = Convert.ToSingle(value);
                    break;
                case TypeCode.Double:
                    realValue = Convert.ToDouble(value);
                    break;
                case TypeCode.Decimal:
                    realValue = Convert.ToDecimal(value);
                    break;
                case TypeCode.DateTime:
                    realValue = string.Concat("'", Convert.ToDateTime(value).ToString("yyyy-MM-hh:HH:ss:fff"), "'");
                    break;
                case TypeCode.String:
                    if (value.ToString().Contains(JoinType.InnerJoin)||value.ToString().Contains(JoinType.LeftJoin))
                    {
                        return value.ToString() + "\r\n";
                    }
                    realValue = string.Concat("'", Convert.ToString(value), "'");
                    break;
                default:
                    break;
            }

            return realValue;
        }
    }
}
