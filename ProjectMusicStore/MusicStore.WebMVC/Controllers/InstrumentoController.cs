using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Domain;
using MusicStore.Infra.Data;
using MusicStore.Application;

namespace MusicStore.WebMVC.Controllers
{
    public class InstrumentoController : Controller
    {
        private InstrumentoContext db = new InstrumentoContext();

        private IInstrumentoService service = new InstrumentoService(new InstrumentoRepository());

        // GET: /Instrumento/
        public ActionResult Index()
        {
            return View(service.RetrieveAll());
        }

        // GET: /Instrumento/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Instrumento instrumento = new Instrumento(); //db.Instrumentos.Find(id);
            int i = (int)id;

            Instrumento instrumento = service.Retrieve(i);
            if (instrumento == null)
            {
                return HttpNotFound();
            }
            return View(instrumento);
        }

        // GET: /Instrumento/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Instrumento/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nome,DataFabricacao,Valor,TipoInstrumento")] Instrumento instrumento)
        {
            if (ModelState.IsValid)
            {
                service.Create(instrumento);

                return RedirectToAction("Index");
            }

            return View(instrumento);
        }

        // GET: /Instrumento/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            int i = (int)id;

            Instrumento instrumento = service.Retrieve(i);
            if (instrumento == null)
            {
                return HttpNotFound();
            }
            return View(instrumento);
        }

        // POST: /Instrumento/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome,DataFabricacao,Valor,TipoInstrumento")] Instrumento instrumento)
        {
            if (ModelState.IsValid)
            {
                service.Update(instrumento);

                return RedirectToAction("Index");
            }
            return View(instrumento);
        }

        // GET: /Instrumento/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            int i = (int)id;

            Instrumento instrumento = service.Retrieve(i);
            if (instrumento == null)
            {
                return HttpNotFound();
            }
            return View(instrumento);
        }

        // POST: /Instrumento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            service.Delete(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                //  db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
