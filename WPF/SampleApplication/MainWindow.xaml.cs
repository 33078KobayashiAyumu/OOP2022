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

namespace SampleApplication {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow () {
            InitializeComponent ();
            seasonComboBox.SelectedIndex = get_season ();

        }

        private int get_season () {
            DateTime dt = DateTime.Now;
            if (dt.Month >= 3 && dt.Month <= 5) {
                return 0;
            }
            if (dt.Month >= 6 && dt.Month <= 8) {
                return 1;
            }
            if (dt.Month >= 9 && dt.Month <= 11) {
                return 2;
            }
            if (dt.Month == 12 || dt.Month == 1 || dt.Month == 2) {
                return 3;
            }
            return 0;
        }

        private void CheckBox_Checked (object sender, RoutedEventArgs e) {
            CheckBoxTextBlock.Text = "チェック済み";
        }

        private void CheckBox_Unchecked (object sender, RoutedEventArgs e) {
            CheckBoxTextBlock.Text = "未チェック";
        }

        private void redRadioButton_Checked (object sender, RoutedEventArgs e) {
            colorTextBox.Text = "赤";
        }

        private void seasonComboBox_SelectionChanged (object sender, SelectionChangedEventArgs e) {
            seasonTextBlock.Text = (string)((ComboBoxItem)seasonComboBox.SelectedItem).Content;
        }

        private void yellowRadioButton_Checked (object sender, RoutedEventArgs e) {
            colorTextBox.Text = "黄";
        }

        private void blueRadioButton_Checked (object sender, RoutedEventArgs e) {
            colorTextBox.Text = "青";
        }
    }
}
