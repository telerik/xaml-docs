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

#region gridview-columns-defining-columns_0
public class Employee
{
    [DisplayAttribute( AutoGenerateField = false )]
    public int EmployeeId
    {
        get;
        set;
    }
    [DisplayAttribute( Name = "First Name" )]
    public string FirstName
    {
        get;
        set;
    }
	[DisplayAttribute( Name = "Last Name" )]
    public string LastName
    {
        get;
        set;
    }
}
#endregion

#region gridview-columns-defining-columns_3
GridViewDataColumn column = new GridViewDataColumn();
#endregion

#region gridview-columns-defining-columns_6
GridViewDataColumn column = new GridViewDataColumn();
column.DataMemberBinding = new Binding( "FirstName" );
column.Header = "My Column";
column.UniqueName = "MyColumn";
this.radGridView.AutoGenerateColumns = false;
this.radGridView.Columns.Add( column );
#endregion

#region gridview-columns-defining-columns_8
GridViewDataColumn myColumn = this.radGridView.Columns[ "FirstColumn" ];
myColumn = this.radGridView.Columns[ 0 ];
#endregion

#region gridview-columns-defining-columns_12
GridViewDataColumn column = new GridViewDataColumn();
column.CellTemplate = (DataTemplate)this.Resources["dataTemplate1"];
radGridView.Columns.Add(column );
#endregion
}
