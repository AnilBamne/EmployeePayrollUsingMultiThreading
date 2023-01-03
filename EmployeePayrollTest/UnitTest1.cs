using EmployeePayrollMultiThreading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace EmployeePayrollTest
{
    [TestClass]
    public class UnitTest1
    {
        EmployeeRepository employeeRepository = new EmployeeRepository();

        [TestMethod]
        public void GivenEmployeeDetails_ReturnExecutionTime1()
        {

            List<EmployeeModel> emploeeModellist = new List<EmployeeModel>();
            emploeeModellist.Add(new EmployeeModel() { Name = "Dhiraj", BasicPay = 20700, gender = "M", Phone = 3453160, Department = "HR", Deductions = 1080, TaxablePay = 19070, IncomeTax = 734, NetPay = 18435 });
            emploeeModellist.Add(new EmployeeModel() { Name = "Girish", BasicPay = 30400, gender = "M", Phone = 3453160, Department = "R&D", Deductions = 1080, TaxablePay = 19070, IncomeTax = 734, NetPay = 28435 });
            emploeeModellist.Add(new EmployeeModel() { Name = "Naresh", BasicPay = 43500, gender = "M", Phone = 3453160, Department = "Sales", Deductions = 1080, TaxablePay = 19070, IncomeTax = 734, NetPay = 39435 });

            EmployeePayrollOperation employeePayroll = new EmployeePayrollOperation();
            DateTime startTime = DateTime.Now;
            employeePayroll.AddEmployeeToPayroll(emploeeModellist);
            DateTime endTime = DateTime.Now;
            Console.WriteLine("Duration without thread = " + (endTime - startTime));
        }

            [TestMethod]
        public void GivenEmployeeDetails_ReturnExecutionTime2()
        {

            //List<EmployeeModel> emploeeModellist = new List<EmployeeModel>();
            //emploeeModellist.Add(new EmployeeModel() { Name = "Dhiraj", BasicPay = 20700, gender = "M", Phone = 3453160, Department = "HR", Deductions = 1080, TaxablePay = 19070, IncomeTax = 734, NetPay = 18435 });
            //emploeeModellist.Add(new EmployeeModel() { Name = "Girish", BasicPay = 30400, gender = "M", Phone = 3453160, Department = "R&D", Deductions = 1080, TaxablePay = 19070, IncomeTax = 734, NetPay = 28435 });
            //emploeeModellist.Add(new EmployeeModel() { Name = "Naresh", BasicPay = 43500, gender = "M", Phone = 3453160, Department = "Sales", Deductions = 1080, TaxablePay = 19070, IncomeTax = 734, NetPay = 39435 });

            //EmployeePayrollOperation employeePayroll = new EmployeePayrollOperation();
            //DateTime startTime = DateTime.Now;
            //employeePayroll.AddEmployeeToPayroll(emploeeModellist);
            //DateTime endTime = DateTime.Now;
            //Console.WriteLine("Duration without thread = " + (endTime - startTime));


            //------------------------------------------

            EmployeeModel employeeModel = new EmployeeModel
            {
                Name = "Nandini",
                BasicPay = 20700,
                gender = "F",
                Phone = 3453160,
                Department = "HR",
                Deductions = 1080,
                TaxablePay = 19070,
                IncomeTax = 734,
                NetPay = 18435

        };
            DateTime startTimes = DateTime.Now;
            employeeRepository.AddEmployee(employeeModel);
            DateTime endTimes = DateTime.Now;
            Console.WriteLine("Duration without thread = " + (endTimes - startTimes));
        }
    }
}
