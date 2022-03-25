// using Microsoft.AspNetCore.Mvc;
// using System.Collections.Generic;
// using Factory.Models;
// using Microsoft.EntityFrameworkCore;
// using System.Linq;
// using Microsoft.AspNetCore.Mvc.Rendering;

// namespace Factory.Controllers
// {
//   public class EngineersController : Controller
//   {
//     private readonly FactoryContext _db;
//     EngineersController(FactoryContext db)
//     {
//       _db = db;
//     }

//     public ActionResult Index()
//     {
//       return View(_db.Engineers.ToList());
//     }
//   }
// }