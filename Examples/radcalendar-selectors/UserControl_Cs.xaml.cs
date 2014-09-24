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

#region radcalendar-selectors_1
public class CustomTemplateSelector : DataTemplateSelector
{
    public override DataTemplate SelectTemplate(object item, DependencyObject container)
    {
        CalendarButtonContent content = item as CalendarButtonContent;
        if (content != null)
        {
            if (content.Date.DayOfWeek == DayOfWeek.Saturday || content.Date.DayOfWeek == DayOfWeek.Sunday)
            {
                content.IsEnabled = false;
            }
        }
        return DefaultTemplate;
    }
    public DataTemplate DefaultTemplate
    {
        get;
        set;
    }
}
#endregion
}
