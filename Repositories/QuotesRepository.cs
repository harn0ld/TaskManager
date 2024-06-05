
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskManager.Models;

namespace TaskManager.Repositories
{
    public class QuotesRepository : IQuotesRepository
    {
        private readonly TaskManagerContext _context;

        public QuotesRepository(TaskManagerContext context)
        {
            _context = context;
        }

        public IEnumerable<Quotes> GetAllQuotes()
        {
            return _context.Quotes.ToList();
        }

        public Quotes GetRandomQuote()
        {
            var count = _context.Quotes.Count();
            if (count == 0) return null;
            var randomIndex = new Random().Next(0, count);
            return _context.Quotes.Skip(randomIndex).FirstOrDefault();
        }

        // Implementacja innych metod do dodawania, edycji, usuwania cytatów, jeśli są potrzebne
    }
}

