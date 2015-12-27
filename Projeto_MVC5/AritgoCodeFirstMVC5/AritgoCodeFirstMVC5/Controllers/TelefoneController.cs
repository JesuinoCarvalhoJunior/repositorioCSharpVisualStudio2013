using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AritgoCodeFirstMVC5.Models;

namespace AritgoCodeFirstMVC5.Controllers
{
    public class TelefoneController : Controller
    {
        private ModeloDados db = new ModeloDados();

        // GET: Telefone
        public async Task<ActionResult> Index()
        {
            var telefone = db.Telefone.Include(t => t.Pessoa);
            return View(await telefone.ToListAsync());
        }

        // GET: Telefone/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Telefone telefone = await db.Telefone.FindAsync(id);
            if (telefone == null)
            {
                return HttpNotFound();
            }
            return View(telefone);
        }

        // GET: Telefone/Create
        public ActionResult Create()
        {
            ViewBag.Pessoa_id = new SelectList(db.Pessoa, "Codigo", "Nome");
            return View();
        }

        // POST: Telefone/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Codigo,CodigoDdd,Numero,Pessoa_id")] Telefone telefone)
        {
            if (ModelState.IsValid)
            {
                db.Telefone.Add(telefone);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.Pessoa_id = new SelectList(db.Pessoa, "Codigo", "Nome", telefone.Pessoa_id);
            return View(telefone);
        }

        // GET: Telefone/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Telefone telefone = await db.Telefone.FindAsync(id);
            if (telefone == null)
            {
                return HttpNotFound();
            }
            ViewBag.Pessoa_id = new SelectList(db.Pessoa, "Codigo", "Nome", telefone.Pessoa_id);
            return View(telefone);
        }

        // POST: Telefone/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Codigo,CodigoDdd,Numero,Pessoa_id")] Telefone telefone)
        {
            if (ModelState.IsValid)
            {
                db.Entry(telefone).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.Pessoa_id = new SelectList(db.Pessoa, "Codigo", "Nome", telefone.Pessoa_id);
            return View(telefone);
        }

        // GET: Telefone/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Telefone telefone = await db.Telefone.FindAsync(id);
            if (telefone == null)
            {
                return HttpNotFound();
            }
            return View(telefone);
        }

        // POST: Telefone/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Telefone telefone = await db.Telefone.FindAsync(id);
            db.Telefone.Remove(telefone);
            await db.SaveChangesAsync();
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
