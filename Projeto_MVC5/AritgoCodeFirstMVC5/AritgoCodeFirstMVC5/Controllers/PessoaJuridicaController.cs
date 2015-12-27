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
    public class PessoaJuridicaController : Controller
    {
        private ModeloDados db = new ModeloDados();

        // GET: PessoaJuridica
        public async Task<ActionResult> Index()
        {
            var pessoaJuridica = db.PessoaJuridica.Include(p => p.Pessoa);
            return View(await pessoaJuridica.ToListAsync());
        }

        // GET: PessoaJuridica/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PessoaJuridica pessoaJuridica = await db.PessoaJuridica.FindAsync(id);
            if (pessoaJuridica == null)
            {
                return HttpNotFound();
            }
            return View(pessoaJuridica);
        }

        // GET: PessoaJuridica/Create
        public ActionResult Create()
        {
            ViewBag.Pessoa_id = new SelectList(db.Pessoa, "Codigo", "Nome");
            return View();
        }

        // POST: PessoaJuridica/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Pessoa_id,Cnpj,WebSite")] PessoaJuridica pessoaJuridica)
        {
            if (ModelState.IsValid)
            {
                db.PessoaJuridica.Add(pessoaJuridica);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.Pessoa_id = new SelectList(db.Pessoa, "Codigo", "Nome", pessoaJuridica.Pessoa_id);
            return View(pessoaJuridica);
        }

        // GET: PessoaJuridica/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PessoaJuridica pessoaJuridica = await db.PessoaJuridica.FindAsync(id);
            if (pessoaJuridica == null)
            {
                return HttpNotFound();
            }
            ViewBag.Pessoa_id = new SelectList(db.Pessoa, "Codigo", "Nome", pessoaJuridica.Pessoa_id);
            return View(pessoaJuridica);
        }

        // POST: PessoaJuridica/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Pessoa_id,Cnpj,WebSite")] PessoaJuridica pessoaJuridica)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pessoaJuridica).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.Pessoa_id = new SelectList(db.Pessoa, "Codigo", "Nome", pessoaJuridica.Pessoa_id);
            return View(pessoaJuridica);
        }

        // GET: PessoaJuridica/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PessoaJuridica pessoaJuridica = await db.PessoaJuridica.FindAsync(id);
            if (pessoaJuridica == null)
            {
                return HttpNotFound();
            }
            return View(pessoaJuridica);
        }

        // POST: PessoaJuridica/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            PessoaJuridica pessoaJuridica = await db.PessoaJuridica.FindAsync(id);
            db.PessoaJuridica.Remove(pessoaJuridica);
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
