using Assignment_3.Models;
namespace Assignment6.Models
{
    public class User
    {
        public int Id { get; set; }
        public string name { get; set; }

        public string email { get; set; }
        public ICollection<Tasks> Task { get; set; }
        
    }
}
