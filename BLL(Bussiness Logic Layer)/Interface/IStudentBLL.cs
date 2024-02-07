using BOL_Business_Object_Layer_.StudentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Bussiness_Logic_Layer_.Interface
{
    public interface IStudentBLL
    {
        List<Student> GetAllStudentsFromDAL();
        Student GetStudentByIdFromDAL(int id);
        Student AddStudentToDAL(Student std);
        Student DeleteStudentFromDAL(int id);
        Student UpdateStudentFromDAL(Student std);
    }
}
