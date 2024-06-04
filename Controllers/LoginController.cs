using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
using TaskManager.Models;
using TaskManager.Repositories;
using System.Linq;


namespace TaskManager.Controllers
{
    public class LoginController : Controller
    {
        private readonly TaskManagerContext _context;

        public LoginController(TaskManagerContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string username, string password)
        {
            var passwordHash = ComputeHash(password);
            var user = _context.Logins.FirstOrDefault(u => u.Username == username && u.PasswordHash == passwordHash);
            if (user != null)
            {
                HttpContext.Session.SetString("User", username);
                return RedirectToAction("Welcome");
            }
            ModelState.AddModelError("", "Invalid username or password");
            return View();
        }

        [HttpGet]
        public IActionResult Welcome()
        {
            if (HttpContext.Session.GetString("User") != null)
            {
                return View("~/Views/Task/Index.cshtml");
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            Console.Write(ModelState.IsValid);
            if (ModelState.IsValid)
            {
                var existingUser = _context.Logins.FirstOrDefault(u => u.Username == model.Username);
                if (existingUser != null)
                {
                    ModelState.AddModelError("", "Username already exists.");
                    return View(model);
                }

                var newUser = new Login
                {
                    Username = model.Username,
                    PasswordHash = ComputeHash(model.Password)
                };

                _context.Logins.Add(newUser);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(model);
        }

        private string ComputeHash(string input)
        {
            using (var md5 = MD5.Create())
            {
                var bytes = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
                var sb = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    sb.Append(bytes[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }
    }
}
