using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGame {
    public partial class Form1 : Form {
        Random r = new Random ();
        private int random;
        public Form1 () {
            InitializeComponent ();
        }

        private void textBox1_TextChanged (object sender, EventArgs e) {

        }
        private void Form1_Load (object sender, EventArgs e) {
            random = r.Next (1, 51);

        }
        private void button1_Click (object sender, EventArgs e) {
            
            if (rand.Value < random) {
                tb.Text = "もっとおおきい";
            }else if(rand.Value > random){
                tb.Text = "もっとちいさい";
            } else {
                tb.Text = "正解";
            }

        }

        
    }
}
