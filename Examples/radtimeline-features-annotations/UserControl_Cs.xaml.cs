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

#region radtimeline-features-annotations_0
public class RadTimelineAnnotationsViewModel
{
    public RadTimelineAnnotationsViewModel()
    {
        this.PeriodStart = new DateTime(2011, 1, 1);
        this.PeriodEnd = new DateTime(2012, 1, 1);

        this.GenerateTimelineData();
        this.GenerateTimelineAnnotationsData();
    }

    public DateTime PeriodStart { get; set; }

    public DateTime PeriodEnd { get; set; }

    public List<RadTimelineDataItem> TimelineItems { get; set; }

    public List<RadTimelineAnnotationDataItem> TimelineAnnotationItems { get; set; }

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

    private void GenerateTimelineAnnotationsData()
    {
        Random r = new Random();
        List<RadTimelineAnnotationDataItem> items = new List<RadTimelineAnnotationDataItem>();

        for (DateTime date = this.PeriodStart; date < this.PeriodEnd; date = date.AddDays(7))
        {
            items.Add(new RadTimelineAnnotationDataItem(){
                StartDate = date,
                Duration = TimeSpan.FromDays(r.Next(2, 5)),
                Content = date.ToShortDateString(),
                ZIndex = r.Next(0, 300)
            });
        }

        this.TimelineAnnotationItems = items;
    }
}

public class RadTimelineDataItem
{
    public DateTime StartDate { get; set; }

    public TimeSpan Duration { get; set; }
}

public class RadTimelineAnnotationDataItem
{
    public DateTime StartDate { get; set; }

    public TimeSpan Duration { get; set; }

    public string Content { get; set; }

    public int ZIndex { get; set; }
}
#endregion
	}
}
