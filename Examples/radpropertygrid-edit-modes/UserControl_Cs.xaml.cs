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
#region radpropertygrid-edit-modes_0
void RpgBeginningEdit(object sender, PropertyGridBeginningEditEventArgs e)
{
    // Custom logic
	e.Cancel = true;
}
#endregion
}
