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
        IEnumerable<string> xTitle, xlink;
        List<string> linklist = new List<string> ();
        public RSSReader () {
            InitializeComponent ();
        }

        

        private void btRssGet_Click (object sender, EventArgs e) {
            using (var wc = new WebClient ()) {
                var stream = wc.OpenRead ("https://news.yahoo.co.jp/rss/categories/business.xml");

                var xdoc = XDocument.Load (stream);
                xTitle = xdoc.Root.Descendants ("item").Select (x =>(string)x.Element ("title"));
                xlink = xdoc.Root.Descendants ("item").Select (x => (string)x.Element ("link"));

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
            foreach (var link in xTitle) {
                
            }
        }
    }
}
