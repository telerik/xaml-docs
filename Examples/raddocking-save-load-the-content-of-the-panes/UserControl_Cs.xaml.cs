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

#region raddocking-save-load-the-content-of-the-panes_2
private void radDocking_ElementLoaded( object sender, Telerik.Windows.Controls.LayoutSerializationLoadingEventArgs e )
{
    var pane = e.AffectedElement as RadPane;
    if ( pane != null )
    {
        pane.Content = this.GetPaneContent( e.AffectedElementSerializationTag );
    }
}
#endregion
}
