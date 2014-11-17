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

	#region radcolorpicker-howto-use-isrecentcolorsactive_2

	private void RadButton_Click(object sender, RoutedEventArgs e)
	{
		this.xColorPicker.IsDropDownOpen = false;
		this.xExpander.Opacity = 1;
		this.xExpander.IsExpanded = true;
	}
	#endregion radcolorpicker-howto-use-isrecentcolorsactive_2

	#region radcolorpicker-howto-use-isrecentcolorsactive_4
private void OK_RadButton_Click(object sender, RoutedEventArgs e)
{
	this.xColorPicker.SelectedColor = this.xColorEditor.SelectedColor;
	this.xExpander.IsExpanded = false;
	this.xExpander.Opacity = 0;
	this.xColorPicker.IsDropDownOpen = true;
}
#endregion radcolorpicker-howto-use-isrecentcolorsactive_4
}
