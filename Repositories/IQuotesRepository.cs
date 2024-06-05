using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManager.Models;

namespace TaskManager.Repositories
{
    public interface IQuotesRepository
    {
        IEnumerable<Quotes> GetAllQuotes();
        Quotes GetRandomQuote();
    }
}
