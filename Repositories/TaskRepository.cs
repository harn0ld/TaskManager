using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManager.Models;

namespace TaskManager.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly TaskManagerContext _context;
        public TaskRepository(TaskManagerContext context)
        {
            _context = context;
        }

        //// Implementacje metod dla
        public TaskModel Get(int taskId)
            => _context.Tasks.SingleOrDefault(x => x.TaskId == taskId);

        public IQueryable<TaskModel> GetAllActive()
            => _context.Tasks.Where(x => !x.Done);

        public void Add(TaskModel task)
        {
            _context.Tasks.Add(task);
            _context.SaveChanges();
        }

        public void Update(int taskId, TaskModel task)
        {
            var result = _context.Tasks.SingleOrDefault(x => x.TaskId == taskId);
            if (result != null)
            {
                result.Name = task.Name;
                result.Description = task.Description;
                result.Done = task.Done;

                _context.SaveChanges();
            }
        }

        public void Delete(int taskId)
        {
            var result = _context.Tasks.SingleOrDefault(x => x.TaskId == taskId);
            if (result != null)
            {
                _context.Tasks.Remove(result);
                _context.SaveChanges();
            }
        }



        // Implementacje metod dla Priority
        public Priorities GetPriority(int priorityId)
        {
            return _context.Priorities.Find(priorityId);
        }

        public IQueryable<Priorities> GetAllPriorities()
        {
            return _context.Priorities;
        }

        public void AddPriority(Priorities priority)
        {
            _context.Priorities.Add(priority);
            _context.SaveChanges();
        }

        public void UpdatePriority(int priorityId, Priorities priority)
        {
            var existingPriority = _context.Priorities.Find(priorityId);
            if (existingPriority != null)
            {
                existingPriority.PriorityType = priority.PriorityType;
                existingPriority.Reason = priority.Reason;
                _context.SaveChanges();
            }
        }

        public void DeletePriority(int priorityId)
        {
            var priority = _context.Priorities.Find(priorityId);
            if (priority != null)
            {
                _context.Priorities.Remove(priority);
                _context.SaveChanges();
            }
        }
    }
}
