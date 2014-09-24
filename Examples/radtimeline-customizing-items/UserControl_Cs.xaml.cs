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

#region radtimeline-customizing_items_1
	List<Item> dataSource = new List<Item>();
	var startDate = new DateTime(2011, 1, 1);
	var endDate = new DateTime(2011, 6, 1);

	Random r = new Random();
	for (DateTime i = startDate; i < endDate; i = i.AddMonths(1))
	{
		dataSource.Add(new Item() { Date = i, Duration = TimeSpan.FromDays(r.Next(50, 100)) });
	}

	for (int i = 0; i < 15; i++)
	{
		dataSource.Add(new Item() { Date = startDate.AddMonths(r.Next(0, 5)).AddDays(15)});
	}
	RadTimeline1.ItemsSource = dataSource;

	public class Item
	{
		public TimeSpan Duration { get; set; }
		public DateTime Date { get; set; }
	}
#endregion

#region radtimeline-customizing_items_3
 public class CustomItemTemplateSelector : DataTemplateSelector
    {
        public DataTemplate InstantItemTemplate { get; set; }
        public DataTemplate ItemWithDurationTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            TimelineDataItem data = item as TimelineDataItem;
            Product productItem;

            if (data == null)
                productItem = item as Product;
            else
                productItem = data.DataItem as Product;

            if (productItem == null)
                return base.SelectTemplate(item, container);

            if (productItem.Duration.Days != 0)
                return this.ItemWithDurationTemplate;
            else
                return this.InstantItemTemplate;
        }
    }
#endregion

#region radtimeline-customizing_items_5
private DataTemplateSelector customItemTemplateSelector;
public DataTemplateSelector CustomItemTemplateSelector
{
	get
	{
		return this.customItemTemplateSelector;
	}
	set
	{
		this.customItemTemplateSelector = value;
	}
}
#endregion
	}
}
