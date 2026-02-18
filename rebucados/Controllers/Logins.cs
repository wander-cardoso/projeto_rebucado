using Login23.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using rebucados.Models;

namespace rebucados.Controllers
{
    public class Logins : Controller
    {
        private readonly ApplicationDbContext _context;

        public Logins(ApplicationDbContext context)
        {
            _context = context;
        }

       
        public IActionResult Index(string? nome, string? senha,string? botao)
        {
            
                var utilizador = _context.Utilizadores
                    .FirstOrDefault(m =>m.Nome == nome && m.Password == senha);

                if (utilizador != null)
                {
                    HttpContext.Session.SetString("UTILIZADOR", utilizador.Nome!);
                    HttpContext.Session.SetInt32("ID", utilizador.Id);
                    
                    return RedirectToAction("Index", "Home");
                }
              

                if (!string.IsNullOrEmpty(botao))
                {
                    ViewBag.Erro = "Credenciais inválidas";
                }
            

            return View();
        }
    }
}
