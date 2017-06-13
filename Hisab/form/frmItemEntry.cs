using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Hisab.form
{
    public partial class frmItemEntry : Form
    {
        public frmItemEntry()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["MyDBCon"].ConnectionString;
            string Query = "Select * from Items";
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand Cmd = new SqlCommand(Query, con);
                try
                {
                    con.Open();
                    Cmd.ExecuteReader();
                    MessageBox.Show("Connected uccessfully");
                }
                catch (Exception ex )
                {
                    MessageBox.Show(ex.ToString() +"Unable to connect to database");
                }

            }
        }
    }
}
