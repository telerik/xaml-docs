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

#region raddocking-how-to-implement-conditional-docking_2
private void radDocking_PreviewShowCompass( object sender, Telerik.Windows.Controls.Docking.PreviewShowCompassEventArgs e )
{
    e.Compass.IsLeftIndicatorVisible = false;
}
#endregion

#region raddocking-how-to-implement-conditional-docking_4
private void radDocking_PreviewShowCompass( object sender, Telerik.Windows.Controls.Docking.PreviewShowCompassEventArgs e )
{
    e.Compass.IsLeftIndicatorVisible = false;
    e.Compass.IsTopIndicatorVisible = false;
}
#endregion

#region raddocking-how-to-implement-conditional-docking_6
private void radDocking_PreviewShowCompass( object sender, Telerik.Windows.Controls.Docking.PreviewShowCompassEventArgs e )
{
    e.Compass.IsLeftIndicatorVisible = false;
    e.Compass.IsTopIndicatorVisible = false;
    e.Compass.IsRightIndicatorVisible = false;
}
#endregion

#region raddocking-how-to-implement-conditional-docking_8
private void radDocking_PreviewShowCompass( object sender, Telerik.Windows.Controls.Docking.PreviewShowCompassEventArgs e )
{
    e.Compass.IsLeftIndicatorVisible = false;
    e.Compass.IsTopIndicatorVisible = false;
    e.Compass.IsRightIndicatorVisible = false;
    e.Compass.IsBottomIndicatorVisible = false;
}
#endregion

#region raddocking-how-to-implement-conditional-docking_10
private void radDocking_PreviewShowCompass( object sender, Telerik.Windows.Controls.Docking.PreviewShowCompassEventArgs e )
{
    e.Compass.IsLeftIndicatorVisible = false;
    e.Compass.IsTopIndicatorVisible = false;
    e.Compass.IsRightIndicatorVisible = false;
    e.Compass.IsBottomIndicatorVisible = false;
    e.Compass.IsCenterIndicatorVisible = false;
}
#endregion
}
