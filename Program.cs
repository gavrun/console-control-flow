using System;

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
                Console.WriteLine("Input a task to run (rewards, comments, tasks) or exit (quit):");

                //input actions
                var selectedTask = Console.ReadLine();

                //message
                Console.WriteLine("Input a data set (ds1, ds2):");

                //input data set
                var selectedDataSet = Console.ReadLine();

                //show results
                var surveyResults = ; //TBD in a new class

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
                        break;
                    default:
                        //daction
                        break;
                }

                //spacer
                Console.WriteLine();
            }
            while (!quitProgram);
        }
    }
}
