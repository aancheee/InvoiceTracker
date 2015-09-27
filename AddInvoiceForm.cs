using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
        private int _ClientID = -1;

        public int InvoiceID
        {
            get { return _InvoiceID; }
            set { _InvoiceID = value; }
        }

        private Rectangle rect;
        private ToolTip toolTip = new ToolTip();
        private bool isError;
        private string errorText = "";

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
            // TODO: This line of code loads data into the 'invoiceTrackerDataSet.InvoiceType' table. You can move, or remove it, as needed.
            this.invoiceTypeTableAdapter.Fill(this.invoiceTrackerDataSet.InvoiceType);
            this.unitTableAdapter.Fill(this.invoiceTrackerDataSet.Unit);
            try { this.invoiceItemTableAdapter.Fill(this.invoiceTrackerDataSet.InvoiceItem); }
            catch (Exception ex) { string a = ""; }
            this.locationTableAdapter.Fill(this.invoiceTrackerDataSet.Location);
            this.clientTableAdapter.Fill(this.invoiceTrackerDataSet.Client);
            try
            {
                this.invoiceTableAdapter.Fill(this.invoiceTrackerDataSet.Invoice);
            }
            catch (Exception ex)
            {
                string a = "";
            }

            _IsNew = _InvoiceID < 1;

            this.Text = LocalizedText.NewInvoice;
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
            this.btnPrint.Text = LocalizedText.Print;
            this.lblInvoiceType.Text = LocalizedText.Type;
            this.lblTurnoverDate.Text = LocalizedText.TurnoverDate;
            this.btnChooseClient.Text = LocalizedText.ChooseClient;

            this.cbLocations.SelectedIndex = -1;
            
            //this.tbInvoiceNumber.Text = _InvoiceID.ToString();

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
                tbInvoiceNumber.Text = inv.InvoiceNumber;
                cbInvoiceTypes.SelectedValue = inv.InvoiceTypeID;
                dateTurnover.Value = inv.TurnoverDate;
                SetTurnoverDate();
            }

            if (_IsNew)
                btnPrint.Enabled = false;
            else
            {
                btnPrint.Enabled = true;
                cbInvoiceTypes.Enabled = false;
            }

            foreach (DataGridViewRow row in dgInvoiceItems.Rows)
            {
                if (row.Cells["UnitPriceColumn"].Value != null && row.Cells["QuantityColumn"].Value != null)
                {
                    row.Cells["ValueColumn"].Value = Convert.ToDouble(row.Cells["UnitPriceColumn"].Value) * Convert.ToDouble(row.Cells["QuantityColumn"].Value);

                    if (row.Cells["VATColumn"].Value != null)
                    {
                        row.Cells["VatSumColumn"].Value = Convert.ToDouble(row.Cells["ValueColumn"].Value) * Convert.ToDouble(row.Cells["VATColumn"].Value) / 100;

                        row.Cells["TotalColumn"].Value = Convert.ToDouble(row.Cells["ValueColumn"].Value) + Convert.ToDouble(row.Cells["VatSumColumn"].Value);
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string invNoHlp = ""; 
            statusLabel.Text = "";

            if ((cbLocations.SelectedValue == null && cbLocations.Text == "") ||
                dateInvoice.Value == null)
            {
                MessageBox.Show(LocalizedText.FillRequiredFields, LocalizedText.Error);
                statusLabel.Text = LocalizedText.FillRequiredFields;
                return;
            }

            int locationID = -1;
            
            //  Client
            if (_ClientID == -1)
            {
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
                    _ClientID = this.invoiceTrackerDataSet.Client.OrderByDescending(x => x.ClientID).First().ClientID;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, LocalizedText.Error);
                    statusLabel.Text = LocalizedText.Error;
                    return;
                }
            }

            //  Location
            if (cbLocations.FindStringExact(cbLocations.Text) == -1)
            {
                InvoiceTrackerDataSet.LocationRow newLocation = invoiceTrackerDataSet.Location.NewLocationRow();
                newLocation.LocationName = cbLocations.Text;
                invoiceTrackerDataSet.Location.Rows.Add(newLocation);

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
                    statusLabel.Text = LocalizedText.Error;
                    return;
                }
            }
            else
                locationID = Convert.ToInt32(cbLocations.SelectedValue);

            //  Invoice
            InvoiceTrackerDataSet.InvoiceRow invoice;       
            InvoiceTrackerDataSet.InvoiceRow hlpInvoice;
            if (_IsNew)
                invoice = invoiceTrackerDataSet.Invoice.NewInvoiceRow();
            else
                invoice = invoiceTrackerDataSet.Invoice.Where(x => x.InvoiceID == _InvoiceID).FirstOrDefault();

            invoice.ClientID = _ClientID;
            invoice.InvoiceDate = dateInvoice.Value;
            invoice.LocationID = locationID;
            invoice.Note = tbNote.Text;
            invoice.InvoiceTypeID = Convert.ToInt32(cbInvoiceTypes.SelectedValue);
            if (dateTurnover.Enabled)
                invoice.TurnoverDate = dateTurnover.Value;

            if (_IsNew)
            {
                if (invoice.InvoiceTypeID == 1 || invoice.InvoiceTypeID == 2)       //  racun otpremnica, avansni racun
                //  1, 2, 3... by year
                {
                    hlpInvoice = invoiceTrackerDataSet.Invoice.Where(x => x.InvoiceTypeID == invoice.InvoiceTypeID && x.InvoiceDate.Year == invoice.InvoiceDate.Year).OrderByDescending(x => x.InvoiceNumber).FirstOrDefault();
                    if (hlpInvoice != null)
                        invNoHlp = (Convert.ToInt32(hlpInvoice.InvoiceNumber) + 1).ToString();
                    else
                        invNoHlp = "1";
                }
                else if (invoice.InvoiceTypeID == 3 || invoice.InvoiceTypeID == 4)  //  ponuda, predracun
                //  01, 02, 03... by month
                {
                    hlpInvoice = invoiceTrackerDataSet.Invoice.Where(x => x.InvoiceTypeID == invoice.InvoiceTypeID && x.InvoiceDate.Year == invoice.InvoiceDate.Year && x.InvoiceDate.Month == invoice.InvoiceDate.Month).OrderByDescending(x => x.InvoiceNumber).FirstOrDefault();
                    if (hlpInvoice != null)
                    {
                        invNoHlp = (Convert.ToInt32(hlpInvoice.InvoiceNumber.Replace(invoice.InvoiceDate.ToString("yyyy") + invoice.InvoiceDate.ToString("MM") + "-", "")) + 1).ToString();
                        if (invNoHlp.Length < 2)
                            invNoHlp = "0" + invNoHlp;

                        invNoHlp = invoice.InvoiceDate.ToString("yyyy") + invoice.InvoiceDate.ToString("MM") + "-" + invNoHlp;
                    }
                    else
                        invNoHlp = invoice.InvoiceDate.ToString("yyyy") + invoice.InvoiceDate.ToString("MM") + "-" + "01";
                }

                invoice.InvoiceNumber = invNoHlp;

                invoiceTrackerDataSet.Invoice.Rows.Add(invoice);
            }
            else
                invNoHlp = tbInvoiceNumber.Text;

            try
            {
                invoiceBindingSource.EndEdit();
                invoiceTableAdapter.Update(invoiceTrackerDataSet.Invoice);
                this.invoiceTableAdapter.Fill(this.invoiceTrackerDataSet.Invoice);

                if (_IsNew)
                {
                    _InvoiceID = this.invoiceTrackerDataSet.Invoice.OrderByDescending(x => x.InvoiceID).First().InvoiceID;

                    foreach (InvoiceTrackerDataSet.InvoiceItemRow row in this.invoiceTrackerDataSet.InvoiceItem.Rows)
                        if (row.InvoiceID == -1)
                            row.InvoiceID = _InvoiceID;

                    invoiceItemBindingSource.Filter = string.Format("InvoiceID = {0}", _InvoiceID);
                    invoiceBindingSource.Filter = string.Format("InvoiceID = {0}", _InvoiceID);                    
                }                        
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, LocalizedText.Error);
                statusLabel.Text = LocalizedText.Error;
                return;
            }

            try
            {
                invoiceItemBindingSource.EndEdit();
                invoiceItemTableAdapter.Update(invoiceTrackerDataSet.InvoiceItem);
                this.invoiceItemTableAdapter.Fill(this.invoiceTrackerDataSet.InvoiceItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, LocalizedText.Error);
                statusLabel.Text = LocalizedText.Error;
                return;
            }

            MessageBox.Show(LocalizedText.ChangesSaved, LocalizedText.Success);
            statusLabel.Text = LocalizedText.ChangesSaved;
            tbInvoiceNumber.Text = invNoHlp; 
            cbInvoiceTypes.Enabled = false;

            if (_IsNew)
            {
                _IsNew = false;
                btnPrint.Enabled = true;
            }
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
            if (e.ColumnIndex == 4 || e.ColumnIndex == 5 || e.ColumnIndex == 6 || e.ColumnIndex == 7)
            {
                DataGridViewCell cell = dgInvoiceItems.Rows[e.RowIndex].Cells[e.ColumnIndex];
                                
                if (e.FormattedValue != null)
                {
                    //if (e.FormattedValue.ToString().Trim() == string.Empty)
                    //{
                    //    cell.Value = 0;
                    //    e.Cancel = true;
                    //}
                    //else
                    //{
                        double res = 0;
                        if (!double.TryParse(Convert.ToString(e.FormattedValue), out res))
                        {
                            cell.ErrorText = errorText = LocalizedText.FieldTypeNumber;
                            isError = true;                            
                            e.Cancel = true;
                            
                            if (cell.Tag == null)
                            {
                                cell.Tag = cell.Style.Padding;
                                cell.Style.Padding = new Padding(0, 0, 18, 0);
                            }
                        }
                        else
                        {
                            cell.ErrorText = errorText = string.Empty;
                            isError = false;
                        }
                    //}
                }
            }
        }

        private void dgInvoiceItems_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgInvoiceItems.Rows[e.RowIndex].Cells[1].Value == null)
                dgInvoiceItems.Rows[e.RowIndex].Cells[1].Value = _InvoiceID;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            InvoicePrintForm form = new InvoicePrintForm(_InvoiceID);
            form.ShowDialog();
        }

        private void dgInvoiceItems_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells[7].Value = 20.00;               //set VAT value in the new row to 20% by default
        }

        private void dgInvoiceItems_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (!string.IsNullOrEmpty(dgInvoiceItems[e.ColumnIndex, e.RowIndex].ErrorText))
            {
                DataGridViewCell cell = dgInvoiceItems.Rows[e.RowIndex].Cells[e.ColumnIndex];
                cell.ErrorText = string.Empty;
                cell.Style.Padding = (Padding)cell.Tag;
                cell.Tag = null;
            }
        }

        private void dgInvoiceItems_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (dgInvoiceItems.IsCurrentCellDirty)
            {
                if (!string.IsNullOrEmpty(e.ErrorText))
                {
                    GraphicsContainer container = e.Graphics.BeginContainer();
                    rect = dgInvoiceItems.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);

                    e.Graphics.TranslateTransform(18, 0);
                    e.Paint(this.ClientRectangle, DataGridViewPaintParts.ErrorIcon);
                    e.Graphics.EndContainer(container);
                    e.Handled = true;
                }
            }
        }

        private void dgInvoiceItems_MouseHover(object sender, EventArgs e)
        {
            if (isError)
            {
                Point pos = dgInvoiceItems.PointToClient(Cursor.Position);
                
                if (rect.Contains(pos.X - 20, pos.Y - 5) && errorText != string.Empty)
                {
                    toolTip.Show(errorText, dgInvoiceItems.EditingControl, 3000);
                }
            }
        }

        private void dgInvoiceItems_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            
        }
        
        private void dgInvoiceItems_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            
        }

        private void btnChooseClient_Click(object sender, EventArgs e)
        {
            FindClientForm form = new FindClientForm();
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK && form.Client != null)
            {
                _ClientID = form.Client.ClientID;
                tbClientName.Text = form.Client.ClientName;
                tbClientPIB.Text = form.Client.ClientPIB;
                tbClientAddress.Text = form.Client.Address;
            }
        }

        private void cbInvoiceTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetTurnoverDate();
        }

        private void SetTurnoverDate()
        {
            if (cbInvoiceTypes.SelectedValue != null)
            {
                if (Convert.ToInt32(cbInvoiceTypes.SelectedValue) == 1 || Convert.ToInt32(cbInvoiceTypes.SelectedValue) == 2)
                    dateTurnover.Enabled = true;
                else
                    dateTurnover.Enabled = false;
            }
            else
                dateTurnover.Enabled = false;
        }          
    }
}
