using TaskManager.API.DTOs;
using TaskManager.API.Model;
using TaskManager.API.Repositories;

namespace TaskManager.API.Services
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _repo;

        public TaskService(ITaskRepository repo) => _repo = repo;

        public async Task<List<TaskItem>> GetAllTasksAsync() => await _repo.GetAllAsync();

        public async Task<TaskItem> CreateTaskAsync(TaskCreateDto dto)
        {
            var task = new TaskItem
            {
                Title = dto.Title,
                Description = dto.Description,
                DueDate = dto.DueDate,
                StatusId = dto.StatusId
            };
            await _repo.AddAsync(task);
            return task;
        }

        public async Task<TaskItem> UpdateTaskAsync(int id, TaskUpdateDto dto)
        {
            var task = await _repo.GetByIdAsync(id);
            if (task == null) throw new Exception("Task not found");

            task.Title = dto.Title;
            task.Description = dto.Description;
            task.DueDate = dto.DueDate;
            task.StatusId = dto.StatusId;

            await _repo.UpdateAsync(task);
            return task;
        }

        public async Task DeleteTaskAsync(int id)
        {
            var task = await _repo.GetByIdAsync(id);
            if (task == null) throw new Exception("Task not found");
            await _repo.DeleteAsync(task);
        }
    }
}
