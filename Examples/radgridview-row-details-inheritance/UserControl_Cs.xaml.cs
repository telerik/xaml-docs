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

#region radgridview-row-details-templateselector-0
public class MyCustomRowDetailsTemplateSelector : DataTemplateSelector
{
	public override System.Windows.DataTemplate SelectTemplate(object item, System.Windows.DependencyObject container)
	{
		if (item is Club)
		{
			Club club = item as Club;
			if (club.StadiumCapacity > 50000)
			{
				return bigStadium;
			}
			else
			{
				return smallStadium;
			}
		}
		return null;
	}
	public DataTemplate bigStadium { get; set; }
	public DataTemplate smallStadium { get; set; }
}
#endregion
}
