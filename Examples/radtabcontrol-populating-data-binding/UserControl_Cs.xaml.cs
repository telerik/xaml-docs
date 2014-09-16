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

#region radtabcontrol-populating-data-binding_1
RadTabControl radTabControl= new RadTabControl();
radTabControl.DataContext = new Collection<WordDocument>();
#endregion

#region radtabcontrol-populating-data-binding_4
RadTabControl radTabControl= new RadTabControl();
radTabControl.DataContext = new Collection<Person>();
radTabControl.DisplayMemberPath = "Name";
#endregion
}
