namespace InvoiceTracker
{
    partial class AddInvoiceForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddInvoiceForm));
            this.tbInvoiceNumber = new System.Windows.Forms.TextBox();
            this.lblInvoiceNumber = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceTrackerDataSet = new InvoiceTracker.InvoiceTrackerDataSet();
            this.clientTableAdapter = new InvoiceTracker.InvoiceTrackerDataSetTableAdapters.ClientTableAdapter();
            this.lblInvoiceDate = new System.Windows.Forms.Label();
            this.lblInvoiceLocation = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.dateInvoice = new System.Windows.Forms.DateTimePicker();
            this.cbLocations = new System.Windows.Forms.ComboBox();
            this.locationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbNote = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.locationTableAdapter = new InvoiceTracker.InvoiceTrackerDataSetTableAdapters.LocationTableAdapter();
            this.invoiceTableAdapter = new InvoiceTracker.InvoiceTrackerDataSetTableAdapters.InvoiceTableAdapter();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgInvoiceItems = new System.Windows.Forms.DataGridView();
            this.ItemIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitIDColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.unitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UnitPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VATColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VatSumColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceItemTableAdapter = new InvoiceTracker.InvoiceTrackerDataSetTableAdapters.InvoiceItemTableAdapter();
            this.unitTableAdapter = new InvoiceTracker.InvoiceTrackerDataSetTableAdapters.UnitTableAdapter();
            this.lblClientPIB = new System.Windows.Forms.Label();
            this.lblClientAddress = new System.Windows.Forms.Label();
            this.gbClient = new System.Windows.Forms.GroupBox();
            this.btnChooseClient = new System.Windows.Forms.Button();
            this.tbClientAddress = new System.Windows.Forms.TextBox();
            this.tbClientPIB = new System.Windows.Forms.TextBox();
            this.tbClientName = new System.Windows.Forms.TextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPrint = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.cbInvoiceTypes = new System.Windows.Forms.ComboBox();
            this.invoiceTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblInvoiceType = new System.Windows.Forms.Label();
            this.invoiceTypeTableAdapter = new InvoiceTracker.InvoiceTrackerDataSetTableAdapters.InvoiceTypeTableAdapter();
            this.lblTurnoverDate = new System.Windows.Forms.Label();
            this.dateTurnover = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceTrackerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgInvoiceItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceItemBindingSource)).BeginInit();
            this.gbClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbInvoiceNumber
            // 
            this.tbInvoiceNumber.CausesValidation = false;
            this.tbInvoiceNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInvoiceNumber.Location = new System.Drawing.Point(163, 27);
            this.tbInvoiceNumber.Name = "tbInvoiceNumber";
            this.tbInvoiceNumber.ReadOnly = true;
            this.tbInvoiceNumber.Size = new System.Drawing.Size(277, 22);
            this.tbInvoiceNumber.TabIndex = 1;
            // 
            // lblInvoiceNumber
            // 
            this.lblInvoiceNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceNumber.Location = new System.Drawing.Point(17, 27);
            this.lblInvoiceNumber.Name = "lblInvoiceNumber";
            this.lblInvoiceNumber.Size = new System.Drawing.Size(134, 29);
            this.lblInvoiceNumber.TabIndex = 0;
            this.lblInvoiceNumber.Text = "lblInvoiceNumber";
            // 
            // lblClientName
            // 
            this.lblClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientName.Location = new System.Drawing.Point(12, 53);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(134, 29);
            this.lblClientName.TabIndex = 1;
            this.lblClientName.Text = "lblClientName";
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.invoiceTrackerDataSet;
            // 
            // invoiceTrackerDataSet
            // 
            this.invoiceTrackerDataSet.DataSetName = "InvoiceTrackerDataSet";
            this.invoiceTrackerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // lblInvoiceDate
            // 
            this.lblInvoiceDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceDate.Location = new System.Drawing.Point(17, 66);
            this.lblInvoiceDate.Name = "lblInvoiceDate";
            this.lblInvoiceDate.Size = new System.Drawing.Size(134, 29);
            this.lblInvoiceDate.TabIndex = 4;
            this.lblInvoiceDate.Text = "lblInvoiceDate";
            // 
            // lblInvoiceLocation
            // 
            this.lblInvoiceLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceLocation.Location = new System.Drawing.Point(517, 61);
            this.lblInvoiceLocation.Name = "lblInvoiceLocation";
            this.lblInvoiceLocation.Size = new System.Drawing.Size(134, 29);
            this.lblInvoiceLocation.TabIndex = 6;
            this.lblInvoiceLocation.Text = "lblInvoiceLocation";
            // 
            // lblNote
            // 
            this.lblNote.Location = new System.Drawing.Point(517, 126);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(134, 29);
            this.lblNote.TabIndex = 9;
            this.lblNote.Text = "lblNote";
            // 
            // dateInvoice
            // 
            this.dateInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateInvoice.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateInvoice.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dateInvoice.Location = new System.Drawing.Point(164, 61);
            this.dateInvoice.Name = "dateInvoice";
            this.dateInvoice.Size = new System.Drawing.Size(277, 22);
            this.dateInvoice.TabIndex = 5;
            // 
            // cbLocations
            // 
            this.cbLocations.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbLocations.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbLocations.DataSource = this.locationBindingSource;
            this.cbLocations.DisplayMember = "LocationName";
            this.cbLocations.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLocations.FormattingEnabled = true;
            this.cbLocations.Location = new System.Drawing.Point(657, 58);
            this.cbLocations.Name = "cbLocations";
            this.cbLocations.Size = new System.Drawing.Size(277, 24);
            this.cbLocations.TabIndex = 7;
            this.cbLocations.ValueMember = "LocationID";
            // 
            // locationBindingSource
            // 
            this.locationBindingSource.DataMember = "Location";
            this.locationBindingSource.DataSource = this.invoiceTrackerDataSet;
            // 
            // tbNote
            // 
            this.tbNote.Location = new System.Drawing.Point(657, 117);
            this.tbNote.Multiline = true;
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(277, 84);
            this.tbNote.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSave.AutoEllipsis = true;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(459, 546);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "btn&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(545, 546);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "btn&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // locationTableAdapter
            // 
            this.locationTableAdapter.ClearBeforeFill = true;
            // 
            // invoiceTableAdapter
            // 
            this.invoiceTableAdapter.ClearBeforeFill = true;
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataMember = "Invoice";
            this.invoiceBindingSource.DataSource = this.invoiceTrackerDataSet;
            // 
            // dgInvoiceItems
            // 
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgInvoiceItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgInvoiceItems.AutoGenerateColumns = false;
            this.dgInvoiceItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInvoiceItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemIDColumn,
            this.InvoiceIDColumn,
            this.DescriptionColumn,
            this.UnitIDColumn,
            this.UnitPriceColumn,
            this.QuantityColumn,
            this.ValueColumn,
            this.VATColumn,
            this.VatSumColumn,
            this.TotalColumn});
            this.dgInvoiceItems.DataSource = this.invoiceItemBindingSource;
            this.dgInvoiceItems.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgInvoiceItems.Location = new System.Drawing.Point(21, 315);
            this.dgInvoiceItems.Name = "dgInvoiceItems";
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgInvoiceItems.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgInvoiceItems.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgInvoiceItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgInvoiceItems.Size = new System.Drawing.Size(942, 195);
            this.dgInvoiceItems.TabIndex = 13;
            this.dgInvoiceItems.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgInvoiceItems_CellEndEdit);
            this.dgInvoiceItems.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgInvoiceItems_CellLeave);
            this.dgInvoiceItems.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgInvoiceItems_CellPainting);
            this.dgInvoiceItems.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgInvoiceItems_CellValidating);
            this.dgInvoiceItems.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgInvoiceItems_CellValueChanged);
            this.dgInvoiceItems.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgInvoiceItems_DataBindingComplete);
            this.dgInvoiceItems.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgInvoiceItems_DefaultValuesNeeded);
            this.dgInvoiceItems.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgInvoiceItems_RowEnter);
            this.dgInvoiceItems.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgInvoiceItems_RowsAdded);
            this.dgInvoiceItems.MouseHover += new System.EventHandler(this.dgInvoiceItems_MouseHover);
            // 
            // ItemIDColumn
            // 
            this.ItemIDColumn.DataPropertyName = "ItemID";
            this.ItemIDColumn.HeaderText = "ItemID";
            this.ItemIDColumn.Name = "ItemIDColumn";
            this.ItemIDColumn.Visible = false;
            this.ItemIDColumn.Width = 120;
            // 
            // InvoiceIDColumn
            // 
            this.InvoiceIDColumn.DataPropertyName = "InvoiceID";
            this.InvoiceIDColumn.HeaderText = "InvoiceID";
            this.InvoiceIDColumn.Name = "InvoiceIDColumn";
            this.InvoiceIDColumn.Visible = false;
            // 
            // DescriptionColumn
            // 
            this.DescriptionColumn.DataPropertyName = "Description";
            this.DescriptionColumn.HeaderText = "Description";
            this.DescriptionColumn.Name = "DescriptionColumn";
            this.DescriptionColumn.Width = 150;
            // 
            // UnitIDColumn
            // 
            this.UnitIDColumn.DataPropertyName = "UnitID";
            this.UnitIDColumn.DataSource = this.unitBindingSource;
            this.UnitIDColumn.DisplayMember = "FullName";
            this.UnitIDColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.UnitIDColumn.HeaderText = "Unit";
            this.UnitIDColumn.Name = "UnitIDColumn";
            this.UnitIDColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UnitIDColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.UnitIDColumn.ValueMember = "UnitID";
            this.UnitIDColumn.Width = 120;
            // 
            // unitBindingSource
            // 
            this.unitBindingSource.DataMember = "Unit";
            this.unitBindingSource.DataSource = this.invoiceTrackerDataSet;
            // 
            // UnitPriceColumn
            // 
            this.UnitPriceColumn.DataPropertyName = "UnitPrice";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "N2";
            dataGridViewCellStyle10.NullValue = "0.00";
            this.UnitPriceColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.UnitPriceColumn.HeaderText = "Unit Price";
            this.UnitPriceColumn.Name = "UnitPriceColumn";
            // 
            // QuantityColumn
            // 
            this.QuantityColumn.DataPropertyName = "Quantity";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "N2";
            dataGridViewCellStyle11.NullValue = "0";
            this.QuantityColumn.DefaultCellStyle = dataGridViewCellStyle11;
            this.QuantityColumn.HeaderText = "Quantity";
            this.QuantityColumn.Name = "QuantityColumn";
            // 
            // ValueColumn
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "N2";
            dataGridViewCellStyle12.NullValue = "0.00";
            this.ValueColumn.DefaultCellStyle = dataGridViewCellStyle12;
            this.ValueColumn.HeaderText = "Value";
            this.ValueColumn.Name = "ValueColumn";
            this.ValueColumn.ReadOnly = true;
            // 
            // VATColumn
            // 
            this.VATColumn.DataPropertyName = "VAT";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle13.Format = "N2";
            dataGridViewCellStyle13.NullValue = "0.00";
            this.VATColumn.DefaultCellStyle = dataGridViewCellStyle13;
            this.VATColumn.HeaderText = "VAT";
            this.VATColumn.Name = "VATColumn";
            // 
            // VatSumColumn
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.Format = "N2";
            dataGridViewCellStyle14.NullValue = "0.00";
            this.VatSumColumn.DefaultCellStyle = dataGridViewCellStyle14;
            this.VatSumColumn.HeaderText = "VatSum";
            this.VatSumColumn.Name = "VatSumColumn";
            this.VatSumColumn.ReadOnly = true;
            // 
            // TotalColumn
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle15.Format = "N2";
            dataGridViewCellStyle15.NullValue = "0.00";
            this.TotalColumn.DefaultCellStyle = dataGridViewCellStyle15;
            this.TotalColumn.HeaderText = "Total";
            this.TotalColumn.Name = "TotalColumn";
            this.TotalColumn.ReadOnly = true;
            // 
            // invoiceItemBindingSource
            // 
            this.invoiceItemBindingSource.DataMember = "InvoiceItem";
            this.invoiceItemBindingSource.DataSource = this.invoiceTrackerDataSet;
            // 
            // invoiceItemTableAdapter
            // 
            this.invoiceItemTableAdapter.ClearBeforeFill = true;
            // 
            // unitTableAdapter
            // 
            this.unitTableAdapter.ClearBeforeFill = true;
            // 
            // lblClientPIB
            // 
            this.lblClientPIB.AutoSize = true;
            this.lblClientPIB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientPIB.Location = new System.Drawing.Point(12, 85);
            this.lblClientPIB.Name = "lblClientPIB";
            this.lblClientPIB.Size = new System.Drawing.Size(76, 16);
            this.lblClientPIB.TabIndex = 3;
            this.lblClientPIB.Text = "lblClientPIB";
            // 
            // lblClientAddress
            // 
            this.lblClientAddress.AutoSize = true;
            this.lblClientAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientAddress.Location = new System.Drawing.Point(12, 118);
            this.lblClientAddress.Name = "lblClientAddress";
            this.lblClientAddress.Size = new System.Drawing.Size(106, 16);
            this.lblClientAddress.TabIndex = 5;
            this.lblClientAddress.Text = "lblClientAddress";
            // 
            // gbClient
            // 
            this.gbClient.Controls.Add(this.btnChooseClient);
            this.gbClient.Controls.Add(this.tbClientAddress);
            this.gbClient.Controls.Add(this.tbClientPIB);
            this.gbClient.Controls.Add(this.lblClientAddress);
            this.gbClient.Controls.Add(this.tbClientName);
            this.gbClient.Controls.Add(this.lblClientPIB);
            this.gbClient.Controls.Add(this.lblClientName);
            this.gbClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbClient.Location = new System.Drawing.Point(21, 97);
            this.gbClient.Name = "gbClient";
            this.gbClient.Size = new System.Drawing.Size(438, 200);
            this.gbClient.TabIndex = 8;
            this.gbClient.TabStop = false;
            this.gbClient.Text = "gbClient";
            // 
            // btnChooseClient
            // 
            this.btnChooseClient.AutoSize = true;
            this.btnChooseClient.Location = new System.Drawing.Point(304, 20);
            this.btnChooseClient.Name = "btnChooseClient";
            this.btnChooseClient.Size = new System.Drawing.Size(116, 26);
            this.btnChooseClient.TabIndex = 0;
            this.btnChooseClient.Text = "btnChooseClient";
            this.btnChooseClient.UseVisualStyleBackColor = true;
            this.btnChooseClient.Click += new System.EventHandler(this.btnChooseClient_Click);
            // 
            // tbClientAddress
            // 
            this.tbClientAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClientAddress.Location = new System.Drawing.Point(143, 118);
            this.tbClientAddress.Multiline = true;
            this.tbClientAddress.Name = "tbClientAddress";
            this.tbClientAddress.Size = new System.Drawing.Size(277, 62);
            this.tbClientAddress.TabIndex = 6;
            // 
            // tbClientPIB
            // 
            this.tbClientPIB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClientPIB.Location = new System.Drawing.Point(143, 85);
            this.tbClientPIB.Name = "tbClientPIB";
            this.tbClientPIB.Size = new System.Drawing.Size(277, 22);
            this.tbClientPIB.TabIndex = 4;
            // 
            // tbClientName
            // 
            this.tbClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClientName.Location = new System.Drawing.Point(143, 53);
            this.tbClientName.Name = "tbClientName";
            this.tbClientName.Size = new System.Drawing.Size(277, 22);
            this.tbClientName.TabIndex = 2;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.invoiceItemBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(21, 513);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.bindingNavigator1.Size = new System.Drawing.Size(266, 25);
            this.bindingNavigator1.TabIndex = 14;
            this.bindingNavigator1.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(39, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(57, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPrint.Location = new System.Drawing.Point(373, 546);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 15;
            this.btnPrint.Text = "btnPrint";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 582);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(984, 22);
            this.statusStrip.TabIndex = 18;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // cbInvoiceTypes
            // 
            this.cbInvoiceTypes.DataSource = this.invoiceTypeBindingSource;
            this.cbInvoiceTypes.DisplayMember = "InvoiceTypeName";
            this.cbInvoiceTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInvoiceTypes.FormattingEnabled = true;
            this.cbInvoiceTypes.Location = new System.Drawing.Point(657, 27);
            this.cbInvoiceTypes.Name = "cbInvoiceTypes";
            this.cbInvoiceTypes.Size = new System.Drawing.Size(277, 24);
            this.cbInvoiceTypes.TabIndex = 3;
            this.cbInvoiceTypes.ValueMember = "InvoiceTypeID";
            this.cbInvoiceTypes.SelectedIndexChanged += new System.EventHandler(this.cbInvoiceTypes_SelectedIndexChanged);
            // 
            // invoiceTypeBindingSource
            // 
            this.invoiceTypeBindingSource.DataMember = "InvoiceType";
            this.invoiceTypeBindingSource.DataSource = this.invoiceTrackerDataSet;
            // 
            // lblInvoiceType
            // 
            this.lblInvoiceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceType.Location = new System.Drawing.Point(517, 27);
            this.lblInvoiceType.Name = "lblInvoiceType";
            this.lblInvoiceType.Size = new System.Drawing.Size(134, 29);
            this.lblInvoiceType.TabIndex = 2;
            this.lblInvoiceType.Text = "lblInvoiceType";
            // 
            // invoiceTypeTableAdapter
            // 
            this.invoiceTypeTableAdapter.ClearBeforeFill = true;
            // 
            // lblTurnoverDate
            // 
            this.lblTurnoverDate.AutoSize = true;
            this.lblTurnoverDate.Location = new System.Drawing.Point(517, 215);
            this.lblTurnoverDate.Name = "lblTurnoverDate";
            this.lblTurnoverDate.Size = new System.Drawing.Size(105, 16);
            this.lblTurnoverDate.TabIndex = 11;
            this.lblTurnoverDate.Text = "lblTurnoverDate";
            // 
            // dateTurnover
            // 
            this.dateTurnover.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTurnover.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTurnover.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dateTurnover.Location = new System.Drawing.Point(657, 215);
            this.dateTurnover.Name = "dateTurnover";
            this.dateTurnover.Size = new System.Drawing.Size(277, 22);
            this.dateTurnover.TabIndex = 12;
            // 
            // AddInvoiceForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(984, 604);
            this.Controls.Add(this.dateTurnover);
            this.Controls.Add(this.lblTurnoverDate);
            this.Controls.Add(this.lblInvoiceType);
            this.Controls.Add(this.cbInvoiceTypes);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dgInvoiceItems);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbNote);
            this.Controls.Add(this.cbLocations);
            this.Controls.Add(this.dateInvoice);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lblInvoiceLocation);
            this.Controls.Add(this.lblInvoiceDate);
            this.Controls.Add(this.lblInvoiceNumber);
            this.Controls.Add(this.tbInvoiceNumber);
            this.Controls.Add(this.gbClient);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1000, 590);
            this.Name = "AddInvoiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddInvoice";
            this.Load += new System.EventHandler(this.AddInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceTrackerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgInvoiceItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceItemBindingSource)).EndInit();
            this.gbClient.ResumeLayout(false);
            this.gbClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceTypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInvoiceNumber;
        private System.Windows.Forms.Label lblInvoiceNumber;
        private System.Windows.Forms.Label lblClientName;
        private InvoiceTrackerDataSet invoiceTrackerDataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private InvoiceTrackerDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.Label lblInvoiceDate;
        private System.Windows.Forms.Label lblInvoiceLocation;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.DateTimePicker dateInvoice;
        private System.Windows.Forms.ComboBox cbLocations;
        private System.Windows.Forms.TextBox tbNote;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.BindingSource locationBindingSource;
        private InvoiceTrackerDataSetTableAdapters.LocationTableAdapter locationTableAdapter;
        private InvoiceTrackerDataSetTableAdapters.InvoiceTableAdapter invoiceTableAdapter;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private System.Windows.Forms.DataGridView dgInvoiceItems;
        private System.Windows.Forms.BindingSource invoiceItemBindingSource;
        private InvoiceTrackerDataSetTableAdapters.InvoiceItemTableAdapter invoiceItemTableAdapter;
        private System.Windows.Forms.BindingSource unitBindingSource;
        private InvoiceTrackerDataSetTableAdapters.UnitTableAdapter unitTableAdapter;
        private System.Windows.Forms.Label lblClientPIB;
        private System.Windows.Forms.Label lblClientAddress;
        private System.Windows.Forms.GroupBox gbClient;
        private System.Windows.Forms.TextBox tbClientAddress;
        private System.Windows.Forms.TextBox tbClientPIB;
        private System.Windows.Forms.TextBox tbClientName;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
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
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn UnitIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValueColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn VATColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn VatSumColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalColumn;
        private System.Windows.Forms.ComboBox cbInvoiceTypes;
        private System.Windows.Forms.Label lblInvoiceType;
        private System.Windows.Forms.BindingSource invoiceTypeBindingSource;
        private InvoiceTrackerDataSetTableAdapters.InvoiceTypeTableAdapter invoiceTypeTableAdapter;
        private System.Windows.Forms.Button btnChooseClient;
        private System.Windows.Forms.Label lblTurnoverDate;
        private System.Windows.Forms.DateTimePicker dateTurnover;
    }
}