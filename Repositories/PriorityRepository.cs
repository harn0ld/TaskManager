
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskManager.Models;

namespace TaskManager.Repositories
{
    public class PriorityRepository : IPriorityRepository
    {
        private readonly TaskManagerContext _context;

        public PriorityRepository(TaskManagerContext context)
        {
            _context = context;
        }

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
                // Inne aktualizowane pola

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

