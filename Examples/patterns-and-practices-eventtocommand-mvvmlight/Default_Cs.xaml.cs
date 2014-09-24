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

#region patterns-and-practices-eventtocommand-mvvmlight_4
private void xGridMVVMLight_Click(object sender, RoutedEventArgs e)
{
   xContentBorder.Child = new GridMVVMLight();
}
#endregion

#region patterns-and-practices-eventtocommand-mvvmlight_6
// MVVM Light Version with PassEventArgs
public void RunEdit(object obj)
{
	GridViewRowEditEndedEventArgs e = obj as GridViewRowEditEndedEventArgs;

	if (e.EditAction == GridViewEditAction.Commit)
	{
		ExampleDataItem edi = e.EditedItem as ExampleDataItem;
		VM.ListItems.Add(string.Format("Item {0} edited with name {1}, date {2}, and availability {3}", edi.ID.ToString(), 
				edi.Name, edi.Date.ToShortDateString(), edi.IsAvailable.ToString()));
	}
}
#endregion


}