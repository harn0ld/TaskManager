using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManager.Models;

namespace TaskManager.Repositories
{
    public interface IPriorityRepository
    {
        // Metody dla tabeli Priority
        Priorities GetPriority(int priorityId);
        IQueryable<Priorities> GetAllPriorities();
        void AddPriority(Priorities priority);
        void UpdatePriority(int priorityId, Priorities priority);
        void DeletePriority(int priorityId);

    }
}
