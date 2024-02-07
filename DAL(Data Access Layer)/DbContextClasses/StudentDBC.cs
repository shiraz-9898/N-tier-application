using BOL_Business_Object_Layer_.StudentModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Data_Access_Layer_.DbContextClasses
{
    public class StudentDBC : DbContext
    {
        public StudentDBC(DbContextOptions<StudentDBC> options):base(options)
        {
            
        }

        public DbSet<Student> Students { get; set; }
    }
}
