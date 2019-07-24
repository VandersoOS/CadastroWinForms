using ProjectTesteCiaTecnica.Conexao.Repositorio;

namespace ProjectTesteCiaTecnica.Conexao.Utilities
{
    public interface IRepositoryFactory
    {
        CiaTecnicaEntities Db { get; set; }

        PessoaRepository CreatePessoaRepository();

       
    }
}