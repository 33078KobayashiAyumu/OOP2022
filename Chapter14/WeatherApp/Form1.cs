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

            switch (cmbArea.Text) {

                case "宗谷地方":
                    dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/011000.json");
                    dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/011000.json");
                    break;
                case "上川・留萌地方":
                    dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/012000.json");
                    dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/012000.json");
                    break;
                case "網走・北見・紋別地方":
                    dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/013000.json");
                    dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/013000.json");
                    break;
                case "十勝地方":
                    dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/014030.json");
                    dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/014030.json");
                    break;
                case "釧路・根室地方":
                    dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/014100.json");
                    dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/014100.json");
                    break;
                case "胆振・日高地方":
                    dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/015000.json");
                    dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/015000.json");
                    break;
                case "石狩・空知・後志地方":
                    dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/016000.json");
                    dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/016000.json");
                    break;
                case "渡島・檜山地方":
                    dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/017000.json");
                    dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/017000.json");
                    break;
                case "青森県":
                    dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/020000.json");
                    dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/020000.json");
                    break;
                case "岩手県":
                    dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/030000.json");
                    dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/030000.json");
                    break;
                case "宮城県":
                    dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/040000.json");
                    dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/040000.json");
                    break;
                case "秋田県":
                    dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/050000.json");
                    dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/050000.json");
                    break;
                case "山形県":
                    dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/060000.json");
                    dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/060000.json");
                    break;
                case "福島県":
                    dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/070000.json");
                    dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/070000.json");
                    break;
                case "茨城県":
                    dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/080000.json");
                    dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/080000.json");
                    break;
                case "栃木県":
                    dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/090000.json");
                    dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/090000.json");
                    break;
                case "群馬県":
                    dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/100000.json");
                    dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/100000.json");
                    break;
                case "埼玉県":
                    dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/110000.json");
                    dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/110000.json");
                    break;
                case "千葉県":
                    dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/120000.json");
                    dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/120000.json");
                    break;
                case "東京都":
                    dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/130000.json");
                    dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/130000.json");
                    break;
                case "神奈川県":
                    dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/140000.json");
                    dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/140000.json");
                    break;
                case "山梨県":
                    dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/190000.json");
                    dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/190000.json");
                    break;
                case "長野県":
                    dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/200000.json");
                    dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/200000.json");
                    break;
                case "岐阜県":
                    dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/210000.json");
                    dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/210000.json");
                    break;
                case "静岡県":
                    dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/220000.json");
                    dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/220000.json");
                    break;
                case "愛知県":
                    dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/230000.json");
                    dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/230000.json");
                    break;
                case "三重県":
                    dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/240000.json");
                    dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/240000.json");
                    break;
                case "新潟県":
                    dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/150000.json");
                    dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/150000.json");
                    break;
                case "富山県":
                    dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/160000.json");
                    dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/160000.json");
                    break;
                case "石川県":
                    dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/170000.json");
                    dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/170000.json");
                    break;
                case "福井県":
                    dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/180000.json");
                    dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/180000.json");
                    break;
                case "滋賀県":
                    dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/250000.json");
                    dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/250000.json");
                    break;
                case "京都府":
                    dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/260000.json");
                    dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/260000.json");
                    break;
                case "大阪府":
                    dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/270000.json");
                    dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/270000.json");
                    break;
                case "兵庫県":
                    dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/280000.json");
                    dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/280000.json");
                    break;
                case "奈良県":
                    dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/290000.json");
                    dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/290000.json");
                    break;
                case "和歌山県":
                    dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/300000.json");
                    dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/300000.json");
                    break;
                case "鳥取県":
                    dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/310000.json");
                    dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/310000.json");
                    break;
                case "島根県":
                    dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/320000.json");
                    dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/320000.json");
                    break;
                case "岡山県":
                    dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/330000.json");
                    dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/330000.json");
                    break;
                case "広島県":
                    dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/340000.json");
                    dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/340000.json");
                    break;
                case "徳島県":
                    dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/360000.json");
                    dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/30000.json");
                    break;
                case "香川県":
                    dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/370000.json");
                    dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/370000.json");
                    break;
                case "愛媛県":
                    dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/380000.json");
                    dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/380000.json");
                    break;
                case "高知県":
                    dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/390000.json");
                    dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/390000.json");
                    break;
                case "山口県":
                    dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/350000.json");
                    dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/350000.json");
                    break;
                case "福岡県":
                    dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/400000.json");
                    dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/400000.json");
                    break;
                case "佐賀県":
                    dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/410000.json");
                    dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/410000.json");
                    break;
                case "長崎県":
                    dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/420000.json");
                    dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/420000.json");
                    break;
                case "熊本県":
                    dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/430000.json");
                    dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/430000.json");
                    break;
                case "大分県":
                    dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/440000.json");
                    dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/440000.json");
                    break;
                case "宮崎県":
                    dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/450000.json");
                    dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/450000.json");
                    break;
                case "鹿児島県":
                    dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/460100.json");
                    dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/471460100000.json");
                    break;
                case "沖縄本島地方":
                    dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/471000.json");
                    dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/471000.json");
                    break;
                case "大東島地方":
                    dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/472000.json");
                    dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/472000.json");
                    break;
                case "宮古島地方":
                    dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/473000.json");
                    dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/473000.json");
                    break;
                case "八重山地方":
                    dString = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/474000.json");
                    dString1 = wc.DownloadString ("https://www.jma.go.jp/bosai/forecast/data/forecast/474000.json");
                    break;
            }


            var json = JsonConvert.DeserializeObject<Rootobject> (dString);
            tbTime.Text = json.reportDatetime.ToString();
            tbWeatherInfo.Text = json.text;

            var json1 = JsonConvert.DeserializeObject<Class1[]> (dString1);
            tbH.Text = json1[1].tempAverage.areas[0].max + "度";
            tbL.Text = json1[1].tempAverage.areas[0].min + "度";

            tbToday.Text = json1[0].timeSeries[0].areas[0].weathers[0];
            tbTom.Text = json1[0].timeSeries[0].areas[0].weathers[1];
            
            pbToday.ImageLocation = @"https://www.jma.go.jp/bosai/forecast/img/" + json1[0].timeSeries[0].areas[0].weatherCodes[0] + ".png";
            pbTom.ImageLocation = @"https://www.jma.go.jp/bosai/forecast/img/" + json1[0].timeSeries[0].areas[0].weatherCodes[1] + ".png";

            pb1.ImageLocation = @"https://www.jma.go.jp/bosai/forecast/img/" + json1[1].timeSeries[0].areas[0].weatherCodes[0] + ".png";
            pb2.ImageLocation = @"https://www.jma.go.jp/bosai/forecast/img/" + json1[1].timeSeries[0].areas[0].weatherCodes[1] + ".png";
            pb3.ImageLocation = @"https://www.jma.go.jp/bosai/forecast/img/" + json1[1].timeSeries[0].areas[0].weatherCodes[2] + ".png";
            pb4.ImageLocation = @"https://www.jma.go.jp/bosai/forecast/img/" + json1[1].timeSeries[0].areas[0].weatherCodes[3] + ".png";
            pb5.ImageLocation = @"https://www.jma.go.jp/bosai/forecast/img/" + json1[1].timeSeries[0].areas[0].weatherCodes[4] + ".png";
            pb6.ImageLocation = @"https://www.jma.go.jp/bosai/forecast/img/" + json1[1].timeSeries[0].areas[0].weatherCodes[5] + ".png";
            pb7.ImageLocation = @"https://www.jma.go.jp/bosai/forecast/img/" + json1[1].timeSeries[0].areas[0].weatherCodes[6] + ".png";
            try {
                tbAfter.Text = json1[0].timeSeries[0].areas[0].weathers[2];
            } catch (Exception) {

            }
            try {
                pbAfter.ImageLocation = json1[0].timeSeries[0].areas[0].weathers[2];
            } catch (Exception) {

            }

        }

        private void bt北海道_Click (object sender, EventArgs e) {
            cmbArea.Items.Clear();
            cmbArea.Items.Add ("宗谷地方");
            cmbArea.Items.Add ("上川・留萌地方");
            cmbArea.Items.Add ("網走・北見・紋別地方");
            cmbArea.Items.Add ("釧路・根室地方");
            cmbArea.Items.Add ("胆振・日高地方");
            cmbArea.Items.Add ("石狩・空知・後志地方");
            cmbArea.Items.Add ("渡島・檜山地方");
        }

        private void bt東北_Click (object sender, EventArgs e) {
            cmbArea.Items.Clear ();
            cmbArea.Items.Add ("青森県");
            cmbArea.Items.Add ("岩手県");
            cmbArea.Items.Add ("宮城県");
            cmbArea.Items.Add ("秋田県");
            cmbArea.Items.Add ("山形県");
            cmbArea.Items.Add ("福島県");
        }

        private void bt関東_Click (object sender, EventArgs e) {
            cmbArea.Items.Clear ();
            cmbArea.Items.Add ("茨城県");
            cmbArea.Items.Add ("栃木県");
            cmbArea.Items.Add ("群馬県");
            cmbArea.Items.Add ("埼玉県");
            cmbArea.Items.Add ("千葉県");
            cmbArea.Items.Add ("東京都");
            cmbArea.Items.Add ("神奈川県");

        }

        private void bt中部_Click (object sender, EventArgs e) {
            cmbArea.Items.Clear ();
            cmbArea.Items.Add ("新潟県");
            cmbArea.Items.Add ("富山県");
            cmbArea.Items.Add ("石川県");
            cmbArea.Items.Add ("福井県");
            cmbArea.Items.Add ("山梨県");
            cmbArea.Items.Add ("長野県");
            cmbArea.Items.Add ("岐阜県");
            cmbArea.Items.Add ("静岡県");
            cmbArea.Items.Add ("愛知県");
        }

        private void bt近畿_Click (object sender, EventArgs e) {

            cmbArea.Items.Clear ();
            cmbArea.Items.Add ("三重県");
            cmbArea.Items.Add ("滋賀県");
            cmbArea.Items.Add ("京都府");
            cmbArea.Items.Add ("大阪府");
            cmbArea.Items.Add ("兵庫県");
            cmbArea.Items.Add ("奈良県");
            cmbArea.Items.Add ("和歌山県");
        }

        private void bt中国_Click (object sender, EventArgs e) {
            cmbArea.Items.Clear ();
            cmbArea.Items.Add ("鳥取県");
            cmbArea.Items.Add ("島根県");
            cmbArea.Items.Add ("岡山県");
            cmbArea.Items.Add ("広島県");
            cmbArea.Items.Add ("山口県");
        }

        private void bt四国_Click (object sender, EventArgs e) {
            cmbArea.Items.Clear ();
            cmbArea.Items.Add ("徳島県");
            cmbArea.Items.Add ("香川県");
            cmbArea.Items.Add ("愛媛県");
            cmbArea.Items.Add ("高知県");
        }

        private void bt九州_Click (object sender, EventArgs e) {
            cmbArea.Items.Clear ();
            cmbArea.Items.Add ("福岡県");
            cmbArea.Items.Add ("佐賀県");
            cmbArea.Items.Add ("長崎県");
            cmbArea.Items.Add ("熊本県");
            cmbArea.Items.Add ("大分県");
            cmbArea.Items.Add ("宮崎県");
            cmbArea.Items.Add ("鹿児島県");
        }

        private void bt沖縄_Click (object sender, EventArgs e) {
            cmbArea.Items.Clear ();
            cmbArea.Items.Add ("沖縄本島地方");
            cmbArea.Items.Add ("大東島地方");
            cmbArea.Items.Add ("宮古島地方");
            cmbArea.Items.Add ("八重山地方");
        }
    }
}
