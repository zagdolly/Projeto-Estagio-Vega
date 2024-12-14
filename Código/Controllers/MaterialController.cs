using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Teste_Estágio.Context;
using Teste_Estágio.Models;
using Teste_Estágio.Repositorio;

namespace Teste_Estágio.Controllers;


public class MaterialController : Controller
{
    private readonly IMaterialRepositorio _materialRepositorio;
    private readonly ISupplierRepositorio _supplierRepositorio;
    private readonly BancoContext _context;
    public MaterialController(IMaterialRepositorio materialRepositorio, BancoContext contexto)
    {
        _materialRepositorio = materialRepositorio;
        _context = contexto;
    }

    

    public IActionResult Index()
    {

        List<MaterialsModel> materials = _materialRepositorio.searchEveryItem();
        return View(materials);
    }

    public IActionResult Create()
    {
        var suppliers = _context.Supplier.ToList(); // Obtenha os fornecedores do banco de dados
        var model = new MaterialModel();
        {
            model.ListaSuppliers = suppliers;
        };
        return View(model);
    }


    public IActionResult Edit(int id)
    {
        MaterialsModel material = _materialRepositorio.searchForId(id);
        return View(material);
    }
    public IActionResult Delete(int id)
    {
        _materialRepositorio.Delete(id);
        return RedirectToAction("Index");
    }

    public IActionResult ConfirmDelete(int id)
    {
        MaterialsModel material = _materialRepositorio.searchForId(id);
        return View(material);
    }

    [HttpPost]
    public IActionResult Create(MaterialsModel material)
    {
        material.CreatedAt = DateTime.Now;
        material.UpdatedAt = DateTime.Now;
        material.UpdatedBy = material.CreatedBy;
        _materialRepositorio.add(material);        
        return RedirectToAction("Index");
    }

    [HttpPost]
    public IActionResult Change(MaterialsModel material)
    {
        _materialRepositorio.Update(material);
        return RedirectToAction("Index");
    }

}
