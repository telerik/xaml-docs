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
	
#region radtimebar_formatter_provider_0
using  Telerik.Windows.Controls.TimeBar;

public class HourFormatterProvider : IIntervalFormatterProvider
{
    private static Func<DateTime, string>[] formatters;
    private Func<DateTime, string>[] intervalSpanFormatters;

    static HourFormatterProvider()
    {
        formatters = new Func<DateTime, string>[]
        {
            date => date.ToString("H:mm"),
            date => date.ToString("HH")
        };
    }

    public Func<DateTime, string>[] GetFormatters(IntervalBase interval)
    {
        return formatters;
    }

    public Func<DateTime, string>[] GetIntervalSpanFormatters(IntervalBase interval)
    {
        if (this.intervalSpanFormatters == null)
        {
            this.intervalSpanFormatters = new Func<DateTime, string>[]
            {
                date => String.Format("{0} - {1}", date.ToString("dddd H:mm"), interval.IncrementByCurrentInterval(date).ToString("H:mm"))
            };
        }

        return this.intervalSpanFormatters;
    }
}
#endregion

}
