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

#region gridview-paging-using-silverlight-datapager_2
QueryableCollectionView qcv = new QueryableCollectionView( RadGridViewSampleData.GetEmployees() );
#endregion

#region gridview-paging-using-silverlight-datapager_4
QueryableCollectionView qcv = new QueryableCollectionView( RadGridViewSampleData.GetEmployees() );
dataPager.Source = qcv;
radGridView.ItemsSource = qcv;
#endregion
}
