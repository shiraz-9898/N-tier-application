using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL_Business_Object_Layer_.StudentModel
{
    public class Student
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; }
        public string contact {  get; set; }
        public string gender { get; set; }
        public string standard { get; set; }
    }
}
