using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Dec29Console
{
    //copy Constructor
    public class Employee
    {
        private int id;
        private string name;
        public  Employee(int id,string name) {
        this.id = id;
            this.name = name;
        }
        public  Employee (Employee emp)
        {
            id = emp.id;
            name=emp.name;

        }
        public string Result
        {   
            get { return  $"| Employee Id : {id} | Employee Name : {name} |"; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(12,"Naveen");
            Employee emp2 = new Employee(13, "Naveen Madhesan");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine(emp.Result);
            Console.WriteLine(emp2.Result);
            Console.WriteLine("---------------------------------------------");
            Console.ReadLine();
        }
    }
}
