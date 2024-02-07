using BLL_Bussiness_Logic_Layer_.Interface;
using BOL_Business_Object_Layer_;
using BOL_Business_Object_Layer_.StudentModel;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace UI_User_Interface_.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentBLL _studentBLL;
        public StudentController(IStudentBLL studentBLL)
        {
            _studentBLL = studentBLL;
        }
        public IActionResult Index()
        {
            var data = _studentBLL.GetAllStudentsFromDAL();
            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student std)
        {
            if(ModelState.IsValid)
            {
                var data = _studentBLL.AddStudentToDAL(std);
                return RedirectToAction("Index");
            }
            return View(std);
        }

        public IActionResult Edit(int id)
        {
            if(id > 0)
            {
                var data = _studentBLL.GetStudentByIdFromDAL(id);
                return View(data);
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Edit(Student std)
        {
            if(ModelState.IsValid)
            {
                var data = _studentBLL.UpdateStudentFromDAL(std);
                return RedirectToAction("Index");
            }
            return View(std);
        }

        public IActionResult Delete(int id)
        {
            if (id > 0)
            {
                var data = _studentBLL.GetStudentByIdFromDAL(id);
                return View(data);
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteStudent(int id)
        {
            if(id > 0)
            {
                var data = _studentBLL.DeleteStudentFromDAL(id);
                return RedirectToAction("Index");
            }
            return View(id);
        }

        public IActionResult Details(int id)
        {
            if(id > 0)
            {
                var data = _studentBLL.GetStudentByIdFromDAL(id);
                return View(data);
            }
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
