using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollMultiThreading
{
    public class EmployeeModel
    {
        /// <summary>
        /// created properties 
        /// </summary>
        public int ID { get; set; }
        public string Name { get; set; }
        public double BasicPay { get; set; }
        public DateTime StartDate { get; set; }
        public string gender { get; set; }
        public Int64 Phone { get; set; }
        public string Address { get; set; }
        public string Department { get; set; }
        public double Deductions { get; set; }
        public double TaxablePay { get; set; }
        public double IncomeTax { get; set; }
        public double NetPay { get; set; }


    }
}
