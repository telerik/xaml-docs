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

//this region intentionally skipped:
#region radtimeline_howto_expand_collapse_groups-0

#endregion

#region radtimeline_howto_expand_collapse_groups-1
public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
{
    if (value != null && value is string)
    {
        string groupKey = (string)value;
        string initiallyExpandedGroupKey = (string)parameter;

        if (groupKey == initiallyExpandedGroupKey)
        {
            return true;
        }
    }

    return false;
}
#endregion

#region radtimeline_howto_expand_collapse_groups-2
public static readonly DependencyProperty ExpandedGroupKeyProperty = DependencyProperty.RegisterAttached("ExpandedGroupKey",
    typeof(string), typeof(TimelineItemGroupControlBehavior), new PropertyMetadata(OnExpandedGroupKeyChanged));

public static object GetExpandedGroupKey(DependencyObject obj)
{
    return (string)obj.GetValue(ExpandedGroupKeyProperty);
}

public static void SetExpandedGroupKey(DependencyObject obj, string value)
{
    obj.SetValue(ExpandedGroupKeyProperty, value);
}

private static void OnExpandedGroupKeyChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
{
    TimelineItemGroupControl timelineGroup = sender as TimelineItemGroupControl;
    if (timelineGroup == null || e.NewValue == null)
        return;

    timelineGroup.IsExpanded = string.Equals(timelineGroup.Header, (string)e.NewValue);
}
#endregion
	}
}
