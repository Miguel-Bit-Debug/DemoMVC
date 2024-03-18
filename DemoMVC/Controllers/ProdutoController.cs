using DemoMVC.Interfaces;
using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IProdutoService _produtoService;
        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }


        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost, ActionName("Index")]
        public IActionResult CriarProduto([FromForm] Produto produto)
        {
            if (produto == null)
                return BadRequest();

            _produtoService.AdicionarProduto(produto);
            return RedirectToAction("Index", "Home");
        }
    }
}
