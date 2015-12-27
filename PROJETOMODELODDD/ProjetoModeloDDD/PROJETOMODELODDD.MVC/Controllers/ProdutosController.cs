
using System.Collections;
using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using PROJETOMODELODDD.Aplicacao.Interface;
using PROJETOMODELODDD.DOMINIO.Entidades;
using PROJETOMODELODDD.MVC.ViewModels;

namespace PROJETOMODELODDD.MVC.Controllers
{
    public class ProdutosController : Controller

    {

        private readonly IProdutoAppServicoBase _produtoAppServicoBase;
        private readonly IClienteAppServicoBase _clienteAppServicoBase;

        public ProdutosController(IProdutoAppServicoBase produtoAppServicoBase, IClienteAppServicoBase clienteAppServicoBase)
        {
            _produtoAppServicoBase = produtoAppServicoBase;
            _clienteAppServicoBase = clienteAppServicoBase;
        }


        // GET: Produtos
        public ActionResult Index()
        {
            var produtoViewModel =
                Mapper.Map<IEnumerable<Produto>, IEnumerable<ProdutoViewModel>>(_produtoAppServicoBase.GetAll());
            return View(produtoViewModel);
        }

        // GET: Produtos/Details/5
        public ActionResult Details(int id)
        {
            var produto = _produtoAppServicoBase.GetById(id);
            var produtoViewModel = Mapper.Map<Produto, ProdutoViewModel>(produto);

            return View(produtoViewModel);
        }

        // GET: Produtos/Create
        public ActionResult Create()
        {
            ViewBag.ClienteId = new SelectList(_clienteAppServicoBase.GetAll(), "ClienteId", "Nome");
            return View();
        }

        // POST: Produtos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProdutoViewModel produto)
        {
            if (ModelState.IsValid)
            {
                var produtoDomain = Mapper.Map<ProdutoViewModel, Produto>(produto);
                _produtoAppServicoBase.Add(produtoDomain);

                return RedirectToAction("Index");
            }

            ViewBag.ClienteId = new SelectList(_clienteAppServicoBase.GetAll(), "ClienteId", "Nome", produto.ClienteId);
            return View(produto);
        }

        // GET: Produtos/Edit/5
        public ActionResult Edit(int id)
        {
            var produto = _produtoAppServicoBase.GetById(id);
            var produtoViewModel = Mapper.Map<Produto, ProdutoViewModel>(produto);

            ViewBag.ClienteId = new SelectList(_clienteAppServicoBase.GetAll(), "ClienteId", "Nome", produtoViewModel.ClienteId);

            return View(produtoViewModel);
        }

        // POST: Produtos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProdutoViewModel produto)
        {
            if (ModelState.IsValid)
            {
                var produtoDomain = Mapper.Map<ProdutoViewModel, Produto>(produto);
                _produtoAppServicoBase.Update(produtoDomain);

                return RedirectToAction("Index");
            }

            ViewBag.ClienteId = new SelectList(_clienteAppServicoBase.GetAll(), "ClienteId", "Nome", produto.ClienteId);
            return View(produto);
        }

        // GET: Produtos/Delete/5
        public ActionResult Delete(int id)
        {
            var produto = _produtoAppServicoBase.GetById(id);
            var produtoViewModel = Mapper.Map<Produto, ProdutoViewModel>(produto);

            return View(produtoViewModel);
        }

        // POST: Produtos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var produto = _produtoAppServicoBase.GetById(id);
            _produtoAppServicoBase.Remove(produto);

            return RedirectToAction("Index");
        }
    }
}