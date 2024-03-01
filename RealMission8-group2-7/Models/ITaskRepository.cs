namespace RealMission8_group2_7.Models
{
    public interface ITaskRepository
    {

        List<TaskModel> Tasks { get; }
        List<Categories> Categories { get; }
        
        public void AddTask(TaskModel task);
        public void UpdateTask(TaskModel task);

        public void DeleteTask(TaskModel task);

     
    }
}
