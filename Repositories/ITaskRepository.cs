using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManager.Models;

namespace TaskManager.Repositories
{
    public interface ITaskRepository
    {
        TaskModel Get(int taskId);
        IQueryable<TaskModel> GetAllActive();
        void Add(TaskModel task);
        void Update(int taskId, TaskModel task);
        void Delete(int taskId);

        // Metody dla tabeli Priority
        Priorities GetPriority(int priorityId);
        IQueryable<Priorities> GetAllPriorities();
        void AddPriority(Priorities priority);
        void UpdatePriority(int priorityId, Priorities priority);
        void DeletePriority(int priorityId);

    }
}
