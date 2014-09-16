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

#region radwindow-how-to-use-radwindow-as-user-control_1
public partial class RadWindowControl : RadWindow
{
    public RadWindowControl()
    {
        InitializeComponent();
    }
}
#endregion

#region radwindow-how-to-use-radwindow-as-user-control_3
RadWindowControl window = new RadWindowControl();
window.Show();
#endregion
}
