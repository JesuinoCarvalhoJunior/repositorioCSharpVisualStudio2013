namespace Consulta
{
    partial class frmConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsulta));
            System.Windows.Forms.Label iDConsultaLabel;
            System.Windows.Forms.Label iDMedicoLabel;
            System.Windows.Forms.Label iDPacienteLabel;
            System.Windows.Forms.Label dataConsultaLabel;
            System.Windows.Forms.Label horaInicioLabel;
            System.Windows.Forms.Label horaFimLabel;
            System.Windows.Forms.Label observacaoLabel;
            this.consultorioDataSet = new Consulta.ConsultorioDataSet();
            this.consultaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultaTableAdapter = new Consulta.ConsultorioDataSetTableAdapters.ConsultaTableAdapter();
            this.tableAdapterManager = new Consulta.ConsultorioDataSetTableAdapters.TableAdapterManager();
            this.consultaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.consultaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDConsultaLabel1 = new System.Windows.Forms.Label();
            this.iDMedicoComboBox = new System.Windows.Forms.ComboBox();
            this.iDPacienteComboBox = new System.Windows.Forms.ComboBox();
            this.dataConsultaDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.horaInicioDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.horaFimDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.medicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicoTableAdapter = new Consulta.ConsultorioDataSetTableAdapters.MedicoTableAdapter();
            this.pacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacienteTableAdapter = new Consulta.ConsultorioDataSetTableAdapters.PacienteTableAdapter();
            this.consultaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.observacaoTextBox = new System.Windows.Forms.TextBox();
            iDConsultaLabel = new System.Windows.Forms.Label();
            iDMedicoLabel = new System.Windows.Forms.Label();
            iDPacienteLabel = new System.Windows.Forms.Label();
            dataConsultaLabel = new System.Windows.Forms.Label();
            horaInicioLabel = new System.Windows.Forms.Label();
            horaFimLabel = new System.Windows.Forms.Label();
            observacaoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.consultorioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaBindingNavigator)).BeginInit();
            this.consultaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataConsultaDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataConsultaDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horaInicioDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horaInicioDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horaFimDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horaFimDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // consultorioDataSet
            // 
            this.consultorioDataSet.DataSetName = "ConsultorioDataSet";
            this.consultorioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // consultaBindingSource
            // 
            this.consultaBindingSource.DataMember = "Consulta";
            this.consultaBindingSource.DataSource = this.consultorioDataSet;
            // 
            // consultaTableAdapter
            // 
            this.consultaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConsultaTableAdapter = this.consultaTableAdapter;
            this.tableAdapterManager.MedicoTableAdapter = this.medicoTableAdapter;
            this.tableAdapterManager.PacienteTableAdapter = this.pacienteTableAdapter;
            this.tableAdapterManager.UpdateOrder = Consulta.ConsultorioDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // consultaBindingNavigator
            // 
            this.consultaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.consultaBindingNavigator.BindingSource = this.consultaBindingSource;
            this.consultaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.consultaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.consultaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.consultaBindingNavigatorSaveItem,
            this.toolStripSeparator1,
            this.toolStripButton1});
            this.consultaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.consultaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.consultaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.consultaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.consultaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.consultaBindingNavigator.Name = "consultaBindingNavigator";
            this.consultaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.consultaBindingNavigator.Size = new System.Drawing.Size(538, 25);
            this.consultaBindingNavigator.TabIndex = 0;
            this.consultaBindingNavigator.Text = "bindingNavigator1";
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
            // consultaBindingNavigatorSaveItem
            // 
            this.consultaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.consultaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("consultaBindingNavigatorSaveItem.Image")));
            this.consultaBindingNavigatorSaveItem.Name = "consultaBindingNavigatorSaveItem";
            this.consultaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.consultaBindingNavigatorSaveItem.Text = "Save Data";
            this.consultaBindingNavigatorSaveItem.Click += new System.EventHandler(this.consultaBindingNavigatorSaveItem_Click);
            // 
            // iDConsultaLabel
            // 
            iDConsultaLabel.AutoSize = true;
            iDConsultaLabel.Location = new System.Drawing.Point(16, 39);
            iDConsultaLabel.Name = "iDConsultaLabel";
            iDConsultaLabel.Size = new System.Drawing.Size(62, 13);
            iDConsultaLabel.TabIndex = 1;
            iDConsultaLabel.Text = "IDConsulta:";
            // 
            // iDConsultaLabel1
            // 
            this.iDConsultaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultaBindingSource, "IDConsulta", true));
            this.iDConsultaLabel1.Location = new System.Drawing.Point(99, 39);
            this.iDConsultaLabel1.Name = "iDConsultaLabel1";
            this.iDConsultaLabel1.Size = new System.Drawing.Size(121, 23);
            this.iDConsultaLabel1.TabIndex = 2;
            this.iDConsultaLabel1.Text = "label1";
            // 
            // iDMedicoLabel
            // 
            iDMedicoLabel.AutoSize = true;
            iDMedicoLabel.Location = new System.Drawing.Point(16, 68);
            iDMedicoLabel.Name = "iDMedicoLabel";
            iDMedicoLabel.Size = new System.Drawing.Size(56, 13);
            iDMedicoLabel.TabIndex = 3;
            iDMedicoLabel.Text = "IDMedico:";
            // 
            // iDMedicoComboBox
            // 
            this.iDMedicoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.consultaBindingSource, "IDMedico", true));
            this.iDMedicoComboBox.DataSource = this.medicoBindingSource;
            this.iDMedicoComboBox.DisplayMember = "NomeMedico";
            this.iDMedicoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.iDMedicoComboBox.FormattingEnabled = true;
            this.iDMedicoComboBox.Location = new System.Drawing.Point(99, 65);
            this.iDMedicoComboBox.Name = "iDMedicoComboBox";
            this.iDMedicoComboBox.Size = new System.Drawing.Size(396, 21);
            this.iDMedicoComboBox.TabIndex = 4;
            this.iDMedicoComboBox.ValueMember = "IDMedico";
            // 
            // iDPacienteLabel
            // 
            iDPacienteLabel.AutoSize = true;
            iDPacienteLabel.Location = new System.Drawing.Point(16, 95);
            iDPacienteLabel.Name = "iDPacienteLabel";
            iDPacienteLabel.Size = new System.Drawing.Size(63, 13);
            iDPacienteLabel.TabIndex = 5;
            iDPacienteLabel.Text = "IDPaciente:";
            // 
            // iDPacienteComboBox
            // 
            this.iDPacienteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.consultaBindingSource, "IDPaciente", true));
            this.iDPacienteComboBox.DataSource = this.pacienteBindingSource;
            this.iDPacienteComboBox.DisplayMember = "NomePaciente";
            this.iDPacienteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.iDPacienteComboBox.FormattingEnabled = true;
            this.iDPacienteComboBox.Location = new System.Drawing.Point(99, 92);
            this.iDPacienteComboBox.Name = "iDPacienteComboBox";
            this.iDPacienteComboBox.Size = new System.Drawing.Size(396, 21);
            this.iDPacienteComboBox.TabIndex = 6;
            this.iDPacienteComboBox.ValueMember = "IDPaciente";
            // 
            // dataConsultaLabel
            // 
            dataConsultaLabel.AutoSize = true;
            dataConsultaLabel.Location = new System.Drawing.Point(16, 119);
            dataConsultaLabel.Name = "dataConsultaLabel";
            dataConsultaLabel.Size = new System.Drawing.Size(77, 13);
            dataConsultaLabel.TabIndex = 7;
            dataConsultaLabel.Text = "Data Consulta:";
            // 
            // dataConsultaDateEdit
            // 
            this.dataConsultaDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.consultaBindingSource, "DataConsulta", true));
            this.dataConsultaDateEdit.EditValue = null;
            this.dataConsultaDateEdit.Location = new System.Drawing.Point(99, 119);
            this.dataConsultaDateEdit.Name = "dataConsultaDateEdit";
            this.dataConsultaDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dataConsultaDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dataConsultaDateEdit.Properties.DisplayFormat.FormatString = "dd/MMM/yyyy";
            this.dataConsultaDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dataConsultaDateEdit.Properties.EditFormat.FormatString = "dd/MMM/yyyy";
            this.dataConsultaDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dataConsultaDateEdit.Properties.Mask.EditMask = "dd/MMM/yyyy";
            this.dataConsultaDateEdit.Size = new System.Drawing.Size(171, 20);
            this.dataConsultaDateEdit.TabIndex = 8;
            // 
            // horaInicioLabel
            // 
            horaInicioLabel.AutoSize = true;
            horaInicioLabel.Location = new System.Drawing.Point(16, 145);
            horaInicioLabel.Name = "horaInicioLabel";
            horaInicioLabel.Size = new System.Drawing.Size(61, 13);
            horaInicioLabel.TabIndex = 9;
            horaInicioLabel.Text = "Hora Inicio:";
            // 
            // horaInicioDateEdit
            // 
            this.horaInicioDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.consultaBindingSource, "HoraInicio", true));
            this.horaInicioDateEdit.EditValue = null;
            this.horaInicioDateEdit.Location = new System.Drawing.Point(99, 142);
            this.horaInicioDateEdit.Name = "horaInicioDateEdit";
            this.horaInicioDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.horaInicioDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.horaInicioDateEdit.Properties.DisplayFormat.FormatString = "HH:mm";
            this.horaInicioDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.horaInicioDateEdit.Properties.EditFormat.FormatString = "HH:mm";
            this.horaInicioDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.horaInicioDateEdit.Properties.Mask.EditMask = "HH:mm";
            this.horaInicioDateEdit.Size = new System.Drawing.Size(171, 20);
            this.horaInicioDateEdit.TabIndex = 10;
            // 
            // horaFimLabel
            // 
            horaFimLabel.AutoSize = true;
            horaFimLabel.Location = new System.Drawing.Point(16, 171);
            horaFimLabel.Name = "horaFimLabel";
            horaFimLabel.Size = new System.Drawing.Size(52, 13);
            horaFimLabel.TabIndex = 11;
            horaFimLabel.Text = "Hora Fim:";
            // 
            // horaFimDateEdit
            // 
            this.horaFimDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.consultaBindingSource, "HoraFim", true));
            this.horaFimDateEdit.EditValue = null;
            this.horaFimDateEdit.Location = new System.Drawing.Point(99, 168);
            this.horaFimDateEdit.Name = "horaFimDateEdit";
            this.horaFimDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.horaFimDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.horaFimDateEdit.Properties.DisplayFormat.FormatString = "HH:mm";
            this.horaFimDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.horaFimDateEdit.Properties.EditFormat.FormatString = "HH:mm";
            this.horaFimDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.horaFimDateEdit.Properties.Mask.EditMask = "HH:mm";
            this.horaFimDateEdit.Size = new System.Drawing.Size(171, 20);
            this.horaFimDateEdit.TabIndex = 12;
            // 
            // observacaoLabel
            // 
            observacaoLabel.AutoSize = true;
            observacaoLabel.Location = new System.Drawing.Point(16, 197);
            observacaoLabel.Name = "observacaoLabel";
            observacaoLabel.Size = new System.Drawing.Size(68, 13);
            observacaoLabel.TabIndex = 13;
            observacaoLabel.Text = "Observacao:";
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
            // medicoBindingSource
            // 
            this.medicoBindingSource.DataMember = "Medico";
            this.medicoBindingSource.DataSource = this.consultorioDataSet;
            // 
            // medicoTableAdapter
            // 
            this.medicoTableAdapter.ClearBeforeFill = true;
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
            // consultaBindingSource1
            // 
            this.consultaBindingSource1.DataMember = "FK_Consulta_Paciente";
            this.consultaBindingSource1.DataSource = this.pacienteBindingSource;
            // 
            // observacaoTextBox
            // 
            this.observacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultaBindingSource1, "Observacao", true));
            this.observacaoTextBox.Location = new System.Drawing.Point(99, 197);
            this.observacaoTextBox.Multiline = true;
            this.observacaoTextBox.Name = "observacaoTextBox";
            this.observacaoTextBox.Size = new System.Drawing.Size(396, 63);
            this.observacaoTextBox.TabIndex = 16;
            // 
            // frmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 272);
            this.Controls.Add(this.observacaoTextBox);
            this.Controls.Add(iDConsultaLabel);
            this.Controls.Add(this.iDConsultaLabel1);
            this.Controls.Add(iDMedicoLabel);
            this.Controls.Add(this.iDMedicoComboBox);
            this.Controls.Add(iDPacienteLabel);
            this.Controls.Add(this.iDPacienteComboBox);
            this.Controls.Add(dataConsultaLabel);
            this.Controls.Add(this.dataConsultaDateEdit);
            this.Controls.Add(horaInicioLabel);
            this.Controls.Add(this.horaInicioDateEdit);
            this.Controls.Add(horaFimLabel);
            this.Controls.Add(this.horaFimDateEdit);
            this.Controls.Add(observacaoLabel);
            this.Controls.Add(this.consultaBindingNavigator);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsulta";
            this.Load += new System.EventHandler(this.frmConsulta_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmConsulta_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.consultorioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaBindingNavigator)).EndInit();
            this.consultaBindingNavigator.ResumeLayout(false);
            this.consultaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataConsultaDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataConsultaDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horaInicioDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horaInicioDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horaFimDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horaFimDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ConsultorioDataSet consultorioDataSet;
        private System.Windows.Forms.BindingSource consultaBindingSource;
        private ConsultorioDataSetTableAdapters.ConsultaTableAdapter consultaTableAdapter;
        private ConsultorioDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator consultaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton consultaBindingNavigatorSaveItem;
        private System.Windows.Forms.Label iDConsultaLabel1;
        private System.Windows.Forms.ComboBox iDMedicoComboBox;
        private System.Windows.Forms.ComboBox iDPacienteComboBox;
        private DevExpress.XtraEditors.DateEdit dataConsultaDateEdit;
        private DevExpress.XtraEditors.DateEdit horaInicioDateEdit;
        private DevExpress.XtraEditors.DateEdit horaFimDateEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private ConsultorioDataSetTableAdapters.MedicoTableAdapter medicoTableAdapter;
        private System.Windows.Forms.BindingSource medicoBindingSource;
        private ConsultorioDataSetTableAdapters.PacienteTableAdapter pacienteTableAdapter;
        private System.Windows.Forms.BindingSource pacienteBindingSource;
        private System.Windows.Forms.BindingSource consultaBindingSource1;
        private System.Windows.Forms.TextBox observacaoTextBox;
    }
}