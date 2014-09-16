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

#region edit-item-outside-gridview_0
Club selectedItem = this.clubsGrid.SelectedItem as Club;
this.clubsGrid.Items.EditItem(selectedItem);
#endregion

#region edit-item-outside-gridview_2
selectedItem.Name = "new Name of the item";
this.clubsGrid.Items.CommitEdit();
#endregion
}
