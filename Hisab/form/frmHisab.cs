using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Hisab.Class;

namespace Hisab.form
{
    public partial class frmHisab : Form
    {
        public frmHisab()
        {
            InitializeComponent();
        }

        private void addItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmItemEntry objFrmItemEntry = new frmItemEntry();
            FromConfigration parent = new FromConfigration();
            parent.LoadMDIChild(objFrmItemEntry, this);
            //objFrmItemEntry.MdiParent = this;
            //objFrmItemEntry.Dock = DockStyle.Fill;
            //objFrmItemEntry.AutoScroll = true;
            //objFrmItemEntry.TopLevel = false;
            //objFrmItemEntry.ControlBox = false;
            //objFrmItemEntry.Text = String.Empty;
            //objFrmItemEntry.Show();
        }

        private void frmHisab_Load(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                //this.ControlBox = false;
                //this.Text = String.Empty;
                frm.ControlBox = false;
                frm.Text = String.Empty;
            }
        }

        private void newSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSalesEntry objFrmSalesEntry = new frmSalesEntry();
            FromConfigration parent = new FromConfigration();
            parent.LoadMDIChild(objFrmSalesEntry, this);
        }
    }
}
