using BOL_Business_Object_Layer_.StudentModel;
using DAL_Data_Access_Layer_.DbContextClasses;
using DAL_Data_Access_Layer_.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Data_Access_Layer_.Services
{
    public class StudentDAL : IStudentDAL
    {
        private readonly StudentDBC _context;
        public StudentDAL(StudentDBC context)
        {
            _context = context;
        }

        public Student AddStudentToDB(Student std)
        {
            _context.Students.Add(std);
            _context.SaveChanges();
            return std;
        }

        public Student DeleteStudentFromDB(int id)
        {
            var data = _context.Students.Find(id);
            if (data != null)
            {
                _context.Students.Remove(data);
                _context.SaveChanges();
            }
            return data;
        }

        public List<Student> GetAllStudentFromDB()
        {
            var result = _context.Students.OrderBy(x => x.id).ToList();
            return result;
        }

        public Student GetStudentByIdFromDB(int id)
        {
            var data = _context.Students.FirstOrDefault(x => x.id == id);
            return data;
        }

        public Student UpdateStudentFromDB(Student std)
        {

            _context.Students.Update(std);
            _context.SaveChanges();

            return std;
        }
    }
}
