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

#region GridView-Commands-Overview_0
private void Button1_Click(object sender, RoutedEventArgs e)
  {
   var moveDownCommand = RadGridViewCommands.MoveDown as RoutedUICommand;
   var selectCommand = RadGridViewCommands.SelectCurrentUnit as RoutedUICommand;
   var deleteCommand = RadGridViewCommands.Delete as RoutedUICommand;
   moveDownCommand.Execute(null, this.clubsGrid);
   selectCommand.Execute(null, this.clubsGrid);
   deleteCommand.Execute(null, this.clubsGrid);    
  }
#endregion
}
