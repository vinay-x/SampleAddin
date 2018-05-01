using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using AddinExpress.OL;
  
namespace SampleAddin
{
    public partial class ADXOlForm1 : AddinExpress.OL.ADXOlForm
    {
        public ADXOlForm1()
        {
            InitializeComponent();
        }

        public void pluginView_Load(object sender, EventArgs e)
        {
            showDefaultPage();
        }

        public void pluginView_Load()
        {
            showDefaultPage();
        }

        public void showDefaultPage()
        {
            try
            {
                webBrowser1.Navigate("http://192.168.1.9:8001/samplePage.html");
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception occured: " + e.Message);
            }
        }
    }
}
