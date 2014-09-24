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

#region radcontextmenu-features-working-with-radcontext-menu_1
public Example()
{
    InitializeComponent();
    RadContextMenu radContextMenu = new RadContextMenu();
    RadContextMenu.SetContextMenu( this.textBox, radContextMenu );
}
#endregion

#region radcontextmenu-features-working-with-radcontext-menu_4
public Example()
{
    InitializeComponent();
    RadContextMenu radContextMenu = new RadContextMenu();
    RadMenuItem copyItem = new RadMenuItem();
    copyItem.Header = "Copy";
    radContextMenu.Items.Add( copyItem );
    RadMenuItem pasteItem = new RadMenuItem();
    pasteItem.Header = "Paste";
    radContextMenu.Items.Add( pasteItem );
    RadMenuItem cutItem = new RadMenuItem();
    cutItem.Header = "Cut";
    radContextMenu.Items.Add( cutItem );
    RadContextMenu.SetContextMenu( this.textBox, radContextMenu );
}
#endregion

#region radcontextmenu-features-working-with-radcontext-menu_6
RadTreeViewItem item = radContextMenu.GetClickedElement<RadTreeViewItem>();
#endregion
}
