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

#region radtreeview-how-to-implement-copy-drag-0
DragDropManager.AddDragOverHandler(xTreeView, OnDragOver, true)
#endregion

#region radtreeview-how-to-implement-copy-drag-3
DragDropManager.AddDragOverHandler(radTreeView2, OnDragOver, true);
#endregion

#region radtreeview-how-to-implement-copy-drag-4
private void OnDragOver(object sender, Telerik.Windows.DragDrop.DragEventArgs e)
{
    var options = DragDropPayloadManager.GetDataFromObject(e.Data, TreeViewDragDropOptions.Key) as TreeViewDragDropOptions;
    if (options != null)
    {
        options.DropAction = DropAction.Copy;
    }
}
#endregion

#region radtreeview-how-to-implement-copy-drag-1
DragDropManager.AddDropHandler(xTreeView, OnDrop, true);
DragDropManager.AddDragDropCompletedHandler(xTreeView, OnDragDropCompleted, true);
#endregion

#region radtreeview-how-to-implement-copy-drag-2
private void OnDrop(object sender, Telerik.Windows.DragDrop.DragEventArgs e)
{
    var options = DragDropPayloadManager.GetDataFromObject(e.Data, TreeViewDragDropOptions.Key) as TreeViewDragDropOptions;
    if (options != null)
    {
        options.DropAction = DropAction.None;
    }
}
#endregion

#region radtreeview-how-to-implement-copy-drag-5
private Team CopyTeam(Team team)
{
    return new Team(team.Name);
}

private Division CopyDivision(Division division)
{
    Division copyDivision = new Division(division.Name);
    foreach (Team team in division.Teams)
    {
        copyDivision.Teams.Add(this.CopyTeam(team));
    }
    return copyDivision;
}

private League CopyLeague(League league)
{
    League copyLeague = new League(league.Name);
    foreach (Division division in league.Divisions)
    {
        copyLeague.Divisions.Add(this.CopyDivision(division));
    }
    return copyLeague;
}
#endregion
#region radtreeview-how-to-implement-copy-drag-6
private void OnDragDropCompleted(object sender, DragDropCompletedEventArgs e)
{
    var options = DragDropPayloadManager.GetDataFromObject(e.Data, TreeViewDragDropOptions.Key) as TreeViewDragDropOptions;
    if (options != null)
    {
        var item = options.DraggedItems.FirstOrDefault();
        if (options.DropTargetItem != null)
        {
            if (item is Team)
            {
                if (options.DropPosition == Telerik.Windows.Controls.DropPosition.Inside && options.DropTargetItem.Item is Division)
                {
                    (options.DropTargetItem.Item as Division).Teams.Add(CopyTeam((Team)item));
                }
                else if (options.DropPosition != Telerik.Windows.Controls.DropPosition.Inside && options.DropTargetItem.Item is Team)
                {
                    Division parentDivision = options.DropTargetItem.ParentItem.Item as Division;
                    switch (options.DropPosition)
                    {
                        case Telerik.Windows.Controls.DropPosition.After:
                            parentDivision.Teams.Insert(options.DropTargetItem.Index + 1, CopyTeam((Team)item));
                            break;
                        case Telerik.Windows.Controls.DropPosition.Before:
                            parentDivision.Teams.Insert(options.DropTargetItem.Index, CopyTeam((Team)item));
                            break;
                    }
                }
            }
            else if (item is Division)
            {
                if (options.DropPosition == Telerik.Windows.Controls.DropPosition.Inside && options.DropTargetItem.Item is League)
                {
                    (options.DropTargetItem.Item as League).Divisions.Add(CopyDivision((Division)item));
                }
                else if (options.DropPosition != Telerik.Windows.Controls.DropPosition.Inside && options.DropTargetItem.Item is Division)
                {
                    League parentLeague = options.DropTargetItem.ParentItem.Item as League;
                    switch (options.DropPosition)
                    {
                        case Telerik.Windows.Controls.DropPosition.After:
                            parentLeague.Divisions.Insert(options.DropTargetItem.Index + 1, CopyDivision((Division)item));
                            break;
                        case Telerik.Windows.Controls.DropPosition.Before:
                            parentLeague.Divisions.Insert(options.DropTargetItem.Index, CopyDivision((Division)item));
                            break;
                    }
                }
            }
            else if (item is League)
            {
                if (options.DropTargetItem == null && options.DropTargetTree != null)
                {
                    (options.DropTargetTree.ItemsSource as IList).Add(CopyLeague((League)item));
                }
                else if (options.DropPosition != Telerik.Windows.Controls.DropPosition.Inside && options.DropTargetItem.Item is League)
                {
                    IList source = options.DropTargetItem.ParentTreeView.ItemsSource as IList;
                    switch (options.DropPosition)
                    {
                        case Telerik.Windows.Controls.DropPosition.After:
                            source.Insert(options.DropTargetItem.Index + 1, CopyLeague((League)item));
                            break;
                        case Telerik.Windows.Controls.DropPosition.Before:
                            source.Insert(options.DropTargetItem.Index, CopyLeague((League)item));
                            break;
                    }
                }
            }

        }
    }
}
#endregion
}
