namespace CursoCSharpModuloII.ADONET
{
    partial class FormCadCategoria
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
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.salvarButton = new System.Windows.Forms.Button();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.idNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.Location = new System.Drawing.Point(77, 43);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(100, 20);
            this.codigoTextBox.TabIndex = 0;
            // 
            // salvarButton
            // 
            this.salvarButton.Location = new System.Drawing.Point(102, 95);
            this.salvarButton.Name = "salvarButton";
            this.salvarButton.Size = new System.Drawing.Size(75, 23);
            this.salvarButton.TabIndex = 0;
            this.salvarButton.Text = "Salvar";
            this.salvarButton.UseVisualStyleBackColor = true;
            this.salvarButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.Location = new System.Drawing.Point(77, 69);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(100, 20);
            this.descricaoTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Id";
            // 
            // idNumericUpDown
            // 
            this.idNumericUpDown.Location = new System.Drawing.Point(77, 17);
            this.idNumericUpDown.Name = "idNumericUpDown";
            this.idNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.idNumericUpDown.TabIndex = 5;
            this.idNumericUpDown.Validated += new System.EventHandler(this.idNumericUpDown_Validated);
            // 
            // FormCadCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.idNumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.descricaoTextBox);
            this.Controls.Add(this.salvarButton);
            this.Controls.Add(this.codigoTextBox);
            this.Name = "FormCadCategoria";
            this.Text = "FormCadCliente";
            ((System.ComponentModel.ISupportInitialize)(this.idNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.Button salvarButton;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown idNumericUpDown;
    }
}