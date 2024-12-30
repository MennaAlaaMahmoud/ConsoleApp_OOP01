using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmment
{

    public enum SecurityLevel
    {
        Guest,
        Developer,
        Secretary,
        DBA,
        SecurityOfficer // Add 3
    }
    internal class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        private string gender;
        public string Gender
        {
            get => gender;
            set
            {
                if (value == "M" || value == "F")
                {
                    gender = value;
                }
                else
                {
                    throw new ArgumentException("Gender must be 'M' or 'F'.");
                }
            }
        }
        public SecurityLevel SecurityLevel { get; set; }
        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }

        public Employee(int id, string name, string gender, SecurityLevel securityLevel, decimal salary, DateTime hireDate)
        {
            ID = id;
            Name = name;
            Gender = gender;
            SecurityLevel = securityLevel;
            Salary = salary;
            HireDate = hireDate;
        }

        public override string ToString()
        {
            return $"Employee ID: {ID}\n" +
                   $"Name: {Name}\n" +
                   $"Gender: {(Gender == "M" ? "Male" : "Female")}\n" +
                   $"Security Level: {SecurityLevel}\n" +
                   $"Salary: {Salary.ToString("C", CultureInfo.CurrentCulture)}\n" +
                   $"Hire Date: {HireDate:MMMM dd, yyyy}";
        }


    }
}
