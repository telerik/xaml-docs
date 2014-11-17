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

		#region How_to_set_the_content_from_code_behind_1
		private void Button_Click(object sender, RoutedEventArgs e)
		{
			RadHtmlPlaceholder1.SourceUrl = new Uri("http://www.bing.com");
		}
		#endregion

		#region How_to_set_the_content_from_code_behind_2
		private void Button_Click(object sender, RoutedEventArgs e)
		{
			RadHtmlPlaceholder1.HtmlSource = @"<b>Hello World.</b>";
		}
		#endregion
	}
}
