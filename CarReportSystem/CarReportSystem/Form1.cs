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
        Settings settings = Settings.getInstance();
        int mode = 0;
        BindingList<CarReport> listCarReports = new BindingList<CarReport> ();
        public Form1 () {
            InitializeComponent ();
        }

        private void btEnd_Click (object sender, EventArgs e) {
            Application.Exit ();
        }


        private void btAdd_Click (object sender, EventArgs e) {
            DataRow newRow = infosys202229DataSet.CarReportDB.NewRow ();

            newRow[1] = dtp.Value;
            newRow[2] = cmbRec.Text;
            newRow[3] = MakerChck();
            newRow[4] = cmbCarName.Text;
            newRow[5] = txtReport.Text;
            newRow[6] = ImageToByteArray (pbBox.Image);

            //データセットへ新しいレコードを追加
            infosys202229DataSet.CarReportDB.Rows.Add (newRow);
            //データベース更新
            this.carReportDBTableAdapter.Update (this.infosys202229DataSet.CarReportDB);

            setCmbRec (cmbRec.Text);

            setCmbCarName (cmbCarName.Text);
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


        private void btFix_Click (object sender, EventArgs e) {
            //各テキストボックスからデータグリッドビューに設定
            carReportDBDataGridView.CurrentRow.Cells[1].Value = dtp.Value;
            carReportDBDataGridView.CurrentRow.Cells[2].Value = cmbRec.Text; 
            carReportDBDataGridView.CurrentRow.Cells[3].Value = MakerChck ();
            carReportDBDataGridView.CurrentRow.Cells[4].Value = cmbCarName.Text;
            carReportDBDataGridView.CurrentRow.Cells[5].Value = txtReport.Text;
            carReportDBDataGridView.CurrentRow.Cells[6].Value = ImageToByteArray ((pbBox.Image));

            //データセットの中をデータベースに反映(保存)
            this.Validate ();
            this.carReportDBBindingSource.EndEdit ();
            this.tableAdapterManager.UpdateAll (this.infosys202229DataSet);
        }


        private void btImgOpen_Click (object sender, EventArgs e) {
            if (ofdPic.ShowDialog () == DialogResult.OK) {
               pbBox.Image = System.Drawing.Image.FromFile (ofdPic.FileName);
            }
        }

        private void btimgDelete_Click (object sender, EventArgs e) {
            pbBox.Image = null;
        }

        private void Form1_Load (object sender, EventArgs e) {
            try {
                using (var read = XmlReader.Create ("Setting.xml")) {
                    var serializer = new XmlSerializer (typeof (Settings));
                    settings = serializer.Deserialize (read) as Settings;
                    BackColor = Color.FromArgb (settings.MainFormColor);
                }
            }
            catch(Exception) {

            }
        }


        private void 開くToolStripMenuItem_Click (object sender, EventArgs e) {
            // TODO: このコード行はデータを 'infosys202229DataSet.CarReportDB' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.carReportDBTableAdapter.Fill (this.infosys202229DataSet.CarReportDB);
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

        private void carReportDBBindingNavigatorSaveItem_Click (object sender, EventArgs e) {
            this.Validate ();
            this.carReportDBBindingSource.EndEdit ();
            this.tableAdapterManager.UpdateAll (this.infosys202229DataSet);

        }

        private void btConnect_Click (object sender, EventArgs e) {
            // TODO: このコード行はデータを 'infosys202229DataSet.CarReportDB' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.carReportDBTableAdapter.Fill (this.infosys202229DataSet.CarReportDB);
            cmbRec.Items.Clear ();    //コンボボックスのアイテム消去
            cmbCarName.Items.Clear ();    //コンボボックスのアイテム消去
                                          //コンボボックスへ新規登録


            for (int i = 0; i < carReportDBDataGridView.Rows.Count; i++) {
                setCmbRec (carReportDBDataGridView.Rows[i].Cells[2].Value.ToString ());
                setCmbCarName (carReportDBDataGridView.Rows[i].Cells[4].Value.ToString ());
            }


        }
        // バイト配列をImageオブジェクトに変換
        public static Image ByteArrayToImage (byte[] b) {
            ImageConverter imgconv = new ImageConverter ();
            Image img = (Image)imgconv.ConvertFrom (b);
            return img;
        }

        // Imageオブジェクトをバイト配列に変換
        public static byte[] ImageToByteArray (Image img) {
            ImageConverter imgconv = new ImageConverter ();
            byte[] b = (byte[])imgconv.ConvertTo (img, typeof (byte[]));
            return b;
        }

        private void MakerChckDB () {
            if ((string)carReportDBDataGridView.CurrentRow.Cells[3].Value == "トヨタ") {
                cbT.Checked = true;
            }
            if ((string)carReportDBDataGridView.CurrentRow.Cells[3].Value == "日産") {
                cbN.Checked = true;
            }
            if ((string)carReportDBDataGridView.CurrentRow.Cells[3].Value == "ホンダ") {
                cbH.Checked = true;
            }
            if ((string)carReportDBDataGridView.CurrentRow.Cells[3].Value == "スバル") {
                cbS.Checked = true;
            }
            if ((string)carReportDBDataGridView.CurrentRow.Cells[3].Value == "外国車") {
                cbFC.Checked = true;
            }
            if ((string)carReportDBDataGridView.CurrentRow.Cells[3].Value == "その他") {
                cbAther.Checked = true;
            }
        }

        private void carReportDBDataGridView_DataError (object sender, DataGridViewDataErrorEventArgs e) {

        }

        private void btSearch_Click (object sender, EventArgs e) {
            this.carReportDBTableAdapter.FillByAutor (this.infosys202229DataSet.CarReportDB, tbSearch.Text);
            Null_Check ();
        }
        private void Null_Check () {
            if (tbSearch.Text == null) {
                btRelieve.Enabled = false;
            } else {
                btRelieve.Enabled = true;
            }
        }

        private void btRelieve_Click (object sender, EventArgs e) {
            this.carReportDBTableAdapter.Fill (this.infosys202229DataSet.CarReportDB);
            tbSearch.Text = null;
        }

        private void btClear_Click (object sender, EventArgs e) {
            cmbRec.Text = null;
            CheckClear ();
            cmbCarName.Text = null;
            txtReport.Text = null;
            carReportDBDataGridView.ClearSelection ();
        }
        private void CheckClear () {
            cbT.Checked = false;
            cbN.Checked = false;
            cbH.Checked = false;
            cbS.Checked = false;
            cbFC.Checked = false;
            cbAther.Checked = false;
        }
        private void setCmbRec (string company) {
            if (!cmbRec.Items.Contains (company)) {
                //まだ登録されていなければ登録処理
                cmbRec.Items.Add (company);
            }
        }
        //コンボボックスに車名を登録する（重複なし）
        private void setCmbCarName (string company) {
            if (!cmbCarName.Items.Contains (company)) {
                //まだ登録されていなければ登録処理
                cmbCarName.Items.Add (company);
            }
        }

        private void carReportDBDataGridView_CellContentClick (object sender, MouseEventArgs e) {
            //データグリッドビューの選択レコードを各テキストボックスに設定
            dtp.Value = (DateTime)carReportDBDataGridView.CurrentRow.Cells[1].Value;
            cmbRec.Text = carReportDBDataGridView.CurrentRow.Cells[2].Value.ToString ();
            MakerChckDB ();
            cmbCarName.Text = carReportDBDataGridView.CurrentRow.Cells[4].Value.ToString ();
            txtReport.Text = carReportDBDataGridView.CurrentRow.Cells[5].Value.ToString ();

            if (!(carReportDBDataGridView.CurrentRow.Cells[6].Value is DBNull)) {
                pbBox.Image = ByteArrayToImage ((byte[])carReportDBDataGridView.CurrentRow.Cells[6].Value);
            } else {
                pbBox.Image = null;
            }

            

            
        }
    }
}
