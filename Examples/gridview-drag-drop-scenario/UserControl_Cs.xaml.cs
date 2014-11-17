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

#region gridview-drag-drop-scenario_2
private void EnableDropBehavior()
{
  RadDragAndDropManager.SetAllowDrop( radGridView, true );
}
#endregion

#region gridview-drag-drop-scenario_7
private void radTreeView_PreviewDragEnded( object sender, RadTreeViewDragEndedEventArgs e )
{
   e.Handled = true;
}
#endregion

#region gridview-drag-drop-scenario_9
RadDragAndDropManager.AddDropQueryHandler( radGridView, new EventHandler<DragDropQueryEventArgs>( this.RadGridView_OnDropQuery ) );
RadDragAndDropManager.AddDropInfoHandler( radGridView, new EventHandler<DragDropEventArgs>( this.RadGridView_OnDropInfo ) );
#endregion

#region gridview-drag-drop-scenario_11
private void RadGridView_OnDropQuery( object sender, DragDropQueryEventArgs e )
{
    e.QueryResult = ( e.Options.Source as RadTreeViewItem ).Item is Team;
}
private void RadGridView_OnDropInfo( object sender, DragDropEventArgs e )
{
    if ( e.Options.Status == DragStatus.DropComplete )
    {
        ( radGridView.ItemsSource as IList<Team> ).Add( ( e.Options.Payload as Collection<Object> )[ 0 ] as Team );
    }
}
#endregion
}
