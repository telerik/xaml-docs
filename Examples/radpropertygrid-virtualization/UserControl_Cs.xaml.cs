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
#region radpropertygrid-virtualization_1
this.propertyGrid1.Item = this.GetVeryLargeDataSource();
#endregion

}
