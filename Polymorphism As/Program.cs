using System;

namespace InterfaceDemoApp
{
    // 🎯 Step 1: Define the interface IQuittable
    // Interfaces act like "contracts" – they tell any class that implements them 
    // that it must provide definitions for the methods declared here.
    interface IQuittable
    {
        // The Quit() method has no implementation here — just a declaration.
        // It must be implemented by any class that adopts this interface.
        void Quit();
    }

    // 🧑‍💼 Step 2: Create the Employee class that inherits from IQuittable
    // This class will represent an employee, and it promises to define how the Quit() method behaves.
    class Employee : IQuittable
    {
        // Basic properties for the Employee class
        public int Id { get; set; }             // Unique identifier for the employee
        public string FirstName { get; set; }   // Employee's first name
        public string LastName { get; set; }    // Employee's last name

        // 🪄 Implement the Quit() method from the IQuittable interface
        // Here, we define *what happens* when an employee "quits"
        public void Quit()
        {
            // Just a fun, expressive message showing this employee has quit
            Console.WriteLine($"👋 {FirstName} {LastName} (ID: {Id}) has decided to quit the company. Wishing them the best!");
        }
    }

    // 🚀 Step 3: Program entry point
    // This is where our console app starts running.
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate a new Employee object and assign values to its properties
            Employee employee = new Employee
            {
                Id = 101,
                FirstName = "Fadya",
                LastName = "Alkarkukli"
            };

            // 🧩 Step 4: Use polymorphism
            // Even though we're assigning an Employee object, 
            // we're storing it in a variable of type IQuittable.
            // This demonstrates polymorphism: one object taking multiple forms.
            IQuittable quittableEmployee = employee;

            // ✨ Step 5: Call the Quit() method using the IQuittable interface reference
            // The Employee's version of Quit() will be executed here.
            quittableEmployee.Quit();

            // Keep the console window open until the user presses a key
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
