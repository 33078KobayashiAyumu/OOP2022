using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
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

        //追加ボタンをクリックした時の処理
        private void btAddPerson_Click (object sender, EventArgs e) {

            if (String.IsNullOrWhiteSpace (tbName.Text)) {
                MessageBox.Show ("氏名が入力されてません");
                return;
            }

            Person newPerson = new Person {

                Name = tbName.Text,
                MailAddress = tbMainAddress.Text,
                Adress = tbAdress.Text,
                Company = cbCompany.Text,
                Picture = pbPicture.Image,
                Registration = dateTime.Value,
                listGroup = GetChckBoxGroup (),
            };
            listPerson.Add (newPerson);

            EnabledCheck ();

            setCbCompany (cbCompany.Text);

        }

        //コンボボックスに会社名を登録
        private void setCbCompany (string company) {

            if (!cbCompany.Items.Contains (company)) {
                //登録されていないとき処理
                cbCompany.Items.Add (company);
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

        

        //更新ボタンが押された時の処理
        private void btUpdate_Click (object sender, EventArgs e) {

            var getIndex = dgvPrersons.CurrentRow.Index;

            listPerson[getIndex].Name = tbName.Text;
            listPerson[getIndex].MailAddress = tbMainAddress.Text;
            listPerson[getIndex].Adress = tbAdress.Text;
            listPerson[getIndex].Company = cbCompany.Text;
            listPerson[getIndex].Picture = pbPicture.Image;
            listPerson[getIndex].Registration = dateTime.Value;
            listPerson[getIndex].listGroup = GetChckBoxGroup ();
            dgvPrersons.Refresh (); // データグリットビュー更新
        }

        //削除ボタンが押された時の処理
        private void btDel_Click (object sender, EventArgs e) {

            listPerson.RemoveAt (dgvPrersons.CurrentRow.Index);

            EnabledCheck ();
        }
        
        //更新・削除ボタンのマスク処理を行う（マスク判定込み）
        private void EnabledCheck () {
            btDel.Enabled = btUpdate.Enabled =  listPerson.Count () > 0 ? true : false;
        }

        private void Form1_Load (object sender, EventArgs e) {
            EnabledCheck ();
        }

        //保存ボタンのイベントハンドラ
        private void btSave_Click (object sender, EventArgs e) {
            if (sfdSaveDialog.ShowDialog () == DialogResult.OK) {
                try {
                    //バイナリ形式でシリアル化
                    var bf = new BinaryFormatter ();

                    using (FileStream fs = File.Open(sfdSaveDialog.FileName,FileMode.Create)) {
                        bf.Serialize (fs, listPerson);
                    }

                } catch (Exception ex) {
                    MessageBox.Show (ex.Message);
                }
            }
        }

        //開くボタンのイベントハンドラ
        private void btOpen_Click (object sender, EventArgs e) {
            if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK) {
                try {
                    //バイナリ形式で逆シリアル化
                    var bf = new BinaryFormatter ();

                    using (FileStream fs = File.Open (ofdFileOpenDialog.FileName, FileMode.Open, FileAccess.Read)) {
                        //逆シリアル化して読み込む
                        listPerson = (BindingList<Person>)bf.Deserialize (fs);
                        dgvPrersons.DataSource = null;
                        dgvPrersons.DataSource = listPerson;

                    }
                } catch (Exception ex) {
                    MessageBox.Show (ex.Message);

                }
                cbCompany.Items.Clear ();
                foreach (var item in listPerson.Select (p => p.Company)) {
                    //存在する会社を登録
                    setCbCompany (item);
                }
                EnabledCheck ();
            }
        }
    }
}
