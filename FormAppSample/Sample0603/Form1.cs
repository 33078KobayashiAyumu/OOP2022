using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample0603 {
    public partial class Form1 : Form {
        public Form1 () {
            InitializeComponent ();
        }

        private void Form1_Load (object sender, EventArgs e) {

        }
        //　ボタンクリックイベントハンドラ
        private void btPush_Click (object sender, EventArgs e) {
            //ans.Text = (int.Parse(tbsuu1.Text) + int.Parse(tbsuu2.Text)).ToString();
            n_ans.Value = suu1.Value + suu2.Value;
        }

        private void textBox1_TextChanged (object sender, EventArgs e) {
            
        }

        private void label1_Click (object sender, EventArgs e) {

        }
    }
}
