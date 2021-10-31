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
    class SurveyData //what type of class this should be?
    {
        public static SurveyResults GetDataByFileName(string fileName)
        {
            //accept set1 set2
            //put to File.ReadAllText($"StaticData/{fileName}.json")
            return JsonConvert.DeserializeObject<SurveyResults>
                (File.ReadAllText($"SurveyData/{fileName}.json")
                );
        }
    }
}
