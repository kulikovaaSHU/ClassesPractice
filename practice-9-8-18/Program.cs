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

        static string random_first_name()
        {
            string[] names = { "John", "Jerry", "Greg", "Anna", "Liza", "Pamela", "Peter", "Selene", "Jackie", "Robert", "Shea", "Shilla", "Riley", "Kelly", "Kurt", "Neil" };
            string newname = names[roll_dice(0, names.Length-1)];
            return newname;
        }

        static string random_last_name()
        {
            string[] names = { "Goldberg","Johanson","Greene","Smith","McDouglas","Peters","VanFonDiesel","Freeman","Parker","Prince","Sailer"};
            string newname = names[roll_dice(0, names.Length-1)];
            return newname;
        }

        static Employee create_employee()
        {
            Employee newEmployee = new Employee();
            newEmployee.firstName = random_first_name();
            newEmployee.lastName = random_last_name();
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

        static Customer create_customer()
        {
            Customer customer = new Customer();
            customer.firstName = random_first_name();
            customer.lastName = random_last_name();
            customer.birthDay = roll_dice(1, 29);
            customer.birthMonth = roll_dice(1, 12);
            customer.birthYear = roll_dice(1945, 1995);
            customer.address = "123 Street St";
            customer.city = "City";
            customer.state = "ST";
            customer.zipcode = "01234";
            customer.email = "123email@example.com";
            customer.phonenumber = "123-456-7890";
            customer.commercial = true;
            customer.member = true;
            customer.membershipID = 1234567;
            return customer;
        }

        static void output_info_employee(Employee employee)
        {
            Console.WriteLine("Full Name:           " + employee.firstName + " " + employee.lastName);
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

        static void output_info_customer(Customer customer)
        {
            Console.WriteLine("Full Name:           " + customer.firstName + " " + customer.lastName);
            Console.WriteLine("Date of Birth:       " + customer.birthDay + "." + customer.birthMonth + "." + customer.birthYear);
            Console.WriteLine("Residence:           " + customer.address + ", " + customer.city + ", " + customer.state + " " + customer.zipcode);
            Console.WriteLine("Email:               " + customer.email);
            Console.WriteLine("Phone:               " + customer.phonenumber);
            Console.WriteLine("Commercial:          " + customer.commercial);
            Console.WriteLine("Membership:          " + customer.member);

            if(customer.member)
            {
                Console.WriteLine("Membership ID:       " + customer.membershipID);
            }
        }

        static void Main(string[] args)
        {
            int i;

            for (i = 0; i < 10; i++)
            {
                output_info_employee(create_employee());
                Console.WriteLine("\n");
            }





            output_info_customer(create_customer());

            Console.ReadLine();
        }
    }
}
