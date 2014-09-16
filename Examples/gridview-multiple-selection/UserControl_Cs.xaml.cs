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

#region gridview-multiple-selection_1
this.radGridView.SelectionMode = System.Windows.Controls.SelectionMode.Extended;
#endregion

#region gridview-multiple-selection_4
listBoxSelectedItems.ItemsSource = this.radGridView.SelectedItems;
#endregion
}
