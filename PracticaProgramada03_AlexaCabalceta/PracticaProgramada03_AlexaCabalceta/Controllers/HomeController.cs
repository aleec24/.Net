using BlogDAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PracticaProgramada03_AlexaCabalceta.Models;
using System;
using System.Diagnostics;

namespace PracticaProgramada03_AlexaCabalceta.Controllers
{
    public class HomeController : Controller
    {
        private readonly BlogDbContext _context;

        public HomeController(BlogDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            try
            {
                var blogs = _context.Blogs
                                .Include(b => b.UsuarioCreacion)
                                .Include(b => b.Comentarios)
                                .ThenInclude(c => c.UsuarioCreacion);

                var numeroComentarios = _context.Comentarios.Count();
                ViewData["numeroComentarios"] = numeroComentarios;

                //throw new Exception("dffffg");

                return View(blogs);
            }catch (Exception ex)
            {
                TempData["Error"] = "Upsss! Algo salió mal. Por favor intente nuevamente.";
                return View(new List<Blog>());
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
