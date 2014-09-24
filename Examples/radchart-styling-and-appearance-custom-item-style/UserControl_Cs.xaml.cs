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

#region radchart-styling-and-appearance-custom-item-style_0
public Sample()
{
    InitializeComponent();
    this.radChart.CreateItemStyleDelegate = this.BuildCustomItemStyle;
}
public Style BuildCustomItemStyle( Control item, Style style, DataPoint point, DataSeries dataSeries )
{
    Style newStyle = new Style();
    newStyle.BasedOn = style;
    return newStyle;
}
#endregion

#region radchart-styling-and-appearance-custom-item-style_2
public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
            int maxItems = 10;
            Random r = new Random();
            List<Company> sampleData = new List<Company>();
            for (int i = 0; i < maxItems; i++)
            {
                sampleData.Add(new Company(r.Next(200, 400)));
            }
            SeriesMapping seriesMapping = new SeriesMapping();
            seriesMapping.LegendLabel = "My Custom Bars";
            seriesMapping.SeriesDefinition = new BarSeriesDefinition();
            seriesMapping.ItemMappings.Add(new ItemMapping("PurchasePrice", DataPointMember.YValue));
            RadChart1.ItemsSource = sampleData;
            RadChart1.SeriesMappings.Add(seriesMapping);
            this.RadChart1.CreateItemStyleDelegate = BuildCustomItemStyle;
        }
        public class Company
        {
            public double PurchasePrice { get; set; }
            public Company(double price)
            {
                PurchasePrice = price;
            }
        }
        public Style BuildCustomItemStyle(Control item, Style style, DataPoint point, DataSeries dataSeries)
        {
            Style newStyle = new Style(style.TargetType);
            newStyle.BasedOn = style;
            Brush brush;
            if (item is BaseChartItem)
            {
                if (dataSeries[(item as BaseChartItem).CurrentIndex].YValue > 300)
                {
                    brush = new SolidColorBrush(Colors.Red);
                }
                else
                {
                    brush = new SolidColorBrush(Colors.Green);
                }
                newStyle.Setters.Add(new Setter(Shape.FillProperty, brush));
            }
            if (item is SeriesItemLabel)
            {
                if ((item as SeriesItemLabel).DataPoint.YValue > 300)
                    brush = new SolidColorBrush(Colors.Red);
                else
                    brush = new SolidColorBrush(Colors.Green);
                newStyle.Setters.Add(new Setter(SeriesItemLabel.FillProperty, brush));
                newStyle.Setters.Add(new Setter(SeriesItemLabel.StrokeProperty, brush));
            }
            if (item is ChartLegendItem)
            {
                brush = this.Resources["LegendItemStyle"] as Brush;
                newStyle.Setters.Add(new Setter(Path.FillProperty, brush));
            }
            return newStyle;
        }
    }
#endregion
}
