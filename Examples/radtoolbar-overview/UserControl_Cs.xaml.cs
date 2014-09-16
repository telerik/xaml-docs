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

#region radtoolbar-overview_1
using Telerik.Windows.Controls;
void CreateToolbar()
{
	RadToolBar toolbar = new RadToolBar();
	this.toolbarHolder.Children.Add(toolbar);
}
#endregion
}
