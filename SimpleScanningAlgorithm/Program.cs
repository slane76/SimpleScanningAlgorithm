using System;
using System.Collections.Generic;



namespace SimpleScanningAlgorithm

{
    public class MyTaskList
    {
        static List<string> taskList = new List<string>();
        //string userResponse;

        static void Main(string[] args)
        {
            //int userResponse = 0;
            //Prompt user for name
            Console.WriteLine("Please Enter Your First and Last Name. \n");
            string greetUser = Console.ReadLine();
            Console.WriteLine($"Hello: {greetUser} nice to meet you. \n");
            //Prompt user to make a selection from menu
            Console.WriteLine("Please make a number selection from the Main Menu. \n");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------\n");
            Console.WriteLine("1. I would like to ADD a task. \n");
            Console.WriteLine("2. I would like to REMOVE a task. \n");
            Console.WriteLine("3. I would like to OPEN a saved list. \n");
            Console.WriteLine("4. I would like to QUIT the application. \n");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------\n");

            int userResponse = Convert.ToInt32(Console.ReadLine());

            if (userResponse == 1)
            {
                addTask();
            }
            else if (userResponse == 2)
            {
                removeTask();
            }
            else if (userResponse == 3)
            {
                openTask();
            }
            else if (userResponse == 4)
            {
                quitApp();
            }
            else
                Console.WriteLine("Invalid Option");
        }



        public static void addTask()
        {
            //var taskList = new List<string>();

            int listNumber = 0;
            string userEntry;
            int count = 0;
            int userResponse = 1;

            do
            {
                count++;
                listNumber++;

                //Ask if user will be adding a task to list
                Console.WriteLine("You have selected to add a task.  Please enter in the task you would like to add. Press 0 to exit Application. \n");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------------\n");

                //Accept user entry and add to list
                userEntry = Console.ReadLine();

                Console.WriteLine($"You have entered : {listNumber}. {userEntry}");
                // Store task inside of the list
                taskList.Add(userEntry);


                //int userResponse;
                //Promt user if they want to enter another task
                Console.WriteLine("Thank you, Would like to add another task? Enter 1 for YES and 2 for NO \n");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------------\n");


                userResponse = Convert.ToInt32(Console.ReadLine());
            } while (userResponse != 2);


            quitApp();

        }

        public static void removeTask()
        {
            //Ask if user has completed a task and will be marking it off the list
            Console.WriteLine("You have selected to remove a task from the list. Which task would you like to remove? \n");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------\n");

            string removeTask = Convert.ToString(Console.ReadLine());
        }

        private static void openTask()
        {
            string openTextFile;
            Console.WriteLine("You have chosen to OPEN a file, which file would you like to open \n");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------\n");
            openTextFile = Console.ReadLine();
            string filePath = @"C:\Users\samuel.lane.sa\Documents\Education\" + $"{openTextFile}.txt", taskList;
            //List<> openTextFile = file.ReadAllLines(@"C:\Users\samuel.lane.sa\Documents\Education\" + $"{openTextFile}.txt", taskList).ToList();
        }

        public static void quitApp()
        {
            //Ask user if he/she would like to quit the application
            Console.WriteLine("Are you sure you would like to quit the application? Press 1 for Yes and 2 for No \n");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------\n");

            string quitApp = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Thank you, until next time stay safe!!! \n");

            Console.WriteLine("-------------------------------------------------------------------------------------------------------------\n");

            Console.WriteLine("Your task list has been updated \n");


            int userResponse = 0;

            foreach (string i in taskList)
            {
                if (i == null)
                    Console.WriteLine("(null)");
                else
                    Console.WriteLine("\"{0}\"", i);

            }
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------\n");

            Console.WriteLine("Would you like to save your list now? Press 1 for YES and 2 for NO \n");
            userResponse = Convert.ToInt32(Console.ReadLine());


            if (userResponse == 1)
            {
                Console.WriteLine("Please name your file \n");
                string SaveFileAs = Console.ReadLine();
                System.IO.File.WriteAllLines(@"C:\Users\samuel.lane.sa\Documents\Education\" + $"{SaveFileAs}.txt", taskList);

            }
            else if (userResponse == 2)
            {
                //exitApp;
            }
            else
            {
                Console.WriteLine("Your Task List has not been saved \n");

            }
            /*Console.WriteLine("Would you like to now view your list in a text document? Press 1 for YES and 2 for NO");
            openTask = Console.WriteLine();

            if (openTask == 1);
            {
                openTask();
            }
            else 
            {
                exitApp();
            }*/

            
            
        }
    }

}
