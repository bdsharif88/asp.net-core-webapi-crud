using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiPractice.Models;
using WebApiPractice.ViewModels;

namespace WebApiPractice.Services
{
    public class EmployeeService
    {
        AppDbContext _context;

        public EmployeeService(AppDbContext context)
        {
            _context = context;
        }

        public List<Employee> GetEmployees() => _context.Employees.ToList();
        public void AddEmployee(EmployeeVM empVM)
        {
            var _Emp = new Employee
            {
                EmployeeName = empVM.EmployeeName,
                Department = empVM.Department,
                DateOfJoining = empVM.DateOfJoining
            };

            _context.Employees.Add(_Emp);
            _context.SaveChanges();
        }

        public Employee UpdateEmployee(int empid, EmployeeVM vM)
        {
            var _Emp = _context.Employees.FirstOrDefault(n => n.EmployeeID == empid);

            if (_Emp != null)
            {
                _Emp.EmployeeName = vM.EmployeeName;
                _Emp.Department = vM.Department;
                _Emp.DateOfJoining = vM.DateOfJoining;

                _context.SaveChanges();
            }

            return _Emp;
                
        }

        public void DelteEmployee(int empid)
        {
            var _Emp = _context.Employees.First(n => n.EmployeeID == empid);

            if (_Emp != null)
            {
                _context.Employees.Remove(_Emp);
                _context.SaveChanges();
            }
        }

        
    }
}
