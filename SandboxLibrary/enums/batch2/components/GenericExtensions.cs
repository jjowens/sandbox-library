using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SandboxLibrary.enums.batch2.components
{
    public static class GenericExtensions
    {

        public static string AppendText(this Enum value, string appendText)
        {
            return string.Format("{0} {1}", value.ToString(), appendText);
        }

        public static string DanceToMusic(this System.ComponentModel.PropertyDescriptor value)
        {
            return string.Format("{0} with music", value.ToString());
        }

        public static string SwordFighting(this Enum value)
        {
            return string.Format("{0} does some sword fighting", value.ToString());
        }

        public static string Cartwheels (this System.ComponentModel.DescriptionAttribute value)
        {
            return string.Format("{0} does some cartwheels", value.Description.ToString());
        }

        public static string GetRandomComponent(this RandomPeopleComponent value)
        {
            return string.Format("has been doing {0} for {1} years", value.Role, value.Years);
        }

    }
}
