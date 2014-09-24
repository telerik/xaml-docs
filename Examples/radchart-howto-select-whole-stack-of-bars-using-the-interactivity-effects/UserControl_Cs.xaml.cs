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

#region radchart-howto-select-whole-stack-of-bars-using-the-interactivity-effects_0
public partial class MainPage : UserControl   // MainWindow in WPF
    {
        public class Company
        {
            public double Value1 { get; set; }
            public double Value2 { get; set; }
            public double Value3 { get; set; }
            public DateTime Category { get; set; }
            public Company(DateTime category, double value1, double value2, double value3)
            {
                Category = category;
                Value1 = value1;
                Value2 = value2;
                Value3 = value3;
            }
        } 
        public MainPage()
        {
            InitializeComponent();
            RadChart1.DefaultView.ChartArea.ItemClick +=new EventHandler<ChartItemClickEventArgs>(ChartArea_ItemClick);
            DateTime today = DateTime.Today;
            List<Company> sampleData = new List<Company>();
            Random r = new Random();
            for (int i = 0; i < 3; i++)
            {
                sampleData.Add(new Company(today.AddDays(i), r.Next(0, 100), r.Next(0, 100), r.Next(0, 100)));                
            }
            SeriesMapping seriesMapping = new SeriesMapping { LegendLabel = "Series 1" };
            seriesMapping.ItemMappings.Add(new ItemMapping("Value1", DataPointMember.YValue));
            seriesMapping.ItemMappings.Add(new ItemMapping("Category", DataPointMember.XCategory));
            SeriesMapping seriesMapping1 = new SeriesMapping { LegendLabel = "Series 2" };
            seriesMapping1.ItemMappings.Add(new ItemMapping("Value2", DataPointMember.YValue));
            seriesMapping1.ItemMappings.Add(new ItemMapping("Category", DataPointMember.XCategory));
            SeriesMapping seriesMapping2 = new SeriesMapping { LegendLabel = "Series 3" };
            seriesMapping2.ItemMappings.Add(new ItemMapping("Value3", DataPointMember.YValue));
            seriesMapping2.ItemMappings.Add(new ItemMapping("Category", DataPointMember.XCategory));
            StackedBarSeriesDefinition horBar = new StackedBarSeriesDefinition();
            horBar.InteractivitySettings.SelectionMode = ChartSelectionMode.Multiple;
            horBar.InteractivitySettings.SelectionScope = InteractivityScope.Item;
            seriesMapping2.SeriesDefinition = horBar;
            seriesMapping1.SeriesDefinition = horBar;
            seriesMapping.SeriesDefinition = horBar;
            RadChart1.DefaultView.ChartArea.AxisX.LayoutMode = AxisLayoutMode.Inside;
            RadChart1.ItemsSource = sampleData;
            RadChart1.SeriesMappings.Add(seriesMapping);
            RadChart1.SeriesMappings.Add(seriesMapping1);
            RadChart1.SeriesMappings.Add(seriesMapping2);
        }
        void ChartArea_ItemClick(object sender, ChartItemClickEventArgs e)
        {
            if (RadChart1.DefaultView.ChartArea.SelectedItems.Count > 1)
            {
                RadChart1.DefaultView.ChartArea.ClearSelection();
            }
            List<DataPoint> barsInStack = new List<DataPoint>();
            foreach (StackedBar item in this.RadChart1.DefaultView.ChartArea.ChildrenOfType<StackedBar>())
            {
                if (item.DataPoint.XCategory == e.DataPoint.XCategory)
                {
                    barsInStack.Add(item.DataPoint);
                }
            }
            RadChart1.DefaultView.ChartArea.SelectItems(barsInStack);
        }
    }
#endregion
}
