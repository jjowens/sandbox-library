using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandboxLibrary.enums.original
{
    public static class CaseHelper
    {

        public static string ToTitleCase(string lineOfText)
        {
            List<string> lst = lineOfText.Trim().Split(' ').ToList();

            StringBuilder sb = new StringBuilder();

            foreach (string item in lst)
            {
                if (item.Length > 0) {
                    sb.AppendFormat("{0}{1}", item[0].ToString().ToUpper(), item.Substring(1).ToLower());
                } else
                {
                    sb.AppendFormat("{0}", item.ToUpper());
                }
            }

            return sb.ToString().Trim();
        }

        public static string ToSnakeCase(string lineOfText)
        {
            return lineOfText.ToLower().Trim().Replace(" ", "-");
        }

        public static string ToUnderscoreCase(string lineOfText)
        {
            return lineOfText.ToLower().Trim().Replace(" ", "_");
        }

        public static string ToCamelCase(string lineOfText)
        {
            List<string> lst = lineOfText.Trim().Split(' ').ToList();

            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("{0}", lst[0].ToLower());

            for (int idx=1; idx < lst.Count(); idx++)
            {
                if (lst[idx].Length > 0)
                {
                    sb.AppendFormat("{0}{1}", lst[idx][0].ToString().ToUpper(), lst[idx].Substring(1).ToLower());
                }
                else
                {
                    sb.AppendFormat("{0}", lst[idx].ToString().ToUpper());
                }
            }

            return sb.ToString().Trim();
        }

    }
}
