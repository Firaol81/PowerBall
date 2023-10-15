using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Powerball_Ticket_Generator.Models;
using System.Linq;

namespace Powerball_Ticket_Generator.Controllers
{
    public class PowerBallController : Controller
    {
        private readonly LotteryContext _context;

        public PowerBallController(LotteryContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var powerballTickets = _context.Lottery.ToList();
            return View(powerballTickets);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Lottery lottery)
        {
            if (ModelState.IsValid)
            {
                _context.Lottery.Add(lottery);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lottery);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var lottery = _context.Lottery.Find(id);
            if (lottery == null)
            {
                return NotFound();
            }
            return View(lottery);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Lottery lottery)
        {
            if (id != lottery.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Entry(lottery).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(lottery);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var lottery = _context.Lottery.Find(id);
            if (lottery == null)
            {
                return NotFound();
            }
            return View(lottery);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var lottery = _context.Lottery.Find(id);
            if (lottery == null)
            {
                return NotFound();
            }
            _context.Lottery.Remove(lottery);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
