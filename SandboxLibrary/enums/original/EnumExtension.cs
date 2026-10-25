using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandboxLibrary.enums.original
{
    public static class EnumExtensions
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

        public static string ToSnakeCase(this Enum value)
        {
            var attribute = value.GetAttribute<DescriptionAttribute>();
            return attribute == null ? CaseHelper.ToSnakeCase(value.ToString()) : CaseHelper.ToSnakeCase(attribute.Description);
        }

        public static string ToUnderscoreCase(this Enum value)
        {
            var attribute = value.GetAttribute<DescriptionAttribute>();
            return attribute == null ? CaseHelper.ToUnderscoreCase(value.ToString()) : CaseHelper.ToUnderscoreCase(attribute.Description);
        }

        public static string ToCamelCase(this Enum value)
        {
            var attribute = value.GetAttribute<DescriptionAttribute>();
            return attribute == null ? CaseHelper.ToCamelCase(value.ToString()) : CaseHelper.ToCamelCase(attribute.Description);
        }

        public static string ToTitleCase(this Enum value)
        {
            var attribute = value.GetAttribute<DescriptionAttribute>();
            return attribute == null ? CaseHelper.ToTitleCase(value.ToString()) : CaseHelper.ToTitleCase(attribute.Description);
        }

        public static string ToLowerCase(this Enum value)
        {
            var attribute = value.GetAttribute<DescriptionAttribute>();
            return attribute == null ? value.ToString().ToLower() : attribute.Description.Trim().ToLower().Replace(" ", "");
        }
    }
}
