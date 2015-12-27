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
    public class PessoaController : Controller
    {
        private ModeloDados db = new ModeloDados();

        // GET: Pessoa
        public async Task<ActionResult> Index()
        {
            var pessoa = db.Pessoa.Include(p => p.Departamento).Include(p => p.PessoaFisica).Include(p => p.PessoaJuridica);
            return View(await pessoa.ToListAsync());
        }

        // GET: Pessoa/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pessoa pessoa = await db.Pessoa.FindAsync(id);
            if (pessoa == null)
            {
                return HttpNotFound();
            }
            return View(pessoa);
        }

        // GET: Pessoa/Create
        public ActionResult Create()
        {
            ViewBag.Departamento_id = new SelectList(db.Departamento, "Codigo", "Nome");
            ViewBag.Codigo = new SelectList(db.PessoaFisica, "Pessoa_id", "Cpf");
            ViewBag.Codigo = new SelectList(db.PessoaJuridica, "Pessoa_id", "Cnpj");
            return View();
        }

        // POST: Pessoa/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Codigo,Nome,Endereco,Cep,Email,DataCadastro,Status,Departamento_id")] Pessoa pessoa)
        {
            if (ModelState.IsValid)
            {
                db.Pessoa.Add(pessoa);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.Departamento_id = new SelectList(db.Departamento, "Codigo", "Nome", pessoa.Departamento_id);
            ViewBag.Codigo = new SelectList(db.PessoaFisica, "Pessoa_id", "Cpf", pessoa.Codigo);
            ViewBag.Codigo = new SelectList(db.PessoaJuridica, "Pessoa_id", "Cnpj", pessoa.Codigo);
            return View(pessoa);
        }

        // GET: Pessoa/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pessoa pessoa = await db.Pessoa.FindAsync(id);
            if (pessoa == null)
            {
                return HttpNotFound();
            }
            ViewBag.Departamento_id = new SelectList(db.Departamento, "Codigo", "Nome", pessoa.Departamento_id);
            ViewBag.Codigo = new SelectList(db.PessoaFisica, "Pessoa_id", "Cpf", pessoa.Codigo);
            ViewBag.Codigo = new SelectList(db.PessoaJuridica, "Pessoa_id", "Cnpj", pessoa.Codigo);
            return View(pessoa);
        }

        // POST: Pessoa/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Codigo,Nome,Endereco,Cep,Email,DataCadastro,Status,Departamento_id")] Pessoa pessoa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pessoa).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.Departamento_id = new SelectList(db.Departamento, "Codigo", "Nome", pessoa.Departamento_id);
            ViewBag.Codigo = new SelectList(db.PessoaFisica, "Pessoa_id", "Cpf", pessoa.Codigo);
            ViewBag.Codigo = new SelectList(db.PessoaJuridica, "Pessoa_id", "Cnpj", pessoa.Codigo);
            return View(pessoa);
        }

        // GET: Pessoa/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pessoa pessoa = await db.Pessoa.FindAsync(id);
            if (pessoa == null)
            {
                return HttpNotFound();
            }
            return View(pessoa);
        }

        // POST: Pessoa/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Pessoa pessoa = await db.Pessoa.FindAsync(id);
            db.Pessoa.Remove(pessoa);
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
