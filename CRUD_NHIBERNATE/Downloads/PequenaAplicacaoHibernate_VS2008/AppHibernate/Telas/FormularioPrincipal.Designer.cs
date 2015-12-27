namespace PrimeraAplicacaoNHibernate.Telas
{
    partial class FormularioPrincipal
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
            this.btCategoria = new System.Windows.Forms.Button();
            this.btPessoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btCategoria
            // 
            this.btCategoria.Location = new System.Drawing.Point(46, 12);
            this.btCategoria.Name = "btCategoria";
            this.btCategoria.Size = new System.Drawing.Size(75, 23);
            this.btCategoria.TabIndex = 8;
            this.btCategoria.Text = "Categorias";
            this.btCategoria.UseVisualStyleBackColor = true;
            this.btCategoria.Click += new System.EventHandler(this.btCategoria_Click);
            // 
            // btPessoa
            // 
            this.btPessoa.Location = new System.Drawing.Point(180, 12);
            this.btPessoa.Name = "btPessoa";
            this.btPessoa.Size = new System.Drawing.Size(75, 23);
            this.btPessoa.TabIndex = 9;
            this.btPessoa.Text = "Pessoas";
            this.btPessoa.UseVisualStyleBackColor = true;
            this.btPessoa.Click += new System.EventHandler(this.btPessoa_Click);
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 63);
            this.Controls.Add(this.btPessoa);
            this.Controls.Add(this.btCategoria);
            this.Name = "FormularioPrincipal";
            this.Text = "Primeira Aplicação NHibernate";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCategoria;
        private System.Windows.Forms.Button btPessoa;
    }
}