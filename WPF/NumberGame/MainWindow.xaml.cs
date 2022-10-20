using System;
using System.Collections.Generic;
using System.Linq;
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

namespace NumberGame {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {

        Random random = new Random();

        private int correctNumber;//正解の数字


        public MainWindow () {
            InitializeComponent ();
        }
        
        private void Button_Click (object sender, RoutedEventArgs e) {
            
            Button bt = (Button)sender;
            if (bt.Content.ToString() == correctNumber.ToString()) {
                infDisp.Text = "正解";
            } else {

                infDisp.Text =
                    int.Parse ((string)bt.Content) < correctNumber ? "もっと大きい" : "もっと小さい";

                bt.Background = Brushes.Aqua;
            }
        }

        private void Window_Loaded (object sender, RoutedEventArgs e) {
            correctNumber = random.Next (25) + 1;
            Title = correctNumber.ToString (); //　デバッグ用
        }
    }
}
