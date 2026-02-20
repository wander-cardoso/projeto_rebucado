using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using rebucados.ViewModel;


public IActionResult Index()
{
    var vm = new VendedorVenda
    {
        Vendedores = _context.Vendedores.ToList(),
        Vendas = _context.Vendas.ToList()
    };

    return View(vm);
}