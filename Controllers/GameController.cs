using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CaraCara.ViewModel;
using CaraCara.Models;
using CaraCara.Data;

namespace CaraCara.Controllers
{
    public class GameController : Controller
    {
        private readonly ApplicationDbContext _context;
        public GameController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            GameViewModel GameData = new GameViewModel();
            GameData.Chars = new List<Character>();
            GameData.Chars = _context.Chars.ToList();
            return View(GameData);
        }
    }
}