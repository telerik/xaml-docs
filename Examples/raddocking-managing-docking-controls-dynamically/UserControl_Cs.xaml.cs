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

#region raddocking-managing-docking-controls-dynamically_1
private void MakeFloatingDockable()
{
    radPane1.MakeFloatingDockable();
}
#endregion

#region raddocking-managing-docking-controls-dynamically_3
private void MakeFloatingOnly()
{
    radPane1.MakeFloatingOnly();
}
#endregion

#region raddocking-managing-docking-controls-dynamically_7
private void MakeDockable()
{
    radPane1.MakeDockable();
}
#endregion

#region raddocking-managing-docking-controls-dynamically_10
public void AddItem( RadPane item, DockPosition dockPosition );
#endregion

#region raddocking-managing-docking-controls-dynamically_16
private void PinPane()
{
    radPane1.IsPinned = true;
}
#endregion

#region raddocking-managing-docking-controls-dynamically_18
private void UnpinPane()
{
    radPane1.IsPinned = false;
}
#endregion

#region raddocking-managing-docking-controls-dynamically_21
private void ClosePane()
{
    radPane1.IsHidden = false;
}
#endregion
}
