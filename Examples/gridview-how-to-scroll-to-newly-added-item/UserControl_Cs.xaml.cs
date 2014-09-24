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

#region gridview-how-to-scroll-to-newly-added-item_0
 private void clubsGrid_RowEditEnded(object sender, GridViewRowEditEndedEventArgs e)
        {
            if (e.Row is GridViewNewRow)            
            {
                this.clubsGrid.SelectedItem = e.Row.Item;
                this.clubsGrid.ScrollIntoView(this.clubsGrid.SelectedItem);
            }
        }
#endregion
}
