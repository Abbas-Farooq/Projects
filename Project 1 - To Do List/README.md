# To-Do List Application in C#
Overview: This is a simple console-based To-Do List application built in C#. The application allows users to:

Add Tasks – Users can input new tasks that they need to accomplish.
Remove Tasks – Users can remove completed tasks from the list.
View Tasks – Users can view the list of current tasks at any time.

# Features:
Adding Tasks:

Users can enter a description of the task they want to add to their to-do list.
The task is saved to a list, and the user is given the option to add more tasks or perform other actions (like viewing or removing tasks).
Removing Tasks:

Users can view their tasks by index and remove a task that has been completed.
The list is updated to reflect the removal of the task, ensuring the user can see only active, pending tasks.

# Viewing Tasks:

Users can view the entire list of tasks, showing the task description along with an index or number for easy reference.
This helps users track what is left to do and allows them to easily remove tasks once completed.

# Complications – Saving Data After Shutdown:
One of the biggest challenges faced during the development of this To-Do List application is ensuring that tasks persist across application sessions (i.e., after the application is shut down and reopened).

# Task Persistence:
Without persistent storage (like a database or file system), all tasks would be lost once the application is closed.
In this scenario, a simple in-memory list (e.g., List<string>) is used to store tasks. However, this is not a permanent solution since the data is cleared every time the program terminates.
Solution Using File Storage:

To address this, tasks can be saved to a file (e.g., a .txt file or a JSON file) before the application shuts down.
Upon startup, the application can read this file to restore the tasks, so users can continue where they left off.
Steps to Implement:

# Saving Tasks on Shutdown:

When a task is added or removed, the task list should be written to a text file or serialized to a more structured format like JSON.
For example, each task could be written on a new line in a .txt file, or the list could be saved as a JSON array of task objects.

# Loading Tasks on Startup:
On application launch, the program will attempt to read the file and populate the task list from the stored data.
Error handling is important here to account for the situation when the file does not exist (e.g., the first time the user runs the program).

