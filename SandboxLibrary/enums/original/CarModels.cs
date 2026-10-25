using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandboxLibrary.enums.original
{
    public enum CarModels
    {
        RedCar,
        [Description("Blue Car With White Walled Wheels")]
        BlueCarWithWhiteWalledWheels,
        [Description("slow car")]
        SlowCar,
        [Description("fASt cAR")]
        FastCar,
        [Description("  brand new car ")]
        BrandNewCar

    }
}
