using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//add package
using Newtonsoft.Json;

namespace console_control_flow.Tasks
{
    class SurveyData //what type of class ?
    {
        public static Results GetDataByFileName(string fileName)
        {
            return JsonConvert.DeserializeObject<Results>(File.ReadAllText($"StaticData/{fileName}.json"));
        }

        //accept set1 set2
        //put here File.ReadAllText($"StaticData/{fileName}.json")
    }
}
