using System.ComponentModel.DataAnnotations;

namespace TaskManager.API.DTOs
{
    public class TaskCreateDto
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public DateTime DueDate { get; set; }

        [Required]
        public int StatusId { get; set; }
    }
}