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

#region gridview-troubleshooting-validation-stays_0
private void rgvTest_RowEditEnded(object sender, GridViewRowEditEndedEventArgs e)
{
	if (e.EditAction == GridViewEditAction.Cancel)
	{
		e.UserDefinedErrors.Clear();
	}
}

#endregion
}
