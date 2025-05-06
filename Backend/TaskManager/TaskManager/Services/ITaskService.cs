using TaskManager.API.DTOs;
using TaskManager.API.Model;

namespace TaskManager.API.Services
{
    public interface ITaskService
    {
        Task<List<TaskItem>> GetAllTasksAsync();
        Task<TaskItem> CreateTaskAsync(TaskCreateDto dto);
        Task<TaskItem> UpdateTaskAsync(int id, TaskUpdateDto dto);
        Task DeleteTaskAsync(int id);
    }
}
