using DemoMVC.Interfaces;
using DemoMVC.Models;

namespace DemoMVC.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private static List<Produto> _produtoList { get; set; }

        public ProdutoRepository()
        {
            if(_produtoList == null)
                _produtoList = new List<Produto>();
        }

        public void SalvarProduto(Produto produto)
        {
            _produtoList.Add(produto);
        }
    }
}
