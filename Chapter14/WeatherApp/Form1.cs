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
        string[] str;
        string dString;
        string dString1;
        public Form1 () {
            InitializeComponent ();
        }

        private void btWeatherGet_Click (object sender, EventArgs e) {


            
            

        }

        private void bt北海道_Click (object sender, EventArgs e) {
            cmbArea.Items.Clear();

            str = new string[] { 
                "宗谷地方", "上川・留萌地方", "網走・北見・紋別地方", "釧路・根室地方",
                "胆振・日高地方", "石狩・空知・後志地方","渡島・檜山地方" 
            };
            cmbArea.Items.AddRange (str);

        }

        private void bt東北_Click (object sender, EventArgs e) {
            cmbArea.Items.Clear ();

            str = new string[] {
                "青森県","岩手県","宮城県","秋田県","山形県","福島県"
            };
            cmbArea.Items.AddRange (str);
        }

        private void bt関東_Click (object sender, EventArgs e) {
            cmbArea.Items.Clear ();

            str = new string[] {
                "茨城県","栃木県","群馬県","埼玉県","千葉県","東京都","神奈川県"
            };
            cmbArea.Items.AddRange (str);

        }

        private void bt中部_Click (object sender, EventArgs e) {
            cmbArea.Items.Clear ();

            str = new string[] {
                "新潟県","富山県","石川県","福井県","山梨県","長野県","岐阜県","静岡県","愛知県"
            };
            cmbArea.Items.AddRange (str);

        }

        private void bt近畿_Click (object sender, EventArgs e) {

            cmbArea.Items.Clear ();

            str = new string[] {
                "三重県","滋賀県","京都府","大阪府","兵庫県","奈良県","和歌山県"
            };
            cmbArea.Items.AddRange (str);
        }

        private void bt中国_Click (object sender, EventArgs e) {
            cmbArea.Items.Clear ();

            str = new string[] {
                "鳥取県","島根県","岡山県","広島県","山口県"
            };
            cmbArea.Items.AddRange (str);
        }

        private void bt四国_Click (object sender, EventArgs e) {
            cmbArea.Items.Clear ();

            str = new string[] {
                "徳島県","香川県","愛媛県","高知県"
            };
            cmbArea.Items.AddRange (str);
        }

        private void bt九州_Click (object sender, EventArgs e) {
            cmbArea.Items.Clear ();

            str = new string[] {
                "福岡県","佐賀県","長崎県","熊本県","大分県","宮崎県","鹿児島県"
            };
            cmbArea.Items.AddRange (str);
        }

        private void bt沖縄_Click (object sender, EventArgs e) {
            cmbArea.Items.Clear ();

            str = new string[] {
                "沖縄本島地方","大東島地方","宮古島地方","八重山地方"
            };
            cmbArea.Items.AddRange (str);
        }

        private void cmbArea_SelectedIndexChanged (object sender, EventArgs e) {
            try {
                var wc = new WebClient () {

                    Encoding = Encoding.UTF8

                };
                string AreaNum = "";
                switch (cmbArea.Text) {

                    case "宗谷地方":
                        AreaNum = "011000";
                        break;
                    case "上川・留萌地方":
                        AreaNum = "012000";
                        break;
                    case "網走・北見・紋別地方":
                        AreaNum = "013000";
                        break;
                    case "十勝地方":
                        break;
                    case "釧路・根室地方":
                        AreaNum = "014100";
                        break;
                    case "胆振・日高地方":
                        AreaNum = "015000";
                        break;
                    case "石狩・空知・後志地方":
                        AreaNum = "016000";
                        break;
                    case "渡島・檜山地方":
                        AreaNum = "017000";
                        break;
                    case "青森県":
                        AreaNum = "020000";
                        break;
                    case "岩手県":
                        AreaNum = "030000";
                        break;
                    case "宮城県":
                        AreaNum = "040000";
                        break;
                    case "秋田県":
                        AreaNum = "050000";
                        break;
                    case "山形県":
                        AreaNum = "060000";
                        break;
                    case "福島県":
                        AreaNum = "070000";
                        break;
                    case "茨城県":
                        AreaNum = "080000";
                        break;
                    case "栃木県":
                        AreaNum = "090000";
                        break;
                    case "群馬県":
                        AreaNum = "100000";
                        break;
                    case "埼玉県":
                        AreaNum = "110000";
                        break;
                    case "千葉県":
                        AreaNum = "120000";
                        break;
                    case "東京都":
                        AreaNum = "130000";
                        break;
                    case "神奈川県":
                        AreaNum = "140000";
                        break;
                    case "山梨県":
                        AreaNum = "190000";
                        break;
                    case "長野県":
                        AreaNum = "200000";
                        break;
                    case "岐阜県":
                        AreaNum = "210000";
                        break;
                    case "静岡県":
                        AreaNum = "220000";
                        break;
                    case "愛知県":
                        AreaNum = "230000";
                        break;
                    case "三重県":
                        AreaNum = "240000";
                        break;
                    case "新潟県":
                        AreaNum = "150000";
                        break;
                    case "富山県":
                        AreaNum = "160000";
                        break;
                    case "石川県":
                        AreaNum = "170000";
                        break;
                    case "福井県":
                        AreaNum = "180000";
                        break;
                    case "滋賀県":
                        AreaNum = "250000";
                        break;
                    case "京都府":
                        AreaNum = "260000";
                        break;
                    case "大阪府":
                        AreaNum = "270000";
                        break;
                    case "兵庫県":
                        AreaNum = "280000";
                        break;
                    case "奈良県":
                        AreaNum = "290000";
                        break;
                    case "和歌山県":
                        AreaNum = "300000";
                        break;
                    case "鳥取県":
                        AreaNum = "310000";

                        break;
                    case "島根県":
                        AreaNum = "320000";

                        break;
                    case "岡山県":
                        AreaNum = "330000";

                        break;
                    case "広島県":
                        AreaNum = "340000";

                        break;
                    case "徳島県":
                        AreaNum = "360000";

                        break;
                    case "香川県":
                        AreaNum = "370000";

                        break;
                    case "愛媛県":
                        AreaNum = "380000";

                        break;
                    case "高知県":
                        AreaNum = "390000";

                        break;
                    case "山口県":
                        AreaNum = "350000";

                        break;
                    case "福岡県":
                        AreaNum = "400000";

                        break;
                    case "佐賀県":
                        AreaNum = "410000";

                        break;
                    case "長崎県":
                        AreaNum = "420000";

                        break;
                    case "熊本県":
                        AreaNum = "430000";

                        break;
                    case "大分県":
                        AreaNum = "440000";

                        break;
                    case "宮崎県":
                        AreaNum = "450000";

                        break;
                    case "鹿児島県":
                        AreaNum = "460100";
                        break;
                    case "沖縄本島地方":
                        AreaNum = "471000";
                        break;
                    case "大東島地方":
                        AreaNum = "472000";
                        break;
                    case "宮古島地方":
                        AreaNum = "473000";
                        break;
                    case "八重山地方":
                        AreaNum = "474000";
                        break;
                }
                string url = "https://www.jma.go.jp/bosai/forecast/data/overview_forecast/" + AreaNum + ".json";
                string url1 = "https://www.jma.go.jp/bosai/forecast/data/forecast/" + AreaNum + ".json";
                dString = wc.DownloadString (url);
                dString1 = wc.DownloadString (url1);

                var dt = DateTime.Now.Day;
                var json = JsonConvert.DeserializeObject<Rootobject> (dString);
                tbTime.Text = json.reportDatetime.ToString ();
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

                label4.Text = dt + "日の天気";
                label5.Text = dt + 1 + "日の天気";
                label6.Text = dt + 2 + "日の天気";

                lb1.Text = json1[1].timeSeries[0].timeDefines[0].Day + "日";
                lb2.Text = json1[1].timeSeries[0].timeDefines[0].Day + 1 + "日";
                lb3.Text = json1[1].timeSeries[0].timeDefines[0].Day + 2 + "日";
                lb4.Text = json1[1].timeSeries[0].timeDefines[0].Day + 3 + "日";
                lb5.Text = json1[1].timeSeries[0].timeDefines[0].Day + 4 + "日";
                lb6.Text = json1[1].timeSeries[0].timeDefines[0].Day + 5 + "日";
                lb7.Text = json1[1].timeSeries[0].timeDefines[0].Day + 6 + "日";

                tb1.Text = json1[0].timeSeries[1].areas[0].pops[1] + "%";
                try {
                    tbAfter.Text = json1[0].timeSeries[0].areas[0].weathers[2];
                } catch (Exception) {
                    MessageBox.Show ("データが存在しません");
                }
                try {
                    pbAfter.ImageLocation = @"https://www.jma.go.jp/bosai/forecast/img/" + json1[0].timeSeries[0].areas[0].weatherCodes[2] + ".png";
                } catch (Exception) {
                    MessageBox.Show ("データが存在しません");
                }
            } catch (WebException) {
                MessageBox.Show ("ネットワークに接続されてません");
            }
        }
    }
}
