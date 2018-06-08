using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ADO_Test.Models;
using System.Data;
using System.Data.SqlClient;

namespace ADO_Test.Controllers
{
    [Produces("application/json")]
    [Route("api/Employee")]
    public class EmployeeController : Controller
    {
        private string connectionString = "Server=SBETHIREDDY01;database=Employee;Trusted_Connection=True;MultipleActiveResultSets=true";
        [HttpDelete("{id}")]
        public void DeleteEmployee(int id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("DeleteEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@employeeId", id);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        [HttpPost]
        public void AddEmployee([FromBody]EmployeeInformation employee)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("AddEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", employee.Id);
                cmd.Parameters.AddWithValue("@Name", employee.Name);
                cmd.Parameters.AddWithValue("@City", employee.City);
                cmd.Parameters.AddWithValue("@Department", employee.Department);
                cmd.Parameters.AddWithValue("@Gender", employee.Gender);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

        }
        public List<EmployeeInformation> GetEmployee()
        {
            List<EmployeeInformation> newemployee = new List<EmployeeInformation>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("GetEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    EmployeeInformation employee = new EmployeeInformation();
                    employee.Id = Convert.ToInt32(rdr["EmployeeID"]);
                    employee.Name = rdr["Name"].ToString();
                    employee.City = rdr["City"].ToString();
                    employee.Department = rdr["Department"].ToString();
                    employee.Gender = rdr["Gender"].ToString();
                    newemployee.Add(employee);
                }
                con.Close();
            }
            return newemployee;
        }
        public void UpdateEmployee([FromBody]EmployeeInformation employee)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("UpdateEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmployeeId", employee.Id);
                cmd.Parameters.AddWithValue("@Name", employee.Name);
                cmd.Parameters.AddWithValue("@City", employee.City);
                cmd.Parameters.AddWithValue("@Department", employee.Department);
                cmd.Parameters.AddWithValue("@Gender", employee.Gender);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}

