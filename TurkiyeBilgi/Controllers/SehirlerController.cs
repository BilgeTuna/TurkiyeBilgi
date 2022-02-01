using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TurkiyeBilgi.Models;

namespace TurkiyeBilgi.Controllers
{
    public class SehirlerController : Controller
    {
        private readonly TurkiyeContext _db;

        public SehirlerController(TurkiyeContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.Sehirler.Include(x => x.Bolge).ToList());
        }
    }
}
