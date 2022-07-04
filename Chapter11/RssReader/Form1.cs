using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RssReader {
    public partial class RSSReader : Form {

        List<string> linklist = new List<string> ();
        public RSSReader () {
            InitializeComponent ();
        }

        

        private void btRssGet_Click (object sender, EventArgs e) {
            using (var wc = new WebClient ()) {
                if (String.IsNullOrWhiteSpace (cbRssUrl.Text)) {
                    MessageBox.Show ("error");
                    return;
                }

                var stream = wc.OpenRead (cbRssUrl.Text);

                var xdoc = XDocument.Load (stream);
                var xTitle = xdoc.Root.Descendants ("item").Select (x =>(string)x.Element ("title"));
                var xlink = xdoc.Root.Descendants ("item").Select (x => (string)x.Element ("link"));
                lbRssTitle.Items.Clear ();
                foreach (var data in xTitle) {
                    lbRssTitle.Items.Add(data);
                }
                foreach (var link in xlink) {
                    linklist.Add (link);
                }
            }
        }

        private void lbRssTitle_Click (object sender, EventArgs e) {
            var index = lbRssTitle.SelectedIndex;
            //wbBrowser.Navigate (linklist[index]);
            if (index == -1) return;
            wvBrowser.Source = new Uri (linklist[index]);
        }
        
        private void button1_Click (object sender, EventArgs e) {
                wvBrowser.GoBack ();
        }

        private void button2_Click (object sender, EventArgs e) {
                wvBrowser.GoForward ();
        }

        private void RSSReader_Load (object sender, EventArgs e) {
            MaskCheck ();
        }

        private void MaskCheck () {
            btBack.Enabled = wvBrowser.CanGoBack;
            btForward.Enabled = wvBrowser.CanGoForward;
        }

        private void wvBrowser_NavigationCompleted (object sender, Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlNavigationCompletedEventArgs e) {
            MaskCheck ();
        }
    }
}
