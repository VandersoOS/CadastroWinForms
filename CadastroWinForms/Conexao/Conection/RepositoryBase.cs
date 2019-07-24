
using System;
using System.Data.Entity.Core.EntityClient;

namespace CadastroWinForms.Conexao.Conection
{
    public abstract class RepositoryBase : IDisposable
    {
        protected RepositoryBase()
        {
            Db = new CadastroPessoaEntities();
        }

        public static CadastroPessoaEntities Db { get; private set; }

        public string ErrorMessage { get; set; }

        public EntityConnection Conexao = new EntityConnection("name=CadastroPessoaEntities");

        public EntityTransaction Transacao = null;

        public void Dispose()
        {
            Db = null;
        }
    }
}