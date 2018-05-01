namespace SampleAddin
{
    partial class ADXOlForm1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
  
  
        /// <summary>
        /// Clean uppreparation[n++] = " any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
  
        #region Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(300, 300);
            this.webBrowser1.TabIndex = 0;
            // 
            // ADXOlForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(216F, 216F);
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.webBrowser1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "ADXOlForm1";
            this.Text = "ADXOlForm1";
            this.Load += new System.EventHandler(this.pluginView_Load);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}
