using AutoMapper;
using PROJETOMODELODDD.DOMINIO.Entidades;
using System.Collections.Generic;
using System.Web.Mvc;
using PROJETOMODELODDD.Aplicacao.Interface;
using PROJETOMODELODDD.MVC.ViewModels;

namespace PROJETOMODELODDD.MVC.Controllers
{
    public class ClientesController : Controller
    {
        //obs. MVC nao olha para DADOS


        private readonly IClienteAppServicoBase _clienteAppServicoBase;

        public ClientesController(IClienteAppServicoBase clienteAppServicoBase)
        {
            _clienteAppServicoBase = clienteAppServicoBase;
        }

        // GET: Clientes
        public ActionResult Index()
        {
            var clienteViewModel = Mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteViewModel>>(_clienteAppServicoBase.GetAll());
            return View(clienteViewModel);
        }

        // GET: Clientes Especiais
        public ActionResult ClienteEspeciais()
        {
            var clienteViewModel = Mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteViewModel>>(_clienteAppServicoBase.ObterClientesEspeciais());
            return View(clienteViewModel);
        }
        
        // GET: Clientes/Details/5
        public ActionResult Details(int id)
        {
            var cliente = _clienteAppServicoBase.GetById(id);
            var clienteViewModel = Mapper.Map<Cliente, ClienteViewModel>(cliente);

            return View(clienteViewModel);
        }
        
        // GET: Clientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clientes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClienteViewModel cliente)
        {
            if (ModelState.IsValid)
            {
                var clienteDominio = Mapper.Map<ClienteViewModel, Cliente>(cliente);
                _clienteAppServicoBase.Add(clienteDominio);

                return RedirectToAction("Index");
            }
            return View(cliente);
        }

        // GET: Clientes/Edit/5
        public ActionResult Edit(int id)
        {
            var cliente = _clienteAppServicoBase.GetById(id);
            var clienteViewModel = Mapper.Map<Cliente, ClienteViewModel>(cliente);

            return View(clienteViewModel);
        }

        // POST: Clientes/Edit/5
        [HttpPost]
        public ActionResult Edit(ClienteViewModel cliente)
        {
            if (ModelState.IsValid)
            {
                var clienteDominio = Mapper.Map<ClienteViewModel, Cliente>(cliente);
                _clienteAppServicoBase.Update(clienteDominio);

                return RedirectToAction("Index");

            }
            return View(cliente);
        }

        // GET: Clientes/Delete/5
        public ActionResult Delete(int id)
        {
            var cliente = _clienteAppServicoBase.GetById(id);
            var clienteViewModel = Mapper.Map<Cliente, ClienteViewModel>(cliente);

            return View(clienteViewModel);
        }

        // POST: Clientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConformed(int id)
        {
            var cliente = _clienteAppServicoBase.GetById(id);
           _clienteAppServicoBase.Remove(cliente);

            return RedirectToAction("Index");
        }
    }
}
