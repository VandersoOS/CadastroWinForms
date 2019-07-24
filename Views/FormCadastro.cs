using ProjectTesteCiaTecnica.Conexao;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ProjectTesteCiaTecnica.Views
{
    public partial class FormCadastro : Form
    {
        private readonly Pessoa _pessoa;
        private string _tipoPessoa;
        private bool _carregandoFormulario;
        private static string _CpfCnpJ;

        public FormCadastro(Pessoa pessoa)
        {
            InitializeComponent();
            _pessoa = pessoa;
        }

        private void FormCadastro_Load(object sender, EventArgs e)
        {
            CarregarDados();

            _carregandoFormulario = true;
        }

        private void CarregarDados()
        {
            MontarTela();
            txtNomeRazaoSocial.Text = _pessoa.Nome;
            mskCpfCnpj.Text = _pessoa.CPFCNPJ;
            dptDataNascimento.Value = _pessoa.PessoaId == 0 ? DateTime.Now.Date.AddYears(-19) : _pessoa.Data_Nascimento;
            txtSobrenomeFantasia.Text = _pessoa.Sobrenome;
            txtLogradouro.Text = _pessoa.Logradouro;
            txtCep.Text = _pessoa.Cep;
            txtComplemento.Text = _pessoa.Complemento;
            txtNumero.Text = _pessoa.Numero;
            txtBairro.Text = _pessoa.Bairro;
            txtCidade.Text = _pessoa.Cidade;
            txtUF.Text = _pessoa.UF;
        }

        //Monta tela inicial
        private void MontarTela()
        {
            if (_pessoa.PessoaId == 0 || _pessoa.TipoPessoa == "Física")
                rbdFisica.Checked = true;
            else if (_pessoa.TipoPessoa == "Jurídica")
                rdbJuridico.Checked = true;
        }

        private void SalvarDados()
        {
            _pessoa.TipoPessoa = _tipoPessoa;
            _pessoa.Nome = txtNomeRazaoSocial.Text;
            _pessoa.CPFCNPJ = mskCpfCnpj.Text;
            _pessoa.Data_Nascimento = dptDataNascimento.Value;
            _pessoa.Sobrenome = txtSobrenomeFantasia.Text;
            _pessoa.Logradouro = txtLogradouro.Text;
            _pessoa.Cep = txtCep.Text;
            _pessoa.Complemento = txtComplemento.Text;
            _pessoa.Numero = txtNumero.Text;
            _pessoa.Bairro = txtBairro.Text;
            _pessoa.Cidade = txtCidade.Text;
            _pessoa.UF = txtUF.Text;
        }

        private bool ValidaCamposObrigatorios()
        {
            if (mskCpfCnpj.Text == "   .   .   -" || mskCpfCnpj.Text == "  .   .   /    -" || string.IsNullOrEmpty(mskCpfCnpj.Text))
            {
                MessageBox.Show("Digitos do CPF ou CNPJ invalidos!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskCpfCnpj.Focus();
                return false;
            }
            else if (!_carregandoFormulario)
            {
                //bool cpfCnpjValido = ValidarCPFCNPJ();

                if (!ValidarCPFCNPJ())
                {
                    MessageBox.Show("Digitos do CPF ou CNPJ invalidos!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mskCpfCnpj.Focus();
                    return false;
                }
            }

            if (string.IsNullOrEmpty(txtNomeRazaoSocial.Text))
            {
                MessageBox.Show(@"Informar o nome.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNomeRazaoSocial.Focus();
                return false;
            }

            if (dptDataNascimento.Value.Date > DateTime.Now)
            {
                MessageBox.Show(@"Data de nascimento superior a data atual!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dptDataNascimento.Value = DateTime.Now.Date;
                return false;
            }
            else
            {
                var nascimento = dptDataNascimento.Value;
                int anos = DateTime.Now.Year - nascimento.Year;

                if (rbdFisica.Checked && anos < 19)
                {
                    MessageBox.Show("Idade menor que 19 anos não permitida", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dptDataNascimento.Focus();
                    return false;
                }
            }

            if (string.IsNullOrEmpty(txtSobrenomeFantasia.Text))
            {
                MessageBox.Show(@"Informar o Sobrenome.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSobrenomeFantasia.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtLogradouro.Text))
            {
                MessageBox.Show(@"Informar Logradouro.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLogradouro.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtCep.Text))
            {
                MessageBox.Show(@"Informar o Cep.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCep.Focus();
                return false;
            }


            if (string.IsNullOrEmpty(txtNumero.Text))
            {
                MessageBox.Show(@"Informar o Número.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumero.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtBairro.Text))
            {
                MessageBox.Show(@"Informar o Bairro.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBairro.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtCidade.Text))
            {
                MessageBox.Show(@"Informar o Cidade.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCidade.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtUF.Text))
            {
                MessageBox.Show(@"Informar o Estado.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUF.Focus();
                return false;
            }

            return true;
        }

        //Verifica se o CPF ou CNPJ digitado é válido
        public static bool ValidarCPFCNPJ()
        {

            if (string.IsNullOrEmpty(_CpfCnpJ))
                return false;
            else
            {
                int[] d = new int[14];
                int[] v = new int[2];
                int j, i, soma;
                string Sequencia, SoNumero;

                SoNumero = Regex.Replace(_CpfCnpJ, "[^0-9]", string.Empty);

                //verificando se todos os numeros são iguais
                if (new string(SoNumero[0], SoNumero.Length) == SoNumero) return false;

                // se a quantidade de dígitos numérios for igual a 11
                // iremos verificar como CPF
                if (SoNumero.Length == 11)
                {
                    for (i = 0; i <= 10; i++) d[i] = Convert.ToInt32(SoNumero.Substring(i, 1));
                    for (i = 0; i <= 1; i++)
                    {
                        soma = 0;
                        for (j = 0; j <= 8 + i; j++) soma += d[j] * (10 + i - j);

                        v[i] = (soma * 10) % 11;
                        if (v[i] == 10) v[i] = 0;
                    }
                    return (v[0] == d[9] & v[1] == d[10]);
                }
                // se a quantidade de dígitos numérios for igual a 14
                // iremos verificar como CNPJ
                else if (SoNumero.Length == 14)
                {
                    Sequencia = "6543298765432";
                    for (i = 0; i <= 13; i++) d[i] = Convert.ToInt32(SoNumero.Substring(i, 1));
                    for (i = 0; i <= 1; i++)
                    {
                        soma = 0;
                        for (j = 0; j <= 11 + i; j++)
                            soma += d[j] * Convert.ToInt32(Sequencia.Substring(j + 1 - i, 1));

                        v[i] = (soma * 10) % 11;
                        if (v[i] == 10) v[i] = 0;
                    }
                    return (v[0] == d[12] & v[1] == d[13]);
                }
                // CPF ou CNPJ inválido se
                // a quantidade de dígitos numérios for diferente de 11 e 14
                else return false;
            }
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            //valida os campos obrigatorios
            if (!ValidaCamposObrigatorios()) return;

            SalvarDados();

            DialogResult = DialogResult.OK;
            Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void rdbJuridico_CheckedChanged(object sender, EventArgs e)
        {
            if (!rdbJuridico.Checked) return;

            MontarTelaPessoaJuridica();
        }

        private void MontarTelaPessoaJuridica()
        {
            mskCpfCnpj.Text = txtSobrenomeFantasia.Text = txtCep.Text = txtUF.Text = string.Empty;
            mskCpfCnpj.Mask = "00,000,000/0000-00";
            _tipoPessoa = "Jurídica";
            lblCpfCnpj.Text = "CNPJ";
            lblNomeRazaoSocial.Text = "Razão Social";
            lblSobrenomeFantazia.Text = "Nome Fantasia";
            txtCep.MaxLength = 9;
            txtUF.MaxLength = 20;
            lblDataNascimento.Visible = dptDataNascimento.Visible = false;
        }

        private void rbdFisica_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbdFisica.Checked) return;

            MontarTelaPessoaFisica();
        }

        private void MontarTelaPessoaFisica()
        {
            _tipoPessoa = "Física";
            mskCpfCnpj.Text = txtSobrenomeFantasia.Text = txtCep.Text = txtUF.Text = string.Empty;
            mskCpfCnpj.Mask = "000,000,000-00";
            lblCpfCnpj.Text = "CPF";
            dptDataNascimento.Value = DateTime.Now.Date.AddYears(-19);
            lblNomeRazaoSocial.Text = "Nome";
            lblSobrenomeFantazia.Text = "Sobrenome";
            txtCep.MaxLength = 8;
            txtUF.MaxLength = 8;
            lblDataNascimento.Visible = dptDataNascimento.Visible = true; ;
        }

        private void MskCpfCnpj_Validated(object sender, EventArgs e)
        {
            _carregandoFormulario = false;
            _CpfCnpJ = mskCpfCnpj.Text;
        }
    }
}
