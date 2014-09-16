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

#region gridview-master-details-scenario_1
QueryableCollectionView qcv = new QueryableCollectionView( RadGridViewSampleData.GetEmployees() );
#endregion

#region gridview-master-details-scenario_3
QueryableCollectionView qcv = new QueryableCollectionView( RadGridViewSampleData.GetEmployees() );
this.radGridViewItemsSource = qcv;
this.dataPager.Source = qcv;
this.dataForm.ItemsSource = qcv;
#endregion
}
