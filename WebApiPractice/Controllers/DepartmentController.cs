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
    public class DepartmentController : ControllerBase
    {
        public DepartmentService _service;

        public DepartmentController(DepartmentService service)
        {
            _service = service;
        }


        [HttpGet]
        public IActionResult GetDepartments()
        {
            var departments = _service.GetDepartments();
            return Ok(departments);

        }

        [HttpPost]
        public IActionResult AddDepartment(DepartmentVM vM)
        {
            _service.AddDepartment(vM);
            return Ok();
        }

        [HttpPut("update-department-by-id/{id}")]
        public IActionResult EditDepartment(int id, DepartmentVM vM)
        {
            var UpdatedDep = _service.EditDepartment(id, vM);
            return Ok(UpdatedDep);
        }

        [HttpDelete("delete-department-by-id/{id}")]
        public IActionResult DeleteDepartment(int id)
        {
            _service.DeleteDepartment(id);
            return Ok();
        }
    }
}
