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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace inter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double [] dataX = { -1, 0, 1 };

        public MainWindow()
        {
            InitializeComponent();
        }

        public double Interpolatev2(double [] dataY)
        {
            double f1 = dataY[0];
            double f2 = dataY[1];
            double f3 = dataY[2];

            double a, b, c, x = 0;

            c = f2;
            a = ((f1 + f3) - 2.0 * c) / 2.0;
            b = f3 - a - c;

            x = -b / (2 * a);

            Console.WriteLine(x);

            return x;
        }

        // do the interpolation
        public double Interpolate( double f1 , double f2 , double f3 )
        {
            double a, b, c, x=0;

            c = f2;
            a = ((f1 + f3) - 2.0*c)/2.0;
            b = f3 - a - c;

            x =  -b / (2 * a);

            Console.WriteLine(x);

            return x;
        }

        /// <summary>
        /// calculate the values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calculate(object sender, RoutedEventArgs e)
        {
            double y_1 = (double)Yminus1.Value;
            double y0 = (double)Y0.Value;
            double Y1 = (double)Yplus1.Value;

            double [] dataY = { y_1, y0, Y1 };

            double res = Interpolatev2( dataY );

            // use scottplot graph the input data
            WpfPlot1.Plot.Clear();
            var sp = WpfPlot1.Plot.Add.Scatter(dataX, dataY);
            WpfPlot1.Plot.Axes.AutoScale();
            sp.Smooth = true;
            WpfPlot1.Refresh();

            XPeak.Value = res;
        }
    }
}
