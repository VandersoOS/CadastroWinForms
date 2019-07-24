

using CadastroWinForms.Conexao.Repositorio;

namespace CadastroWinForms.Conexao.Conection
{
    public class RepositoryFactory : IRepositoryFactory
    {
        private static IRepositoryFactory _instance;

        public static IRepositoryFactory Instance
        {
            get { return _instance ?? (_instance = new RepositoryFactory()); }
            set { _instance = value; }
        }

        public CadastroPessoaEntities Db { get; set; }

        public PessoaRepository CreatePessoaRepository() { return new PessoaRepository(); }

        

    }
}