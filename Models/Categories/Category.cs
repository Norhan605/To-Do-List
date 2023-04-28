using TaskProject.Models.ToDoTasks;

namespace TaskProject.Models.Categories
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<ToDoTask> Tasks { get; set; }

    }
}
