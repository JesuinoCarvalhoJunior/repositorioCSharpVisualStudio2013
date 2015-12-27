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
    public class PessoaFisicaController : Controller
    {
        private ModeloDados db = new ModeloDados();

        // GET: PessoaFisica
        public async Task<ActionResult> Index()
        {
            var pessoaFisica = db.PessoaFisica.Include(p => p.Pessoa);
            return View(await pessoaFisica.ToListAsync());
        }

        // GET: PessoaFisica/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PessoaFisica pessoaFisica = await db.PessoaFisica.FindAsync(id);
            if (pessoaFisica == null)
            {
                return HttpNotFound();
            }
            return View(pessoaFisica);
        }

        // GET: PessoaFisica/Create
        public ActionResult Create()
        {
            ViewBag.Pessoa_id = new SelectList(db.Pessoa, "Codigo", "Nome");
            return View();
        }

        // POST: PessoaFisica/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Pessoa_id,Cpf,Nacionalidade")] PessoaFisica pessoaFisica)
        {
            if (ModelState.IsValid)
            {
                db.PessoaFisica.Add(pessoaFisica);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.Pessoa_id = new SelectList(db.Pessoa, "Codigo", "Nome", pessoaFisica.Pessoa_id);
            return View(pessoaFisica);
        }

        // GET: PessoaFisica/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PessoaFisica pessoaFisica = await db.PessoaFisica.FindAsync(id);
            if (pessoaFisica == null)
            {
                return HttpNotFound();
            }
            ViewBag.Pessoa_id = new SelectList(db.Pessoa, "Codigo", "Nome", pessoaFisica.Pessoa_id);
            return View(pessoaFisica);
        }

        // POST: PessoaFisica/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Pessoa_id,Cpf,Nacionalidade")] PessoaFisica pessoaFisica)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pessoaFisica).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.Pessoa_id = new SelectList(db.Pessoa, "Codigo", "Nome", pessoaFisica.Pessoa_id);
            return View(pessoaFisica);
        }

        // GET: PessoaFisica/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PessoaFisica pessoaFisica = await db.PessoaFisica.FindAsync(id);
            if (pessoaFisica == null)
            {
                return HttpNotFound();
            }
            return View(pessoaFisica);
        }

        // POST: PessoaFisica/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            PessoaFisica pessoaFisica = await db.PessoaFisica.FindAsync(id);
            db.PessoaFisica.Remove(pessoaFisica);
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
