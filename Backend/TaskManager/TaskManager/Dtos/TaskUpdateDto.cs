using System.ComponentModel.DataAnnotations;

namespace TaskManager.API.DTOs
{
    public class TaskUpdateDto : TaskCreateDto
    {
        [Required]
        public int TaskId { get; set; }
    }
}
