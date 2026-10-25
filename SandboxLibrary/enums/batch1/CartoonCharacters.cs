using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SandboxLibrary.enums.batch1.components;

namespace SandboxLibrary.enums.batch1
{
  
    public enum CartoonCharacters
    {
        [JsonCase("road-runner", "road_runner")]
        RoadRunner,
        [JsonCase("porky-pig", "porky_pig")]
        PorkyPig,
        [JsonCase("yosmite-sam", "yosmite_sam")]
        YosmiteSam,
        [JsonCase("marvin-the-martian", "marvin_the_martian")]
        MarvinTheMartian,
        [JsonCase("daffy-duck", "daffy_duck")]
        DaffyDuck,
        [JsonCase("bugs-bunny", "bugs_bunny")]
        BugsBunny
    }

}
