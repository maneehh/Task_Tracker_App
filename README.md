# Task Tracker Application

This application is designed to help users track their tasks. Users can add, edit, mark as done, and delete tasks using this application. The application utilizes Blazor and also a SQL database to store tasks.

## Features

- Add new tasks
- Edit existing tasks
- Mark tasks as done
- Delete tasks

## Technologies Used

- C# (.NET Core)
- Blazor
- SQL
- Entity Framework Core

## Installation

To run this application, follow these steps:

1. Clone this repository to your local machine.
2. Open the project in your preferred development environment (e.g., Visual Studio, Visual Studio Code).
3. Ensure you have the necessary prerequisites installed, including .NET Core SDK.
4. Set up a SQL database to store tasks.
5. Update the connection string in the application to connect to your SQL database.
6. Build and run the application.

## Usage

Once the application is running, you can perform the following actions:

- Add a new task by entering the task content and clicking "Save."
- Edit an existing task by clicking the "Edit" button next to the task, making changes, and clicking "Save".
- Mark a task as done by clicking the "Done" button next to the task.
- Delete a task by clicking the "Delete" button next to the task.

## Folder Structure

- `Pages/`: Contains the Blazor components for the application's user interface.
- `Data/`: Contains the database context and entity classes.

## License

This project is licensed under the [MIT License](LICENSE).
