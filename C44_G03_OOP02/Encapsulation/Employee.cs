using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_OOP02.Encapsulation
{
    internal struct Employee
    {
        #region Attributes
        private int Id; 
        private string? EmpName;
        private decimal empSalary;
        public int Age { get; set; }

        //private decimal deduction;

        
        public decimal Deduction // Read Only Property
        {
            get { return Salary * 0.1m; }
        }



        #endregion

        #region Encapsulation

        #region Getter & Setter

        public string GetName()
        {
            return EmpName;
        }

        public void SetName(string? value)
        {
            EmpName = value?.Length > 10 ? value.Substring(0, 10) : value;
        }

        #endregion

        #region Property
        public decimal Salary
        {
            get { return empSalary; }
            set { empSalary = value > 5000 ? 5000 : value; }
        }

        #endregion

        #endregion

        #region Constructor
        //public Employee(int id, string name)
        //{
        //    Id = id;
        //    SetName(name);
        //}

        public Employee(int id, string? empName, decimal empSalary)
        {
            Id = id;
            SetName(empName);
            Salary = empSalary;
        }
        #endregion

        #region Method
        public override string ToString()
        {
            return $"Id : {Id},  Name : {EmpName}";
        }
        #endregion


    }
}
