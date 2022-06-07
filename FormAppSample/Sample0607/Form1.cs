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
    public partial class Form1 : Form {
        public Form1 () {
            InitializeComponent ();
        }

        private void label1_Click (object sender, EventArgs e) {

        }

        private void button1_Click (object sender, EventArgs e) {
            if (nm2.Value != 0) {
                nma.Value = nm1.Value / nm2.Value;
                nmm.Value = nm1.Value / nm2.Value;
            } else {
                MessageBox.Show ("われません","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
