using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RefugiadosEmpregabilidade.Models;

namespace RefugiadosEmpregabilidade.Controllers
{
    public class RefugiadosController : Controller
    {
        private Contexto db = new Contexto();

        // GET: Refugiadoes
        public ActionResult Index()
        {
            return View(db.Refugiados.ToList());
        }

        // GET: Refugiadoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Refugiado refugiado = db.Refugiados.Find(id);
            if (refugiado == null)
            {
                return HttpNotFound();
            }
            return View(refugiado);
        }

        // GET: Refugiadoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Refugiadoes/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nome,Idade,Genero,EstadoCivil,Telefone,Email,Nacionalidade,Etnia,Especialidade")] Refugiado refugiado)
        {
            if (ModelState.IsValid)
            {
                db.Refugiados.Add(refugiado);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(refugiado);
        }

        // GET: Refugiadoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Refugiado refugiado = db.Refugiados.Find(id);
            if (refugiado == null)
            {
                return HttpNotFound();
            }
            return View(refugiado);
        }

        // POST: Refugiadoes/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome,Idade,Genero,EstadoCivil,Telefone,Email,Nacionalidade,Etnia,Especialidade")] Refugiado refugiado)
        {
            if (ModelState.IsValid)
            {
                db.Entry(refugiado).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(refugiado);
        }

        // GET: Refugiadoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Refugiado refugiado = db.Refugiados.Find(id);
            if (refugiado == null)
            {
                return HttpNotFound();
            }
            return View(refugiado);
        }

        // POST: Refugiadoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Refugiado refugiado = db.Refugiados.Find(id);
            db.Refugiados.Remove(refugiado);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
