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

#region radgridview-row-details-external-row-details_1
this.ExternalPresenter.DetailsProvider = this.radGridView.RowDetailsProvider;
#endregion
}
