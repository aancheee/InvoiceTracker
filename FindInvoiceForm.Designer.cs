namespace InvoiceTracker
{
    partial class FindInvoiceForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindInvoiceForm));
            this.dgInvoices = new System.Windows.Forms.DataGridView();
            this.gbFindInvoice = new System.Windows.Forms.GroupBox();
            this.tbPib = new System.Windows.Forms.TextBox();
            this.tbLocation = new System.Windows.Forms.TextBox();
            this.tbClientName = new System.Windows.Forms.TextBox();
            this.lblPib = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.bnFindInvoice = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnClose = new System.Windows.Forms.Button();
            this.invoiceTrackerDataSet1 = new InvoiceTracker.InvoiceTrackerDataSet();
            this.btnNewInvoice = new System.Windows.Forms.Button();
            this.findInvoiceDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.findInvoiceDataSet = new InvoiceTracker.FindInvoiceDataSet();
            this.findInvoiceQueryTableAdapter = new InvoiceTracker.FindInvoiceDataSetTableAdapters.FindInvoiceQueryTableAdapter();
            this.InvoiceDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceTypeNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientPIBColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocationNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditInvoiceButtonColumn = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgInvoices)).BeginInit();
            this.gbFindInvoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnFindInvoice)).BeginInit();
            this.bnFindInvoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceTrackerDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.findInvoiceDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.findInvoiceDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgInvoices
            // 
            this.dgInvoices.AllowUserToAddRows = false;
            this.dgInvoices.AllowUserToDeleteRows = false;
            this.dgInvoices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgInvoices.AutoGenerateColumns = false;
            this.dgInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInvoices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InvoiceDateColumn,
            this.InvoiceNumberColumn,
            this.InvoiceTypeNameColumn,
            this.ClientNameColumn,
            this.ClientPIBColumn,
            this.LocationNameColumn,
            this.InvoiceIDColumn,
            this.EditInvoiceButtonColumn});
            this.dgInvoices.DataSource = this.findInvoiceDataSetBindingSource;
            this.dgInvoices.Location = new System.Drawing.Point(17, 156);
            this.dgInvoices.Margin = new System.Windows.Forms.Padding(4);
            this.dgInvoices.Name = "dgInvoices";
            this.dgInvoices.ReadOnly = true;
            this.dgInvoices.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgInvoices.RowTemplate.Height = 30;
            this.dgInvoices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgInvoices.Size = new System.Drawing.Size(879, 320);
            this.dgInvoices.TabIndex = 1;
            this.dgInvoices.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgInvoices_CellClick);
            this.dgInvoices.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgInvoices_CellDoubleClick);
            // 
            // gbFindInvoice
            // 
            this.gbFindInvoice.Controls.Add(this.tbPib);
            this.gbFindInvoice.Controls.Add(this.tbLocation);
            this.gbFindInvoice.Controls.Add(this.tbClientName);
            this.gbFindInvoice.Controls.Add(this.lblPib);
            this.gbFindInvoice.Controls.Add(this.lblLocation);
            this.gbFindInvoice.Controls.Add(this.lblClientName);
            this.gbFindInvoice.Location = new System.Drawing.Point(17, 15);
            this.gbFindInvoice.Margin = new System.Windows.Forms.Padding(4);
            this.gbFindInvoice.Name = "gbFindInvoice";
            this.gbFindInvoice.Padding = new System.Windows.Forms.Padding(4);
            this.gbFindInvoice.Size = new System.Drawing.Size(877, 123);
            this.gbFindInvoice.TabIndex = 0;
            this.gbFindInvoice.TabStop = false;
            this.gbFindInvoice.Text = "gbFindInvoice";
            // 
            // tbPib
            // 
            this.tbPib.Location = new System.Drawing.Point(128, 78);
            this.tbPib.Margin = new System.Windows.Forms.Padding(4);
            this.tbPib.Name = "tbPib";
            this.tbPib.Size = new System.Drawing.Size(307, 22);
            this.tbPib.TabIndex = 5;
            this.tbPib.TextChanged += new System.EventHandler(this.tbPib_TextChanged);
            // 
            // tbLocation
            // 
            this.tbLocation.Location = new System.Drawing.Point(545, 39);
            this.tbLocation.Margin = new System.Windows.Forms.Padding(4);
            this.tbLocation.Name = "tbLocation";
            this.tbLocation.Size = new System.Drawing.Size(307, 22);
            this.tbLocation.TabIndex = 3;
            this.tbLocation.TextChanged += new System.EventHandler(this.tbLocation_TextChanged);
            // 
            // tbClientName
            // 
            this.tbClientName.Location = new System.Drawing.Point(128, 39);
            this.tbClientName.Margin = new System.Windows.Forms.Padding(4);
            this.tbClientName.Name = "tbClientName";
            this.tbClientName.Size = new System.Drawing.Size(307, 22);
            this.tbClientName.TabIndex = 1;
            this.tbClientName.TextChanged += new System.EventHandler(this.tbClientName_TextChanged);
            // 
            // lblPib
            // 
            this.lblPib.Location = new System.Drawing.Point(8, 82);
            this.lblPib.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPib.Name = "lblPib";
            this.lblPib.Size = new System.Drawing.Size(95, 16);
            this.lblPib.TabIndex = 4;
            this.lblPib.Text = "lblPib";
            // 
            // lblLocation
            // 
            this.lblLocation.Location = new System.Drawing.Point(444, 39);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(93, 16);
            this.lblLocation.TabIndex = 2;
            this.lblLocation.Text = "lblLocation";
            // 
            // lblClientName
            // 
            this.lblClientName.Location = new System.Drawing.Point(8, 39);
            this.lblClientName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(95, 16);
            this.lblClientName.TabIndex = 0;
            this.lblClientName.Text = "lblClientName";
            // 
            // bnFindInvoice
            // 
            this.bnFindInvoice.AddNewItem = null;
            this.bnFindInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bnFindInvoice.BindingSource = this.findInvoiceDataSetBindingSource;
            this.bnFindInvoice.CountItem = this.bindingNavigatorCountItem;
            this.bnFindInvoice.DeleteItem = null;
            this.bnFindInvoice.Dock = System.Windows.Forms.DockStyle.None;
            this.bnFindInvoice.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bnFindInvoice.Location = new System.Drawing.Point(12, 486);
            this.bnFindInvoice.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnFindInvoice.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnFindInvoice.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnFindInvoice.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnFindInvoice.Name = "bnFindInvoice";
            this.bnFindInvoice.PositionItem = this.bindingNavigatorPositionItem;
            this.bnFindInvoice.Size = new System.Drawing.Size(224, 25);
            this.bnFindInvoice.TabIndex = 2;
            this.bnFindInvoice.Text = "bnFindInvoice";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 23);
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
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(462, 514);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 42);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // invoiceTrackerDataSet1
            // 
            this.invoiceTrackerDataSet1.DataSetName = "InvoiceTrackerDataSet";
            this.invoiceTrackerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnNewInvoice
            // 
            this.btnNewInvoice.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNewInvoice.Location = new System.Drawing.Point(350, 514);
            this.btnNewInvoice.Name = "btnNewInvoice";
            this.btnNewInvoice.Size = new System.Drawing.Size(100, 42);
            this.btnNewInvoice.TabIndex = 4;
            this.btnNewInvoice.Text = "btnNewInvoice";
            this.btnNewInvoice.UseVisualStyleBackColor = true;
            this.btnNewInvoice.Click += new System.EventHandler(this.btnNewInvoice_Click);
            // 
            // findInvoiceDataSetBindingSource
            // 
            this.findInvoiceDataSetBindingSource.DataMember = "FindInvoiceQuery";
            this.findInvoiceDataSetBindingSource.DataSource = this.findInvoiceDataSet;
            // 
            // findInvoiceDataSet
            // 
            this.findInvoiceDataSet.DataSetName = "FindInvoiceDataSet";
            this.findInvoiceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // findInvoiceQueryTableAdapter
            // 
            this.findInvoiceQueryTableAdapter.ClearBeforeFill = true;
            // 
            // InvoiceDateColumn
            // 
            this.InvoiceDateColumn.DataPropertyName = "InvoiceDate";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.Format = "dd-MM-yyyy";
            dataGridViewCellStyle4.NullValue = null;
            this.InvoiceDateColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.InvoiceDateColumn.HeaderText = "InvoiceDate";
            this.InvoiceDateColumn.Name = "InvoiceDateColumn";
            this.InvoiceDateColumn.ReadOnly = true;
            this.InvoiceDateColumn.Width = 125;
            // 
            // InvoiceNumberColumn
            // 
            this.InvoiceNumberColumn.DataPropertyName = "InvoiceNumber";
            this.InvoiceNumberColumn.HeaderText = "InvoiceNumber";
            this.InvoiceNumberColumn.Name = "InvoiceNumberColumn";
            this.InvoiceNumberColumn.ReadOnly = true;
            // 
            // InvoiceTypeNameColumn
            // 
            this.InvoiceTypeNameColumn.DataPropertyName = "InvoiceTypeName";
            this.InvoiceTypeNameColumn.HeaderText = "InvoiceTypeName";
            this.InvoiceTypeNameColumn.Name = "InvoiceTypeNameColumn";
            this.InvoiceTypeNameColumn.ReadOnly = true;
            // 
            // ClientNameColumn
            // 
            this.ClientNameColumn.DataPropertyName = "ClientName";
            this.ClientNameColumn.HeaderText = "ClientName";
            this.ClientNameColumn.Name = "ClientNameColumn";
            this.ClientNameColumn.ReadOnly = true;
            this.ClientNameColumn.Width = 125;
            // 
            // ClientPIBColumn
            // 
            this.ClientPIBColumn.DataPropertyName = "ClientPIB";
            this.ClientPIBColumn.HeaderText = "ClientPIB";
            this.ClientPIBColumn.Name = "ClientPIBColumn";
            this.ClientPIBColumn.ReadOnly = true;
            this.ClientPIBColumn.Width = 125;
            // 
            // LocationNameColumn
            // 
            this.LocationNameColumn.DataPropertyName = "LocationName";
            this.LocationNameColumn.HeaderText = "LocationName";
            this.LocationNameColumn.Name = "LocationNameColumn";
            this.LocationNameColumn.ReadOnly = true;
            this.LocationNameColumn.Width = 125;
            // 
            // InvoiceIDColumn
            // 
            this.InvoiceIDColumn.DataPropertyName = "InvoiceID";
            this.InvoiceIDColumn.HeaderText = "InvoiceID";
            this.InvoiceIDColumn.Name = "InvoiceIDColumn";
            this.InvoiceIDColumn.ReadOnly = true;
            this.InvoiceIDColumn.Visible = false;
            this.InvoiceIDColumn.Width = 125;
            // 
            // EditInvoiceButtonColumn
            // 
            this.EditInvoiceButtonColumn.HeaderText = "Edit";
            this.EditInvoiceButtonColumn.Image = ((System.Drawing.Image)(resources.GetObject("EditInvoiceButtonColumn.Image")));
            this.EditInvoiceButtonColumn.Name = "EditInvoiceButtonColumn";
            this.EditInvoiceButtonColumn.ReadOnly = true;
            this.EditInvoiceButtonColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.EditInvoiceButtonColumn.Width = 75;
            // 
            // FindInvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(912, 569);
            this.Controls.Add(this.btnNewInvoice);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.bnFindInvoice);
            this.Controls.Add(this.gbFindInvoice);
            this.Controls.Add(this.dgInvoices);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(928, 607);
            this.Name = "FindInvoiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FindInvoiceForm";
            this.Load += new System.EventHandler(this.FindInvoiceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgInvoices)).EndInit();
            this.gbFindInvoice.ResumeLayout(false);
            this.gbFindInvoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnFindInvoice)).EndInit();
            this.bnFindInvoice.ResumeLayout(false);
            this.bnFindInvoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceTrackerDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.findInvoiceDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.findInvoiceDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgInvoices;
        private System.Windows.Forms.BindingSource findInvoiceDataSetBindingSource;
        private FindInvoiceDataSet findInvoiceDataSet;
        private FindInvoiceDataSetTableAdapters.FindInvoiceQueryTableAdapter findInvoiceQueryTableAdapter;
        private System.Windows.Forms.GroupBox gbFindInvoice;
        private System.Windows.Forms.Label lblPib;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.TextBox tbPib;
        private System.Windows.Forms.TextBox tbLocation;
        private System.Windows.Forms.TextBox tbClientName;
        private System.Windows.Forms.BindingNavigator bnFindInvoice;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Button btnClose;
        private InvoiceTrackerDataSet invoiceTrackerDataSet1;
        private System.Windows.Forms.Button btnNewInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceTypeNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientPIBColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceIDColumn;
        private System.Windows.Forms.DataGridViewImageColumn EditInvoiceButtonColumn;
    }
}