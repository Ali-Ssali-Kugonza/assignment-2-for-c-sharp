using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace array
{
    class typesOfArrays
    {

        static void arrayy(string[] args)
        {
            /*
            double number;
            double sum = 0;
            Console.Write("PLEASE ENTER ODD NUMBERS BETWEEN 7 AND 15: ");
            number = Convert.ToDouble(Console.ReadLine());
           

            for (int i = 7; i <= number; i+=2)
            {
                sum += i;


            }
            Console.WriteLine($"THE SUM OF ODD NUMBERS BETWEEN 7 to {number} IS {sum}");
            Console.ReadLine();
            */

            int number;
            int sum = 0;
            Console.Write("PLEASE ENTER ODD NUMBERS BETWEEN 7 AND 15: ");
            number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0 & number <= 15)
            {
                Console.Write("PLEASE ENTER ODD NUMBERS BETWEEN 7 AND 15: ");
                number = Convert.ToInt32(Console.ReadLine());

                for (int i = 7; i <= number; i += 2)
                {
                    sum += i;
                };

            }
            else
            {
                Console.Write("PLEASE ENTER ONLY ODD NUMBERS BETWEEN 7 AND 15: ");
                number = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"THE SUM OF ODD NUMBERS BETWEEN 7 to  IS:", sum);
            Console.ReadLine();
        }
    }
}

namespace Person
{


    class Employee
    {

        private int empId;
        private static string empName;

        public int EmployeeId
        {
            get
            {
                return empId;
            }

            set
            {
                empId = value;
            }
        }


        public static string EmployeeName
        {
            get
            {
                return empName;
            }

            set
            {
                empName = value;
            }
        }


        static void Main(string[] args)
        {

            Employee e = new Employee();

            int userInput = 67; //  Convert.ToInt32(Console.ReadLine());
            e.EmployeeId = userInput;
            Console.WriteLine("The employee id is " + e.EmployeeId);

            Employee.EmployeeName = "SSali";
            Console.WriteLine("The employee name is " + Employee.EmployeeName);

           

            array.typesOfArrays t = new array.typesOfArrays();
            t.
        }
    }
}
