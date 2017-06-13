using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hisab.Class
{
    public class FromConfigration
    {
        public void LoadMDIChild(Form frmObj,Form parent)
        {
            frmObj.MdiParent = parent;
            frmObj.Dock = DockStyle.Fill;
            frmObj.AutoScroll = true;
            //frmObj.TopLevel = false;
            //frmObj.ControlBox = false;
            frmObj.Text = String.Empty;
            frmObj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmObj.Show();
        }   
    }
}
