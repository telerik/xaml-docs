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

#region radchart-howto-integrate-data-visualization-controls-with-wcf-ria-services_2
public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            IEnumerable<FlightStatisticsView> data = (value as DataItemCollection).Cast<FlightStatisticsView>();
            return (from p in data
                    select new FlightRecords() { Type = "Arrival", TimeStamp = p.TimeStamp, FlightCount = p.Arrivals }).Concat(
                    from p in data
                    select new FlightRecords() { Type = "Departures", TimeStamp = p.TimeStamp, FlightCount = p.Departures });
        }
#endregion
}
