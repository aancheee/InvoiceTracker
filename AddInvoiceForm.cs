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
    public partial class AddInvoiceForm : Form
    {
        private int _InvoiceID = -1;
        private bool _IsNew = false;

        public int InvoiceID
        {
            get { return _InvoiceID; }
            set { _InvoiceID = value; }
        }

        public AddInvoiceForm()
        {
            InitializeComponent();
        }

        public AddInvoiceForm(int invoiceID)
            : this()
        {
            _InvoiceID = invoiceID;
        }

        private void AddInvoice_Load(object sender, EventArgs e)
        {
            this.unitTableAdapter.Fill(this.invoiceTrackerDataSet.Unit);
            try { this.invoiceItemTableAdapter.Fill(this.invoiceTrackerDataSet.InvoiceItem); }
            catch (Exception ex) { string a = ""; }
            this.locationTableAdapter.Fill(this.invoiceTrackerDataSet.Location);
            this.clientTableAdapter.Fill(this.invoiceTrackerDataSet.Client);
            this.invoiceTableAdapter.Fill(this.invoiceTrackerDataSet.Invoice);

            if (_InvoiceID < 1 && invoiceTrackerDataSet.Invoice.Count > 0)
            {
                _IsNew = true;
                _InvoiceID = Convert.ToInt32(invoiceTrackerDataSet.Invoice.OrderByDescending(x => x.InvoiceID).First().InvoiceID) + 1;
            }
            else
                _IsNew = false;                
               
            this.lblInvoiceNumber.Text = LocalizedText.InvoiceNumber;
            this.lblClientName.Text = LocalizedText.ClientName;
            this.lblInvoiceDate.Text = LocalizedText.InvoiceDate;
            this.lblInvoiceLocation.Text = LocalizedText.InvoiceLocation;
            this.lblNote.Text = LocalizedText.Note;
            this.btnSave.Text = LocalizedText.Save;
            this.btnCancel.Text = LocalizedText.Cancel;
            this.lblClientPIB.Text = LocalizedText.PIB;
            this.lblClientAddress.Text = LocalizedText.Address;
            this.DescriptionColumn.HeaderText = LocalizedText.Description;
            this.UnitIDColumn.HeaderText = LocalizedText.Unit;
            this.UnitPriceColumn.HeaderText = LocalizedText.UnitPrice;
            this.QuantityColumn.HeaderText = LocalizedText.Quantity;
            this.ValueColumn.HeaderText = LocalizedText.Value;
            this.VATColumn.HeaderText = LocalizedText.VAT;
            this.VatSumColumn.HeaderText = LocalizedText.VATSum;
            this.TotalColumn.HeaderText = LocalizedText.Total;
            this.gbClient.Text = LocalizedText.ClientInfo;

            this.cbLocations.SelectedIndex = -1;
            
            this.tbInvoiceNumber.Text = _InvoiceID.ToString();

            this.QuantityColumn.ValueType = typeof(double);
            this.UnitPriceColumn.ValueType = typeof(double);
            this.ValueColumn.ValueType = typeof(double);
            this.VATColumn.ValueType = typeof(double);
            this.TotalColumn.ValueType = typeof(double);
            this.VatSumColumn.ValueType = typeof(double);

            invoiceItemBindingSource.Filter = string.Format("InvoiceID = {0}", _InvoiceID);
            invoiceBindingSource.Filter = string.Format("InvoiceID = {0}", _InvoiceID);

            if (invoiceBindingSource.Count > 0)
            {
                InvoiceTrackerDataSet.InvoiceRow inv = ((InvoiceTrackerDataSet.InvoiceRow)((DataRowView)invoiceBindingSource.Current).Row);
                tbClientName.Text = inv.ClientRow.ClientName;
                tbClientAddress.Text = inv.ClientRow.Address;
                tbClientPIB.Text = inv.ClientRow.ClientPIB;
                cbLocations.SelectedValue = inv.LocationID;
                tbNote.Text = inv.Note;
                dateInvoice.Value = inv.InvoiceDate;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if ((cbLocations.SelectedValue == null && cbLocations.Text == "") ||
                dateInvoice.Value == null)
            {
                MessageBox.Show(LocalizedText.FillRequiredFields, LocalizedText.Error);
                return;
            }

            int clientID = -1, locationID = -1;
            
            //  Client
            InvoiceTrackerDataSet.ClientRow newClient = invoiceTrackerDataSet.Client.NewClientRow();
            newClient.ClientName = tbClientName.Text.Trim();
            newClient.ClientPIB = tbClientPIB.Text.Trim();
            newClient.Address = tbClientAddress.Text.Trim();
            invoiceTrackerDataSet.Client.Rows.Add(newClient);

            try
            {
                clientBindingSource.EndEdit();
                clientTableAdapter.Update(invoiceTrackerDataSet.Client);
                this.clientTableAdapter.Fill(this.invoiceTrackerDataSet.Client);
                clientID = this.invoiceTrackerDataSet.Client.OrderByDescending(x => x.ClientID).First().ClientID;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, LocalizedText.Error);
            }

            //  Location
            if (cbLocations.FindStringExact(cbLocations.Text) == -1)
            {
                InvoiceTrackerDataSet.LocationRow newLocation = invoiceTrackerDataSet.Location.NewLocationRow();
                newLocation.LocationName = cbLocations.Text;
                invoiceTrackerDataSet.Location.Rows.Add(newLocation);
                //invoiceTrackerDataSet.AcceptChanges();

                try
                {
                    locationBindingSource.EndEdit();
                    locationTableAdapter.Update(invoiceTrackerDataSet.Location);
                    this.locationTableAdapter.Fill(this.invoiceTrackerDataSet.Location);
                    locationID = this.invoiceTrackerDataSet.Location.OrderByDescending(x => x.LocationID).First().LocationID;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, LocalizedText.Error);
                }
            }
            else
                locationID = Convert.ToInt32(cbLocations.SelectedValue);

            //  Invoice
            InvoiceTrackerDataSet.InvoiceRow invoice;       // = invoiceTrackerDataSet.Invoice.NewInvoiceRow();
            if (_IsNew)
                invoice = invoiceTrackerDataSet.Invoice.NewInvoiceRow();
            else
                invoice = invoiceTrackerDataSet.Invoice.Where(x => x.InvoiceID == _InvoiceID).FirstOrDefault();

            invoice.ClientID = clientID;
            invoice.InvoiceDate = DateTime.Now;
            invoice.LocationID = locationID;
            invoice.Note = tbNote.Text;

            if (_IsNew)
                invoiceTrackerDataSet.Invoice.Rows.Add(invoice);
            //invoiceTrackerDataSet.AcceptChanges();

            try
            {
                invoiceBindingSource.EndEdit();
                invoiceTableAdapter.Update(invoiceTrackerDataSet.Invoice);
                this.invoiceTableAdapter.Fill(this.invoiceTrackerDataSet.Invoice);
                
                //invoiceID = this.invoiceTrackerDataSet.Invoice.OrderByDescending(x => x.InvoiceID).First().InvoiceID;                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, LocalizedText.Error);
            }

            try
            {
                invoiceItemBindingSource.EndEdit();
                invoiceItemTableAdapter.Update(invoiceTrackerDataSet.InvoiceItem);                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, LocalizedText.Error);
            }

            MessageBox.Show(LocalizedText.ChangesSaved, LocalizedText.Success);
            Close();            
        }

        private void dgInvoiceItems_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && (e.ColumnIndex == 4 || e.ColumnIndex == 5 || e.ColumnIndex == 7))
            {
                DataGridView view = (DataGridView)sender;
                if (view.Rows[e.RowIndex].Cells[4].Value != DBNull.Value &&
                    view.Rows[e.RowIndex].Cells[5].Value != DBNull.Value)
                {
                    //  value = quantity * unit price
                    view.Rows[e.RowIndex].Cells[6].Value = 
                        Convert.ToDouble(view.Rows[e.RowIndex].Cells[4].Value) * Convert.ToDouble(view.Rows[e.RowIndex].Cells[5].Value);

                    //  vat sum = quantity * unit price * vat / 100
                    if (view.Rows[e.RowIndex].Cells[7].Value != DBNull.Value)
                        view.Rows[e.RowIndex].Cells[8].Value =
                           Convert.ToDouble(view.Rows[e.RowIndex].Cells[4].Value) * Convert.ToDouble(view.Rows[e.RowIndex].Cells[5].Value) * Convert.ToDouble(view.Rows[e.RowIndex].Cells[7].Value) / 100;

                    //  total = quantity * unit price * (1 + vat / 100)
                    if (view.Rows[e.RowIndex].Cells[7].Value != DBNull.Value)
                        view.Rows[e.RowIndex].Cells[9].Value =
                           Convert.ToDouble(view.Rows[e.RowIndex].Cells[4].Value) * Convert.ToDouble(view.Rows[e.RowIndex].Cells[5].Value) * (1 + Convert.ToDouble(view.Rows[e.RowIndex].Cells[7].Value) / 100);        
                            //Convert.ToDouble(view.Rows[e.RowIndex].Cells[4].Value) * Convert.ToDouble(view.Rows[e.RowIndex].Cells[5].Value) * (1 + Convert.ToDouble(view.Rows[e.RowIndex].Cells[7].Value)/100);
                }
            }
        }

        private void dgInvoiceItems_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            /*if (e.RowIndex > -1 ) //&& (e.ColumnIndex == 4 || e.ColumnIndex == 5 || e.ColumnIndex == 6))
            {
                double res = 0;
                DataGridView view = (DataGridView)sender;

                if (e.ColumnIndex == 4 && !double.TryParse(view.Rows[e.RowIndex].Cells[4].Value.ToString(), out res))
                    view.Rows[e.RowIndex].Cells[4].Value = 0;

                if (e.ColumnIndex == 5 && !double.TryParse(view.Rows[e.RowIndex].Cells[5].Value.ToString(), out res))
                    view.Rows[e.RowIndex].Cells[5].Value = 0;

                if (e.ColumnIndex == 6 && !double.TryParse(view.Rows[e.RowIndex].Cells[6].Value.ToString(), out res))
                    view.Rows[e.RowIndex].Cells[6].Value = 0;
            }*/
        }

        private void dgInvoiceItems_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.RowIndex == 4 || e.RowIndex == 5 || e.RowIndex == 6 || e.RowIndex == 7)
            {
                if (dgInvoiceItems.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    double res = 0;
                    if (!double.TryParse(dgInvoiceItems.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out res))
                        dgInvoiceItems.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
                }
            }
        }

        private void dgInvoiceItems_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgInvoiceItems.Rows[e.RowIndex].Cells[7].Value = 20.00;            //set VAT value in the new row to 20% by default
        }

        private void dgInvoiceItems_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgInvoiceItems.Rows[e.RowIndex].Cells[1].Value = _InvoiceID;            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            InvoicePrintForm form = new InvoicePrintForm(_InvoiceID);
            form.ShowDialog();
        }             

        //private void dgInvoiceItems_DataError(object sender, DataGridViewDataErrorEventArgs e)
        //{
        //    if (e.RowIndex == 4 || e.RowIndex == 5 || e.RowIndex == 7 || e.RowIndex == 8)
        //    {
        //        dgInvoiceItems.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
        //    }
        //}                         
    }
}
