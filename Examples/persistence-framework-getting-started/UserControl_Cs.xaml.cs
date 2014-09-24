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

#region persistence-framework-getting-started_1
IsolatedStorageProvider isoProvider = new IsolatedStorageProvider();
isoProvider.SaveToStorage();
#endregion

#region persistence-framework-getting-started_3
IsolatedStorageProvider isoProvider = new IsolatedStorageProvider();
isoProvider.LoadFromStorage();
#endregion

#region persistence-framework-getting-started_6
private Stream stream;
private void Save(object sender, RoutedEventArgs e)
{
 PersistenceManager manager = new PersistenceManager();
 stream = manager.Save(treeView); 
}
#endregion

#region persistence-framework-getting-started_8
private void Load(object sender, RoutedEventArgs e)
{
 stream.Position = 0L;
 PersistenceManager manager = new PersistenceManager();
 manager.Load(treeView, stream);
}
#endregion
}
