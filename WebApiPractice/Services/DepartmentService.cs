using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiPractice.Models;
using WebApiPractice.ViewModels;

namespace WebApiPractice.Services
{
    public class DepartmentService
    {
        AppDbContext _context;

        public DepartmentService(AppDbContext context)
        {
            _context = context;
        }

        public List<Department> GetDepartments() => _context.Departments.ToList();
        public void AddDepartment(DepartmentVM vM)
        {
            var _Dep = new Department
            {
                DepartmentName = vM.DepartmentName
            };

            _context.Departments.Add(_Dep);
            _context.SaveChanges();
        }


        public Department EditDepartment(int id, DepartmentVM vM)
        {
            var _Dep = _context.Departments.FirstOrDefault(n => n.DepartmentID == id);

            if (_Dep != null)
            {
                _Dep.DepartmentName = vM.DepartmentName;

                _context.SaveChanges();
            }

            return _Dep;
        }

        public void DeleteDepartment(int id)
        {
            var _Dep = _context.Departments.FirstOrDefault(n => n.DepartmentID == id);

            if (_Dep != null)
            {
                _context.Departments.Remove(_Dep);

                _context.SaveChanges();
            }

        }
    }
}
