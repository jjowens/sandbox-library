using SandboxLibrary.enums.original;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandboxLibrary.enums.batch1.components
{
    public static class JsonEnumExtensions
    {
        public static T GetAttribute<T>(this Enum value) where T : Attribute
        {
            var type = value.GetType();
            var memberInfo = type.GetMember(value.ToString());
            var attributes = memberInfo[0].GetCustomAttributes(typeof(T), false);
            return attributes.Length > 0
              ? (T)attributes[0]
              : null;
        }

        public static string GetSnakeCase(this Enum value)
        {
            var attribute = value.GetAttribute<JsonCase>();
            return attribute == null ? value.ToString() : attribute.ToSnakeCase();
        }

        public static string GetUnderscore(this Enum value)
        {
            var attribute = value.GetAttribute<JsonCase>();
            return attribute == null ? value.ToString() : attribute.ToUnderscoreCase();
        }

    }
}
