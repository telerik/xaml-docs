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

#region gridview-how-to-access-child-gridview_1
private void employeeRadGridView_DataLoading(object sender, GridViewDataLoadingEventArgs e)
{
     GridViewDataControl dataControl = (GridViewDataControl) sender;
     if (dataControl.ParentRow != null)
     {
            //dataControl is the child gridview
            dataControl.ShowGroupPanel = false;
            GridViewDataColumn column = new GridViewDataColumn();
            column.DataMemberBinding = new Binding("EmployeeID");
            dataControl.Columns.Add(column);
            column = new GridViewDataColumn();
            column.DataMemberBinding = new Binding("FirstName");
            dataControl.Columns.Add(column);
            column = new GridViewDataColumn();
            column.DataMemberBinding = new Binding("LastName");
            dataControl.Columns.Add(column);
            column = new GridViewDataColumn();
            column.DataMemberBinding = new Binding("Title");
            dataControl.Columns.Add(column);
      }
}
#endregion
}
