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

#region radtabcontrol-how-to-move-tab-using-drag-and-drop_1
private void EnableReordering()
{
    radTabControl.AllowDragReorder = true;
}
#endregion
}
