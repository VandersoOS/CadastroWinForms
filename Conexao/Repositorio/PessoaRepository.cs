using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using ProjectTesteCiaTecnica.Conexao.Utilities;

namespace ProjectTesteCiaTecnica.Conexao.Repositorio
{
    public class PessoaRepository : RepositoryBase
    {
        public void Save(Pessoa pessoa)
        {
            ErrorMessage = string.Empty;

            if (pessoa == null)
            {
                ErrorMessage = "NULL Entity";
                return;
            }

            Conexao.Open();
            Transacao = Conexao.BeginTransaction();

            try
            {

                Db.Pessoa.AddOrUpdate(pessoa);

                Db.SaveChanges();
                Transacao.Commit();
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                Transacao.Rollback();
            }

            Conexao.Close();
        }

        public void Delete(Pessoa pessoa)
        {
            ErrorMessage = string.Empty;

            if (pessoa == null)
            {
                ErrorMessage = "NULL Entity";
                return;
            }

            Conexao.Open();
            Transacao = Conexao.BeginTransaction();

            try
            {
                Pessoa p = GetById(pessoa.PessoaId);

                if (p == null)
                {
                    return;
                }

                if (Db.Entry(pessoa).State == EntityState.Detached)
                {
                    Db.Entry(p).State = EntityState.Modified;
                }

                Db.Pessoa.Remove(p);
                Db.SaveChanges();
                Transacao.Commit();
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                Transacao.Rollback();
            }

            Conexao.Close();
        }

        public Pessoa GetById(int id)
        {
            ErrorMessage = string.Empty;
            Pessoa result = null;

            try
            {
                result = Db.Pessoa.FirstOrDefault(q => q.PessoaId == id);
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }

            return result;
        }


        public List<Pessoa> GetAll()
        {
            ErrorMessage = string.Empty;
            List<Pessoa> result = new List<Pessoa>();

            try
            {
                result = Db.Pessoa.ToList();
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }

            return result;
        }
    }
}