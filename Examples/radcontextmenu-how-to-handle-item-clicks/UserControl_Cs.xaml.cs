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

#region radcontextmenu-how-to-handle-item-clicks_1
private void RadMenuItem_Click( object sender, RadRoutedEventArgs e )
{
    RadMenuItem item = sender as RadMenuItem;
    //implement the logic regarding the instance here.
}
#endregion

#region radcontextmenu-how-to-handle-item-clicks_4
private void radContextMenu_ItemClick( object sender, RadRoutedEventArgs e )
{
    RadMenuItem item = e.OriginalSource as RadMenuItem;
    //implement the logic regarding the instance here.
}
#endregion
}
