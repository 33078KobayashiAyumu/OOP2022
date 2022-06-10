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
                listGroup = GetChckBoxGroup(),
            };
            listPerson.Add (newPerson);
        }

        //チェックボックスにセットされている値をリストとして取り出す
        private List<Person.GroupType> GetChckBoxGroup () {
            var listGroup = new List<Person.GroupType> ();
            if (cbFamily.Checked) {
                listGroup.Add (Person.GroupType.家族);
            }
            if (cbFriend.Checked) {
                listGroup.Add (Person.GroupType.友人);
            }
            if (cbOther.Checked){
                listGroup.Add (Person.GroupType.仕事);
            }
            if (cbOther.Checked) {
                listGroup.Add (Person.GroupType.その他);
            }
            return listGroup;
        }

        private void dgvPrersons_CellContentClick (object sender, DataGridViewCellEventArgs e) {

        }


        //データグリットビューがクリックされたときのイベントハンドラ
        private void dgvPrersons_CellClick (object sender, DataGridViewCellEventArgs e) {
            var getIndex = dgvPrersons.CurrentRow.Index;

            tbName.Text = listPerson[getIndex].Name;
            tbMainAddress.Text = listPerson[getIndex].MailAddress;
            tbAdress.Text = listPerson[getIndex].Adress;
            tbCompany.Text = listPerson[getIndex].Company;
            pbPicture.Image = listPerson[getIndex].Picture;

            foreach (var group in listPerson[getIndex].listGroup) {
                switch (group) {
                    case Person.GroupType.家族:
                        cbFamily.Checked = true;
                        break;
                    case Person.GroupType.友人:
                        cbFriend.Checked = true;
                        break;
                    case Person.GroupType.仕事:
                        cbWork.Checked = true;
                        break;
                    case Person.GroupType.その他:
                        cbOther.Checked = true;
                        break;
                    default:
                        break;
                }
            }
        }



        
        private void dgvPrersons_Click (object sender, EventArgs e) {
            
        }

        private void dgvPrersons_MouseClick (object sender, MouseEventArgs e) {
            
        }

        private void Form1_Load (object sender, EventArgs e) {

        }
    }
}
