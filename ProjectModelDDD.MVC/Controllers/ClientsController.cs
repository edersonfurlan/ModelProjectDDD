using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using ModelProjectDDD.Domain.Entities;
using ModelProjectDDD.Infra.Data.Repositories;
using ModelProjectDDD.MVC.ViewModels;

namespace ModelProjectDDD.MVC.Controllers
{
    public class ClientsController : Controller
    {
        private readonly ClientRepository _clientRepository = new ClientRepository();
        // GET: Clients
        public ActionResult Index()
        {
            var clientViewModel = Mapper.Map<IEnumerable<Client>, IEnumerable<ClientViewModel>>(_clientRepository.GetAll());

            return View(clientViewModel);
        }

        // GET: Clients/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Clients/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clients/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClientViewModel client)
        {
            if (ModelState.IsValid)
            {
                var clientDomain = Mapper.Map<ClientViewModel, Client>(client);
                _clientRepository.Add(clientDomain);

                return RedirectToAction("Index");
            }

            return View(client);
        }

        // GET: Clients/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Clients/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Clients/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Clients/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
