using System;
using System.Data.Entity.Core.EntityClient;

namespace ProjectTesteCiaTecnica.Conexao.Utilities
{
    public abstract class RepositoryBase : IDisposable
    {
        protected RepositoryBase()
        {
            Db = new CiaTecnicaEntities();
        }

        public static CiaTecnicaEntities Db { get; private set; }

        public string ErrorMessage { get; set; }

        public EntityConnection Conexao = new EntityConnection("name=CiaTecnicaEntities");

        public EntityTransaction Transacao = null;

        public void Dispose()
        {
            Db = null;
        }
    }
}