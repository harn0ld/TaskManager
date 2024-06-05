using Microsoft.AspNetCore.Mvc;
using TaskManager.Models;
using TaskManager.Repositories;

namespace TaskManager.Controllers
{
    public class QuotesController : Controller
    {
        private readonly IQuotesRepository _quotesRepository;

        public QuotesController(IQuotesRepository quotesRepository)
        {
            _quotesRepository = quotesRepository;
        }

        // Akcja do wyświetlenia listy cytatów
        public IActionResult Index()
        {
            var quotes = _quotesRepository.GetAllQuotes();
            var randomQuote = _quotesRepository.GetRandomQuote();
            ViewBag.RandomQuote = randomQuote; 
            return View(quotes);
        }

        // Inne akcje do dodawania, edycji, usuwania itp., jeśli są potrzebne
    }
}
