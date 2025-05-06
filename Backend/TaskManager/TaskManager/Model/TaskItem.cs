namespace TaskManager.API.Model
{
    public class TaskItem
    {
        public int TaskId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }

        public int StatusId { get; set; }          
        public Status Status { get; set; }        
    }
}