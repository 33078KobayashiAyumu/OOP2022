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
        public Form1 () {
            InitializeComponent ();
        }

        private void btEnd_Click (object sender, EventArgs e) {
            Application.Exit ();
        }


        private void btAdd_Click (object sender, EventArgs e) {
            DataRow newRow = infosys202229DataSet.CarReportDB.NewRow ();

            newRow[1] = dtp.Text;
            newRow[2] = cmbRec.Text;
            newRow[3] = MakerChck();
            newRow[4] = cmbCarName.Text;
            newRow[5] = txtReport.Text;
            newRow[6] = ImageToByteArray (pbBox.Image);

            //データセットへ新しいレコードを追加
            infosys202229DataSet.CarReportDB.Rows.Add (newRow);
            //データベース更新
            this.carReportDBTableAdapter.Update (this.infosys202229DataSet.CarReportDB);
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
            carReportDBDataGridView.CurrentRow.Cells[1].Value = cmbRec.Text;
            carReportDBDataGridView.CurrentRow.Cells[2].Value = dtp.Text;
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

        private void carReportDBDataGridView_CellContentClick (object sender, DataGridViewCellEventArgs e) {
            //データグリッドビューの選択レコードを各テキストボックスに設定
            dtp.Text = carReportDBDataGridView.CurrentRow.Cells[1].Value.ToString ();
            cmbRec.Text = carReportDBDataGridView.CurrentRow.Cells[2].Value.ToString ();
            MakerChck ();
            cmbCarName.Text = carReportDBDataGridView.CurrentRow.Cells[4].Value.ToString ();
            txtReport.Text = carReportDBDataGridView.CurrentRow.Cells[5].Value.ToString ();

            if (!(carReportDBDataGridView.CurrentRow.Cells[6].Value is DBNull)) {
                pbBox.Image = ByteArrayToImage ((byte[])carReportDBDataGridView.CurrentRow.Cells[6].Value);
            } else {
                pbBox.Image = null;
            }
        }

        private void carReportDBDataGridView_DataError (object sender, DataGridViewDataErrorEventArgs e) {

        }
    }
}
