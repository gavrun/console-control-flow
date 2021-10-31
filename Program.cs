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
                Console.WriteLine("Input a task to run (rewards, comments, tasks) or exit (quit):");

                //input actions
                var selectedTask = Console.ReadLine();

                //message
                Console.WriteLine("Input a data set (ds1, ds2):");

                //input data set
                var selectedDataSet = Console.ReadLine();

                //show results
                var surveyResults = SurveyData.GetDataByFileName(selectedDataSet); //TBD in a new class

                switch (selectedTask)
                {
                    case "rewards":
                        //action 1
                        break;
                    case "comments":
                        //action 2
                        break;
                    case "tasks":
                        //action3
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
