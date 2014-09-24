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

#region raddocking-panes-radpane_1
RadPane radPane1 = new RadPane();
radPane1.Header = "Document 1";
radPane1.Content = new TextBlock() { Text = "Some simple text here" };
RadPane radPane2 = new RadPane();
radPane2.Header = "Document 2";
radPane2.Content = new TextBlock() { Text = "Some simple text here" };
radPaneGroup.Items.Add( radPane1 );
radPaneGroup.Items.Add( radPane2 );
#endregion

#region raddocking-panes-radpane_4
radPane.IsHidden = true;
#endregion

#region raddocking-panes-radpane_5
private void Button_Click(object sender, RoutedEventArgs e)
{
    this.Pane3.IsActive = true;
}
#endregion

#region raddocking-panes-radpane_6
#endregion
}
