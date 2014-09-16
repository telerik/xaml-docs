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

#region raddocking-features-pane-groups_1
private void GroupPanes()
{
    Telerik.Windows.Controls.RadPane pane3 = new Telerik.Windows.Controls.RadPane();
    pane3.Header = "Properties";
    Group1.Items.Add( pane3 );
}
#endregion

#region raddocking-features-pane-groups_3
private void GroupPanes()
{
    Telerik.Windows.Controls.RadPane pane3 = new Telerik.Windows.Controls.RadPane();
    pane3.Header = "Properties";
    Group1.AddItem( pane3, Telerik.Windows.Controls.Docking.DockPosition.Center );
}
#endregion

#region raddocking-features-pane-groups_5
private void RemovePane( RadPane paneToRemove )
{
    Group1.Items.Remove( paneToRemove );
}
#endregion

#region raddocking-features-pane-groups_7
private void RemovePane( RadPane paneToRemove )
{
    paneToRemove.RemoveFromParent();
}
#endregion

#region raddocking-features-pane-groups_9
private void HideAllPanes()
{
    Group1.HideAllPanes();
}
#endregion

#region raddocking-features-pane-groups_11
private void ShowAllPanes()
{
    Group1.ShowAllPanes();
}
#endregion

#region raddocking-features-pane-groups_13
private void PinAllPanes()
{
    Group1.PinAllPanes();
}
#endregion

#region raddocking-features-pane-groups_15
private void UnpinAllPanes()
{
    Group1.UnpinAllPanes();
}
#endregion
}
