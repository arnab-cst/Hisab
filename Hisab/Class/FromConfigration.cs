using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Hisab.Class
{
    public class FromConfigration
    {
        string CS = ConfigurationManager.ConnectionStrings["MyDBCon"].ConnectionString;
        public void LoadMDIChild(Form frmObj, Form parent)
        {
            frmObj.MdiParent = parent;
            frmObj.Dock = DockStyle.Fill;
            frmObj.AutoScroll = true;
            //frmObj.TopLevel = false;
            //frmObj.ControlBox = false;
            frmObj.Text = String.Empty;
            frmObj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmObj.BackColor = Properties.Settings.Default.DefaultBGColor;
            frmObj.Show();
        }
        public void FillCombo(ComboBox c,string ComboType,string query="")
        {

            try
            {

                using (SqlConnection con = new SqlConnection(CS))
                {
                    using (SqlCommand cmd = new SqlCommand("Get_LUData", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@param1", ComboType);
                        cmd.Parameters.AddWithValue("@query", query);

                        con.Open();
                        // SqlDataAdapter dr = new SqlDataAdapter(cmd);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        c.DisplayMember = "TEXT";
                        c.ValueMember = "ID";
                        c.DataSource = ds.Tables[0];
                    }
                }
            }
            catch(Exception ex){}
            finally{
            }
           // con.Close();
        }
        public string Create()
        {
            string msg = "Fail To Update Record";
            try
            {

                //using (SqlConnection con = new SqlConnection(CS))
                //{
                //    using (SqlCommand cmd = new SqlCommand("Manage_SalesRecord", con))
                //    {
                //        cmd.CommandType = CommandType.StoredProcedure;
                //        cmd.Parameters.AddWithValue("@param1", ComboType);
                //        cmd.Parameters.AddWithValue("@query", query);
                //        cmd.Parameters.AddRange

                //        con.Open();
                //    }
                //}
            }
            catch (Exception ex) { }
            finally { }

            return msg;
        }

    }
}

    