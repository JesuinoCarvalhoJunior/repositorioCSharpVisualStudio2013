namespace PrimeraAplicacaoNHibernate.Telas
{
    partial class FormularioDeCategoria
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btNovo = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btRemover = new System.Windows.Forms.Button();
            this.ListaDeCategorias = new System.Windows.Forms.ListBox();
            this.btSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Enabled = false;
            this.txtDescricao.Location = new System.Drawing.Point(15, 25);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(302, 20);
            this.txtDescricao.TabIndex = 1;
            // 
            // btNovo
            // 
            this.btNovo.Location = new System.Drawing.Point(6, 61);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(75, 23);
            this.btNovo.TabIndex = 2;
            this.btNovo.Text = "Novo";
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(87, 61);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(75, 23);
            this.btEditar.TabIndex = 3;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btRemover
            // 
            this.btRemover.Location = new System.Drawing.Point(168, 61);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(75, 23);
            this.btRemover.TabIndex = 4;
            this.btRemover.Text = "Remover";
            this.btRemover.UseVisualStyleBackColor = true;
            this.btRemover.Click += new System.EventHandler(this.btRemover_Click);
            // 
            // ListaDeCategorias
            // 
            this.ListaDeCategorias.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ListaDeCategorias.FormattingEnabled = true;
            this.ListaDeCategorias.Location = new System.Drawing.Point(0, 93);
            this.ListaDeCategorias.Name = "ListaDeCategorias";
            this.ListaDeCategorias.Size = new System.Drawing.Size(329, 173);
            this.ListaDeCategorias.TabIndex = 5;
            this.ListaDeCategorias.SelectedIndexChanged += new System.EventHandler(this.ListaDeCategorias_SelectedIndexChanged);
            // 
            // btSalvar
            // 
            this.btSalvar.Enabled = false;
            this.btSalvar.Location = new System.Drawing.Point(248, 61);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 6;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // FormularioDeCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 266);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.ListaDeCategorias);
            this.Controls.Add(this.btRemover);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FormularioDeCategoria";
            this.Text = "Categorias";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.ListBox ListaDeCategorias;
        private System.Windows.Forms.Button btSalvar;
    }
}