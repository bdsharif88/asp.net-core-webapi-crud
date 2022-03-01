using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiPractice.Services;
using WebApiPractice.ViewModels;

namespace WebApiPractice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public EmployeeService _service;

        public EmployeeController(EmployeeService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetEmployees()
        {
            var employees = _service.GetEmployees();
            return Ok(employees);
        }

        [HttpPost]

        public IActionResult AddEmployee(EmployeeVM vM)
        {
            _service.AddEmployee(vM);
            return Ok();
        }

        [HttpPut("update-employee-by-id/{id}")]
        public IActionResult UpdateEmployee(int id, EmployeeVM vM)
        {
           var UpdatedEmp = _service.UpdateEmployee(id, vM);
            return Ok(UpdatedEmp);
        }

        [HttpDelete("delete-employee-by-id/{id}")]
        public IActionResult DelteEmployee(int id)
        {
            _service.DelteEmployee(id);
            return Ok();
        }
    }
}
