using Microsoft.AspNetCore.Mvc;
using TaskProject.Models.Categories;
using TaskProject.Models;
using TaskProject.Models.ToDoTasks;
using TaskProject.Models.Users;
using Microsoft.EntityFrameworkCore;

namespace TaskProject.Controllers
{
    public class ToDoTaskController : Controller
    {
        Context context = new Context();

        public IActionResult GetTask()
        {

            var task = context.ToDoTasks.ToList();
            return View("GetTask", task);
        }


        public ActionResult Filter(string searchString)
        {
            var tasks = context.ToDoTasks.Where(s=>s.Name.Contains(searchString)).ToList();
           
          
            return View("GetTask", tasks);
        }

        [Route("ToDoTask/GetTaskDetails/{id}")]
        public IActionResult GetTaskDetails(int id)
        {

            var task = context.ToDoTasks.Include(x=>x.Category).Include(x=>x.User).FirstOrDefault(x=>x.Id==id);
            ViewBag.TaskDetails = task;
            return View();
        }
        public IActionResult CreateTask()
        {

            return View();
        }
        [HttpPost]
        public IActionResult CreateTask(ToDoTask task)
        {

            context.Add(task);
            context.SaveChanges();

            return RedirectToAction("GetTask");
        }

        public IActionResult UpdateTask()
        {
            return View();
        }

        [HttpPost]

        public IActionResult UpdateTask(ToDoTask task)
        {

            context.Update(task);
            context.SaveChanges();

            return RedirectToAction("GetTask");
        }


        public IActionResult DeleteTask()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DeleteTask(int id)
        {
            Context context = new Context();
            var DeletedTask = context.ToDoTasks.Find(id);
            context.ToDoTasks.Remove(DeletedTask);
            context.SaveChanges();

            return RedirectToAction("GetTask");
        }
    }
}
