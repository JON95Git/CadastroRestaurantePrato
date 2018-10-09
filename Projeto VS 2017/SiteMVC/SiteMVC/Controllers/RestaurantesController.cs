using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SiteMVC.Models;

namespace SiteMVC.Controllers
{
    public class RestaurantesController : Controller
    {
        RestaurantePratoDBContext db;
        public RestaurantesController()
        {
            db = new RestaurantePratoDBContext();
        }

        // GET: Restaurantes
        public ActionResult Index()
        {
            var restaurantes = db.TblRestaurante.ToList();
            return View(restaurantes);
        }

    
        public ActionResult Create()
        {
            ViewBag.Restaurantes = db.TblRestaurante;
            var model = new RestauranteViewModel();
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RestauranteViewModel model)
        {

            if (ModelState.IsValid)
            {
                var restaurante = new Restaurante();
                restaurante.NomeRestaurante = model.NomeRestaurante;
                restaurante.IdRestaurante = model.IdRestaurante;

                db.TblRestaurante.Add(restaurante);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            // Se ocorrer um erro retorna para pagina
            ViewBag.Restaurantes = db.TblRestaurante;
            return View(model);
        }







        // GET: Produtos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Restaurante restaurante = db.TblRestaurante.Find(id);
            if (restaurante == null)
            {
                return HttpNotFound();
            }
            ViewBag.Restaurante = db.TblRestaurante;
            return View(restaurante);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdRestaurante,NomeRestaurante")] Restaurante model)
        {
            if (ModelState.IsValid)
            {
                var restaurante = db.TblRestaurante.Find(model.IdRestaurante);
                if (restaurante == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                restaurante.NomeRestaurante = model.NomeRestaurante;
                restaurante.IdRestaurante = model.IdRestaurante;

                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Restaurantes = db.TblRestaurante;
            return View(model);
        }





        // GET: Produtos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            Restaurante restaurante = db.TblRestaurante.Find(id);
            if (restaurante == null)
            {
                return HttpNotFound();
            }
            ViewBag.Categoria = db.TblRestaurante.Find(restaurante.IdRestaurante).NomeRestaurante;
            return View(restaurante);
        }
        // POST: Produtos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Restaurante restaurante = db.TblRestaurante.Find(id);
            db.TblRestaurante.Remove(restaurante);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Produtos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Restaurante restaurante = db.TblRestaurante.Find(id);
            if (restaurante == null)
            {
                return HttpNotFound();
            }
            ViewBag.Restaurante = db.TblRestaurante.Find(restaurante.IdRestaurante).NomeRestaurante;
            return View(restaurante);
        }


    }
}