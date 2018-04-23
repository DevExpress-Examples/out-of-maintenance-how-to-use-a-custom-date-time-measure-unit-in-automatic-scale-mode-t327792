using System;
using System.Collections.Generic;
using System.Windows;

namespace CustomDateTimeMeasureUnitsCalcuslatorSample {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            DataContext = GenerateData(10000);
        }

        List<DataPoint> GenerateData(int count) {
            List<DataPoint> points = new List<DataPoint>(count);
            DateTime time = DateTime.Now;
            Random generator = new Random();
            for (int i = 0; i < count; ++i) {
                time = time.AddHours(1);
                points.Add(new DataPoint { X = time, Y = generator.NextDouble() });
            }
            return points;
        }
    }

    public class DataPoint {
        public DateTime X { get; set; }
        public double Y { get; set; }
    }
}
