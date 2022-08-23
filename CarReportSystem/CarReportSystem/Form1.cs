using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace CarReportSystem {
    public partial class Form1 : Form {
        Settings settings = new Settings();
        int mode = 0;
        BindingList<CarReport> listCarReport = new BindingList<CarReport> ();
        public Form1 () {
            InitializeComponent ();
            dgvCarReportSys.DataSource = listCarReport;
        }

        private void btEnd_Click (object sender, EventArgs e) {
            Application.Exit ();
        }


        private void btAdd_Click (object sender, EventArgs e) {
            if (String.IsNullOrWhiteSpace (cmbRec.Text)) {
                MessageBox.Show ("氏名が入力されてません");
                return;
            }
            CarReport newCarReport = new CarReport {
                Date = dtp.Value,
                Auther = cmbRec.Text,
                Maker = MakerChck(),
                CarName = cmbCarName.Text,
                Report = txtReport.Text,
                Picture = pbBox.Image,
            };
            listCarReport.Add (newCarReport);
            setAuther (cmbRec.Text);
            setCarName (cmbCarName.Text);
            dgvCarReportSys.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCarReportSys.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            EnabledCheck ();

        }

        private void setCarName (string CarName) {
            if (!cmbCarName.Items.Contains (CarName)) {
                //登録されていないとき処理
                cmbCarName.Items.Add (CarName);
            }
        }

        private void setAuther (string Rec) {
            if (!cmbRec.Items.Contains (Rec)) {
                //登録されていないとき処理
                cmbRec.Items.Add (Rec);
            }
        }

        private CarReport.MakerGroup MakerChck () {
            var selectedMaker = CarReport.MakerGroup.その他;
            if (cbT.Checked) {
                selectedMaker = CarReport.MakerGroup.トヨタ;
            }
            if (cbN.Checked) {
                selectedMaker = CarReport.MakerGroup.日産;
            }
            if (cbH.Checked) {
                selectedMaker = CarReport.MakerGroup.ホンダ;
            }
            if (cbS.Checked) {
                selectedMaker = CarReport.MakerGroup.スバル;
            }
            if (cbFC.Checked) {
                selectedMaker = CarReport.MakerGroup.外国車;
            }
            if (cbAther.Checked) {
                selectedMaker = CarReport.MakerGroup.その他;
            }
            return selectedMaker;
        }

        private void dgv_Click (object sender, EventArgs e) {
            if (dgvCarReportSys.CurrentRow == null) return;

            var index = dgvCarReportSys.CurrentRow.Index;
            cmbRec.Text = listCarReport[index].Auther;
            cmbCarName.Text = listCarReport[index].CarName;
            txtReport.Text = listCarReport[index].Report;
            pbBox.Image = listCarReport[index].Picture;
            dtp.Value = listCarReport[index].Date.Year > 1900 ?
                        listCarReport[index].Date : DateTime.Today;
        }

        private void btFix_Click (object sender, EventArgs e) {
            var index = dgvCarReportSys.CurrentRow.Index;
            cmbRec.Text = listCarReport[index].Auther;
            cmbCarName.Text = listCarReport[index].CarName;
            txtReport.Text = listCarReport[index].Report;
            pbBox.Image = listCarReport[index].Picture;
            dgvCarReportSys.Refresh ();
            EnabledCheck ();
        }

        private void btDelete_Click (object sender, EventArgs e) {
            listCarReport.RemoveAt (dgvCarReportSys.CurrentRow.Index);
            EnabledCheck ();
        }

        private void btImgOpen_Click (object sender, EventArgs e) {
            if (ofdPic.ShowDialog() == DialogResult.OK) {
                pbBox.Image = Image.FromFile (ofdPic.FileName);
            }
        }

        private void btimgDelete_Click (object sender, EventArgs e) {
            pbBox.Image = null;
        }

        private void btArSave_Click (object sender, EventArgs e) {
            if (sfdxml.ShowDialog() ==DialogResult.OK) {
                try {
                    var bf = new BinaryFormatter ();
                    using (FileStream fs = File.Open (sfdxml.FileName, FileMode.Create))
                        bf.Serialize (fs,listCarReport);
                } catch(Exception ex) {
                    MessageBox.Show (ex.Message);
                }
            }
        }

        private void btArOpen_Click (object sender, EventArgs e) {
            if (ofdPic.ShowDialog () == DialogResult.OK) {
                try {
                    var bf = new BinaryFormatter ();
                    using (FileStream fs = File.Open (ofdPic.FileName, FileMode.Open, FileAccess.Read))
                        listCarReport = (BindingList<CarReport>)bf.Deserialize (fs);
                        dgvCarReportSys.DataSource = null;
                        dgvCarReportSys.DataSource = listCarReport;
                } catch (Exception ex) {
                    MessageBox.Show (ex.Message);
                }
                cmbCarName.Items.Clear ();
                foreach (var item in listCarReport.Select (p => p.CarName)) {
                    
                     setCarName(item);
                }
                cmbRec.Items.Clear ();
                foreach (var item in listCarReport.Select (p => p.Auther)) {
                    
                    setAuther (item);
                }
                EnabledCheck ();
            }
        }

        private void Form1_Load (object sender, EventArgs e) {
            using (var read = XmlReader.Create ("Setting.xml")) {
                var serializer = new XmlSerializer (typeof (Settings));
                settings = serializer.Deserialize (read) as Settings;
                BackColor = Color.FromArgb(settings.MainFormColor);

            }
            EnabledCheck ();
        }

        private void EnabledCheck () {
            btDelete.Enabled = btFix.Enabled = listCarReport.Count () > 0 ? true : false;
        }

        private void 開くToolStripMenuItem_Click (object sender, EventArgs e) {
            if (ofdPic.ShowDialog () == DialogResult.OK) {
                try {
                    var bf = new BinaryFormatter ();
                    using (FileStream fs = File.Open (ofdPic.FileName, FileMode.Open, FileAccess.Read))
                        listCarReport = (BindingList<CarReport>)bf.Deserialize (fs);
                    dgvCarReportSys.DataSource = null;
                    dgvCarReportSys.DataSource = listCarReport;
                } catch (Exception ex) {
                    MessageBox.Show (ex.Message);
                }
                cmbCarName.Items.Clear ();
                foreach (var item in listCarReport.Select (p => p.CarName)) {
                    //存在する会社を登録
                    setCarName (item);
                }
                cmbRec.Items.Clear ();
                foreach (var item in listCarReport.Select (p => p.Auther)) {
                    //存在する会社を登録
                    setAuther (item);
                }
                EnabledCheck ();
            }
        }

        private void 保存ToolStripMenuItem_Click (object sender, EventArgs e) {
            if (sfdxml.ShowDialog () == DialogResult.OK) {
                try {
                    var bf = new BinaryFormatter ();
                    using (FileStream fs = File.Open (sfdxml.FileName, FileMode.Create))
                        bf.Serialize (fs, listCarReport);
                } catch (Exception ex) {
                    MessageBox.Show (ex.Message);
                }
            }
        }

        private void 終了ToolStripMenuItem1_Click (object sender, EventArgs e) {
            Application.Exit ();
        }

        private void 色設定ToolStripMenuItem_Click (object sender, EventArgs e) {
            if(colorDialog1.ShowDialog () == DialogResult.OK) {
                BackColor = colorDialog1.Color;
                settings.MainFormColor = colorDialog1.Color.ToArgb();
            }
        }

        private void a_Click (object sender, EventArgs e) {
            pbBox.SizeMode = (PictureBoxSizeMode)mode;
            mode = mode < 4 ? ++mode : 0;
        }

        private void Form1_FormClosed (object sender, FormClosedEventArgs e) {
            using (var write = XmlWriter.Create ("Setting.xml")) {
                var serializer = new XmlSerializer (settings.GetType ());
                serializer.Serialize (write,settings);
            }
            
        }
    }
}
