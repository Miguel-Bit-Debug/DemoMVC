using DemoMVC.Models;

namespace DemoMVC.Interfaces
{
    public interface IProdutoRepository
    {
        void SalvarProduto(Produto produto);
    }
}
