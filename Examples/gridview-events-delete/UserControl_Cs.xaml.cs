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

#region gridview-events-delete_1
this.gridView.Deleting += new EventHandler<GridViewDeletingEventArgs>(gridView_Deleting);
#endregion

#region gridview-events-delete_3
public MainPage()
{
   InitializeComponent();
   gridView.ItemsSource = Club.GetClubs();
   this.gridView.Deleting += new EventHandler<GridViewDeletingEventArgs>(gridView_Deleting);
}
protected IEnumerable<Object> itemsToBeDeleted;
private void gridView_Deleting(object sender, Telerik.Windows.Controls.GridViewDeletingEventArgs e)
{
   //store the items to be deleted
   itemsToBeDeleted = e.Items;
   //cancel the event so the item is not deleted
   //and wait for the user confirmation
   e.Cancel = true;
   //open the Confirm dialog
   RadWindow.Confirm("Are you sure?", this.OnRadWindowClosed);
}
private void OnRadWindowClosed(object sender, WindowClosedEventArgs e)
{
   //check whether the user confirmed
   bool shouldDelete = e.DialogResult.HasValue ? e.DialogResult.Value : false;
   if (shouldDelete)
   {
     foreach (var club in itemsToBeDeleted)
     {
        gridView.Items.Remove(club);
     }
   }
}
#endregion

#region gridview-events-delete_6
this.gridView.Deleted += new EventHandler<GridViewDeletedEventArgs>(gridView_Deleted);
#endregion
}
