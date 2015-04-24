using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace InvoiceTracker
{
    public partial class InvoicePrintForm : Form
    {
        private int _InvoiceID = -1;
        public int InvoiceID
        {
            get { return _InvoiceID; }
            set { _InvoiceID = value; }
        }

        public InvoicePrintForm()
        {
            InitializeComponent();
        }

        public InvoicePrintForm(int invoiceID)
            : this()
        {
            _InvoiceID = invoiceID;
        }

        private void InvoicePrintForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ReportDataSet.Invoice' table. You can move, or remove it, as needed.
            this.InvoiceTableAdapter.Fill(this.ReportDataSet.Invoice);

            ReportDataSetTableAdapters.InvoiceTableAdapter invoiceAdapter = new ReportDataSetTableAdapters.InvoiceTableAdapter();
            ReportDataSet.InvoiceDataTable invoiceTable = new ReportDataSet.InvoiceDataTable();
            invoiceAdapter.FillByInvoiceID(invoiceTable, _InvoiceID);

            ReportDataSetTableAdapters.InvoiceItemsTableAdapter invoiceItemsAdapter = new ReportDataSetTableAdapters.InvoiceItemsTableAdapter();
            ReportDataSet.InvoiceItemsDataTable invoiceItemsTable = new ReportDataSet.InvoiceItemsDataTable();
            invoiceItemsAdapter.FillByInvoiceID(invoiceItemsTable, _InvoiceID);

            ReportDataSource invoiceDataSource = new ReportDataSource("Invoice", (DataTable)invoiceTable);
            ReportDataSource invoiceItemsDataSource = new ReportDataSource("InvoiceItems", (DataTable)invoiceItemsTable);

            this.InvoiceReportViewer.LocalReport.DataSources.Clear();
            this.InvoiceReportViewer.LocalReport.DataSources.Add(invoiceDataSource);
            this.InvoiceReportViewer.LocalReport.DataSources.Add(invoiceItemsDataSource);

            this.InvoiceReportViewer.LocalReport.Refresh();
            this.InvoiceReportViewer.RefreshReport();

            this.Text = LocalizedText.Invoice;
        }

    }
}
