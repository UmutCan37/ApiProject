using ApiProject.WebApi.Context;
using ApiProject.WebApi.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeTasksController : ControllerBase
    {
        private readonly ApiContext _context;

        public EmployeeTasksController(ApiContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult EmployeTaskList()
        {
            var values = _context.EmployeeTasks.ToList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateEmployeTask(EmployeeTask EmployeTask)
        {
            _context.EmployeeTasks.Add(EmployeTask);
            _context.SaveChanges();
            return Ok(" ekleme işlemi başarılı");
        }

        [HttpDelete]
        public IActionResult DeleteEmployeTask(int id)
        {
            var value = _context.EmployeeTasks.Find(id);
            _context.EmployeeTasks.Remove(value);
            _context.SaveChanges();
            return Ok(" silme işlemi başarılı");
        }
        [HttpGet("GetEmployeTask")]
        public IActionResult GetEmployeTask(int id)
        {
            var value = _context.EmployeeTasks.Find(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateEmployeTask(EmployeeTask EmployeTask)
        {
            _context.EmployeeTasks.Update(EmployeTask);
            _context.SaveChanges();
            return Ok(" güncelleme işlemi başarılı");
        }
    }
}
