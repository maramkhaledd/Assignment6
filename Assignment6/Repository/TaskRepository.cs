using Assignment_3.Models;
using Assignment_3.Middleware;
namespace Assignment_3.Repository
{
    public class TaskRepository : ITaskRepository
    {
        private List <Tasks> tasks = new List <Tasks> ();
   
      

        public List<Tasks> CreateTasks(Tasks task)
        {
            foreach (Tasks t in tasks) 
            { if(t.Id == task.Id)
                {
                    throw new ConflictException("This task already exists");
                }
            }

            tasks.Add(task);
            return tasks;
        }

        public List<Tasks> GetAllTasks() 
        {
            return tasks;
        }

        public Tasks GetTaskById(int id)
        {
           foreach (Tasks t in tasks)
            {
                if (t.Id == id)
                {
                    return t;
                }
            }
            return null;
        }
    }
}
