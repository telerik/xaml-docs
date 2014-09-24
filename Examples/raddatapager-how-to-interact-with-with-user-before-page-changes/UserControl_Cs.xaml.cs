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

#region raddatapager-how-to-interact-with-with-user-before-page-changes_1
private bool myCondition;
private void radDataPager_PageIndexChanging( object sender, PageIndexChangingEventArgs e )
{
    if ( myCondition )
    {
        MessageBoxResult result = MessageBox.Show( "There is unsaved data! Are you sure you want to continue?", "Confirm", MessageBoxButton.OKCancel );
        if ( result == MessageBoxResult.Cancel )
        {
            e.Cancel = true;
        }
    }
}
#endregion
}
