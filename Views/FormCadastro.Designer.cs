namespace ProjectTesteCiaTecnica.Views
{
    partial class FormCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastro));
            this.mskCpfCnpj = new System.Windows.Forms.MaskedTextBox();
            this.dptDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.txtNomeRazaoSocial = new System.Windows.Forms.TextBox();
            this.gpbPessoa = new System.Windows.Forms.GroupBox();
            this.rbdFisica = new System.Windows.Forms.RadioButton();
            this.rdbJuridico = new System.Windows.Forms.RadioButton();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.lblNomeRazaoSocial = new System.Windows.Forms.Label();
            this.txtSobrenomeFantasia = new System.Windows.Forms.TextBox();
            this.lblSobrenomeFantazia = new System.Windows.Forms.Label();
            this.lblCpfCnpj = new System.Windows.Forms.Label();
            this.lblComplememto = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.lblCep = new System.Windows.Forms.Label();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.lblUF = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.gpbPessoa.SuspendLayout();
            this.SuspendLayout();
            // 
            // mskCpfCnpj
            // 
            this.mskCpfCnpj.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCpfCnpj.Location = new System.Drawing.Point(308, 28);
            this.mskCpfCnpj.Mask = "999.999.999-99";
            this.mskCpfCnpj.Name = "mskCpfCnpj";
            this.mskCpfCnpj.Size = new System.Drawing.Size(106, 22);
            this.mskCpfCnpj.TabIndex = 1;
            this.mskCpfCnpj.Validated += new System.EventHandler(this.MskCpfCnpj_Validated);
            // 
            // dptDataNascimento
            // 
            this.dptDataNascimento.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dptDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dptDataNascimento.Location = new System.Drawing.Point(308, 90);
            this.dptDataNascimento.Name = "dptDataNascimento";
            this.dptDataNascimento.Size = new System.Drawing.Size(106, 22);
            this.dptDataNascimento.TabIndex = 3;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogradouro.Location = new System.Drawing.Point(12, 190);
            this.txtLogradouro.MaxLength = 50;
            this.txtLogradouro.Multiline = true;
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(290, 20);
            this.txtLogradouro.TabIndex = 5;
            // 
            // txtNomeRazaoSocial
            // 
            this.txtNomeRazaoSocial.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeRazaoSocial.Location = new System.Drawing.Point(12, 90);
            this.txtNomeRazaoSocial.MaxLength = 15;
            this.txtNomeRazaoSocial.Name = "txtNomeRazaoSocial";
            this.txtNomeRazaoSocial.Size = new System.Drawing.Size(290, 22);
            this.txtNomeRazaoSocial.TabIndex = 2;
            // 
            // gpbPessoa
            // 
            this.gpbPessoa.Controls.Add(this.rbdFisica);
            this.gpbPessoa.Controls.Add(this.rdbJuridico);
            this.gpbPessoa.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbPessoa.Location = new System.Drawing.Point(12, 10);
            this.gpbPessoa.Name = "gpbPessoa";
            this.gpbPessoa.Size = new System.Drawing.Size(234, 50);
            this.gpbPessoa.TabIndex = 0;
            this.gpbPessoa.TabStop = false;
            this.gpbPessoa.Text = "Pessoa";
            // 
            // rbdFisica
            // 
            this.rbdFisica.AutoSize = true;
            this.rbdFisica.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbdFisica.Location = new System.Drawing.Point(45, 19);
            this.rbdFisica.Name = "rbdFisica";
            this.rbdFisica.Size = new System.Drawing.Size(53, 17);
            this.rbdFisica.TabIndex = 0;
            this.rbdFisica.Text = "Fisica";
            this.rbdFisica.UseVisualStyleBackColor = true;
            this.rbdFisica.CheckedChanged += new System.EventHandler(this.rbdFisica_CheckedChanged);
            // 
            // rdbJuridico
            // 
            this.rdbJuridico.AutoSize = true;
            this.rdbJuridico.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbJuridico.Location = new System.Drawing.Point(144, 19);
            this.rdbJuridico.Name = "rdbJuridico";
            this.rdbJuridico.Size = new System.Drawing.Size(64, 17);
            this.rdbJuridico.TabIndex = 1;
            this.rdbJuridico.Text = "Juridica";
            this.rdbJuridico.UseVisualStyleBackColor = true;
            this.rdbJuridico.CheckedChanged += new System.EventHandler(this.rdbJuridico_CheckedChanged);
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNascimento.Location = new System.Drawing.Point(308, 70);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(110, 13);
            this.lblDataNascimento.TabIndex = 12;
            this.lblDataNascimento.Text = "Data de Nascimneto";
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogradouro.Location = new System.Drawing.Point(12, 170);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(68, 13);
            this.lblLogradouro.TabIndex = 10;
            this.lblLogradouro.Text = "Logradouro";
            // 
            // lblNomeRazaoSocial
            // 
            this.lblNomeRazaoSocial.AutoSize = true;
            this.lblNomeRazaoSocial.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeRazaoSocial.Location = new System.Drawing.Point(12, 70);
            this.lblNomeRazaoSocial.Name = "lblNomeRazaoSocial";
            this.lblNomeRazaoSocial.Size = new System.Drawing.Size(37, 13);
            this.lblNomeRazaoSocial.TabIndex = 8;
            this.lblNomeRazaoSocial.Text = "Nome";
            // 
            // txtSobrenomeFantasia
            // 
            this.txtSobrenomeFantasia.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSobrenomeFantasia.Location = new System.Drawing.Point(12, 140);
            this.txtSobrenomeFantasia.MaxLength = 15;
            this.txtSobrenomeFantasia.Multiline = true;
            this.txtSobrenomeFantasia.Name = "txtSobrenomeFantasia";
            this.txtSobrenomeFantasia.Size = new System.Drawing.Size(290, 20);
            this.txtSobrenomeFantasia.TabIndex = 4;
            // 
            // lblSobrenomeFantazia
            // 
            this.lblSobrenomeFantazia.AutoSize = true;
            this.lblSobrenomeFantazia.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobrenomeFantazia.Location = new System.Drawing.Point(12, 120);
            this.lblSobrenomeFantazia.Name = "lblSobrenomeFantazia";
            this.lblSobrenomeFantazia.Size = new System.Drawing.Size(66, 13);
            this.lblSobrenomeFantazia.TabIndex = 16;
            this.lblSobrenomeFantazia.Text = "Sobrenome";
            // 
            // lblCpfCnpj
            // 
            this.lblCpfCnpj.AutoSize = true;
            this.lblCpfCnpj.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpfCnpj.Location = new System.Drawing.Point(272, 31);
            this.lblCpfCnpj.Name = "lblCpfCnpj";
            this.lblCpfCnpj.Size = new System.Drawing.Size(29, 13);
            this.lblCpfCnpj.TabIndex = 17;
            this.lblCpfCnpj.Text = "CPF:";
            // 
            // lblComplememto
            // 
            this.lblComplememto.AutoSize = true;
            this.lblComplememto.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplememto.Location = new System.Drawing.Point(12, 220);
            this.lblComplememto.Name = "lblComplememto";
            this.lblComplememto.Size = new System.Drawing.Size(79, 13);
            this.lblComplememto.TabIndex = 18;
            this.lblComplememto.Text = "Complemento";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplemento.Location = new System.Drawing.Point(12, 240);
            this.txtComplemento.MaxLength = 10;
            this.txtComplemento.Multiline = true;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(290, 20);
            this.txtComplemento.TabIndex = 7;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(308, 220);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(48, 13);
            this.lblNumero.TabIndex = 20;
            this.lblNumero.Text = "Número";
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(308, 240);
            this.txtNumero.MaxLength = 10;
            this.txtNumero.Multiline = true;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(104, 20);
            this.txtNumero.TabIndex = 8;
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(232, 290);
            this.txtCidade.MaxLength = 30;
            this.txtCidade.Multiline = true;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(180, 20);
            this.txtCidade.TabIndex = 10;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(234, 270);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(43, 13);
            this.lblCidade.TabIndex = 24;
            this.lblCidade.Text = "Cidade";
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(12, 290);
            this.txtBairro.MaxLength = 30;
            this.txtBairro.Multiline = true;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(214, 20);
            this.txtBairro.TabIndex = 9;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(12, 270);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(38, 13);
            this.lblBairro.TabIndex = 22;
            this.lblBairro.Text = "Bairro";
            // 
            // txtCep
            // 
            this.txtCep.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCep.Location = new System.Drawing.Point(308, 190);
            this.txtCep.MaxLength = 9;
            this.txtCep.Multiline = true;
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(104, 20);
            this.txtCep.TabIndex = 6;
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCep.Location = new System.Drawing.Point(308, 170);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(27, 13);
            this.lblCep.TabIndex = 26;
            this.lblCep.Text = "Cep";
            // 
            // txtUF
            // 
            this.txtUF.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUF.Location = new System.Drawing.Point(13, 342);
            this.txtUF.MaxLength = 20;
            this.txtUF.Multiline = true;
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(101, 20);
            this.txtUF.TabIndex = 11;
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUF.Location = new System.Drawing.Point(12, 322);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(21, 13);
            this.lblUF.TabIndex = 28;
            this.lblUF.Text = "UF";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::ProjectTesteCiaTecnica.Properties.Resources.W8_cancel_32;
            this.btnCancelar.Location = new System.Drawing.Point(208, 386);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 40);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGravar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.Image = global::ProjectTesteCiaTecnica.Properties.Resources.W8_ok_32;
            this.btnGravar.Location = new System.Drawing.Point(314, 386);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(100, 40);
            this.btnGravar.TabIndex = 12;
            this.btnGravar.Text = "&Gravar";
            this.btnGravar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // FormCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(424, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.txtUF);
            this.Controls.Add(this.lblUF);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.lblComplememto);
            this.Controls.Add(this.lblCpfCnpj);
            this.Controls.Add(this.txtSobrenomeFantasia);
            this.Controls.Add(this.lblSobrenomeFantazia);
            this.Controls.Add(this.mskCpfCnpj);
            this.Controls.Add(this.dptDataNascimento);
            this.Controls.Add(this.txtLogradouro);
            this.Controls.Add(this.txtNomeRazaoSocial);
            this.Controls.Add(this.gpbPessoa);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.lblLogradouro);
            this.Controls.Add(this.lblNomeRazaoSocial);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Pessoas";
            this.Load += new System.EventHandler(this.FormCadastro_Load);
            this.gpbPessoa.ResumeLayout(false);
            this.gpbPessoa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskCpfCnpj;
        private System.Windows.Forms.DateTimePicker dptDataNascimento;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.TextBox txtNomeRazaoSocial;
        private System.Windows.Forms.GroupBox gpbPessoa;
        private System.Windows.Forms.RadioButton rbdFisica;
        private System.Windows.Forms.RadioButton rdbJuridico;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.Label lblNomeRazaoSocial;
        private System.Windows.Forms.TextBox txtSobrenomeFantasia;
        private System.Windows.Forms.Label lblSobrenomeFantazia;
        private System.Windows.Forms.Label lblCpfCnpj;
        private System.Windows.Forms.Label lblComplememto;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
    }
}

