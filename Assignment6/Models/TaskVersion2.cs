namespace Assignment_3.Models
{
    public class TaskVersion2
    {
        public int Id { get; set; }

        public string? Title { get; set; }
        public string? Status { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime CreatedAt{ get; set; }
        public bool isCompleted { get; set; }
    }
}
