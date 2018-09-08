using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_9_8_18
{
    class Program
    {
        static int roll_dice(int min, int max)
        {
            Random random = new Random();
            int roll = random.Next(min, max + 1);
            return roll;
        }

        static double roll_dice_double()
        {
            Random random = new Random();
            double roll = random.NextDouble()*10 + 10.00;
            return roll;
        }

        static Employee create_employee()
        {
            Employee newEmployee = new Employee();
            newEmployee.firstName = "John";
            newEmployee.lastName = "Doe";
            newEmployee.birthDay = roll_dice(1, 29);
            newEmployee.birthMonth = roll_dice(1, 12);
            newEmployee.birthYear = roll_dice(1945, 1995);
            newEmployee.address = "123 Street St";
            newEmployee.city = "City";
            newEmployee.state = "ST";
            newEmployee.zipcode = "01234";
            newEmployee.position = "Sales Clerk";
            newEmployee.jobType = "Part-time";
            newEmployee.level = "Level 1";
            newEmployee.location = "City, ST";
            newEmployee.department = "Store";
            newEmployee.yearStarted = roll_dice(2010, 2018);
            newEmployee.salaried = false;
            newEmployee.rate = Math.Round(roll_dice_double(), 2);
            newEmployee.insurance = false;

            return newEmployee;
        }

        static void output_info_employee(Employee employee)
        {
            Console.WriteLine("Full Name            " + employee.firstName + " " + employee.lastName);
            Console.WriteLine("Date of Birth:       " + employee.birthDay + "." + employee.birthMonth + "." + employee.birthYear);
            Console.WriteLine("Residence:           " + employee.address + ", " + employee.city + ", " + employee.state + " " + employee.zipcode);
            Console.WriteLine("Position:            " + employee.position + " " + employee.level + " (" + employee.jobType + "), started in " + employee.yearStarted);
            Console.WriteLine("Location:            " + employee.location);

            if(employee.salaried)
            {
                Console.WriteLine("Salary:              " + "$" + employee.salary);
            }
            else
            {
                Console.WriteLine("Hourly:              " + "$" + employee.rate + "/hr");    
            }

            Console.WriteLine("Insurance:           " + employee.insurance);
        }

        static void Main(string[] args)
        {
            output_info_employee(create_employee());

            Console.ReadLine();
        }
    }
}
