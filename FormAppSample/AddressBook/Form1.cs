using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook {
    public partial class Form1 : Form {
        //住所データ管理用リスト
        BindingList<Person> listPerson = new BindingList<Person> ();

        public Form1 () {
            InitializeComponent ();
            dgvPrersons.DataSource = listPerson;
        }

        private void textBox3_TextChanged (object sender, EventArgs e) {

        }

        private void checkBox1_CheckedChanged (object sender, EventArgs e) {

        }

        private void checkBox2_CheckedChanged (object sender, EventArgs e) {

        }

        private void checkBox3_CheckedChanged (object sender, EventArgs e) {

        }

        private void checkBox4_CheckedChanged (object sender, EventArgs e) {

        }

        private void button3_Click (object sender, EventArgs e) {
            pbPicture.Image = null;
        }

        private void btPictureOpen_Click (object sender, EventArgs e) {
            if (ofdFileOpenDialog.ShowDialog () == DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdFileOpenDialog.FileName);
            }
        }

        private void btAddPerson_Click (object sender, EventArgs e) {
            Person newPerson = new Person {
                Name = tbName.Text,
                MailAddress = tbMainAddress.Text,
                Adress = tbAdress.Text,
                Company = tbCompany.Text,
                Picture = pbPicture.Image,
            };
            listPerson.Add (newPerson);

        }
    }
}
