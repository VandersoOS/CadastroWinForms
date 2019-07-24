using CadastroWinForms.Conexao.Conection;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace CadastroWinForms.Conexao.Repositorio
{
    public class PessoaRepository : RepositoryBase
    {
        public void Save(Pessoa pessoa)
        {
            ErrorMessage = string.Empty;

            if (pessoa == null)
            {
                ErrorMessage = "Pessoa não carregada";
                return;
            }

            Conexao.Open();
            Transacao = Conexao.BeginTransaction();

            try
            {

                Db.Pessoas.AddOrUpdate(pessoa);

                Db.SaveChanges();
                Transacao.Commit();
            }
            catch (Exception ex)
            {
                ErrorMessage = "Erro ao Cadastrar";
                Transacao.Rollback();
            }

            Conexao.Close();
        }

        public void Delete(Pessoa pessoa)
        {
            ErrorMessage = string.Empty;

            if (pessoa == null)
            {
                ErrorMessage = "Pessoa não carregada";
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

                Db.Pessoas.Remove(p);
                Db.SaveChanges();
                Transacao.Commit();
            }
            catch (Exception ex)
            {
                ErrorMessage = "Erro ao deletar";
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
                result = Db.Pessoas.FirstOrDefault(q => q.PessoaId == id);
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
                result = Db.Pessoas.ToList();
            }
            catch (Exception ex)
            {
                ErrorMessage = "Erro carregar Lista";
            }

            return result;
        }
    }
}