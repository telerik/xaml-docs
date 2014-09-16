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

#region radtimeline_features_vertical_scrolling_0
public class RadTimelineDataItem
{
    public DateTime StartDate { get; set; }
    public TimeSpan Duration { get; set; }
}

public class TimelineVerticalScrollBarVisibilityViewModel
{
    public TimelineVerticalScrollBarVisibilityViewModel()
    {
        this.PeriodStart = new DateTime(2011, 1, 1);
        this.PeriodEnd = new DateTime(2012, 1, 1);

        this.GenerateTimelineData();
    }

    public DateTime PeriodStart { get; set; }

    public DateTime PeriodEnd { get; set; }

    public List<RadTimelineDataItem> TimelineItems { get; set; }

    private void GenerateTimelineData()
    {
        Random r = new Random();
        List<RadTimelineDataItem> items = new List<RadTimelineDataItem>();

        for (DateTime date = this.PeriodStart; date < this.PeriodEnd; date = date.AddDays(1))
        {
            items.Add(new RadTimelineDataItem() { StartDate = date, Duration = TimeSpan.FromDays(r.Next(5, 10)) });
        }

        this.TimelineItems = items;
    }
}
#endregion

	}
}
