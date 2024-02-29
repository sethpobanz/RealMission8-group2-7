namespace RealMission8_group2_7.Models
{
    public interface ITaskRepository
    {

        List<TaskModel> Tasks { get; }

        public void AddTask(TaskModel task);
        public void UpdateTask(TaskModel task);
    }
}
