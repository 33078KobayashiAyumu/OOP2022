using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample0607 {
    public partial class けいさん : Form {
        Random r = new Random ();
        public けいさん () {
            InitializeComponent ();
        }

        private void btRund_Click (object sender, EventArgs e) {
            
            Number.Value =  r.Next ((int)randMin.Value, (int)randMax.Value+1);

        }

        private void label1_Click (object sender, EventArgs e) {

        }

        private void randMin_ValueChanged (object sender, EventArgs e) {

        }
    }
}
