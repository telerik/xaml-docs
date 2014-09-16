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

#region Orientation_0
RadProgressBar progressBar = new RadProgressBar();
progressBar.Orientation = System.Windows.Controls.Orientation.Horizontal;
#endregion

#region Orientation_2
RadProgressBar progressBar = new RadProgressBar();
progressBar.Orientation = System.Windows.Controls.Orientation.Vertical;
#endregion
}
