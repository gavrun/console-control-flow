using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_control_flow.Tasks
{
    public static class TasksReport
    {
        public static void GenerateTasksReport(Results results)
        {
            var tasks = new List<string>();

            double responseRate = results.NumberResponded / results.NumberSurveyed;
            double overallScore = (results.ServiceScore + results.CoffeeScore + results.FoodScore + results.PriceScore) / 4;

            //if condition
            if (results.CoffeeScore > results.FoodScore)
            {
                tasks.Add("Investigate coffee recipes and ingredients.");
            }

            //ternary operator for if else condition
            tasks.Add(overallScore > 8.0 ? "Work with leadership." : "Work with employees for ideas.");

            //if multiple condition
            if (responseRate < .33)
            {
                tasks.Add("Research options to improve response rate.");
            }
            else if (responseRate > .33 && responseRate < .66)
            {
                tasks.Add("Reward participants with free coffee coupon.");
            }
            else
            {
                tasks.Add("Rewards participants with discount coffee coupon.");
            }

            //switch condition
            tasks.Add(results.AreaToImprove switch
            {
                //case options by lambda expression
                "RewardsProgram" => "Revisit the rewards deals.",
                "Cleanliness" => "Contact the cleaning vendor",
                "MobileApp" => "Contact the consulting firm about the app.",
                //default 
                _ => "Investigate individual comments for ideas."
            }
            );

            //tasks output
            Console.WriteLine(Environment.NewLine + "Tasks Output:");
            foreach (var task in tasks)
            {
                Console.WriteLine(task);
            }

            //out the results to a file
        }
    }
}
