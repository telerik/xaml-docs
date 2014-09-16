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

#region radtimepicker-header-template_2
Rectangle rectangleHeader = new Rectangle();
    rectangleHeader.Fill = new SolidColorBrush(Colors.Green);
    rectangleHeader.Height = 50;
    rectangleHeader.Width = 50;
    this.timePicker.HeaderContent = rectangleHeader;
#endregion
}
