using DatabaseFirstApproach.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatabaseFirstApproach.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeesController : Controller
    {
        private readonly DatabaseFirstApproachContext _context;

        public EmployeesController(DatabaseFirstApproachContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetEmployees()
        {
            try{
                var employees = await _context.Employees.ToListAsync();
                return Ok(employees);

            }catch(Exception ex){
                throw;
            }
            
        }
    }
}



