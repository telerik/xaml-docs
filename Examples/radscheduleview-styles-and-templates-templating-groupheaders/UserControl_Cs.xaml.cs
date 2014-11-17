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

#region radscheduleview-styles-and-templates-templating-groupheaders_3
public class EmployeeResource : Resource
{
	public string Photo { get; set; }
	public Brush Brush { get; set; }
}
#endregion


#region radscheduleview-styles-and-templates-templating-groupheaders_5
public class CustomGroupHeaderContentTemplateSelector : ScheduleViewDataTemplateSelector
{
	public DataTemplate HorizontalTemplate { set; get; }
	public DataTemplate VerticalTemplate { set; get; }
	public DataTemplate HorizontalResourceTemplate { set; get; }
	public DataTemplate VerticalResourceTemplate { set; get; }

	public override DataTemplate SelectTemplate(object item, DependencyObject container, ViewDefinitionBase activeViewDeifinition)
	{
		CollectionViewGroup cvg = item as CollectionViewGroup;
		if (cvg != null && cvg.Name is IResource)
		{
			if (activeViewDeifinition.GetOrientation() == Orientation.Vertical)
			{
				if (this.HorizontalResourceTemplate != null)
				{
					return this.HorizontalResourceTemplate;
				}
			}
			else
			{
				if (this.VerticalResourceTemplate != null)
				{
					return this.VerticalResourceTemplate;
				}
			}
		}

		if (cvg != null && cvg.Name is DateTime)
		{
			if (activeViewDeifinition.GetOrientation() == Orientation.Vertical)
			{
				return this.HorizontalTemplate;
			}
			else
			{
				return this.VerticalTemplate;
			}
		}
		return base.SelectTemplate(item, container, activeViewDeifinition);
	}
}
#endregion
	}
}
