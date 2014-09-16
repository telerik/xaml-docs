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

#region radgridview-columns-column-types-combobox-column_1
GridViewComboBoxColumn column = new GridViewComboBoxColumn();
this.radGridView.Columns.Add( column );
#endregion

#region radgridview-columns-column-types-combobox-column_4
column.DataMemberBinding = new Binding( "CountryId" );
column.UniqueName = "Country";
#endregion

#region radgridview-columns-column-types-combobox-column_6
( ( GridViewComboBoxColumn )this.radGridView.Columns[ "Country" ] ).ItemsSource = RadGridViewSampleData.GetCountries();
#endregion

#region radgridview-columns-column-types-combobox-column_9
column.SelectedValueMemberPath = "Id";
column.DisplayMemberPath = "Name";
#endregion
}
