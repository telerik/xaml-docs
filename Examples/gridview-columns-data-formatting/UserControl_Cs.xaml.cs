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

#region gridview-columns-data-formatting_1
( ( GridViewDataColumn )this.radGridView.Columns[ "OrderDate" ] ).DataFormatString = "{0:dd, MMM, yyyy}";
    // or
( ( GridViewDataColumn )this.radGridView.Columns[ "OrderDate" ] ).DataFormatString = "dd, MMM, yyyy";
#endregion
}
