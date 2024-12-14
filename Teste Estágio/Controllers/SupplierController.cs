using Microsoft.AspNetCore.Mvc;
using Teste_Estágio.Models;
using Teste_Estágio.Repositorio;

namespace Teste_Estágio.Controllers
{
    public class SupplierController : Controller
    {
        private readonly ISupplierRepositorio _supplierRepositorio;
        public SupplierController(ISupplierRepositorio supplierRepositorio)
        {
            _supplierRepositorio = supplierRepositorio;
        }
        public IActionResult Index()
        {
            List<SuppliersModel> suppliers = _supplierRepositorio.searchEveryItem();
            return View(suppliers);
        }

        public IActionResult Create(int id)
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            SuppliersModel supplier = _supplierRepositorio.searchForId(id);
            return View(supplier);
        }
        public IActionResult Delete(int id)
        {
            _supplierRepositorio.Delete(id);
            return RedirectToAction("Index");
        }

        public IActionResult ConfirmDelete(int id)
        {
            SuppliersModel supplier = _supplierRepositorio.searchForId(id);
            return View(supplier);
        }

        [HttpPost]
        public IActionResult Create(SuppliersModel supplier)
        {
            supplier.QrCode = "%" + supplier.CNPJ + "%-" + supplier.CEP + "%" + "/CAD." + supplier.RegistrationDay + '%';
            _supplierRepositorio.add(supplier);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Change(SuppliersModel supplier)
        {
            _supplierRepositorio.Update(supplier);
            return RedirectToAction("Index");
        }
    }

    
}
