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

#region raddocking-features-split-container_2
private void SetOrientationToVertical()
{
    radSplitContainer.Orientation = Orientation.Vertical;
}
#endregion

#region raddocking-features-split-container_4
private void SetOrientationToHorizontal()
{
    radSplitContainer.Orientation = Orientation.Horizontal;
}
#endregion

#region raddocking-features-split-container_12
private void SetInitialPositionToLeft()
{
    radSplitContainer.InitialPosition = Telerik.Windows.Controls.Docking.DockState.DockedLeft;
}
#endregion

#region raddocking-features-split-container_14
private void SetInitialPositionToTop()
{
    radSplitContainer.InitialPosition = Telerik.Windows.Controls.Docking.DockState.DockedTop;
}
#endregion

#region raddocking-features-split-container_16
private void SetInitialPositionToRight()
{
    radSplitContainer.InitialPosition = Telerik.Windows.Controls.Docking.DockState.DockedRight;
}
#endregion

#region raddocking-features-split-container_18
private void SetInitialPositionToBottom()
{
    radSplitContainer.InitialPosition = Telerik.Windows.Controls.Docking.DockState.DockedBottom;
}
#endregion

#region raddocking-features-split-container_20
private void SetInitialPositionToFloatingOnly()
{
    radSplitContainer.InitialPosition = Telerik.Windows.Controls.Docking.DockState.FloatingOnly;
}
#endregion

#region raddocking-features-split-container_22
private void SetInitialPositionToFloatingDockable()
{
    radSplitContainer.InitialPosition = Telerik.Windows.Controls.Docking.DockState.FloatingDockable;
}
#endregion
}
