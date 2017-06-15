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
    public partial class frmSalesInvoice : Form
    {
        public frmSalesInvoice()
        {
            InitializeComponent();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (cmbItems.Text != "" && txtRate.Text != "" && txtQuantity.Text != "")
            {
                DataGridViewRow row = (DataGridViewRow)dataGridViewSales.Rows[0].Clone();
                row.Cells[0].Value = cmbItems.Text;
                row.Cells[1].Value = txtRate.Text;
                row.Cells[2].Value = txtQuantity.Text;
                row.Cells[3].Value = txtDiscount.Text;
                row.Cells[4].Value = "0";
                row.Cells[4].Value = txtAmount.Text;
                //row.Cells["Rate"].Value = txtRate.Text;
                //row.Cells["Quantity"].Value = txtQuantity.Text;
                //row.Cells["Discount"].Value = txtDiscount.Text;
                //row.Cells["Amount"].Value = txtAmount.Text;
                dataGridViewSales.Rows.Add(row);
            }
            else{
MessageBox.Show("Error","Please Select");
        }
    }
}
