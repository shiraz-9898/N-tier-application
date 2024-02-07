using BLL_Bussiness_Logic_Layer_.Interface;
using BOL_Business_Object_Layer_.StudentModel;
using DAL_Data_Access_Layer_.Interface;
using DAL_Data_Access_Layer_.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Bussiness_Logic_Layer_.Services
{
    public class StudentBLL : IStudentBLL
    {
        private readonly IStudentDAL _studentDAL;
        public StudentBLL(IStudentDAL studentDAL)
        {
           _studentDAL = studentDAL;
        }

        public Student AddStudentToDAL(Student std)
        {
            var data = _studentDAL.AddStudentToDB(std);
            return data;
        }

        public Student DeleteStudentFromDAL(int id)
        {
            var data = _studentDAL.DeleteStudentFromDB(id);
            return data;
        }

        List<Student> IStudentBLL.GetAllStudentsFromDAL()
        {
            return _studentDAL.GetAllStudentFromDB();
        }

        public Student GetStudentByIdFromDAL(int id)
        {
            var data = _studentDAL.GetStudentByIdFromDB(id);
            return data;
        }

        public Student UpdateStudentFromDAL(Student std)
        {
            var data = _studentDAL.UpdateStudentFromDB(std);
            return data;
        }
    }
}
