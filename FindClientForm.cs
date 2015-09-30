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
    public partial class FindClientForm : Form
    {
        public FindClientForm()
        {
            InitializeComponent();
        }

        private void FindClientForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'invoiceTrackerDataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.invoiceTrackerDataSet.Client);

            this.Text = LocalizedText.ChooseClient;
            this.ClientNameColumn.HeaderText = LocalizedText.ClientName;
            this.AddressColumn.HeaderText = LocalizedText.Address;
            this.ClientPIBColumn.HeaderText = LocalizedText.PIB;
            this.btnSelect.Text = LocalizedText.Select;
            this.btnClose.Text = LocalizedText.Cancel;

            _Client = null;
        }

        private InvoiceTrackerDataSet.ClientRow _Client;

        public InvoiceTrackerDataSet.ClientRow Client
        {
            get
            {                
                return _Client;
            }
            set
            {
                _Client = value;
            }
        }

        private void SelectClient()
        {
            try
            {
                if (dgClients.SelectedRows.Count > 0)
                    _Client = invoiceTrackerDataSet.Client.Where(x => x.ClientID == Convert.ToInt32(dgClients.SelectedRows[0].Cells[0].Value)).FirstOrDefault();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, LocalizedText.Error);
            }
            finally
            {
                Close();
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            SelectClient();
        }

        private void dgClients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectClient();
        }    
    }
}
