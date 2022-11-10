using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CollarChecker {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        MyColor mycolor = new MyColor ();
        List<MyColor> myColors = new List<MyColor>();
        public MainWindow () {
            InitializeComponent ();

            mycolor = new MyColor ();

            DataContext = GetColorList ();
        }

        private void RSlider_ValueChanged (object sender, RoutedPropertyChangedEventArgs<double> e) {
            Color_set ();

        }

        private void Color_set () {
            var r = byte.Parse (A.Text);
            var g = byte.Parse (B.Text);
            var b = byte.Parse (C.Text);


            label.Background = new SolidColorBrush (Color.FromRgb (r, g, b));

        }

        /// <summary>
        /// すべての色を取得するメソッド
        /// </summary>
        /// <returns></returns>
        private MyColor[] GetColorList () {
            return typeof (Colors).GetProperties (BindingFlags.Public | BindingFlags.Static)
                .Select (i => new MyColor () { Color = (Color)i.GetValue (null), Name = i.Name }).ToArray ();
        }

        private void Border_Loaded (object sender, RoutedEventArgs e) {
        }

        private void ComboBox_SelectionChanged (object sender, SelectionChangedEventArgs e) {

            mycolor = (MyColor)((ComboBox)sender).SelectedItem;
            //var color = mycolor.Color;
            //var name = mycolor.Name;

            RSlider.Value = mycolor.Color.R;
            GSlider.Value = mycolor.Color.G;
            BSlider.Value = mycolor.Color.B;

            
        }

        private void Window_Loaded (object sender, RoutedEventArgs e) {
            Color_set ();
        }

        private void button_Click (object sender, RoutedEventArgs e) {


            MyColor setColor = new MyColor();

            var r = byte.Parse (A.Text);
            var g = byte.Parse (B.Text);
            var b = byte.Parse (C.Text);
            setColor.Color = Color.FromRgb (r,g,b);

            var colorName = ((IEnumerable<MyColor>)DataContext)
                .Where (c => c.Color.R == setColor.Color.R &&
                             c.Color.G == setColor.Color.G &&
                             c.Color.B == setColor.Color.B).FirstOrDefault ();
            stockList.Items.Insert (0,colorName?.Name ?? "R:" + A.Text + " G:" + B.Text + " B:" + C.Text);
            myColors.Insert(0,setColor);

        }

        private void stockList_SelectionChanged (object sender, SelectionChangedEventArgs e) {

            if (stockList.SelectedIndex == -1) return;
                RSlider.Value = myColors[stockList.SelectedIndex].Color.R;
                GSlider.Value = myColors[stockList.SelectedIndex].Color.G;
                BSlider.Value = myColors[stockList.SelectedIndex].Color.B;
            
            

            Color_set ();
            
            
        }

        private void del_Click (object sender, RoutedEventArgs e) {

            if (stockList.SelectedIndex == -1) return;
            stockList.Items.RemoveAt (stockList.SelectedIndex);
            if (stockList.SelectedIndex == -1) return;
            myColors.RemoveAt (stockList.SelectedIndex);

        }
    }
}
/// <summary>
/// 色と色名を保持するクラス
/// </summary>
public class MyColor {
    public Color Color { get; set; }
    public string Name { get; set; }
}
