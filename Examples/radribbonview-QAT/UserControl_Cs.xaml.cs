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

#region radribbonview-QAT_1
this.radRibbonView.QuickAccessToolBar = new QuickAccessToolBar();
#endregion

#region radribbonview-QAT_5
radRibbonView.QuickAccessToolBarPosition = QuickAccessToolBarPosition.BelowRibbon;
#endregion

#region radribbonview-QAT_8
radRibbonView.QuickAccessToolBarPosition = QuickAccessToolBarPosition.NotHosted;
#endregion

#region radribbonview-QAT_11
private void radRibbonView_ToolBarPositionChanged( object sender, RadRoutedEventArgs e )
{
RadRibbonView ribbonView = sender as RadRibbonView ;
QuickAccessToolBarPosition newPosition = ribbonView.QuickAccessToolBarPosition;
// Do some logic here.
}
#endregion
}
