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

#region radscheduleview-styles-and-templates-styling-groupheaders_5
public class CustomGroupHeaderStyleSelector : OrientedGroupHeaderStyleSelector 
{
    public Style CalendarStyle { get; set; }
    public Style DateStyle { get; set; }
    public override Style SelectStyle(object item, DependencyObject container, ViewDefinitionBase activeViewDeifinition)
    {
        var groupHeader = container as GroupHeader;
        if (groupHeader != null)
        {
            var groupKey = groupHeader.GroupKey as Resource;
            if (groupKey != null && groupKey.ResourceType == "Calendar")
            {
                return this.CalendarStyle;
            }
            else if (groupHeader.GroupKey is DateTime)
            {
                return this.DateStyle;
            }
        }
        return base.SelectStyle(item, container, activeViewDeifinition);
    }
}
#endregion
}
