
namespace RealMission8_group2_7.Models
{
    public class EFTaskRepository : ITaskRepository
    {
        private Mission8ApplicationContext _context;
        public EFTaskRepository(Mission8ApplicationContext temp) 
        {
            _context = temp;
        }


        public List<TaskModel> Tasks => _context.Tasks.ToList();

        public List<Categories> Categories => _context.Categories.ToList();

        public void AddTask(TaskModel task)
        {
            _context.Add(task);
            _context.SaveChanges();
        }

        public void UpdateTask(TaskModel task)
        {
            _context.Update(task);
            _context.SaveChanges();
        }

        public void DeleteTask(TaskModel task)
        {
            _context.Remove(task);
            _context.SaveChanges();
        }

       
    }
}
