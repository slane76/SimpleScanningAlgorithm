using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SimpleScanningAlgorithm

{
    public class MyTaskList
    {
        static List<string> taskList = new List<string>();
        //string userResponse;

        static void Main(string[] args)
        {

            Console.WriteLine("Please Enter Your First and Last Name. \n");
            string greetUser = Console.ReadLine();
            Console.WriteLine($"Hello: {greetUser} nice to meet you. \n");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------\n");
            
            Console.WriteLine("Please make a number selection from the Main Menu. \n");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------\n");
            Console.WriteLine("1.) I would like to CREATE a new task. \n");
            Console.WriteLine("2.) I would like to ADD TO AN EXISTING tasklist. \n");
            Console.WriteLine("3.) I would like to REMOVE FROM AN EXISTING a tasklist. \n");
            Console.WriteLine("4.) I would like to VIEW a saved list. \n");
            Console.WriteLine("5.) I would like to QUIT the application. \n");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------\n");

            int userResponse = Convert.ToInt32(Console.ReadLine());

            Console.Clear();


            if (userResponse == 1)
            {
                createTask();
            }
            else if (userResponse == 2)
            {
                addTask();
            }
            else if (userResponse == 3)
            {
                removeTask();
            }
            else if (userResponse == 4)
            {
                viewTask();
            }
            else if (userResponse == 5)
            {
                quitApp();
            }
            else
            Console.WriteLine("Invalid Option");


        }




        public static void createTask()
        {
            int listNumber = 0;
            int count = 0;
            int userResponse;
            string userEntry = "";

            do
            {
                Console.Clear();

                count++;
                listNumber++;

                Console.WriteLine("You have selected to CREATE a new tasklist.");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------------\n");

                {
                    Console.WriteLine("Please enter a task.");
                    userEntry = Console.ReadLine();
                    Console.WriteLine($"You have entered : {listNumber}. {userEntry}");
                    taskList.Add(userEntry);
                    Console.WriteLine("-------------------------------------------------------------------------------------------------------------\n");
                }

                Console.WriteLine("Thank you, Would like to add another task?\nEnter (1) for YES and (2) for NO \n");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------------\n");


                userResponse = Convert.ToInt32(Console.ReadLine());
            } while (userResponse != 2);


            quitApp();

        }

        private static void addTask()
        {
            string userResponse = "";
            string fileToOpen = "";
            int myLoop = 0;

            Console.Clear();


            Console.WriteLine("You have chosen to OPEN and Edit a tasklist. Which file would you like to open and edit ");
            fileToOpen = Convert.ToString(Console.ReadLine());
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------\n");

            string filePath = @"C:\Users\samuel.lane.sa\Documents\Education\" + $"{fileToOpen}.txt";

            List<string> lines = File.ReadAllLines(filePath).ToList();

            do
            {
                Console.WriteLine("Your current list is: ");

                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }

                Console.WriteLine("-------------------------------------------------------------------------------------------------------------\n");
                Console.WriteLine("What would you like to add?");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------------\n");
                userResponse = Convert.ToString(Console.ReadLine());
                lines.Add(userResponse);
                Console.WriteLine("-------------------------------------------------------------------------------------------------------------\n");
                Console.WriteLine("New item saved, your new list is: ");

                File.WriteAllLines(filePath, lines);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }

                Console.WriteLine("Would you like to add another task? Press (1) for YES and (2) for NO");
                myLoop = Convert.ToInt32(Console.ReadLine());

                if (myLoop == 1)
                {
                    Console.WriteLine("Thank You");
                }
                else
                    quitApp();
            }
            while (myLoop != 2);
        }

        public static void removeTask()
        {
            string userResponse = "";
            string fileToOpen = "";
            int myLoop = 0;

            Console.Clear();

            Console.WriteLine("You have chosen to OPEN and REMOVE items from a tasklist. Which file would you like to open and edit ");
            fileToOpen = Convert.ToString(Console.ReadLine());
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------\n");

            string filePath = @"C:\Users\samuel.lane.sa\Documents\Education\" + $"{fileToOpen}.txt";

            List<string> lines = File.ReadAllLines(filePath).ToList();

            do
            {
                Console.WriteLine("Your current list is: ");

                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }

                Console.WriteLine("-------------------------------------------------------------------------------------------------------------\n");
                Console.WriteLine("What would you like to remove?");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------------\n");
                userResponse = Convert.ToString(Console.ReadLine());
                lines.Remove(userResponse);
                Console.WriteLine("-------------------------------------------------------------------------------------------------------------\n");
                Console.WriteLine("Item removed, your updated list is: ");

                File.WriteAllLines(filePath, lines);

                foreach (string line in lines)
                {
                    Console.WriteLine(line);

                }
                Console.WriteLine("-------------------------------------------------------------------------------------------------------------\n");


                Console.WriteLine("Would you like to remove another task? Press (1) for YES and (2) for NO");
                myLoop = Convert.ToInt32(Console.ReadLine());

                if (myLoop == 1)
                {
                    Console.WriteLine("Thank You");
                }
                else
                    quitApp();
            }
            while (myLoop != 2);

            Console.WriteLine("-------------------------------------------------------------------------------------------------------------\n");

        }

        private static void viewTask()
        {

            string fileToOpen = "";
            int myResponse = 0;

            Console.Clear();


            Console.WriteLine("You have chosen to OPEN and VIEW a tasklist. Which file would you like to open and view ");
            fileToOpen = Convert.ToString(Console.ReadLine());
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------\n");

            string filePath = @"C:\Users\samuel.lane.sa\Documents\Education\" + $"{fileToOpen}.txt";

            List<string> lines = File.ReadAllLines(filePath).ToList();



            Console.WriteLine("Your current list is: ");

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine("-------------------------------------------------------------------------------------------------------------\n");
            Console.WriteLine("What would you like to do now?");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------\n");
            Console.WriteLine("1.) I would like to CREATE a new task. \n");
            Console.WriteLine("2.) I would like to ADD TO AN EXISTING tasklist. \n");
            Console.WriteLine("3.) I would like to REMOVE FROM AN EXISTING a tasklist. \n");
            Console.WriteLine("4.) I would like to QUIT the application. \n");

            myResponse = Convert.ToInt32(Console.ReadLine());

            if (myResponse == 1)
            {
                createTask();
            }
            else if (myResponse == 2)
            {
                addTask();
            }
            else if (myResponse == 3)
            {
                removeTask();
            }
            else if (myResponse == 4)
            {
                quitApp();
            }
            else
            {
                Console.WriteLine("Invalid Option");
            }
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------\n");

        }

        public static void quitApp()
        {
            Console.Clear();

            Console.WriteLine("Are you sure you would like to quit the application?\nPress (1) for Yes and (2) for No \n");
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

            Console.WriteLine("Would you like to save your list now?\nPress (1) for YES and (2) for NO \n");
            userResponse = Convert.ToInt32(Console.ReadLine());


            if (userResponse == 1)
            {
                Console.WriteLine("Please name your file \n");
                string SaveFileAs = Console.ReadLine();
                System.IO.File.WriteAllLines(@"C:\Users\samuel.lane.sa\Documents\Education\" + $"{SaveFileAs}.txt", taskList);

                if (SaveFileAs == SaveFileAs)
                {
                    Console.WriteLine("The file already exist. Would you like to replace the existing file?");
                    Console.ReadLine();

                    if (userResponse == 1)
                    {
                        Console.WriteLine("Thank you");
                    }
                }

                Console.WriteLine("Your tasklist has been updated. Have a wonderful week");
            }
            else if (userResponse == 2)
            {
                Console.WriteLine("WARNING!!! Your data has not been saved");
            }


        }

    }

}


