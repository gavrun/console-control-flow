using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_control_flow.Tasks
{
    public static class CommentsReport
    {
        public static void GenerateCommentsReport(Results results)
        {
            var comments = new List<string>();

            //comments output
            Console.WriteLine(Environment.NewLine + "Comments Output:");

            //for loop 
            for (var i = 0; i < results.ResponsesData.Count; i++)
            {
                var currentItem = results.ResponsesData[i];

                if (currentItem.WouldRecommend < 7.0)
                {
                    Console.WriteLine(currentItem.Comments);
                    comments.Add(currentItem.Comments);
                }
            }

            //for each loop
            foreach (var item in results.ResponsesData)
            {
                if (item.AreaToImprove == results.AreaToImprove)
                {
                    Console.WriteLine(item.Comments);
                    comments.Add(item.Comments);
                }
            }

            //out the results to a file
            File.WriteAllLines("CommentsReport.csv", comments);
        }
    }
}
