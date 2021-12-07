using Capstone.Models;
using System.Collections.Generic;

namespace Capstone.DAO
{
    public interface IStudentSqlDao
    {
        List<Student> GetAllStudents();
    }
}