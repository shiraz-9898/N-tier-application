using BOL_Business_Object_Layer_.StudentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Data_Access_Layer_.Interface
{
    public interface IStudentDAL
    {
        List<Student> GetAllStudentFromDB();
        Student GetStudentByIdFromDB(int id);
        Student AddStudentToDB(Student std);
        Student DeleteStudentFromDB(int id);
        Student UpdateStudentFromDB(Student std);
    }
}
