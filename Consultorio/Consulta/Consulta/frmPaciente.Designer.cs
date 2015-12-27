namespace Consulta
{
    partial class frmPaciente
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPaciente));
            System.Windows.Forms.Label iDPacienteLabel;
            System.Windows.Forms.Label nomePacienteLabel;
            System.Windows.Forms.Label telefoneLabel;
            this.consultorioDataSet = new Consulta.ConsultorioDataSet();
            this.pacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacienteTableAdapter = new Consulta.ConsultorioDataSetTableAdapters.PacienteTableAdapter();
            this.tableAdapterManager = new Consulta.ConsultorioDataSetTableAdapters.TableAdapterManager();
            this.pacienteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.pacienteBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDPacienteLabel1 = new System.Windows.Forms.Label();
            this.nomePacienteTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.telefoneTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            iDPacienteLabel = new System.Windows.Forms.Label();
            nomePacienteLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.consultorioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingNavigator)).BeginInit();
            this.pacienteBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nomePacienteTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefoneTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // consultorioDataSet
            // 
            this.consultorioDataSet.DataSetName = "ConsultorioDataSet";
            this.consultorioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pacienteBindingSource
            // 
            this.pacienteBindingSource.DataMember = "Paciente";
            this.pacienteBindingSource.DataSource = this.consultorioDataSet;
            // 
            // pacienteTableAdapter
            // 
            this.pacienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConsultaTableAdapter = null;
            this.tableAdapterManager.MedicoTableAdapter = null;
            this.tableAdapterManager.PacienteTableAdapter = this.pacienteTableAdapter;
            this.tableAdapterManager.UpdateOrder = Consulta.ConsultorioDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pacienteBindingNavigator
            // 
            this.pacienteBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pacienteBindingNavigator.BindingSource = this.pacienteBindingSource;
            this.pacienteBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pacienteBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pacienteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.pacienteBindingNavigatorSaveItem,
            this.toolStripSeparator1,
            this.toolStripButton1});
            this.pacienteBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pacienteBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pacienteBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pacienteBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pacienteBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pacienteBindingNavigator.Name = "pacienteBindingNavigator";
            this.pacienteBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pacienteBindingNavigator.Size = new System.Drawing.Size(505, 25);
            this.pacienteBindingNavigator.TabIndex = 0;
            this.pacienteBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // pacienteBindingNavigatorSaveItem
            // 
            this.pacienteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pacienteBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pacienteBindingNavigatorSaveItem.Image")));
            this.pacienteBindingNavigatorSaveItem.Name = "pacienteBindingNavigatorSaveItem";
            this.pacienteBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.pacienteBindingNavigatorSaveItem.Text = "Save Data";
            this.pacienteBindingNavigatorSaveItem.Click += new System.EventHandler(this.pacienteBindingNavigatorSaveItem_Click);
            // 
            // iDPacienteLabel
            // 
            iDPacienteLabel.AutoSize = true;
            iDPacienteLabel.Location = new System.Drawing.Point(12, 51);
            iDPacienteLabel.Name = "iDPacienteLabel";
            iDPacienteLabel.Size = new System.Drawing.Size(63, 13);
            iDPacienteLabel.TabIndex = 1;
            iDPacienteLabel.Text = "IDPaciente:";
            // 
            // iDPacienteLabel1
            // 
            this.iDPacienteLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "IDPaciente", true));
            this.iDPacienteLabel1.Location = new System.Drawing.Point(101, 51);
            this.iDPacienteLabel1.Name = "iDPacienteLabel1";
            this.iDPacienteLabel1.Size = new System.Drawing.Size(100, 23);
            this.iDPacienteLabel1.TabIndex = 2;
            this.iDPacienteLabel1.Text = "label1";
            // 
            // nomePacienteLabel
            // 
            nomePacienteLabel.AutoSize = true;
            nomePacienteLabel.Location = new System.Drawing.Point(12, 77);
            nomePacienteLabel.Name = "nomePacienteLabel";
            nomePacienteLabel.Size = new System.Drawing.Size(83, 13);
            nomePacienteLabel.TabIndex = 3;
            nomePacienteLabel.Text = "Nome Paciente:";
            // 
            // nomePacienteTextEdit
            // 
            this.nomePacienteTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.pacienteBindingSource, "NomePaciente", true));
            this.nomePacienteTextEdit.Location = new System.Drawing.Point(101, 74);
            this.nomePacienteTextEdit.Name = "nomePacienteTextEdit";
            this.nomePacienteTextEdit.Size = new System.Drawing.Size(182, 20);
            this.nomePacienteTextEdit.TabIndex = 4;
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(12, 103);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(52, 13);
            telefoneLabel.TabIndex = 5;
            telefoneLabel.Text = "Telefone:";
            // 
            // telefoneTextEdit
            // 
            this.telefoneTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.pacienteBindingSource, "Telefone", true));
            this.telefoneTextEdit.Location = new System.Drawing.Point(101, 100);
            this.telefoneTextEdit.Name = "telefoneTextEdit";
            this.telefoneTextEdit.Size = new System.Drawing.Size(182, 20);
            this.telefoneTextEdit.TabIndex = 6;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(46, 22);
            this.toolStripButton1.Text = "Fechar";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // frmPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 131);
            this.Controls.Add(iDPacienteLabel);
            this.Controls.Add(this.iDPacienteLabel1);
            this.Controls.Add(nomePacienteLabel);
            this.Controls.Add(this.nomePacienteTextEdit);
            this.Controls.Add(telefoneLabel);
            this.Controls.Add(this.telefoneTextEdit);
            this.Controls.Add(this.pacienteBindingNavigator);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Pacientes";
            this.Load += new System.EventHandler(this.frmPaciente_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPaciente_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.consultorioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingNavigator)).EndInit();
            this.pacienteBindingNavigator.ResumeLayout(false);
            this.pacienteBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nomePacienteTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefoneTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ConsultorioDataSet consultorioDataSet;
        private System.Windows.Forms.BindingSource pacienteBindingSource;
        private ConsultorioDataSetTableAdapters.PacienteTableAdapter pacienteTableAdapter;
        private ConsultorioDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pacienteBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton pacienteBindingNavigatorSaveItem;
        private System.Windows.Forms.Label iDPacienteLabel1;
        private DevExpress.XtraEditors.TextEdit nomePacienteTextEdit;
        private DevExpress.XtraEditors.TextEdit telefoneTextEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}