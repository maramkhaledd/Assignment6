using Assignment_3.Repository;
using Assignment_3.Models;
namespace Assignment_3.Services
{
    public class TaskServices : ITaskServices
    {
        private ITaskRepository tasks;

        

        public TaskServices(ITaskRepository tasks)
        {
            this.tasks = tasks;
        }
        public List<Tasks> CreateTasks(Tasks task)
        {


                return tasks.CreateTasks(task);
        }

        public List<Tasks> GetAllTasks()
        {

            return tasks.GetAllTasks();
        }

        public Tasks GetTaskById(int id)
        {
            return tasks.GetTaskById(id);
        }
    }
}
