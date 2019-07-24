
using CadastroWinForms.Conexao.Repositorio;

namespace CadastroWinForms.Conexao.Conection
{
    public interface IRepositoryFactory
    {
        CadastroPessoaEntities Db { get; set; }

        PessoaRepository CreatePessoaRepository();

       
    }
}