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

            if(String.IsNullOrWhiteSpace(tbName.Text)) {
                MessageBox.Show ("氏名が入力されてません");
                return;
            }

            Person newPerson = new Person {

                Name = tbName.Text,
                MailAddress = tbMainAddress.Text,
                Adress = tbAdress.Text,
                Company = cbCompany.Text,
                Picture = pbPicture.Image,
                listGroup = GetChckBoxGroup(),
            };
            listPerson.Add (newPerson);

            if (listPerson.Count () > 0) {
                btDel.Enabled = true;
                btUpdate.Enabled = true;
            }
            //コンボボックスに会社名を登録

            if (!cbCompany.Items.Contains(cbCompany.Text)) {
                cbCompany.Items.Add (cbCompany.Text);
            }
            
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


        
        private void dgvPrersons_CellClick (object sender, DataGridViewCellEventArgs e) {
            
        }

        private void groupChekBoxClear () {
            cbFamily.Checked = cbFriend.Checked = cbWork.Checked = cbOther.Checked = false;
        }


        //データグリットビューがクリックされたときのイベントハンドラ
        private void dgvPrersons_Click (object sender, EventArgs e) {
            if (dgvPrersons.CurrentRow == null) return;
            
            var getIndex = dgvPrersons.CurrentRow.Index;
            
            tbName.Text = listPerson[getIndex].Name;
            tbMainAddress.Text = listPerson[getIndex].MailAddress;
            tbAdress.Text = listPerson[getIndex].Adress;
            cbCompany.Text = listPerson[getIndex].Company;
            pbPicture.Image = listPerson[getIndex].Picture;
            
            groupChekBoxClear ();

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

        private void dgvPrersons_MouseClick (object sender, MouseEventArgs e) {
            
        }

        

        // 更新ボタンが押された時の処理
        private void btUpdate_Click (object sender, EventArgs e) {

            var getIndex = dgvPrersons.CurrentRow.Index;

            listPerson[getIndex].Name = tbName.Text;
            listPerson[getIndex].MailAddress = tbMainAddress.Text;
            listPerson[getIndex].Adress = tbAdress.Text;
            listPerson[getIndex].Company = cbCompany.Text;
            listPerson[getIndex].Picture = pbPicture.Image;
            listPerson[getIndex].listGroup = GetChckBoxGroup ();
            dgvPrersons.Refresh (); // データグリットビュー更新
        }

        private void btDel_Click (object sender, EventArgs e) {

            listPerson.RemoveAt (dgvPrersons.CurrentRow.Index);

            if (listPerson.Count () == 0) {
                btDel.Enabled = false;
                btUpdate.Enabled = false;
            }
        }
        private void Form1_Load (object sender, EventArgs e) {
            btDel.Enabled = false;
            btUpdate.Enabled = false;
        }
    }
}
