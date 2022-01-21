using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Controllers
{
    public class CarsController : Controller
    {
        // GET: CarsController
        public ActionResult Index()
        {
            //return View();
            var Car = from a in Carros()
                      orderby a.Id
                      select a;
            return View(Car);
        }

        // GET: CarsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CarsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CarsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CarsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CarsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CarsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CarsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        [NonAction]
        public List<Cars> Carros()
        {
            return new List<Cars>
            {
                new Cars
                {
                    Id=1,
                    Nombre="Auris",
                    Marca="toyota",
                    AñoSalida=2010,

                },
                new Cars
                {
                    Id=2,
                    Nombre="Cx9",
                    Marca="Mazda",
                    AñoSalida=2016,
                },
                new Cars
                {
                    Id=3,
                    Nombre="Citan",
                    Marca="Mercedes",
                    AñoSalida=2018,

                }



            };
        }
    }
}
