using Microsoft.AspNetCore.Mvc;
using Capstone.DAO;
using Capstone.Models;
using Capstone.Security;
using System.Collections.Generic;

namespace Capstone.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        private readonly IStudentSqlDao studentDao;
        public StudentController(IStudentSqlDao _studentDao)
        {
            studentDao = _studentDao;
        }

        [HttpGet]
        public ActionResult<List<Student>> GetAllStudents()
        {
            List<Student> students = studentDao.GetAllStudents();
            return Ok(students);
        }
    }
}
