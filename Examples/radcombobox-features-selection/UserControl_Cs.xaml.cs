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

#region radcombobox-features-selection_0
RadComboBoxItem selectedItem = radComboBox.SelectedItem as RadComboBoxItem;
#endregion

#region radcombobox-features-selection_2
Agency agency = radComboBox.SelectedItem as Agency;
#endregion

#region radcombobox-features-selection_4
public class Agency
{
    public string Name
    {
        get;
        set;
    }
    public string Phone
    {
        get;
        set;
    }
}
#endregion

#region radcombobox-features-selection_8
string text = radComboBox.Text;
#endregion
}
