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

#region radtreeview-how-to-disable-drop-specific-location_1
private void DisableDropOnSpecificItem()
{
    radTreeViewItemTennis.IsDropAllowed = false;
}
#endregion
}
