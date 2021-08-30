using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demoForWinFormFrame
{
    public partial class Main2Form : Form
    {
        public Main2Form()
        {
            InitializeComponent();
            Load += Main2Form_Load;
        }

        private void Main2Form_Load(object sender, EventArgs e)
        {
            var browser = new ChromiumWebBrowser("www.bing.com")
            {
                BrowserSettings =
                {
                    DefaultEncoding = "UTF-8",
                    WebGl = CefState.Disabled
                }
            };
            MainPanel.Controls.Add(browser);
        }
    }
}
