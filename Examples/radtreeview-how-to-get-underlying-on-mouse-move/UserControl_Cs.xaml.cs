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

#region radtreeview-how-to-get-underlying-on-mouse-move_1
private void radTreeView_MouseMove( object sender, MouseEventArgs e )
{
     FrameworkElement element = e.OriginalSource as FrameworkElement;
     if ( element != null )
     {
         while ( VisualTreeHelper.GetParent( element ) != null )
         {
             element = VisualTreeHelper.GetParent( element ) as FrameworkElement;
             RadTreeViewItem item = element as RadTreeViewItem;
             if ( item != null )
             {
                 // Perform custom logic here
                 // You have to return here because otherwise the method will traverse
                 // the whole visual tree on every mouse move and there will be performance
                 // implications
                 return;
             }
         }
     }
}
#endregion
}
