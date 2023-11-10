using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SnowPark.Models;
using SnowPark.Persistencia;

namespace SnowPark.Controllers;

public class CompraController : Controller
{
    private ParqueContext _parqueContext;

    public CompraController(ParqueContext context)
    {
        _parqueContext = context;
    }

    [HttpPost]
    public IActionResult Cancelar(int id)
    {
        var compra = _parqueContext.Compras.Find(id);
        _parqueContext.Compras.Remove(compra);
        _parqueContext.SaveChanges();
        TempData["msg"] = "Compra cancelada!";
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Cadastrar()
    {
        return View();
    }


    [HttpPost]
    public IActionResult Cadastrar(Compra compra)
    {
        //Cadastrar no banco de dados
        _parqueContext.Compras.Add(compra);
        _parqueContext.SaveChanges();
        //Mensagem de sucesso
        TempData["msg"] = "Compra relizada com sucesso!";
        return RedirectToAction("cadastrar");
    }




    public IActionResult Index(string filtro = "")
    {
        var lista = _parqueContext.Compras
            .Where(p=>p.Nome.Contains(filtro) || string.IsNullOrEmpty(filtro))
            .ToList();
        return View(lista);
    }
}
