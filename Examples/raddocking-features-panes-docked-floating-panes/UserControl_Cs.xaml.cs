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

#region raddocking-features-panes-docked-floating-panes_1
radPane.RemoveFromParent();
radPaneGroup.Items.Add( radPane );
#endregion

#region raddocking-features-panes-docked-floating-panes_3
radPane.RemoveFromParent();
radPaneGroup.AddItem( radPane, DockPosition.Center );
#endregion

#region raddocking-features-panes-docked-floating-panes_6
radPane.MakeFloatingDockable();
#endregion

#region raddocking-features-panes-docked-floating-panes_9
radPane.CanFloat = false;
#endregion
}
