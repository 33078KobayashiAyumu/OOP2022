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
        public MainWindow () {
            InitializeComponent ();

            

            DataContext = GetColorList ();
        }

        private void RSlider_ValueChanged (object sender, RoutedPropertyChangedEventArgs<double> e) {
            Color ();
        }

        private void Color () {

            label.Background = new SolidColorBrush (System.Windows.Media.Color.FromRgb ((byte)RSlider.Value, (byte)GSlider.Value, (byte)BSlider.Value));
            return;
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

            var colors = typeof (Colors).GetProperties (BindingFlags.Public | BindingFlags.Static);

            var mycolor = (MyColor)((ComboBox)sender).SelectedItem;
            var color = mycolor.Color;
            var name = mycolor.Name;

            RSlider.Value = color.R;
            GSlider.Value = color.G;
            BSlider.Value = color.B;
        }

        private void Window_Loaded (object sender, RoutedEventArgs e) {
            Color ();
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
