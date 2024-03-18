using DemoMVC.Interfaces;
using DemoMVC.Models;

namespace DemoMVC.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public void AdicionarProduto(Produto produto)
        {
            if (produto.Descricao.Length < 3 || produto.Nome.Length < 3)
                return;

            _produtoRepository.SalvarProduto(produto);
        }
    }
}
