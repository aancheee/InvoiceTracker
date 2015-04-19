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
            this.InvoiceReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ReportDataSet = new InvoiceTracker.ReportDataSet();
            this.InvoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.InvoiceTableAdapter = new InvoiceTracker.ReportDataSetTableAdapters.InvoiceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // InvoiceReportViewer
            // 
            this.InvoiceReportViewer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.InvoiceReportViewer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.InvoiceBindingSource;
            this.InvoiceReportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.InvoiceReportViewer.LocalReport.ReportEmbeddedResource = "InvoiceTracker.PrintInvoiceReport.rdlc";
            this.InvoiceReportViewer.Location = new System.Drawing.Point(0, 181);
            this.InvoiceReportViewer.Name = "InvoiceReportViewer";
            this.InvoiceReportViewer.ShowBackButton = false;
            this.InvoiceReportViewer.ShowContextMenu = false;
            this.InvoiceReportViewer.ShowCredentialPrompts = false;
            this.InvoiceReportViewer.ShowDocumentMapButton = false;
            this.InvoiceReportViewer.ShowExportButton = false;
            this.InvoiceReportViewer.ShowFindControls = false;
            this.InvoiceReportViewer.ShowPageNavigationControls = false;
            this.InvoiceReportViewer.ShowParameterPrompts = false;
            this.InvoiceReportViewer.ShowProgress = false;
            this.InvoiceReportViewer.ShowPromptAreaButton = false;
            this.InvoiceReportViewer.ShowRefreshButton = false;
            this.InvoiceReportViewer.ShowStopButton = false;
            this.InvoiceReportViewer.ShowToolBar = false;
            this.InvoiceReportViewer.ShowZoomControl = false;
            this.InvoiceReportViewer.Size = new System.Drawing.Size(900, 289);
            this.InvoiceReportViewer.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(3, 1);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(481, 65);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "Salat Centar Plastenici";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.ForeColor = System.Drawing.Color.White;
            this.richTextBox2.Location = new System.Drawing.Point(5, 64);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox2.Size = new System.Drawing.Size(481, 116);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = "Kontakt: Ćopić Dragan\nKontakt telefon: +381 65 210 49 66\t\nAdresa: 99 palih boraca" +
    " br. 42, Ugrinovci\nPIB: 104734536\nMat. br.: 60456763\nŽiro račun: Hypo Alpe Adria" +
    " Bank 165-9649-04";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 181);
            this.panel1.TabIndex = 3;
            // 
            // ReportDataSet
            // 
            this.ReportDataSet.DataSetName = "ReportDataSet";
            this.ReportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // InvoiceBindingSource
            // 
            this.InvoiceBindingSource.DataMember = "Invoice";
            this.InvoiceBindingSource.DataSource = this.ReportDataSet;
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
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.InvoiceReportViewer);
            this.Controls.Add(this.panel1);
            this.Name = "InvoicePrintForm";
            this.Text = "InvoicePrintForm";
            this.Load += new System.EventHandler(this.InvoicePrintForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer InvoiceReportViewer;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource InvoiceBindingSource;
        private ReportDataSet ReportDataSet;
        private ReportDataSetTableAdapters.InvoiceTableAdapter InvoiceTableAdapter;
    }
}