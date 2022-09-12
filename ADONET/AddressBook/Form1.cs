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
        public Form1 () {
            InitializeComponent ();
        }

        private void addressTableBindingNavigatorSaveItem_Click (object sender, EventArgs e) {
            this.Validate ();
            this.addressTableBindingSource.EndEdit ();
            this.tableAdapterManager.UpdateAll (this.infosys202229DataSet);

        }

        private void Form1_Load (object sender, EventArgs e) {
            

        }

        private void addressTableDataGridView_Click (object sender, EventArgs e) {

            //データグリッドビューの選択レコードを各テキストボックスに設定
            tbName.Text = addressTableDataGridView.CurrentRow.Cells[1].Value.ToString ();
            tbAddress.Text = addressTableDataGridView.CurrentRow.Cells[2].Value.ToString ();
            tbTel.Text = addressTableDataGridView.CurrentRow.Cells[3].Value.ToString ();
            tbMail.Text = addressTableDataGridView.CurrentRow.Cells[4].Value.ToString ();
            tbMemo.Text = addressTableDataGridView.CurrentRow.Cells[5].Value.ToString ();

            if (!(addressTableDataGridView.CurrentRow.Cells[6].Value is DBNull)) {
                pbImage.Image = ByteArrayToImage ((byte[])addressTableDataGridView.CurrentRow.Cells[6].Value);
            } else {
                pbImage.Image = null;
            }
        }

        private void btAdd_Click (object sender, EventArgs e) {
            DataRow newRow = infosys202229DataSet.AddressTable.NewRow ();

            newRow[1] = tbName.Text;
            newRow[2] = tbAddress.Text;
            newRow[3] = tbTel.Text;
            newRow[4] = tbMail.Text;
            newRow[5] = tbMemo.Text;
            newRow[6] = ImageToByteArray (pbImage.Image);

            //データセットへ新しいレコードを追加
            infosys202229DataSet.AddressTable.Rows.Add (newRow);
            //データベース更新
            this.addressTableTableAdapter.Update (this.infosys202229DataSet.AddressTable);
        }

        private void btUppdate_Click (object sender, EventArgs e) {
            //各テキストボックスからデータグリッドビューに設定
            addressTableDataGridView.CurrentRow.Cells[1].Value = tbName.Text;
            addressTableDataGridView.CurrentRow.Cells[2].Value = tbAddress.Text;
            addressTableDataGridView.CurrentRow.Cells[3].Value = tbTel.Text;
            addressTableDataGridView.CurrentRow.Cells[4].Value = tbMail.Text;
            addressTableDataGridView.CurrentRow.Cells[5].Value = tbMemo.Text;
            addressTableDataGridView.CurrentRow.Cells[6].Value = ImageToByteArray ((pbImage.Image));

            //データセットの中をデータベースに反映(保存)
            this.Validate ();
            this.addressTableBindingSource.EndEdit ();
            this.tableAdapterManager.UpdateAll (this.infosys202229DataSet);
        }

        private void btImageOpen_Click (object sender, EventArgs e) {
            if (ofdImage.ShowDialog () == DialogResult.OK) {
               pbImage.Image =  System.Drawing.Image.FromFile(ofdImage.FileName);
            }
        }

        private void btImageClear_Click (object sender, EventArgs e) {
            pbImage.Image = null;
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

        private void addressTableDataGridView_DataError (object sender, DataGridViewDataErrorEventArgs e) {

        }

        private void button1_Click (object sender, EventArgs e) {
            this.addressTableTableAdapter.FillByName (this.infosys202229DataSet.AddressTable,tbNameSearch.Text);
            Null_Check ();
        }

        private void btClear_Click (object sender, EventArgs e) {
            tbName.Text = null;
            tbAddress.Text = null;
            tbTel.Text = null;
            tbMail.Text = null;
            tbMemo.Text = null;
            pbImage.Image = null;
            tbNameSearch = null;
            addressTableDataGridView.ClearSelection ();
        }

        private void データベース接続ToolStripMenuItem_Click (object sender, EventArgs e) {
            // TODO: このコード行はデータを 'infosys202229DataSet.AddressTable' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            db_Connect ();
        }

        private void 終了ToolStripMenuItem_Click (object sender, EventArgs e) {
            Application.Exit ();
        }

        private void btRelieve_Click (object sender, EventArgs e) {
            btRelieve.Refresh ();
            db_Connect ();
            tbNameSearch.Text= null;
        }
        private void db_Connect () {
            this.addressTableTableAdapter.Fill (this.infosys202229DataSet.AddressTable);
        }

        private void バージョン情報ToolStripMenuItem_Click (object sender, EventArgs e) {
            new Version ().ShowDialog ();
        }
        private void Null_Check () {
            if (tbNameSearch.Text == null) {
                btRelieve.Enabled = false;
            } else {
                btRelieve.Enabled = true;
            }
        }
    }
}
