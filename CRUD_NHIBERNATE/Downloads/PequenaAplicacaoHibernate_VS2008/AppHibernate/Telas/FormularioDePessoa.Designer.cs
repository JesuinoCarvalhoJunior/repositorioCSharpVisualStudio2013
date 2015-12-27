namespace PrimeraAplicacaoNHibernate
{
    partial class FormularioDePessoa
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.cbCategorias = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btNovo = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btRemover = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.ListaDePessoas = new System.Windows.Forms.ListBox();
            this.rbSexoMasculino = new System.Windows.Forms.RadioButton();
            this.rbSexoFeminino = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(12, 25);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(268, 20);
            this.txtNome.TabIndex = 0;
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Enabled = false;
            this.txtSobrenome.Location = new System.Drawing.Point(12, 70);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(268, 20);
            this.txtSobrenome.TabIndex = 1;
            // 
            // cbCategorias
            // 
            this.cbCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategorias.Enabled = false;
            this.cbCategorias.FormattingEnabled = true;
            this.cbCategorias.Location = new System.Drawing.Point(12, 158);
            this.cbCategorias.Name = "cbCategorias";
            this.cbCategorias.Size = new System.Drawing.Size(268, 21);
            this.cbCategorias.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sobrenome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data de Nascimento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Categoria:";
            // 
            // btNovo
            // 
            this.btNovo.Location = new System.Drawing.Point(12, 186);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(75, 23);
            this.btNovo.TabIndex = 8;
            this.btNovo.Text = "Novo";
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // btEditar
            // 
            this.btEditar.Enabled = false;
            this.btEditar.Location = new System.Drawing.Point(94, 185);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(75, 23);
            this.btEditar.TabIndex = 9;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btRemover
            // 
            this.btRemover.Enabled = false;
            this.btRemover.Location = new System.Drawing.Point(176, 184);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(75, 23);
            this.btRemover.TabIndex = 10;
            this.btRemover.Text = "Remover";
            this.btRemover.UseVisualStyleBackColor = true;
            this.btRemover.Click += new System.EventHandler(this.btRemover_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Enabled = false;
            this.btSalvar.Location = new System.Drawing.Point(258, 184);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 6;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // ListaDePessoas
            // 
            this.ListaDePessoas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ListaDePessoas.FormattingEnabled = true;
            this.ListaDePessoas.Location = new System.Drawing.Point(0, 221);
            this.ListaDePessoas.Name = "ListaDePessoas";
            this.ListaDePessoas.Size = new System.Drawing.Size(375, 173);
            this.ListaDePessoas.TabIndex = 12;
            this.ListaDePessoas.SelectedIndexChanged += new System.EventHandler(this.ListaDePessoas_SelectedIndexChanged);
            // 
            // rbSexoMasculino
            // 
            this.rbSexoMasculino.AutoSize = true;
            this.rbSexoMasculino.Checked = true;
            this.rbSexoMasculino.Enabled = false;
            this.rbSexoMasculino.Location = new System.Drawing.Point(137, 115);
            this.rbSexoMasculino.Name = "rbSexoMasculino";
            this.rbSexoMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbSexoMasculino.TabIndex = 3;
            this.rbSexoMasculino.TabStop = true;
            this.rbSexoMasculino.Text = "Masculino";
            this.rbSexoMasculino.UseVisualStyleBackColor = true;
            // 
            // rbSexoFeminino
            // 
            this.rbSexoFeminino.AutoSize = true;
            this.rbSexoFeminino.Enabled = false;
            this.rbSexoFeminino.Location = new System.Drawing.Point(216, 115);
            this.rbSexoFeminino.Name = "rbSexoFeminino";
            this.rbSexoFeminino.Size = new System.Drawing.Size(67, 17);
            this.rbSexoFeminino.TabIndex = 4;
            this.rbSexoFeminino.Text = "Feminino";
            this.rbSexoFeminino.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Sexo:";
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Enabled = false;
            this.txtDataNascimento.Location = new System.Drawing.Point(15, 114);
            this.txtDataNascimento.Mask = "00/00/0000";
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(73, 20);
            this.txtDataNascimento.TabIndex = 2;
            this.txtDataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // FormularioDePessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 394);
            this.Controls.Add(this.txtDataNascimento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rbSexoFeminino);
            this.Controls.Add(this.rbSexoMasculino);
            this.Controls.Add(this.ListaDePessoas);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.btRemover);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCategorias);
            this.Controls.Add(this.txtSobrenome);
            this.Controls.Add(this.txtNome);
            this.MaximizeBox = false;
            this.Name = "FormularioDePessoa";
            this.Text = "FormularioDePessoa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.ComboBox cbCategorias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.ListBox ListaDePessoas;
        private System.Windows.Forms.RadioButton rbSexoMasculino;
        private System.Windows.Forms.RadioButton rbSexoFeminino;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtDataNascimento;
    }
}