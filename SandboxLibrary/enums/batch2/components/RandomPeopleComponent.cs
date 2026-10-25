using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SandboxLibrary.enums.batch2.components
{
    public class RandomPeopleComponent : System.ComponentModel.DescriptionAttribute
    {
        private string _role = string.Empty;
        private int _years = 0;

        public RandomPeopleComponent(string role, int years) 
        {
            _role = role;
            _years = years;
        }

        public string Role { get { return _role; } set { _role = value; } }
        public int Years { get { return _years; } set { _years = value; } }

    }
}
