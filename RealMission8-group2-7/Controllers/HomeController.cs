using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RealMission8_group2_7.Models;
using System.Diagnostics;

namespace RealMission8_group2_7.Controllers
{
    public class HomeController : Controller
    {
        private ITaskRepository _repo;

        public HomeController(ITaskRepository temp)
        {
            _repo = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Quadrant()
        {
            var tasks = _repo.Tasks.ToList();
            return View(tasks);
        }

        [HttpGet]
        public IActionResult Form()
        {
            ViewBag.Categories = _repo.Categories.OrderBy(x => x.Category).ToList();
            return View(new TaskModel());
        }

        [HttpPost]
        public IActionResult Form(TaskModel response)
        {
            _repo.AddTask(response);

            ViewBag.Categories = _repo.Categories.OrderBy(x => x.Category).ToList();

            return RedirectToAction("Success");
        }

        [HttpGet]
        public IActionResult Success()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var recordToEdit = _repo.Tasks.SingleOrDefault(x => x.TaskId == id);
            if (recordToEdit == null)
            {
                return NotFound(); // or handle the case where the task doesn't exist
            }
            ViewBag.Categories = _repo.Categories.ToList();

            return View("Form", recordToEdit);
        }


        [HttpPost]
        public IActionResult Edit(TaskModel updatedTask)
        {
            _repo.UpdateTask(updatedTask);

            return RedirectToAction("Quadrant");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var recordToDelete = _repo.Tasks.SingleOrDefault(y => y.TaskId == id);
            if (recordToDelete == null)
            {
                return NotFound(); // or handle the case where the task doesn't exist
            }

            return View(recordToDelete);
        }


        [HttpPost]
        public IActionResult Delete(TaskModel tasktodelete)
        {
            _repo.DeleteTask(tasktodelete);
            return RedirectToAction("Quadrant");
        }

        [HttpGet]
        public IActionResult Completed(int id)
        {
            var recordToComplete = _repo.Tasks.SingleOrDefault(y => y.TaskId == id);
            if (recordToComplete == null)
            {
                return NotFound(); // or handle the case where the task doesn't exist
            }

            return View(recordToComplete);
        }


        [HttpPost]
        public IActionResult Completed(TaskModel tasktocomplete)
        {
            _repo.UpdateTask(tasktocomplete);
            return RedirectToAction("Quadrant");
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
