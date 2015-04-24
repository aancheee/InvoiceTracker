namespace InvoiceTracker
{
    partial class InvoicePrintForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.InvoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReportDataSet = new InvoiceTracker.ReportDataSet();
            this.InvoiceReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.InvoiceTableAdapter = new InvoiceTracker.ReportDataSetTableAdapters.InvoiceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // InvoiceBindingSource
            // 
            this.InvoiceBindingSource.DataMember = "Invoice";
            this.InvoiceBindingSource.DataSource = this.ReportDataSet;
            // 
            // ReportDataSet
            // 
            this.ReportDataSet.DataSetName = "ReportDataSet";
            this.ReportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // InvoiceReportViewer
            // 
            this.InvoiceReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InvoiceReportViewer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.InvoiceBindingSource;
            this.InvoiceReportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.InvoiceReportViewer.LocalReport.ReportEmbeddedResource = "InvoiceTracker.PrintInvoiceReport.rdlc";
            this.InvoiceReportViewer.Location = new System.Drawing.Point(0, 0);
            this.InvoiceReportViewer.Margin = new System.Windows.Forms.Padding(1);
            this.InvoiceReportViewer.Name = "InvoiceReportViewer";
            this.InvoiceReportViewer.ShowBackButton = false;
            this.InvoiceReportViewer.ShowContextMenu = false;
            this.InvoiceReportViewer.ShowCredentialPrompts = false;
            this.InvoiceReportViewer.ShowDocumentMapButton = false;
            this.InvoiceReportViewer.ShowFindControls = false;
            this.InvoiceReportViewer.ShowPageNavigationControls = false;
            this.InvoiceReportViewer.ShowParameterPrompts = false;
            this.InvoiceReportViewer.ShowProgress = false;
            this.InvoiceReportViewer.ShowPromptAreaButton = false;
            this.InvoiceReportViewer.ShowRefreshButton = false;
            this.InvoiceReportViewer.ShowStopButton = false;
            this.InvoiceReportViewer.Size = new System.Drawing.Size(900, 470);
            this.InvoiceReportViewer.TabIndex = 0;
            // 
            // InvoiceTableAdapter
            // 
            this.InvoiceTableAdapter.ClearBeforeFill = true;
            // 
            // InvoicePrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 470);
            this.Controls.Add(this.InvoiceReportViewer);
            this.Name = "InvoicePrintForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "InvoicePrintForm";
            this.Load += new System.EventHandler(this.InvoicePrintForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer InvoiceReportViewer;
        private System.Windows.Forms.BindingSource InvoiceBindingSource;
        private ReportDataSet ReportDataSet;
        private ReportDataSetTableAdapters.InvoiceTableAdapter InvoiceTableAdapter;
    }
}