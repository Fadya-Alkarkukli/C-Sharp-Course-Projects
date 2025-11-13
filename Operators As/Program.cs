using System;

namespace EmployeeApp
{
    // Define the Employee class
    class Employee
    {
        // Define properties for the Employee class
        public int Id { get; set; }           // Employee Id, a unique identifier
        public string FirstName { get; set; }  // Employee's first name
        public string LastName { get; set; }   // Employee's last name

        // Overload the equality operator '==' to compare Employee objects by their Id
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // Check if both objects are the same instance in memory (reference comparison)
            if (ReferenceEquals(emp1, emp2)) return true;

            // Check if either of the objects is null (to avoid null reference exceptions)
            if (emp1 is null || emp2 is null) return false;

            // Compare the 'Id' property of the two Employee objects to determine equality
            return emp1.Id == emp2.Id;
        }

        // Overload the inequality operator '!=' to compare Employee objects by their Id
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            // If they are not equal (using '==' operator), return true for inequality
            return !(emp1 == emp2); 
        }

        // Override the Object.Equals method to ensure consistency with == and !=
        public override bool Equals(object obj)
        {
            // If the object is not an Employee, return false (they can't be equal)
            if (obj is not Employee otherEmployee) return false;

            // Return true if the Ids of the two Employee objects are equal
            return this.Id == otherEmployee.Id;
        }

        // Override the Object.GetHashCode method to ensure consistency with Equals
        public override int GetHashCode()
        {
            // Return the Id as the hash code since it is the primary field for comparison
            return Id.GetHashCode();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create two Employee objects and assign values to their properties
            Employee employee1 = new Employee { Id = 1, FirstName = "Fadya", LastName = "Alkarkukli" };
            Employee employee2 = new Employee { Id = 1, FirstName = "Jane", LastName = "Jade" };

            // Compare the two Employee objects using the overloaded '==' operator
            bool areEqual = employee1 == employee2;   // This uses the overloaded '==' operator

            // Display the result of the comparison to the console
            Console.WriteLine($"Are the two employees equal? {areEqual}");

            // Compare the two Employee objects using the overloaded '!=' operator
            bool areNotEqual = employee1 != employee2; // This uses the overloaded '!=' operator

            // Display the result of the inequality comparison
            Console.WriteLine($"Are the two employees not equal? {areNotEqual}");
        }
    }
}
