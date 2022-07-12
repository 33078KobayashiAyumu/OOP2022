using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class Form1 : Form {
        BindingList<CarReport> listCarReport = new BindingList<CarReport> ();
        public Form1 () {
            InitializeComponent ();
        }

        private void btEnd_Click (object sender, EventArgs e) {
            Application.Exit ();
        }


        private void btAdd_Click (object sender, EventArgs e) {
            CarReport newCarReport = new CarReport {
                Date = dtp.Value,
                Auther = cmbRec.Text,
               // Maker = GetChckBoxGroup(),
                CarName = cmbCarName.Text,
                Report = txtReport.Text,
                Picture = pbBox.Image,
            };
            listCarReport.Add (newCarReport);
        }

        private List<CarReport.MakerGroup> GetChckBoxGroup () {
            var listGroup = new List<CarReport.MakerGroup> ();
            if (cbT.Checked) {
                listGroup.Add (CarReport.MakerGroup.トヨタ);
            }
            if (cbN.Checked) {
                listGroup.Add (CarReport.MakerGroup.日産);
            }
            if (cbH.Checked) {
                listGroup.Add (CarReport.MakerGroup.ホンダ);
            }
            if (cbS.Checked) {
                listGroup.Add (CarReport.MakerGroup.スバル);
            }
            if (cbFC.Checked) {
                listGroup.Add (CarReport.MakerGroup.外国車);
            }
            if (cbAther.Checked) {
                listGroup.Add (CarReport.MakerGroup.その他);
            }
            return listGroup;
        }

        private void dgv_Click (object sender, EventArgs e) {
            if (dgvCarReportSys == null) return;

            var index = dgvCarReportSys.CurrentRow.Index;
            cmbRec.Text = listCarReport[index].Auther;
            cmbCarName.Text = listCarReport[index].CarName;
            txtReport.Text = listCarReport[index].Report;
            pbBox.Image = listCarReport[index].Picture;
            dtp.Value = listCarReport[index].Registration.Year > 1900 ?
                        listCarReport[index].Registration : DateTime.Today;
            setGroupType (index);
        }
        private void setGroupType(int index) {
            groupChekBoxClear ();

        }
        private void groupChekBoxClear () {
            cbT.Checked = cbN.Checked = cbH.Checked = cbS.Checked = cbFC.Checked = cbAther.Checked = false;
        }
    }
}
