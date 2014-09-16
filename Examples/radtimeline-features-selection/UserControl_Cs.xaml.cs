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

#region radtimeline-features-selection-0
private void RadTimeline_SelectionChanged(object sender, SelectionChangeEventArgs e)
{
    var selectedItem = (sender as RadTimeline).SelectedItem;

    if (selectedItem != null)
    {
        //Do something with the selected item.
    }
}
#endregion
	}
}
