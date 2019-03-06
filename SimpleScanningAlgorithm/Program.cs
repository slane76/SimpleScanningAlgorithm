using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace SimpleScanningAlgorithm

{
    public class MyTaskList
    {
        static List<string> taskList = new List<string>();

        static void Main(string[] args)
        {
            

            Console.WriteLine();
            foreach (string i in taskList)
            {
                if (i == null)
                    Console.WriteLine("(null)");
                else
                    Console.WriteLine("\"{0}\"", i);
            }


            //int userResponse = 0;
            //Prompt user for name
            Console.WriteLine("Please Enter Your Name");
            string greetUser = Convert.ToString(Console.ReadLine());
            Console.WriteLine($"Hello: {greetUser} nice to meet you.");
            //Prompt user to make a selection from menu
            Console.WriteLine("Please make a number selection from the Main Menu");
            Console.WriteLine("1. I would like to ADD a task. \n");
            Console.WriteLine("2. I would like to REMOVE a task. \n");
            Console.WriteLine("3. I would like to QUIT the application. ");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------n/");

            //userResponse 

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
                quitApp();
            }
            else
                Console.WriteLine("Invalid Option");
        }

       
        

        public static void addTask()
        {
            //var taskList = new List<string>();

            int listNumber = 1;
            string userEntry;
            int count = 0;
            int userAnswer = 0;
            string userList;



            //Ask if user will be adding a task to list
            Console.WriteLine("You have selected to add a task.  Please enter in the task you would like to add. Press 0 to exit Application");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------n/");

            //Accept user entry and add to list
            userEntry = Console.ReadLine();

            Console.WriteLine($"You have entered : {listNumber}. {userEntry}");

            int userResponse = 0;

            do
            {
                //int userResponse;
                //Promt user if they want to enter another task
                Console.WriteLine("Thank you, Would like to add another task? Enter 1 for YES and 2 for NO");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------------n/");


                userResponse = Convert.ToInt32(Console.ReadLine());

                if (userResponse == 1)
                {
                    count++;
                    listNumber++;

                    //Ask if user will be adding a task to list
                    Console.WriteLine("You have selected to add a task.  Please enter in the task you would like to add. Press 0 to exit Application");
                    Console.WriteLine("-------------------------------------------------------------------------------------------------------------n/");

                    //Accept user entry and add to list
                    userEntry = Console.ReadLine();

                    Console.WriteLine($"You have entered : {listNumber}. {userEntry}");
                    // Store task inside of the list
                    taskList.Add(userEntry);

                }
                else if (userResponse == 2)
                {
                    quitApp();
                }

            } while (userResponse != 2);


        }

        public static void removeTask()
        {
            //Ask if user has completed a task and will be marking it off the list
            Console.WriteLine("You have selected to remove a task from the list. Which task would you like to remove?");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------n/");

            string removeTask = Convert.ToString(Console.ReadLine());
        }

        public static void quitApp()
        {
            //Ask user if he/she would like to quit the application
            Console.WriteLine("Would you like to quit the application? Press 1 for Yes and 2 for No");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------n/");

            string quitApp = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Thank you, until next time stay safe!!!");
        }







    }

}
