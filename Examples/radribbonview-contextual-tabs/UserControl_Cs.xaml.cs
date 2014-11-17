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

#region radribbonview-contextual-tabs_3
private void Group1Button_Click( object sender, RoutedEventArgs e )
{
    if ( !this.ContextualGroup1.IsActive )
        this.ContextualGroup1.IsActive = true;
    if ( this.ContextualGroup2.IsActive )
        this.ContextualGroup2.IsActive = false;
}
private void Group2Button_Click( object sender, RoutedEventArgs e )
{
    if ( !this.ContextualGroup2.IsActive )
        this.ContextualGroup2.IsActive = true;
    if ( this.ContextualGroup1.IsActive )
        this.ContextualGroup1.IsActive = false;
}
#endregion
}
