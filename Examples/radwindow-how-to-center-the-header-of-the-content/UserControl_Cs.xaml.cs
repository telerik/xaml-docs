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

#region radwindow-how-to-center-the-header-of-the-content_2
TextBlock textBlock = new TextBlock();
textBlock.Text = "My RadWindow";
textBlock.HorizontalAlignment = HorizontalAlignment.Center;
RadWindow radWindow = new RadWindow();
radWindow.Width = 400;
radWindow.Height = 300;
radWindow.Style = this.Resources[ "RadWindowStyle" ] as Style;
radWindow.Header = textBlock;
#endregion
}
