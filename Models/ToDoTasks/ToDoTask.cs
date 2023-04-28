using TaskProject.Models.Categories;
using TaskProject.Models.Users;

namespace TaskProject.Models.ToDoTasks
{
    public class ToDoTask
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }

        public DateTime AssignDate { get; set; }
        public string Status { get; set; }

        public int  UserId { get; set; }
        public User User { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
