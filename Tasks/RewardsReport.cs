using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_control_flow.Tasks
{
    public static class RewardsReport
    {
        public static void GenerateWinnersEmailsReport(SurveyResults results)
        {
            var selectedEmails = new List<string>();

            //counter outside the while loop
            int counter = 0;

            Console.WriteLine(Environment.NewLine + "Selected Winners Output:");

            while (selectedEmails.Count < 2 && counter < results.Responses.Count)
            {
                var currentItem = results.Responses[counter];

                if (currentItem.FavoriteProduct == "Cappucino")
                {
                    selectedEmails.Add(currentItem.EmailAddress);
                    Console.WriteLine(currentItem.EmailAddress);
                }

                //use counter
                counter++;
            }

            //out the results to a file
            File.WriteAllLines("WinnersReport.csv", selectedEmails);
        }
    }
}
