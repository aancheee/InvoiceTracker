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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.Text = LocalizedText.CompanyName;
            MenuItemInvoice.Text = LocalizedText.Invoice;
            MenuItemNewInvoice.Text = LocalizedText.NewInvoice;
            MenuItemFindInvoice.Text = LocalizedText.Find;
            MenuItemExit.Text = LocalizedText.Exit;
            MenuItemHelp.Text = LocalizedText.Help;
            MenuItemAbout.Text = LocalizedText.About;
        }

        private void MenuItemExit_Click(object sender, EventArgs e)
        {
            Close();
        }       

        private void MenuItemNewInvoice_Click(object sender, EventArgs e)
        {
            AddInvoiceForm form = new AddInvoiceForm();
            form.ShowDialog();
        }

        private void MenuItemFindInvoice_Click(object sender, EventArgs e)
        {
            FindInvoiceForm form = new FindInvoiceForm();
            form.ShowDialog();
        }

        private void menuItemAboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox box = new AboutBox();
            box.ShowDialog();
        }

    }
}
