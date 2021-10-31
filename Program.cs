using System;
//add package
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace console_control_flow.Tasks
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
                var selectedDataSet = Console.ReadLine();

                //show results
                var surveyResults = SurveyData.GetDataByFileName(selectedDataSet); //TBD refactoring, extract to a new class

                //message
                Console.WriteLine("Input a task to run (rewards, comments, tasks) or exit (quit):");

                //input actions
                var selectedTask = Console.ReadLine();


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
