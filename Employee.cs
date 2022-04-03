using System;

namespace EmployeeMaintanenceBL
{
    public class Employee
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int age { get; set; }

        public int EmployeeID { get; set; }
         
        public Employee(int EmployeeID,int age,string FirstName,string LastName,)
        {
            this.EmployeeID = EmployeeID;
            this.age = age;
            this.FirstName = FirstName;
            this.LastName = LastName;
        }





    }

}
