using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Xl.Common
{
    public class EnumHelper
    {
        public static string GetDescription(Enum en)
        {


            Type type = en.GetType();
            MemberInfo[] memInfo = type.GetMember(en.ToString());
            if (memInfo != null && memInfo.Length > 0)
            {
                object[] attrs = memInfo[0].GetCustomAttributes(typeof(System.ComponentModel.DescriptionAttribute), false);
                if (attrs != null && attrs.Length > 0)
                    return ((DescriptionAttribute)attrs[0]).Description;
            }
            return en.ToString();
        }
        public static string GetDescription(Type type, string enumKey)
        {

            MemberInfo[] memInfo = type.GetMember(enumKey);
            if (memInfo != null && memInfo.Length > 0)
            {
                object[] attrs = memInfo[0].GetCustomAttributes(typeof(System.ComponentModel.DescriptionAttribute), false);
                if (attrs != null && attrs.Length > 0)
                    return ((DescriptionAttribute)attrs[0]).Description;
            }
            return enumKey;
        }
        /// <summary>
        /// 列举所有枚举值和描述
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Dictionary<int, string> GetDescriptionDictionary<T>() where T : struct
        {
            Type type = typeof(T);
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            foreach (int item in System.Enum.GetValues(type))
            {
                string description = string.Empty;
                try
                {
                    FieldInfo fieldInfo = type.GetField(System.Enum.GetName(type, item));
                    if (fieldInfo == null)
                    {
                        continue;
                    }
                    DescriptionAttribute da = (DescriptionAttribute)Attribute.GetCustomAttribute(fieldInfo, typeof(DescriptionAttribute));
                    if (da == null)
                    {
                        continue;
                    }
                    description = da.Description;
                }
                catch { }
                dictionary.Add(item, description);
            }
            return dictionary;
        }

    }
}
