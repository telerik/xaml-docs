using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace WpfApplication1
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
	}

#region radchart-howto-highlight-pointmark-on-click_0
public MainPage() //MainWindow() for WPF
        {
            InitializeComponent();
            Random r = new Random();
            List<ItemData> chartData = new List<ItemData>();
            for (int i = 0; i < 20; i++)
            {
                chartData.Add(new ItemData(i, r.Next(0, 100)));
            }
            this.radChart.ItemsSource = chartData;
            this.SetUpMappings();
        }
        private void SetUpMappings()
        {
            SeriesMapping mapping = new SeriesMapping();
            mapping.SeriesDefinition = new LineSeriesDefinition()
            {
                ShowItemToolTips = true,
                ShowItemLabels = false
            };
            mapping.ItemMappings.Add(new ItemMapping("YValue", DataPointMember.YValue));
            mapping.ItemMappings.Add(new ItemMapping("XValue", DataPointMember.XValue));
            this.radChart.SeriesMappings.Add(mapping);
        }
        public class ItemData
        {
            public double XValue { get; set; }
            public double YValue { get; set; }
            public ItemData(double xValue, double yValue)
            {
                this.XValue = xValue;
                this.YValue = yValue;
            }
        }
#endregion

#region radchart-howto-highlight-pointmark-on-click_2
void ChartArea_ItemClick(object sender, ChartItemClickEventArgs e)
        {
            this.ClearPointMarkSelectedState();
            var pointMarks = 
                radChart.DefaultView.ChartArea.ChildrenOfType<PointMark>().ToList<PointMark>();
            this.selectedPointMark =
                pointMarks.Where(x => x.DataContext == e.DataPoint).SingleOrDefault();
            this.SetPointMarkSelectedState();
        }
#endregion

#region radchart-howto-highlight-pointmark-on-click_4
private void SetPointMarkSelectedState()
        {
            if (this.selectedPointMark == null)
                return;
            this.selectedPointMark.Fill = new SolidColorBrush(Colors.Red);
            this.selectedPointMark.Shape = MarkerShape.Triangle;
            this.selectedPointMark.Size = 12;
        }
        private void ClearPointMarkSelectedState()
        {
            if (this.selectedPointMark == null)
                return;
            this.selectedPointMark.Fill = new SolidColorBrush(Colors.White);
            this.selectedPointMark.Shape = MarkerShape.Circle;
        }
#endregion
}
