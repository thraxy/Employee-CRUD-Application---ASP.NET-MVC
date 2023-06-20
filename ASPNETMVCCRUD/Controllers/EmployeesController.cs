using ASPNETMVCCRUD.Data;
using ASPNETMVCCRUD.Models;
using ASPNETMVCCRUD.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using MySql.EntityFrameworkCore;

namespace ASPNETMVCCRUD.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly MVCDemonDbContext mvcDemonDbContext;

        public EmployeesController(MVCDemonDbContext mvcDemonDbContext)
        {
            this.mvcDemonDbContext = mvcDemonDbContext;
        }


        // add a new employee
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(AddEmployeeViewModel addEmployeeRequest)
        {
            var employee = new Employee()
            {
                Id = Guid.NewGuid(),
                Name = addEmployeeRequest.Name,
                Email = addEmployeeRequest.Email,
                Salary = addEmployeeRequest.Salary,
                Department = addEmployeeRequest.Department,
                DateOfBirth = addEmployeeRequest.DateOfBirth
            };

            await mvcDemonDbContext.Employees.AddAsync(employee);
            await mvcDemonDbContext.SaveChangesAsync();
            return RedirectToAction("Add");
        }
    }
        
}
