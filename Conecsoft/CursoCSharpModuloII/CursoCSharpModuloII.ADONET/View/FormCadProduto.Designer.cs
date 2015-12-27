using System.ComponentModel;
using System.Windows.Forms;
using CursoCSharpModuloII.ADONET.DB_EXERCICIO_MODII_CATEGORIA_PRODUTODataSetTableAdapters;
using DevExpress.XtraEditors;
using ComboBox = System.Windows.Forms.ComboBox;

namespace CursoCSharpModuloII.ADONET.View
{
    partial class FormCadProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            this.textEditID = new DevExpress.XtraEditors.TextEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.categoriaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dB_EXERCICIO_MODII_CATEGORIA_PRODUTODataSet = new CursoCSharpModuloII.ADONET.DB_EXERCICIO_MODII_CATEGORIA_PRODUTODataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textEditPeso = new DevExpress.XtraEditors.TextEdit();
            this.textEditNomeProduto = new DevExpress.XtraEditors.TextEdit();
            this.textEditCodigoFabricacao = new DevExpress.XtraEditors.TextEdit();
            this.categoriaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.categoriaTableAdapter = new CursoCSharpModuloII.ADONET.DB_EXERCICIO_MODII_CATEGORIA_PRODUTODataSetTableAdapters.CategoriaTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.textEditID.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_EXERCICIO_MODII_CATEGORIA_PRODUTODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPeso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNomeProduto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditCodigoFabricacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // textEditID
            // 
            this.textEditID.Location = new System.Drawing.Point(109, 19);
            this.textEditID.Name = "textEditID";
            this.textEditID.Size = new System.Drawing.Size(300, 20);
            this.textEditID.TabIndex = 0;
            this.textEditID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEditID_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxCategoria);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textEditPeso);
            this.groupBox1.Controls.Add(this.textEditNomeProduto);
            this.groupBox1.Controls.Add(this.textEditCodigoFabricacao);
            this.groupBox1.Controls.Add(this.textEditID);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 161);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(109, 96);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(300, 21);
            this.comboBoxCategoria.TabIndex = 2;
            // 
            // categoriaBindingSource2
            // 
            this.categoriaBindingSource2.DataMember = "Categoria";
            this.categoriaBindingSource2.DataSource = this.dB_EXERCICIO_MODII_CATEGORIA_PRODUTODataSet;
            // 
            // dB_EXERCICIO_MODII_CATEGORIA_PRODUTODataSet
            // 
            this.dB_EXERCICIO_MODII_CATEGORIA_PRODUTODataSet.DataSetName = "DB_EXERCICIO_MODII_CATEGORIA_PRODUTODataSet";
            this.dB_EXERCICIO_MODII_CATEGORIA_PRODUTODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Peso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Categoria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nome do Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Código Fabricação";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            // 
            // textEditPeso
            // 
            this.textEditPeso.Location = new System.Drawing.Point(109, 123);
            this.textEditPeso.Name = "textEditPeso";
            this.textEditPeso.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textEditPeso.Size = new System.Drawing.Size(300, 20);
            this.textEditPeso.TabIndex = 4;
            // 
            // textEditNomeProduto
            // 
            this.textEditNomeProduto.Location = new System.Drawing.Point(109, 71);
            this.textEditNomeProduto.Name = "textEditNomeProduto";
            this.textEditNomeProduto.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textEditNomeProduto.Size = new System.Drawing.Size(300, 20);
            this.textEditNomeProduto.TabIndex = 2;
            // 
            // textEditCodigoFabricacao
            // 
            this.textEditCodigoFabricacao.Location = new System.Drawing.Point(109, 45);
            this.textEditCodigoFabricacao.Name = "textEditCodigoFabricacao";
            this.textEditCodigoFabricacao.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textEditCodigoFabricacao.Size = new System.Drawing.Size(300, 20);
            this.textEditCodigoFabricacao.TabIndex = 1;
            // 
            // categoriaBindingSource1
            // 
            this.categoriaBindingSource1.DataMember = "Categoria";
            this.categoriaBindingSource1.DataSource = this.dB_EXERCICIO_MODII_CATEGORIA_PRODUTODataSet;
            // 
            // categoriaTableAdapter
            // 
            this.categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(201, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "label6";
            // 
            // FormCadProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 336);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormCadProduto";
            this.Text = "FormCadProduto";
            ((System.ComponentModel.ISupportInitialize)(this.textEditID.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_EXERCICIO_MODII_CATEGORIA_PRODUTODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPeso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNomeProduto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditCodigoFabricacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextEdit textEditID;
        private GroupBox groupBox1;
        private TextEdit textEditPeso;
        private TextEdit textEditNomeProduto;
        private TextEdit textEditCodigoFabricacao;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private CategoriaTableAdapter categoriaTableAdapter;
        private BindingSource categoriaBindingSource1;
        private DB_EXERCICIO_MODII_CATEGORIA_PRODUTODataSet dB_EXERCICIO_MODII_CATEGORIA_PRODUTODataSet;
        private ComboBox comboBoxCategoria;
        private BindingSource categoriaBindingSource2;
        private Button button1;
        private Label label6;
    }
}