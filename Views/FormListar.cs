using ProjectTesteCiaTecnica.Conexao;
using ProjectTesteCiaTecnica.Conexao.Repositorio;
using ProjectTesteCiaTecnica.Conexao.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProjectTesteCiaTecnica.Views
{
    public partial class FormListar : Form
    {
        private Pessoa _linhaSelecionada = new Pessoa();
        public FormListar()
        {
            InitializeComponent();
        }

        private void frmListar_Load(object sender, EventArgs e)
        {
            dgvPessoas.AutoGenerateColumns = false;

            dgvPessoas.Focus();
            CarregarLista();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Cria um novo objeto
            Pessoa novo = new Pessoa()
            {

            };

            LoadingCadForm(novo);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            LoadingCadForm(_linhaSelecionada);
        }

        private void CarregarLista()
        {
            PessoaRepository pRep = RepositoryFactory.Instance.CreatePessoaRepository();

            List<Pessoa> result = pRep.GetAll().OrderBy(x => x.Nome).ToList();

            if (string.IsNullOrEmpty(pRep.ErrorMessage))
            {
                dgvPessoas.DataSource = result;
                btnEditar.Enabled = btnExcluir.Enabled = result.Count > 0;
            }
            else
                MessageBox.Show(pRep.ErrorMessage, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void LoadingCadForm(Pessoa pessoa)
        {
            FormCadastro f = new FormCadastro(pessoa);

            if (f.ShowDialog() == DialogResult.Cancel)
            {
                if (_linhaSelecionada == null) return;

                CarregarLista();
                return;
            }

            Salvar(pessoa);
        }

        private void Salvar(Pessoa pessoa)
        {
            using (PessoaRepository rp = RepositoryFactory.Instance.CreatePessoaRepository())
            {
                rp.Save(pessoa);

                if (string.IsNullOrEmpty(rp.ErrorMessage))
                {
                    MessageBox.Show(@"Pessoa atualizada com sucesso!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarLista();
                }
                else
                {
                    MessageBox.Show(rp.ErrorMessage, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Deseja excluir pessoa Cadastrada?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) return;

            RemoverCadastro();
        }

        private void RemoverCadastro()
        {
            using (PessoaRepository usuaRep = RepositoryFactory.Instance.CreatePessoaRepository())
            {
                usuaRep.Delete(_linhaSelecionada);

                if (string.IsNullOrEmpty(usuaRep.ErrorMessage))
                {
                    MessageBox.Show(@"Pessoa excluída com sucesso!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarLista();
                }
                else
                {
                    MessageBox.Show(usuaRep.ErrorMessage, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DgvPessoas_SelectionChanged(object sender, EventArgs e)
        {
            _linhaSelecionada = (Pessoa)dgvPessoas.CurrentRow.DataBoundItem;
        }

        private void dgvPessoas_DoubleClick(object sender, EventArgs e)
        {
            btnEditar_Click(sender, e);
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
