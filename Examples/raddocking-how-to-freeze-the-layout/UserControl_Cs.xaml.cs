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

#region raddocking-how-to-freeze-the-layout_4
private void DisableMenu()
{
    radPane1.MenuCommands.Clear();
    radPane2.MenuCommands.Clear();
    radPane3.MenuCommands.Clear();
    radPane4.MenuCommands.Clear();
}
#endregion
}
