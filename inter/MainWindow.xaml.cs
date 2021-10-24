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

namespace inter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            double res = Interpolate(20, 200, 200);

        }

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
    }
}
