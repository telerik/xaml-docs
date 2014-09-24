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

#region persistence-framework-isolated-storage_1
private void Save(object sender, RoutedEventArgs e)
{
 IsolatedStorageProvider isoProvider = new IsolatedStorageProvider();
 isoProvider.SaveToStorage();
}
private void Load(object sender, RoutedEventArgs e)
{
 IsolatedStorageProvider isoProvider = new IsolatedStorageProvider();
 isoProvider.LoadFromStorage();
}
#endregion
}
