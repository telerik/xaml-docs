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

#region gridview-checkbox-column-clicks_2
private void gridView_AutoGeneratingColumn(object sender, GridViewAutoGeneratingColumnEventArgs e)
{
    var dataColumn = e.Column as GridViewDataColumn;
            
    if (dataColumn != null)
    {
        if (dataColumn.UniqueName.ToString() == "IsChampion")
        {
            // create GridViewCheckBoxColumn
            GridViewCheckBoxColumn newColumn = new GridViewCheckBoxColumn();
            newColumn.DataMemberBinding = dataColumn.DataMemberBinding;
            newColumn.Header = dataColumn.Header;
            newColumn.UniqueName = dataColumn.UniqueName;
            newColumn.EditTriggers = Telerik.Windows.Controls.GridView.GridViewEditTriggers.CellClick;
            newColumn.AutoSelectOnEdit = true;
            e.Column = newColumn;
        }
    }
}
#endregion
}
