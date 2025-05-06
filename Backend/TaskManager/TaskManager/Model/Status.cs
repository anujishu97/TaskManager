namespace TaskManager.API.Model
{
    public class Status
    {
        public int Id { get; set; }             
        public string Description { get; set; } 

        public ICollection<TaskItem> Tasks { get; set; }
    }
}
