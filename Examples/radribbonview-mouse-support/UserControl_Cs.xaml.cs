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

#region radribbonview-mouse-support_1
radRibbonView.MouseWheel+=new MouseWheelEventHandler(radRibbonView_MouseWheel);
#endregion

#region radribbonview-mouse-support_3
private void radRibbonView_MouseWheel(object sender, MouseWheelEventArgs e)
{
 MessageBox.Show("The mouse wheel has changed: " + e.Delta);
}
#endregion
}
