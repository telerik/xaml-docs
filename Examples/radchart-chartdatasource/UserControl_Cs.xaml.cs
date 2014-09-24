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

#region radchart-chartdatasource_2
	 public class SimpleViewModel : DependencyObject
    {
           Random r = new Random();
        /// <summary>
        /// Identifies the <see cref="Data"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty DataProperty = DependencyProperty.Register("Data",
            typeof(ObservableCollection<SalesInfo>),
            typeof(SimpleViewModel),
            new PropertyMetadata(null));

        public RadObservableCollection<SalesInfo> Data
        {
            get
            {
                return (RadObservableCollection<SalesInfo>)this.GetValue(DataProperty);
            }
            set
            {
                this.SetValue(DataProperty, value);
            }
        }

        public SimpleViewModel()
        {
            var data = new RadObservableCollection<SalesInfo>();

            DateTime startDate = new DateTime(2013, 5, 1);
			
			for (int i = 0; i < 20; i += 1)
			{
				data.Add(new SalesInfo() { Time = startDate.AddDays(i), Value = i });
			}

            this.Data = data;
        }
    }

    public class SalesInfo
    {
        public DateTime Time { get; set; }
        public int Value { get; set; }
    }
#endregion

#region radchart-chartdatasource_5
public class MyBarSeries : BarSeries
{
    protected override ChartAggregateFunction GetValueAggregateFunction()
    {
        return new ChartMinFunction();
    }
}
#endregion

}
