using HotelRegistry.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace HotelRegistry.Controllers
{
	public class HomeController : Controller
	{
		HotelContext db;

		public HomeController(HotelContext context)
		{
			db = context;
		}

		public IActionResult Index()
		{
			return View(db.Hotels.ToList());
		}

		public IActionResult Details(int id)
		{
			ViewBag.Name = db.Hotels.FirstOrDefault(x => x.Id == id).Name;
			ViewBag.Address = db.Hotels.FirstOrDefault(x => x.Id == id).Address;

			return View();
		}

		[HttpGet]
		public IActionResult CreateNew(string name, string address)
		{
			ViewBag.Name = name;
			ViewBag.Address = address;

			return View();
		}

		[HttpPost]
		public IActionResult CreateNew(Hotel hotel)
		{
			db.Hotels.Add(hotel);
			db.SaveChanges();

			return RedirectToAction("Index");
		}

		[HttpGet]
		public IActionResult Change(int id)
		{
			ViewBag.Id = id;

			return View();
		}

		[HttpPost]
		public IActionResult Change(Hotel hotel)
		{
			db.Update(hotel);
			db.SaveChanges();

			return RedirectToAction("Index");
		}

		public IActionResult Delete(int id)
		{
			var hotel = db.Hotels.FirstOrDefault(x => x.Id == id);
			db.Hotels.Remove(hotel);
			db.SaveChanges();

			return View();
		}
	}
}