using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollMultiThreading
{
    public class EmployeePayrollOperation
    {
        public List<EmployeeModel> employeeModelList = new List<EmployeeModel>();
        EmployeeRepository employeeRepo = new EmployeeRepository();

        /// <summary>
        /// Adds the employee to payroll.
        /// </summary>
        /// <param name="employeelist">The employeelist.</param>
        public void AddEmployeeToPayroll(List<EmployeeModel> employeelist)
        {
            employeelist.ForEach(employeeData =>
            {
                Console.WriteLine("Employee being added = " + employeeData.Name);
                this.AddEmployeeToPayroll(employeeData);
                Console.WriteLine("Employee added =" + employeeData.Name);
            });
            Console.WriteLine(this.employeeModelList.ToString());
        }

        /// <summary>
        /// Adds the employee to payroll.
        /// </summary>
        /// <param name="employeeData">The employee data.</param>
        public void AddEmployeeToPayroll(EmployeeModel employeeData)
        {
            employeeModelList.Add(employeeData);

        }
    }
}
