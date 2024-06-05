using Microsoft.AspNetCore.Mvc;
using TaskManager.Models;
using TaskManager.Repositories;

namespace TaskManager.Controllers
{
    public class PriorityController : Controller
    {
        private readonly IPriorityRepository _priorityRepository;

        public PriorityController(IPriorityRepository priorityRepository)
        {
            _priorityRepository = priorityRepository;
        }

        // Akcja do wyświetlenia listy priorytetów
        public IActionResult Index()
        {
            var priorities = _priorityRepository.GetAllPriorities();
            return View(priorities);
        }

        // Inne akcje do dodawania, edycji, usuwania itp., jeśli są potrzebne
    }
}
