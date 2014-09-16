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

#region Getting_Started_0
RadProgressBar progressBar = new RadProgressBar();
#endregion

#region Getting_Started_2
progressBar.Minimum = 10;
progressBar.Maximum = 20;
#endregion
}
