using Assignment6.Models;
namespace Assignment_3.Models
{
    public class Tasks
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsCompleted { get; set; }
        public int UserId { get; set; }
        public User user { get; set; }
    }
}
