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

#region radcombobox-populating-with-data-in-code-behind_1
RadComboBoxItem comboBoxItem = new RadComboBoxItem();
comboBoxItem.Content = "Alapattah";
this.radComboBox.Items.Add( comboBoxItem );
comboBoxItem = new RadComboBoxItem();
comboBoxItem.Content = "Brickell Avenue";
this.radComboBox.Items.Add( comboBoxItem );
#endregion

#region radcombobox-populating-with-data-in-code-behind_3
private void RemoveComboBoxItem( RadComboBoxItem itemToRemove )
{
    this.radComboBox.Items.Remove( itemToRemove );
}
#endregion
}
