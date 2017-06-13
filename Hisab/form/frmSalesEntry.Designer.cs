namespace Hisab.form
{
    partial class frmSalesEntry
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainerSales = new System.Windows.Forms.SplitContainer();
            this.tabControlSales = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerSales)).BeginInit();
            this.splitContainerSales.Panel2.SuspendLayout();
            this.splitContainerSales.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerSales
            // 
            this.splitContainerSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerSales.Location = new System.Drawing.Point(0, 0);
            this.splitContainerSales.Name = "splitContainerSales";
            this.splitContainerSales.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerSales.Panel2
            // 
            this.splitContainerSales.Panel2.Controls.Add(this.tabControlSales);
            this.splitContainerSales.Size = new System.Drawing.Size(815, 351);
            this.splitContainerSales.SplitterDistance = 55;
            this.splitContainerSales.TabIndex = 0;
            // 
            // tabControlSales
            // 
            this.tabControlSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSales.Location = new System.Drawing.Point(0, 0);
            this.tabControlSales.Name = "tabControlSales";
            this.tabControlSales.SelectedIndex = 0;
            this.tabControlSales.Size = new System.Drawing.Size(815, 292);
            this.tabControlSales.TabIndex = 0;
            // 
            // frmSalesEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 351);
            this.Controls.Add(this.splitContainerSales);
            this.Name = "frmSalesEntry";
            this.Text = "Sales Entry";
            this.Load += new System.EventHandler(this.frmSalesEntry_Load);
            this.splitContainerSales.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerSales)).EndInit();
            this.splitContainerSales.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerSales;
        private System.Windows.Forms.TabControl tabControlSales;
    }
}