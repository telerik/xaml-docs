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
    #region gridview-how-to-insert-new-row-into-paged-gridview_0
   private void clubsGrid_AddingNewDataItem(object sender, Telerik.Windows.Controls.GridView.GridViewAddingNewEventArgs e)
        {
          Dispatcher.BeginInvoke(new Action(()=>{
            ((RadGridView)sender).Items.MoveToLastPage();
          }));
        }

    #endregion
}
