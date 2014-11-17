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

#region dragdropmanager-howto-set-dragvisualoffset_0
    private void OnDragInitialize(object sender, DragInitializeEventArgs args)
          {     
              args.DragVisualOffset = new Point(args.RelativeStartPoint.X - 25, args.RelativeStartPoint.Y - 25);              
          }
#endregion
}
