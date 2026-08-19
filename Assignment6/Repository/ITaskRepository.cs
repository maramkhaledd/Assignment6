using Assignment_3.Models;
namespace Assignment_3.Repository
{
    public interface ITaskRepository
    {
        public List<Tasks> CreateTasks(Tasks task);

        public List<Tasks> GetAllTasks();

        public Tasks GetTaskById(int id);
    }
}
