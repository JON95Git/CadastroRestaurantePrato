using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SiteMVC.Models;
using System.Data.Entity.Validation;
using System.Net;

namespace SiteMVC.Controllers
{
    public class PratosController : Controller
    {
        RestaurantePratoDBContext db;
        public PratosController()
        {
            db = new RestaurantePratoDBContext();
        }

        // GET: Pratos
        public ActionResult Index()
        {
            var pratos = db.TblPrato.ToList();
            return View(pratos);
        }

        public ActionResult Create()
        {
            ViewBag.Restaurante = db.TblRestaurante;
            var model = new PratoViewModel();
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PratoViewModel model)
        {

            if (ModelState.IsValid)
            {
                var prato = new Prato();
                prato.NomePrato = model.NomePrato;
                prato.PrecoPrato = model.Preco;
                prato.IdRestaurante = model.IdRestaurante;

                db.TblPrato.Add(prato);
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
            Prato prato = db.TblPrato.Find(id);
            if (prato == null)
            {
                return HttpNotFound();
            }
            ViewBag.Restaurante = db.TblRestaurante;
            return View(prato);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdPrato,NomePrato,PrecoPrato,IdRestaurante")] Prato model)
        {
            if (ModelState.IsValid)
            {
                var prato = db.TblPrato.Find(model.IdPrato);
                if (prato == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                prato.NomePrato = model.NomePrato;
                prato.PrecoPrato = model.PrecoPrato;
                prato.IdRestaurante = model.IdRestaurante;

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
            Prato prato = db.TblPrato.Find(id);
            if (prato == null)
            {
                return HttpNotFound();
            }
            ViewBag.Categoria = db.TblRestaurante.Find(prato.IdRestaurante).NomeRestaurante;
            return View(prato);
        }
        // POST: Produtos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Prato prato = db.TblPrato.Find(id);
            db.TblPrato.Remove(prato);
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
            Prato prato = db.TblPrato.Find(id);
            if (prato == null)
            {
                return HttpNotFound();
            }
            ViewBag.Restaurante = db.TblRestaurante.Find(prato.IdRestaurante).NomeRestaurante;
            return View(prato);
        }

    }
}