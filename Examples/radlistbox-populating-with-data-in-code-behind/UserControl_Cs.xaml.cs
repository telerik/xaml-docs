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

#region radlistbox-populating-with-data-in-code-behind_1
var item1 = new RadListBoxItem() { Content = "Australia" };
radListBox.Items.Add(item1);

var item2 = new RadListBoxItem() { Content = "Brazil" };
radListBox.Items.Add(item2);
#endregion

#region radlistbox-populating-with-data-in-code-behind_2
private void RemoveListBoxItem(RadListBoxItem itemToRemove)
{
	this.radListBox.Items.Remove(itemToRemove);
}
#endregion

}
