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

#region IsIndeterminate_0
RadProgressBar progressBar = new RadProgressBar();
progressBar.IsIndeterminate = false;
#endregion

#region IsIndeterminate_2
RadProgressBar progressBar = new RadProgressBar();
progressBar.IsIndeterminate = true;
#endregion
}
