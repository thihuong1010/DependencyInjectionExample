using System;
namespace DependencyInjectionExample
{
    //Client Class or Dependent Object
    //This is the Class that is going to consume the services provided by the EmployeeDAL Class
    //That means it is the Dependent Class which is Depending on the EmployeeDAL Class
    public class EmployeeBL
    {
        public EmployeeDAL? employeeDAL;
        public List<Employee> GetAllEmployees()
        {
            //Creating an Instance of Dependency Class means it is a Tight Coupling
            employeeDAL = new EmployeeDAL();
            return employeeDAL.SelectAllEmployees();
        }
    }
}

