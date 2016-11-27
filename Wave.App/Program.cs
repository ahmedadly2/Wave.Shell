using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Wave.App
{
    class Program
    {
        
        static void Main(string[] args)
        {
            using (WaveEntities waveContext = new WaveEntities())
            {

                waveContext.Employees.Add(new Employee {
                    EmployeeName = "Mr X",
                    EmployeeAge = "44"
                });
                
                Console.WriteLine("Employee Added !");


                Employee myEmp = waveContext.Employees.FirstOrDefault(emp => emp.EmployeeId == 2);
                myEmp.EmployeeAge = "90";
                waveContext.Employees.Attach(myEmp);
                waveContext.SaveChanges();
                
                Console.WriteLine("Employee Removed !");

                int f = waveContext.Employee_Insert("Sarah", "40");
                
                //Completed

            }
                
        }
    }
}
