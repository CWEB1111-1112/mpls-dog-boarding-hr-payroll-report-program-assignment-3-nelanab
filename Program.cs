using System;

namespace assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarations
            string[] employeeNames = new string[100];
            int[] employeeDepartment = new int[100];
            double[] employeeSalary = new double[100];
            int[] employeeHours = new int[100];
            double[] grossSalary = new double[100];

            string[] departmentNames = {"Personnel", "Marketing", "Information Technology", "Computer Services", "Sales", "Legal", "Accounting"};
            double[] salaries = {0, 0, 0, 0, 0, 0, 0};

            string input = "0";

            int x = 0;

            while(input != "999"){
                Console.Write("Please enter employee name: ");
                employeeNames[x] = Console.ReadLine();

                Console.WriteLine("1. Personnel 2. Marketing 3. Information Technology 4. Computer Services 5. Sales 6. Legal 7. Accounting");
                Console.Write("Enter employee's department: ");
                int departmentTest = Convert.ToInt32(Console.ReadLine());
                if(departmentTest > 7 ){
                    Console.Write("Please enter a valid department number: ");
                    departmentTest = Convert.ToInt32(Console.ReadLine());
                }
                employeeDepartment[x] = departmentTest;

                Console.Write("Enter employee's salary: ");
                employeeSalary[x] = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter employee's hours: ");
                employeeHours[x] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("");

                grossSalary[x] = employeeSalary[x] * employeeHours[x]; 

                Console.WriteLine($"Employee Name: {employeeNames[x]} Employee Department: {departmentNames[employeeDepartment[x] - 1]} Employee Gross Salary: {grossSalary[x].ToString("c")}");

                Console.WriteLine("");
                Console.Write("Enter 0 to continue or QUIT to quit: ");
                string choice = Console.ReadLine();

                if(choice == "QUIT"){
                    input = "999";
                }
                else{
                    x=x+1;
                }

            }

            double [] departmentPayroll = new double [7];

            for(int e=0; e< employeeDepartment.Length; e++){
                if(employeeDepartment[e] == 1){
                    departmentPayroll[0] = departmentPayroll[0] + grossSalary[e];
                }
                if(employeeDepartment[e] == 2){
                    departmentPayroll[1] = departmentPayroll[1] + grossSalary[e];
                }
                if(employeeDepartment[e] == 3){
                    departmentPayroll[2] = departmentPayroll[2] + grossSalary[e];
                }
                if(employeeDepartment[e] == 4){
                    departmentPayroll[3] = departmentPayroll[3] + grossSalary[e];
                }
                if(employeeDepartment[e] == 5){
                    departmentPayroll[4] = departmentPayroll[4] + grossSalary[e];
                }
                if(employeeDepartment[e] == 6){
                    departmentPayroll[5] = departmentPayroll[5] + grossSalary[e];
                }
                if(employeeDepartment[e] == 7){
                    departmentPayroll[6] = departmentPayroll[6] + grossSalary[e];
                }
            }

            Console.WriteLine("");
            Console.WriteLine($"Personnel Payroll: {departmentPayroll[0].ToString("c")}");
            Console.WriteLine($"Marketing Payroll: {departmentPayroll[1].ToString("c")}");
            Console.WriteLine($"Information Technology Payroll: {departmentPayroll[2].ToString("c")}");
            Console.WriteLine($"Computer Services Payroll: {departmentPayroll[3].ToString("c")}");
            Console.WriteLine($"Sales Payroll: {departmentPayroll[4].ToString("c")}");
            Console.WriteLine($"Legal Payroll: {departmentPayroll[5].ToString("c")}");
            Console.WriteLine($"Accounting Payroll: {departmentPayroll[6].ToString("c")}");

            }

        }


    }
