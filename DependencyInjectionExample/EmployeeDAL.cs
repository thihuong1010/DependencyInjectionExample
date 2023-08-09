﻿using System;
namespace DependencyInjectionExample
{
    //Service Class or Dependency Object
    //This is the class that is responsible for Interacting with the Database
    //This class is going to be used by the EmployeeBL class
    //That means it is going to be the Dependency Object
    public class EmployeeDAL
    {
        public List<Employee> SelectAllEmployees()
        {
            List<Employee> ListEmployees = new List<Employee>
            {
                //Get the Employees from the Database
                //for now we are hard coded the employees
                new Employee() { ID = 1, Name = "Pranaya", Department = "IT" },
                new Employee() { ID = 2, Name = "Kumar", Department = "HR" },
                new Employee() { ID = 3, Name = "Rout", Department = "Payroll" }
            };
            return ListEmployees;
        }
    }
}

