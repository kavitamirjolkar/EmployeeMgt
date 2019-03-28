// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EmployeeController.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Kavita Mirjolkar"/>
// --------------------------------------------------------------------------------------------------------------------
namespace WebApplication.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using WebApplication.AccessData;
    using WebApplication.Models;

    /// <summary>
    /// this is employee controller class
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        /// <summary>
        /// Gets or sets the employee data access layer.
        /// </summary>
        /// <value>
        /// The employee data access layer.
        /// </value>
        public EmployeeDataAccessLayer EmployeeDataAccessLayer { get; set; }

        /// <summary>
        /// get all employees
        /// </summary>
        /// <returns>list of employee</returns>
        [HttpGet]
        public IEnumerable<Employee> GetData()
        {
            EmployeeDataAccessLayer = new EmployeeDataAccessLayer();
            return this.EmployeeDataAccessLayer.GetAllEmployees();
        }

        /// <summary>
        /// add new employee to database
        /// </summary>
        /// <param name="employee">The employee</param>
        /// <returns>bool value</returns>
        [HttpPost]
        [Route("create")]
        public bool AddData(Employee employee)
        {
            EmployeeDataAccessLayer = new EmployeeDataAccessLayer();
            this.EmployeeDataAccessLayer.AddEmployee(employee);
            return true;
        }

        /// <summary>
        /// update employee details
        /// </summary>
        /// <param name="employee">the employee</param>
        /// <returns>bool value</returns>
        [HttpPut]
        [Route("update")]
        public bool UpdateData(Employee employee)
        {
            EmployeeDataAccessLayer = new EmployeeDataAccessLayer();
            this.EmployeeDataAccessLayer.UpdateEmployee(employee);
            return true;
        }

        /// <summary>
        /// delete employee details
        /// </summary>
        /// <param name="id">the id</param>
        /// <returns>bool value</returns>
        [HttpDelete]
        [Route("delete/{id}")]
        public bool DeleteData(int id)
        {
            EmployeeDataAccessLayer = new EmployeeDataAccessLayer();
            this.EmployeeDataAccessLayer.DeleteEmployee(id);
            return true;
        }

        /// <summary>
        /// get employee details by id
        /// </summary>
        /// <param name="id">the id</param>
        /// <returns>details of employee</returns>
        [HttpGet]
        [Route("get/{id}")]
        public Employee GetDataById(int id)
        {
            EmployeeDataAccessLayer = new EmployeeDataAccessLayer();
            return this.EmployeeDataAccessLayer.GetEmployeeData(id);
        }
    }
}