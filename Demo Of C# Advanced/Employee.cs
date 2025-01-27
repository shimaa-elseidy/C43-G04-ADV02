using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
//    public class EmployeeCompareName : IComparer
//    {
//        public int Compare(object? x, object? y)
//    {
//        Employee X = (Employee)x;
//        Employee Y = (Employee)y;
//        return X.Name.CompareTo(Y.Name);
//    }
//}
     class EmployeeCompareNameGeneric : IComparer<Employee>
    {
        public int Compare(Employee? x, Employee? y)
        {
            Employee X = (Employee)x;
            Employee Y = (Employee)y;
            return X.Name.CompareTo(Y.Name);
        }
    }
}
    internal class Employee : IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public int CompareTo(object? obj)
        {
            Employee E = obj as Employee;
            return this.Age.CompareTo(E.Age);  
        }

        public override string ToString()
        {
            return $"ID: {Id} , Name: {Name} , Age: {Age} , Salary: {Salary} ";
        }

    }

