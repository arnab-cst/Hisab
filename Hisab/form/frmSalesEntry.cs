using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hisab.form
{
    public partial class frmSalesEntry : Form
    {
        public frmSalesEntry()
        {
            InitializeComponent();
           // this.BackColor = Properties.Settings.Default.DefaultBGColor;
        }

        private void frmSalesEntry_Load(object sender, EventArgs e)
        {
            frmSalesInvoice sf = new frmSalesInvoice();

            sf.TopLevel = false;
            sf.AutoScroll = true;
            sf.Dock = DockStyle.Fill;
            sf.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //Label lbl = new Label();
            //lbl.Text = "Arnab";
            //sf.Controls.Add(lbl);
            TabPage ChildTab = new TabPage();
            ChildTab.Controls.Add(sf);
            ChildTab.Text = "Invoice";
           // tab1.Text = "Bill" + (tabControlSales.TabPages.Count + 1);

            tabControlSales.TabPages.Add(ChildTab);
            splitContainerSales.Panel2.Controls.Add(tabControlSales);
            sf.Show();
        }
    }
}
