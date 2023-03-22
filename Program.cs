using System.Runtime.CompilerServices;

namespace Constructor
{
    using Constructor;
    public class Program
    {
         public static void Main()
         {
            Employee emp1 = new Employee();
            
            Employee emp2 = new Employee(11,"Vijay",20000); // call to parameterless consturctor

            Employee emp3 = new Employee(12, "Vishnu", 30000);// call to parameterized constructor 

            Employee emp2Copy = new Employee(emp2);

           

            emp1.ShowData();
            emp2.ShowData();
            emp3.ShowData();
            emp2Copy.ShowData();


            

         } 
    }
}