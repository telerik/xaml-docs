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

#region radtileview-fluid-content-control_3
private void RadTileView_TileStateChanged(object sender, Telerik.Windows.RadRoutedEventArgs e)
{
 RadTileViewItem item = e.Source as RadTileViewItem;
 if (item != null)
 {
  RadFluidContentControl fluidControl = item.Content as RadFluidContentControl;
  if (fluidControl != null)
  {
   switch (item.TileState)
   {
    case TileViewItemState.Maximized:
     fluidControl.State = FluidContentControlState.Large;
     break;
    case TileViewItemState.Minimized:
     fluidControl.State = FluidContentControlState.Small;
     break;
    case TileViewItemState.Restored:
     fluidControl.State = FluidContentControlState.Normal;
     break;
   }
  }
 }
}
#endregion
}
