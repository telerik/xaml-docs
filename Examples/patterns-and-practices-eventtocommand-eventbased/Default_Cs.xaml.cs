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

#region patterns-and-practices-eventtocommand-eventbased_2
public partial class GridWithEvents : UserControl
{
	public GridWithEvents()
	{
		InitializeComponent();
	}


	private void xRadGridView_RowEditEnded(object sender, Telerik.Windows.Controls.GridViewRowEditEndedEventArgs e)
	{

	}
}
#endregion

#region patterns-and-practices-eventtocommand-eventbased_3
public ExampleViewModel VM;
#endregion

#region patterns-and-practices-eventtocommand-eventbased_4
this.Loaded += new RoutedEventHandler(GridWithEvents_Loaded);
#endregion
}

#region patterns-and-practices-eventtocommand-eventbased_5
void GridWithEvents_Loaded(object sender, RoutedEventArgs e)
{
	VM = new ExampleViewModel();

	xRadGridView.ItemsSource = VM.GridItems;
	xDetailListBox.ItemsSource = VM.ListItems;
}
#endregion

#region patterns-and-practices-eventtocommand-eventbased_6
if (e.EditAction == GridViewEditAction.Commit)
{
}
#endregion

#region patterns-and-practices-eventtocommand-eventbased_7
ExampleDataItem edi = e.EditedItem as ExampleDataItem;
 
VM.ListItems.Add(string.Format("Item {0} edited with name {1}, date {2}, and availability {3}",
		 edi.ID.ToString(), edi.Name, edi.Date.ToShortDateString(), edi.IsAvailable.ToString()));
#endregion

#region patterns-and-practices-eventtocommand-eventbased_9
private void xGridWithEventsButton_Click(object sender, RoutedEventArgs e)
{
	xContentBorder.Child = new GridWithEvents();
}
#endregion