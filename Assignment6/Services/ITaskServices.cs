using Assignment_3.Models;
namespace Assignment_3.Services
{
    public interface ITaskServices
    {
        public List<Tasks> CreateTasks(Tasks task);
        public List<Tasks> GetAllTasks();

        public Tasks GetTaskById(int id);
    }
}
