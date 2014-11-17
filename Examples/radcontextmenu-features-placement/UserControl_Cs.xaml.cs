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

#region radcontextmenu-features-placement-01
public Example()
{
    InitializeComponent();
    this.radContextMenu.PlacementTarget = this.InputBox;
    this.radContextMenu.IsOpen = true;
}
#endregion
}
