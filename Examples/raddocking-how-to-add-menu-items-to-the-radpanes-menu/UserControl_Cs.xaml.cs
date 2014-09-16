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

#region raddocking-how-to-add-menu-items-to-the-radpanes-menu_0
public static class RadDockingCommands
{
	private static RoutedUICommand closeAllPanesButThisCommand;

	public static RoutedUICommand CloseAllPanesButThisCommand
	{
		get
		{
			if (closeAllPanesButThisCommand == null)
			{
				closeAllPanesButThisCommand = new RoutedUICommand("Close all panes but this", "CloseAllPanesButThisCommand", typeof(RadDockingCommands));
			}
			return closeAllPanesButThisCommand;
		}
	}
}
#endregion

#region raddocking-how-to-add-menu-items-to-the-radpanes-menu_3
CommandManager.RegisterClassCommandBinding(
	typeof(RadPaneGroup), 
	new CommandBinding(
		RadDockingCommands.CloseAllPanesButThisCommand, 
		RadDockingCommands.OnCloseAllPanesButThis, 
		RadDockingCommands.OnCloseAllPanesButThisCanExecute));
#endregion

#region raddocking-how-to-add-menu-items-to-the-radpanes-menu_6
radPane.ContextMenuTemplate = null;
#endregion

#region raddocking-how-to-add-menu-items-to-the-radpanes-menu_4
public static class RadDockingCommands
{
	...

	public static void OnCloseAllPanesButThis(object sender, ExecutedRoutedEventArgs e)
	{
		var pane = e.Parameter as RadPane;
		if (pane != null)
		{
			var paneGroup = pane.PaneGroup;
			if (paneGroup != null)
			{
				var panesToClose = paneGroup.EnumeratePanes().Where(x => !x.IsHidden && x.IsPinned);
				foreach (var paneToClose in panesToClose)
				{
					if (paneToClose != pane)
					{
						paneToClose.IsHidden = true;
					}
				}
			}
		}
	}

	public static void OnCloseAllPanesButThisCanExecute(object sender, CanExecuteRoutedEventArgs e)
	{
		e.CanExecute = false;
		var paneGroup = sender as RadPaneGroup;
		if (paneGroup != null)
		{
			int childrenCount = paneGroup.EnumeratePanes().Count(x => !x.IsHidden && x.IsPinned);

			if (childrenCount > 1)
			{
				e.CanExecute = true;
			}
			else
			{
				e.CanExecute = false;
			}
		}
	}
}
#endregion
}
