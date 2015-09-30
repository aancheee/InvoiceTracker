namespace InvoiceTracker
{
    partial class FindClientForm
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
            this.dgClients = new System.Windows.Forms.DataGridView();
            this.ClientIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientPIBColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceTrackerDataSet = new InvoiceTracker.InvoiceTrackerDataSet();
            this.clientTableAdapter = new InvoiceTracker.InvoiceTrackerDataSetTableAdapters.ClientTableAdapter();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceTrackerDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgClients
            // 
            this.dgClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgClients.AutoGenerateColumns = false;
            this.dgClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClientIDColumn,
            this.ClientNameColumn,
            this.AddressColumn,
            this.ClientPIBColumn});
            this.dgClients.DataSource = this.clientBindingSource;
            this.dgClients.Location = new System.Drawing.Point(13, 13);
            this.dgClients.Name = "dgClients";
            this.dgClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgClients.Size = new System.Drawing.Size(807, 307);
            this.dgClients.TabIndex = 0;
            this.dgClients.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgClients_CellDoubleClick);
            // 
            // ClientIDColumn
            // 
            this.ClientIDColumn.DataPropertyName = "ClientID";
            this.ClientIDColumn.HeaderText = "ClientID";
            this.ClientIDColumn.Name = "ClientIDColumn";
            this.ClientIDColumn.Visible = false;
            // 
            // ClientNameColumn
            // 
            this.ClientNameColumn.DataPropertyName = "ClientName";
            this.ClientNameColumn.HeaderText = "ClientName";
            this.ClientNameColumn.Name = "ClientNameColumn";
            this.ClientNameColumn.ReadOnly = true;
            this.ClientNameColumn.Width = 200;
            // 
            // AddressColumn
            // 
            this.AddressColumn.DataPropertyName = "Address";
            this.AddressColumn.HeaderText = "Address";
            this.AddressColumn.Name = "AddressColumn";
            this.AddressColumn.ReadOnly = true;
            this.AddressColumn.Width = 400;
            // 
            // ClientPIBColumn
            // 
            this.ClientPIBColumn.DataPropertyName = "ClientPIB";
            this.ClientPIBColumn.HeaderText = "ClientPIB";
            this.ClientPIBColumn.Name = "ClientPIBColumn";
            this.ClientPIBColumn.ReadOnly = true;
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
            // btnSelect
            // 
            this.btnSelect.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSelect.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(329, 338);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "btnSelect";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(428, 338);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // FindClientForm
            // 
            this.AcceptButton = this.btnSelect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(832, 373);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.dgClients);
            this.Name = "FindClientForm";
            this.Text = "FindClientForm";
            this.Load += new System.EventHandler(this.FindClientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceTrackerDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgClients;
        private InvoiceTrackerDataSet invoiceTrackerDataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private InvoiceTrackerDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientPIBColumn;
    }
}