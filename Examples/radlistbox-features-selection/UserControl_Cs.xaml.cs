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

#region radlistbox-features-selection_0
var selectedItem = radListBox.SelectedItem as RadListBoxItem;
#endregion

#region radlistbox-features-selection_1
var customer = radListBox.SelectedItem as Customer;
#endregion

#region radlistbox-features-selection_3
public class Customer
{
	public string Name { get; set; }
	public string City { get; set; }
}	
#endregion
}
