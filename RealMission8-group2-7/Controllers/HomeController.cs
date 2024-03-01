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
            return View(new TaskModel());
        }

        [HttpPost]
        public IActionResult Form(TaskModel response)
        {
            _repo.AddTask(response);

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
            var recordToEdit = _repo.Tasks.Single(x => x.TaskId == id);

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
            var recordToDelete = _repo.Tasks.Single(y => y.TaskId == id);

            return View(recordToDelete);

        }

        [HttpPost]
        public IActionResult Delete(TaskModel tasktodelete)
        {
            _repo.DeleteTask(tasktodelete);
            return RedirectToAction("Quadrant");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
