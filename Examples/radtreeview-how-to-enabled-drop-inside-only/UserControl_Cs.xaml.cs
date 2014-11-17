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

#region radtreeview-how-to-enabled-drop-inside-only-0
DragDropManager.AddDragOverHandler(xTreeView, OnDragOver, true)
#endregion

#region radtreeview-how-to-enabled-drop-inside-only-1
private void OnDragOver(object sender, Telerik.Windows.DragDrop.DragEventArgs e)
{
    var options = DragDropPayloadManager.GetDataFromObject(e.Data, TreeViewDragDropOptions.Key) as TreeViewDragDropOptions;
    if (options!=null && options.DropPosition != Telerik.Windows.Controls.DropPosition.Inside)
    {
        options.DropPosition = Telerik.Windows.Controls.DropPosition.Inside;
        options.UpdateDragVisual();
    }
}
#endregion
}
