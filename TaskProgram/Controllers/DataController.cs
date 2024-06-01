// public class DataController : Controller
// {
//     private readonly ApplicationDbContext _context;

//     public DataController(ApplicationDbContext context)
//     {
//         _context = context;
//     }

//     public IActionResult Index()
//     {
//         if (HttpContext.Session.GetString("User") == null)
//         {
//             return RedirectToAction("Index", "Login");
//         }

//         var data = _context.Datas.ToList();
//         return View(data);
//     }

//     [HttpGet]
//     public IActionResult Create()
//     {
//         if (HttpContext.Session.GetString("User") == null)
//         {
//             return RedirectToAction("Index", "Login");
//         }

//         return View();
//     }

//     [HttpPost]
//     public IActionResult Create(Data data)
//     {
//         if (HttpContext.Session.GetString("User") == null)
//         {
//             return RedirectToAction("Index", "Login");
//         }

//         _context.Datas.Add(data);
//         _context.SaveChanges();
//         return RedirectToAction("Index");
//     }
// }