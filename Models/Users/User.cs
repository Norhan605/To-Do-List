using TaskProject.Models.ToDoTasks;

namespace TaskProject.Models.Users
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public ICollection<ToDoTask> Tasks { get; set; }
    }
}
