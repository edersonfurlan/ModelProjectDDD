using AutoMapper;
using ModelProjectDDD.Application.Interface;
using ModelProjectDDD.Domain.Entities;
using ModelProjectDDD.MVC.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ModelProjectDDD.MVC.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductAppService _productApp;
        private readonly IClientAppService _clientApp;

        public ProductsController(IProductAppService productApp, IClientAppService clientApp)
        {
            _productApp = productApp;
            _clientApp = clientApp;
        }

        // GET: Product
        public ActionResult Index()
        {
            var productViewModel = Mapper.Map<IEnumerable<Product>, IEnumerable<ProductViewModel>>(_productApp.GetAll());

            return View(productViewModel);
        }

        //Details
        public ActionResult Details(int id)
        {
            var product = _productApp.GetById(id);
            var productViewModel = Mapper.Map<Product, ProductViewModel>(product);

            return View(productViewModel);
        }

        //Create
        public ActionResult Create()
        {
            ViewBag.ClientId = new SelectList(_clientApp.GetAll(), "ClientId", "Name");
            return View();
        }

        // POST: Products/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductViewModel product)
        {
            if (ModelState.IsValid)
            {
                var productDomain = Mapper.Map<ProductViewModel, Product>(product);
                _productApp.Add(productDomain);

                return RedirectToAction("Index");
            }

            ViewBag.ClientId = new SelectList(_clientApp.GetAll(), "ClientId", "Name", product.ClientId);

            return View(product);
        }

        //Edit
        public ActionResult Edit(int id)
        {
            var product = _productApp.GetById(id);
            var productViewModel = Mapper.Map<Product, ProductViewModel>(product);

            ViewBag.ClientId = new SelectList(_clientApp.GetAll(), "ClientId", "Name", productViewModel.ClientId);

            return View(productViewModel);
        }

        //POST: Products/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProductViewModel product)
        {
            if (ModelState.IsValid)
            {
                var productDomain = Mapper.Map<ProductViewModel, Product>(product);
                _productApp.Update(productDomain);

                return RedirectToAction("Index");
            }

            ViewBag.ClientId = new SelectList(_clientApp.GetAll(), "ClientId", "Name", product.ClientId);

            return View(product);
        }

        // GET: Products/Delete/5
        public ActionResult Delete(int id)
        {
            var product = _productApp.GetById(id);
            var productViewModel = Mapper.Map<Product, ProductViewModel>(product);

            return View(productViewModel);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var product = _productApp.GetById(id);
            _productApp.Remove(product);

            return RedirectToAction("Index");

        }
    }
}