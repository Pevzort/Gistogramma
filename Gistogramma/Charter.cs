using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Gistogramma
{
    public partial class Charter : Form
    {
        public Charter()
        {
            InitializeComponent();
        }

        public void MakeParamsChart(List<float> points, List<string> paramsName, string name)
        {
            chart1.Series.Add(name);
            if (chart1.Series.FindByName(name) != null)
            {
                chart1.Series[name].ChartType = SeriesChartType.Column;
                chart1.Series[name].ChartArea = "ChartArea1";
                for (int i = 0; i <= points.Count - 1; i++)
                {
                    chart1.Series[name].Points.AddXY(i + 1, points[i]);
                }
                if (paramsName.Count != 0)
                {
                    for (int i = 0; i <= paramsName.Count - 1; i++)
                    {
                        chart1.Series[name].Points[i].AxisLabel = paramsName[i];
                    }
                }
            }
        }

        public void MakeSystemsChart(float point, string name)
        {
            chart1.Series.Add(name);
            if (chart1.Series.FindByName(name) != null)
            {
                chart1.Series[name].ChartType = SeriesChartType.Column;
                chart1.Series[name].ChartArea = "ChartArea1";
                chart1.Series[name].Points.AddXY(chart1.Series.Count, point);
            }
        }
    }
}
