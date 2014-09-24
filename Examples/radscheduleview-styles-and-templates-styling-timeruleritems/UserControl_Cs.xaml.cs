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

#region radscheduleview-styles-and-templates-styling-timeruleritems_4
public class CustomTimeRulerItemStyleSelector : OrientedTimeRulerItemStyleSelector
    {
        public Style MinorTickLineStyle { get; set;}
        public Style MajorTickLineStyle { get; set; }
        public override Style SelectStyle(object item, DependencyObject container, ViewDefinitionBase activeViewDeifinition)
        {
            if (container is TimeRulerLine)
            {
                TickData tick = item as TickData;
                if (tick.Type == TickType.Major)
                {
                    return MajorTickLineStyle;
                }
                return MinorTickLineStyle;
            }
            return base.SelectStyle(item, container, activeViewDeifinition);
        }    }
#endregion
}
