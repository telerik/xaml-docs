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

#region persistence-framework-save-stream_1
private Stream stream;
private void Save(object sender, RoutedEventArgs e)
{
 PersistenceManager manager = new PersistenceManager();
 stream = manager.Save(treeView);
}
#endregion

#region persistence-framework-save-stream_3
private void Load(object sender, RoutedEventArgs e)
{
 PersistenceManager manager = new PersistenceManager();
 stream.Position = 0L;
 manager.Load(treeView, stream);
}
#endregion
}
