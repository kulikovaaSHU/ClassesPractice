using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_9_8_18
{
    class Program
    {
        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();

        static int roll_dice(int min, int max)
        {
            lock (syncLock)
            {
                int roll = random.Next(min, max + 1);
                return roll;
            }
        }

        static double roll_dice_double()
        {
            lock (syncLock)
            {
                double roll = random.NextDouble() * 10 + 10.00;
                return roll;
            }
        }

        static string random_first_name()
        {
            string[] names = { "John", "Jerry", "Greg", "Anna", "Liza", "Pamela", "Peter", "Selene", "Jackie", "Robert", "Shea", "Shillah", "Riley", "Kelly", "Kurt", "Neil" };
            string newname = names[roll_dice(0, names.Length-1)];
            return newname;
        }

        static string random_last_name()
        {
            string[] names = { "Goldberg","Johanson","Greene","Smith","McDouglas","Peters","VanFonDiesel","Freeman","Parker","Prince","Sailer"};
            string newname = names[roll_dice(0, names.Length-1)];
            return newname;
        }

        static string random_position()
        {
            string[] position = { "Sales Clerk","Floor Manager","Administrative Assistant","Janitor","Administrator","IT support","CEO","CFO","CISO","Vice President","President","Stockroom Manager", "Accountant","Associate Accountant","General Manager","Tech Support Assistant","Consultant","Financial Advisor","Benefits Manager","Shift Leader"};
            string newposition = position[roll_dice(0, position.Length - 1)];
            return newposition;
        }

        static string random_jobType()
        {
            string[] jobType = { "Part-time","Full-time","Contractor","Temporary","Internship"};
            string newJobType = jobType[roll_dice(0, jobType.Length - 1)];
            return newJobType;
        }

        static string random_level()
        {
            string[] levels = { "Level 1","Level 2","Level 3","Executive","Associate","Entry-level"};
            string newLevel = levels[roll_dice(0, levels.Length - 1)];
            return newLevel;
        }

        static string random_department()
        {
            string[] department = { "Store","HR","Sales","IT","Accounting","Marketing","Executive","Customer Support"};
            string newDept = department[roll_dice(0, department.Length - 1)];
            return newDept;
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
            newEmployee.position = random_position();
            newEmployee.jobType = random_jobType();
            newEmployee.level = random_level();
            newEmployee.location = "City, ST";
            newEmployee.department = random_department();
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
            Console.WriteLine("Location:            " + employee.location + ", department - " + employee.department);

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

            Console.WriteLine("Employees:\n");

            for (i = 0; i < 5; i++)
            {
                output_info_employee(create_employee());
                Console.WriteLine("\n");
            }

            Console.WriteLine("\nCustomers:\n");

            for (i = 0; i < 5; i++)
            {
                output_info_customer(create_customer());
                Console.WriteLine("\n");
            }

            Console.ReadLine();
        }
    }
}
