using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Hisab.Class;

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
                try
                {
                    int gross_total = int.Parse(txtRate.Text) * int.Parse(txtQuantity.Text),
                    discount = gross_total * int.Parse(txtDiscount.Text) / 100,
                    netAmount = gross_total - discount;
                    txtAmount.Text = netAmount.ToString();
                }
                catch (Exception ex1)
                {
                    MessageBox.Show("Please Enter a valid amount", "Error");
                }

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
            else
            {
                MessageBox.Show("Please Enter The Mandatory Fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               // MessageBox.Show("", "",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
           
                e.Handled = true;
            
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
           
                e.Handled = true;
            
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            
                e.Handled = true;
        }

        private void frmSalesInvoice_Load(object sender, EventArgs e)
        {
            this.BackColor = Properties.Settings.Default.DefaultBGColor;
            
            FromConfigration frmConfig = new FromConfigration();
            frmConfig.FillCombo(cmbItems,"Item");

            txtRate.Text = "0";
            txtQuantity.Text = "0";
            txtDiscount.Text = "0";
            txtAmount.Text = "0";
        }

        private void cmbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRate.Text = "0";
            txtQuantity.Text = "0";
            txtDiscount.Text = "0";
            txtAmount.Text = "0";
        }

        private void txtRate_TextChanged(object sender, EventArgs e)
        {
           // txtAmount.Text = (int.Parse(txtRate.Text) * int.Parse(txtQuantity.Text) - int.Parse(txtDiscount.Text)).ToString();

            //try
            //{
            //    int gross_total = int.Parse(txtRate.Text) * int.Parse(txtQuantity.Text),
            //    discount = gross_total * int.Parse(txtDiscount.Text) / 100,
            //    netAmount = gross_total - discount;
            //    txtAmount.Text = netAmount.ToString();
            //}
            //catch (Exception ex1)
            //{
            //    MessageBox.Show("Please Enter a valid amount", "Error");
            //}
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
           // txtAmount.Text = (int.Parse(txtRate.Text) * int.Parse(txtQuantity.Text) - int.Parse(txtDiscount.Text)).ToString();
           
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            //txtAmount.Text = (int.Parse(txtRate.Text) * int.Parse(txtQuantity.Text) - int.Parse(txtDiscount.Text)).ToString();
           
        }

        private void btnUpdateSales_Click(object sender, EventArgs e)
        {
           
            for (int i = 0; i < dataGridViewSales.Rows.Count; i++)
            {
                List<SqlParameter> prm = new List<SqlParameter>()
                 {
                     new SqlParameter("@InvoiceID", SqlDbType.VarChar) {Value = "Invoice1"},
                     new SqlParameter("@ItemID", SqlDbType.Int) {Value = dataGridViewSales.Rows[i].Cells[0]},
                     new SqlParameter("@Rate", SqlDbType.Int) {Value  = dataGridViewSales.Rows[i].Cells[1]},
                     new SqlParameter("@Quantity", SqlDbType.Int) {Value = dataGridViewSales.Rows[i].Cells[2]},
                     new SqlParameter("@Discount", SqlDbType.Int) {Value = dataGridViewSales.Rows[i].Cells[3]},
                     new SqlParameter("@TotalAmount", SqlDbType.Int) {Value = dataGridViewSales.Rows[i].Cells[4]},
                     new SqlParameter("@LastUpdateBy", SqlDbType.VarChar) {Value = null},
                     new SqlParameter("@LastUpdateDate", SqlDbType.DateTime) {Value = null},
                 };
            }
        }

       

       

       
       
    }
}
