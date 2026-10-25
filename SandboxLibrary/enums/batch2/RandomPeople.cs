using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SandboxLibrary.enums.batch2.components;

namespace SandboxLibrary.enums.batch2
{

    
    public enum RandomPeople
    {
        [RandomPeopleComponent("IT", 5)]
        [Description("David the Great Guy")]
        David,
        [RandomPeopleComponent("IT", 5)]
        [Description("Ryan the Great Guy")]
        Ryan,
        [RandomPeopleComponent("IT", 5)]
        [Description("Jeri the Great Guy")]
        Jeri,
        [RandomPeopleComponent("IT", 5)]
        [Description("Kerry the Great Guy")]
        Kerry,
        [Description("Julie the Fitness Instructor")]
        Julie,
        [Description("Harry the multitasker")]
        [RandomPeopleComponent("Captain", 8)]
        Harry
    }
}
