using System;
//add package
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
//add namespace
using console_control_flow.Tasks;

namespace console_control_flow
{
    class Program
    {
        static void Main(string[] args)
        {
            //quit
            bool quitProgram = false;

            do
            {
                //message
                Console.WriteLine("Input a data set (set1, set2):");

                //input data set
                var selectedSurveyDataSet = Console.ReadLine();

                //message
                Console.WriteLine("Input a task to run (rewards, comments, tasks) or exit (quit):");

                //input actions
                var selectedTask = Console.ReadLine();

                //show results
                var surveyResults = SurveyData.GetDataByFileName(selectedSurveyDataSet); //TBD refactoring, extract to a new class

                switch (selectedTask)
                {
                    case "rewards":
                        //action 1
                        RewardsReport.GenerateWinnersEmailsReport(surveyResults); //TBD its own class
                        break;
                    case "comments":
                        //action 2
                        CommentsReport.GenerateCommentsReport(surveyResults);
                        break;
                    case "tasks":
                        //action3
                        TasksReport.GenerateTasksReport(surveyResults);
                        break;
                    case "quit":
                        //quit action
                        quitProgram = true;
                        break;
                    default:
                        //default action
                        Console.WriteLine("This is not a valid input. Try again.");
                        break;
                }

                //spacer
                Console.WriteLine();
            }
            while (!quitProgram);
        }
    }
}
