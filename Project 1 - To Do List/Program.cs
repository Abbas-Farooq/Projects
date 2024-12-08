using System;
using System.Collections.Generic;
using System.IO;

namespace ToDoList
{
    class ToDoList
    {
        static string filePath = "todo.txt";  // Path for the todo list file

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the To Do List Program");

            // Load tasks from the file at the start of the program
            List<string> taskList = LoadTasks();

            string option = "";

            while (option != "e")
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("Enter 1 to add a task to the list.");
                Console.WriteLine("Enter 2 to remove a task from the list.");
                Console.WriteLine("Enter 3 to view the list.");
                Console.WriteLine("Enter e to exit the program.");

                option = Console.ReadLine();

                if (option == "1")
                {
                    Console.WriteLine("Please enter the name of the task to add to the list:");
                    string task = Console.ReadLine();
                    taskList.Add(task);
                    Console.WriteLine("Task added to the list.");
                }
                else if (option == "2")
                {
                    Console.WriteLine("Please select a task to remove:");

                    // Display the tasks
                    for (int i = 0; i < taskList.Count; i++)
                    {
                        Console.WriteLine(i + " : " + taskList[i]);
                    }

                    Console.WriteLine("Enter the number of the task you want to remove:");
                    int taskNumber = Convert.ToInt32(Console.ReadLine());
                    if (taskNumber >= 0 && taskNumber < taskList.Count)
                    {
                        taskList.RemoveAt(taskNumber);  // Remove task by index
                        Console.WriteLine("Task removed.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid task number.");
                    }
                }
                else if (option == "3")
                {
                    Console.WriteLine("Current tasks in the list:");
                    // Display all tasks
                    for (int i = 0; i < taskList.Count; i++)
                    {
                        Console.WriteLine(i + ": " + taskList[i]);
                    }
                }
                else if (option == "e")
                {
                    Console.WriteLine("Exiting Program.");
                }
                else
                {
                    Console.WriteLine("Invalid option, please try again.");
                }
            }

            // Save the updated tasks to the file before exiting the program
            SaveTasks(taskList);
            Console.WriteLine("Thank you for using the program.");
        }

        // Load tasks from the file
        static List<string> LoadTasks()
        {
            List<string> taskList = new List<string>();

            // Check if the file exists, and if it does, load the tasks from the file
            if (File.Exists(filePath))
            {
                taskList.AddRange(File.ReadAllLines(filePath));  // Read tasks into the list
                Console.WriteLine("Tasks loaded successfully.");
            }
            else
            {
                Console.WriteLine("No existing tasks found, starting fresh.");
            }

            return taskList;
        }

        // Save tasks to the file
        static void SaveTasks(List<string> taskList)
        {
            try
            {
                // Write all tasks to the file (each task on a new line)
                File.WriteAllLines(filePath, taskList);
                Console.WriteLine("Tasks saved successfully.");
            }
            catch (Exception ex)
            {
                // Handle any errors that might occur during the file-writing process
                Console.WriteLine($"Error saving tasks: {ex.Message}");
            }
        }
    }
}
