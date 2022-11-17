using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherApp {
    public partial class Form1 : Form {
        public Form1 () {
            InitializeComponent ();
        }

        private void btWeatherGet_Click (object sender, EventArgs e) {

            var wc = new WebClient () {

                Encoding = Encoding.UTF8

            };
            var dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/100000.json");
            var dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/011000.json");


            if (cmbArea.SelectedIndex == 0) {
                dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/011000.json");
                dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/011000.json");
            }

            if (cmbArea.SelectedIndex == 1) {
                dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/012000.json");
                dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/012000.json");

            }

            if (cmbArea.SelectedIndex == 2) {
                dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/013000.json");
                dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/013000.json");

            }

            if (cmbArea.SelectedIndex == 3) {
                dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/014030.json");
                dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/014030.json");
            }

            if (cmbArea.SelectedIndex == 4) {
                dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/014100.json");
                dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/014100.json");
            }

            if (cmbArea.SelectedIndex == 5) {
                dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/015000.json");
                dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/015000.json");
            }

            if (cmbArea.SelectedIndex == 6) {
                dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/016000.json");
                dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/016000.json");
            }

            if (cmbArea.SelectedIndex == 7) {
                dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/017000.json");
                dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/017000.json");
            }

            if (cmbArea.SelectedIndex == 8) {
                dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/020000.json");
                dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/020000.json");
            }

            if (cmbArea.SelectedIndex == 9) {
                dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/030000.json");
                dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/030000.json");
            }

            if (cmbArea.SelectedIndex == 10) {
                dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/040000.json");
                dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/040000.json");
            }

            if (cmbArea.SelectedIndex == 11) {
                dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/050000.json");
                dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/050000.json");
            }

            if (cmbArea.SelectedIndex == 12) {
                dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/060000.json");
                dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/060000.json");
            }

            if (cmbArea.SelectedIndex == 13) {
                dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/070000.json");
                dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/070000.json");
            }

            if (cmbArea.SelectedIndex == 14) {
                dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/080000.json");
                dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/080000.json");
            }

            if (cmbArea.SelectedIndex == 15) {
                dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/090000.json");
                dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/090000.json");
            }

            if (cmbArea.SelectedIndex == 16) {
                dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/100000.json");
                dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/100000.json");
            }

            if (cmbArea.SelectedIndex == 17) {
                dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/110000.json");
                dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/110000.json");
            }

            if (cmbArea.SelectedIndex == 18) {
                dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/120000.json");
                dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/120000.json");
            }

            if (cmbArea.SelectedIndex == 18) {
                dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/130000.json");
                dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/130000.json");
            }

            if (cmbArea.SelectedIndex == 19) {
                dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/140000.json");
                dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/140000.json");
            }

            if (cmbArea.SelectedIndex == 20) {
                dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/190000.json");
                dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/190000.json");
            }

            if (cmbArea.SelectedIndex == 21) {
                dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/200000.json");
                dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/200000.json");
            }

            if (cmbArea.SelectedIndex == 22) {
                dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/210000.json");
                dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/210000.json");
            }

            if (cmbArea.SelectedIndex == 23) {
                dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/220000.json");
                dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/220000.json");
            }

            if (cmbArea.SelectedIndex == 24) {
                dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/230000.json");
                dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/230000.json");
            }

            if (cmbArea.SelectedIndex == 25) {
                dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/240000.json");
                dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/240000.json");
            }

            if (cmbArea.SelectedIndex == 26) {
                dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/150000.json");
                dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/150000.json");
            }

            if (cmbArea.SelectedIndex == 27) {
                dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/160000.json");
                dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/160000.json");
            }

            if (cmbArea.SelectedIndex == 28) {
                dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/170000.json");
                dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/170000.json");
            }

            if (cmbArea.SelectedIndex == 29) {
                dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/180000.json");
                dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/180000.json");
            }

            if (cmbArea.SelectedIndex == 30) {
                dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/160000.json");
                dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/160000.json");
            }

            if (cmbArea.SelectedIndex == 31) {
                dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/170000.json");
                dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/170000.json");
            }

            if (cmbArea.SelectedIndex == 32) {
                dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/180000.json");
                dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/180000.json");
            }

            if (cmbArea.SelectedIndex == 33) {
                dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/250000.json");
                dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/250000.json");
            }

            if (cmbArea.SelectedIndex == 34) {
                dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/260000.json");
                dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/260000.json");
            }

            if (cmbArea.SelectedIndex == 35) {
                dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/280000.json");
                dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/280000.json");
            }

            if (cmbArea.SelectedIndex == 36) {
                dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/290000.json");
                dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/290000.json");
            }

            if (cmbArea.SelectedIndex == 37) {
                dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/300000.json");
                dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/300000.json");
            }

            if (cmbArea.SelectedIndex == 38) {
                dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/310000.json");
                dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/310000.json");
            }


            if (cmbArea.SelectedIndex == 39) {
                dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/320000.json");
                dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/320000.json");
            }

            if (cmbArea.SelectedIndex == 40) {
                dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/330000.json");
                dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/330000.json");
            }

            if (cmbArea.SelectedIndex == 41) {
                dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/340000.json");
                dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/340000.json");
            }

            if (cmbArea.SelectedIndex == 42) {
                dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/360000.json");
                dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/360000.json");
            }

            if (cmbArea.SelectedIndex == 43) {
                dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/370000.json");
                dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/370000.json");
            }

            if (cmbArea.SelectedIndex == 44) {
                dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/380000.json");
                dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/380000.json");
            }

            if (cmbArea.SelectedIndex == 45) {
                dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/390000.json");
                dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/390000.json");
            }

            if (cmbArea.SelectedIndex == 46) {
                dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/350000.json");
                dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/350000.json");
            }

            if (cmbArea.SelectedIndex == 47) {
                dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/400000.json");
                dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/400000.json");
            }

            if (cmbArea.SelectedIndex == 48) {
                dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/410000.json");
                dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/410000.json");
            }

            if (cmbArea.SelectedIndex == 49) {
                dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/420000.json");
                dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/420000.json");
            }

            if (cmbArea.SelectedIndex == 50) {
                dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/430000.json");
                dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/430000.json");
            }

            if (cmbArea.SelectedIndex == 51) {
                dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/440000.json");
                dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/440000.json");
            }

            if (cmbArea.SelectedIndex == 52) {
                dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/450000.json");
                dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/450000.json");
            }

            if (cmbArea.SelectedIndex == 53) {
                dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/460040.json");
                dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/460040.json");
            }

            if (cmbArea.SelectedIndex == 54) {
                dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/460100.json");
                dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/460100.json");
            }

            if (cmbArea.SelectedIndex == 55) {
                dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/471000.json");
                dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/471000.json");
            }

            if (cmbArea.SelectedIndex == 56) {
                dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/472000.json");
                dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/472000.json");
            }

            if (cmbArea.SelectedIndex == 57) {
                dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/473000.json");
                dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/473000.json");
            }

            if (cmbArea.SelectedIndex == 58) {
                dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/474000.json");
                dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/474000.json");

            }
            var json = JsonConvert.DeserializeObject<Rootobject> (dString);
            tbTime.Text = json.reportDatetime.ToString();
            tbWeatherInfo.Text = json.text;

            var json1 = JsonConvert.DeserializeObject<Class1[]> (dString1);
            tbToday.Text = json1[0].timeSeries[0].areas[0].weathers[0];
            tbTom.Text = json1[0].timeSeries[0].areas[0].weathers[1];
            tbAfter.Text = json1[0].timeSeries[0].areas[0].weathers[2];
            tbH.Text = json1[1].precipAverage.areas[0].max + "度";
            tbL.Text = json1[1].precipAverage.areas[0].min + "度";
            
        }

        private void cmbArea_SelectedIndexChanged (object sender, EventArgs e) {
            btWeatherGet.Enabled = false;
        }
    }
}
