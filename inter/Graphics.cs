using ScottPlot.WPF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inter
{
    public class Graphics
    {
        WpfPlot myGraph;

        public Graphics(WpfPlot myGraph)
        {
            this.myGraph = myGraph;

            myGraph.Plot.Title("Quadratic Plot");
            myGraph.Plot.XLabel("X Axis");
            myGraph.Plot.YLabel("Y Axis");
        }
    

    public void DoGraph( Quadratic ans)
        {
            double[] dataX;
            double[] dataY;

            dataX = new double[200];
            dataY = new double[200];

            for (int x = 0; x < 200; x++)
            {
                dataX[x] = ( (double)x - 100.0) / 100.0;
                dataY[x] = 50;
                dataY[x] = ans.CalculateValue(dataX[x]);
            }

            var sp = myGraph.Plot.Add.Scatter(dataX, dataY);
            myGraph.Plot.Axes.AutoScale();
            sp.LegendText = "Calcualted Curve";
            myGraph.Refresh();
        }
    }
}
