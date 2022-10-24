using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SampleUnitConverter {
    public class MainWindowViewModel : ViewModel {
        private double metricValue, imperialValue;

        public double MetricValue {
            get { return this.metricValue; }
            set {
                this.metricValue = value;
                this.OnPropertyChanged ();
            }
        }

        public double ImperialValue {
            get { return this.imperialValue; }
            set {
                this.imperialValue = value;
                this.OnPropertyChanged ();
            }
        }

        // 上のComboBoxで選択されている値(単位) 
        public MetricUnit CurrrentMetricUnit { get; set; }

        // 下のComboBoxで選択されている値(単位)
        public MetricUnit CurrrentImperialUnit { get; set; }

        // ▲ボタンで呼ばれるコマンド
        public ICommand ImperialUnitToMetric { get; private set; }

        // ▼ボタンで呼ばれるコマンド
        public ICommand MetricToInperialUnit { get; private set; }

        public MainWindowViewModel () {
            this.CurrrentImperialUnit = ImperialUnit.Units.First();
            this.CurrrentMetricUnit = MetricUnit.Units.First();

            this.MetricToInperialUnit = new DelegateCommand (
                () => this.ImperialValue = this.CurrrentImperialUnit.FromMetricUnit (
                    this.CurrrentMetricUnit, this.MetricValue));

            this.ImperialUnitToMetric = new DelegateCommand (
                () => this.MetricValue = this.CurrrentMetricUnit.FromImperialUnit (
                    this.CurrrentImperialUnit, this.ImperialValue));
        }
    }
}
