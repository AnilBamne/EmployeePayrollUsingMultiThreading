using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollMultiThreading
{
    public class EmployeeRepository
    {
        public static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PayrollService;Integrated Security=True;";
        SqlConnection connection = new SqlConnection(connectionString);

        /// <summary>
        /// Check connection with data base
        /// </summary>
        public void CheckConnection()
        {
            try
            {
                this.connection.Open();
                Console.WriteLine("Connection Established");
                this.connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Connection not established");
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Adding data to DB and usig StoredProcedure AddEmployee
        /// </summary>
        /// <param name="employeeModel"></param>
        /// <exception cref="Exception"></exception>
        public bool AddEmployee(EmployeeModel employeeModel)
        {
            try
            {
                using (this.connection)
                {
                    // not initializing ID becayse id is in auto increament and Address is default
                    SqlCommand cmd = new SqlCommand("AddEmployee", this.connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Name", employeeModel.Name);
                    cmd.Parameters.AddWithValue("@Phone", employeeModel.Phone);
                    cmd.Parameters.AddWithValue("@Department", employeeModel.Department);
                    cmd.Parameters.AddWithValue("@gender", employeeModel.gender);
                    cmd.Parameters.AddWithValue("@BasicPay", employeeModel.BasicPay);
                    cmd.Parameters.AddWithValue("@Deductions", employeeModel.Deductions);
                    cmd.Parameters.AddWithValue("@TaxablePay", employeeModel.TaxablePay);
                    cmd.Parameters.AddWithValue("@IncomeTax", employeeModel.IncomeTax);
                    cmd.Parameters.AddWithValue("@NetPay", employeeModel.NetPay);
                    cmd.Parameters.AddWithValue("@StartDate", DateTime.Now);
                    this.connection.Open();
                    var count=cmd.ExecuteNonQuery();
                    this.connection.Close();
                    if (count != 0)
                    {
                        //Console.WriteLine("Employee has been Added successfully into the table .");
                        return true;
                    }
                    else
                    {
                        //Console.WriteLine("Insert Query failed");
                        return false;
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                this.connection.Close();
            }
        }
    }
}
