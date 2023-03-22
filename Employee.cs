using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Employee
    {

        public  int Id { get; set; }   
        public string Name { get; set; }
        public int Salary { get; set; }

        public static int IncomeTax { get; set; }

        public Employee() // parameterless or default constructor
        {
           this .Id = 10;
           this. Name = "Vaish";
           this. Salary = 10000;
        }


        public Employee( int id, string name,int salary)//parameterized constructor
        {
            this .Id = id;
            this. Name = name;
            this.Salary = salary;
        }

        public Employee(Employee emp ) // copy construstor 
        {
            this.Id= emp.Id;
            this. Name = emp.Name;
            this.Salary = emp.Salary;
        }


        public void Showdata()
        {
            Console.WriteLine("Id=" + this.Id);
            Console.WriteLine("Name=" + this.Name);
            Console.WriteLine("salary=" + this.Salary);
        }

        public void ShowData()
        {
            Console.WriteLine("Id=" + this.Id);
            Console.WriteLine("Name=" + this.Name);
            Console.WriteLine("Salary=" + this.Salary);
        }
      


    }
}
