using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandboxLibrary.enums.batch1.components
{
    public class JsonCase : System.ComponentModel.DescriptionAttribute
    {
        private string _snakeCase = string.Empty;
        private string _underscoreCase = string.Empty;


        public JsonCase(string snakeCase, string underscoreCase) 
        { 
            _snakeCase = snakeCase;
            _underscoreCase = underscoreCase;
        }

        public string ToSnakeCase() { return _snakeCase; }
        public string ToUnderscoreCase() { return _underscoreCase; }
    }
}
