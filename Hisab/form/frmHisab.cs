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
           
        }

        private void frmHisab_Load(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
               
                frm.ControlBox = false;
                frm.Text = String.Empty;
                //frm.BackColor = Properties.Settings.Default.DefaultBGColor;
                   
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
