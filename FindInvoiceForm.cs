using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceTracker
{
    public partial class FindInvoiceForm : Form
    {
        public FindInvoiceForm()
        {
            InitializeComponent();
        }

        private void FindInvoiceForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'findInvoiceDataSet.FindInvoiceQuery' table. You can move, or remove it, as needed.
            this.findInvoiceQueryTableAdapter.Fill(this.findInvoiceDataSet.FindInvoiceQuery);

            SetDataGrid();

            this.Text = LocalizedText.FindInvoice;
            this.gbFindInvoice.Text = LocalizedText.FindInvoice;
            this.lblClientName.Text = LocalizedText.ClientNameFind;
            this.lblLocation.Text = LocalizedText.InvoiceLocation;
            this.lblPib.Text = LocalizedText.PIB;
            this.InvoiceDateColumn.HeaderText = LocalizedText.InvoiceDate;
            this.ClientNameColumn.HeaderText = LocalizedText.ClientName;
            this.ClientPIBColumn.HeaderText = LocalizedText.PIB;
            this.LocationNameColumn.HeaderText = LocalizedText.InvoiceLocation;
            this.EditInvoiceButtonColumn.HeaderText = LocalizedText.Edit;
            this.InvoiceNumberColumn.HeaderText = LocalizedText.InvoiceNumber;
            this.InvoiceTypeNameColumn.HeaderText = LocalizedText.Type;
            this.btnClose.Text = LocalizedText.Cancel;
            this.btnNewInvoice.Text = LocalizedText.NewInvoice;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private string GetFilter()
        {
            string filter = "";

            if (tbClientName.Text.Trim() != "")
                filter = string.Format("ClientName LIKE '%{0}%'", tbClientName.Text.Trim());

            if (tbLocation.Text.Trim() != "")
            {
                if (filter != "")
                    filter += " AND ";

                filter += string.Format("LocationName LIKE '%{0}%'", tbLocation.Text.Trim());
            }

            if (tbPib.Text.Trim() != "")
            {
                if (filter != "")
                    filter += " AND ";

                filter += string.Format("ClientPIB LIKE '%{0}%'", tbPib.Text.Trim());
            }

            return filter;
        }

        private void tbClientName_TextChanged(object sender, EventArgs e)
        {
            SetDataGrid();
        }

        private void tbLocation_TextChanged(object sender, EventArgs e)
        {
            SetDataGrid();
        }

        private void tbPib_TextChanged(object sender, EventArgs e)
        {
            SetDataGrid();
        }

        private void SetDataGrid()
        {
            findInvoiceDataSetBindingSource.Filter = GetFilter();
        }

        private void GetInvoiceDetails(int rowID)
        {
            if (rowID > -1)           
            {
                int invoiceID = Convert.ToInt32(dgInvoices.Rows[rowID].Cells[6].Value);         //  InvoiceID
                AddInvoiceForm form = new AddInvoiceForm(invoiceID);
                form.ShowDialog();
            }
        }

        private void dgInvoices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)           //  button click
                GetInvoiceDetails(e.RowIndex);
        }

        private void btnNewInvoice_Click(object sender, EventArgs e)
        {
            AddInvoiceForm form = new AddInvoiceForm();
            form.ShowDialog();

            //  refresh
            
            this.findInvoiceQueryTableAdapter.Fill(this.findInvoiceDataSet.FindInvoiceQuery);
            SetDataGrid();
        }

        private void dgInvoices_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            GetInvoiceDetails(e.RowIndex);
        }              
    }
}
