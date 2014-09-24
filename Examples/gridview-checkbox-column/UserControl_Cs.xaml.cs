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
    #region gridview-checkbox-column_4
    private void RadGridView_PreparingCellForEdit(object sender, Telerik.Windows.Controls.GridViewPreparingCellForEditEventArgs e)
       {
           if (e.Column.UniqueName == "GridViewCheckBoxColumn")
           {
               var checkBox = e.EditingElement as CheckBox;
               checkBox.Margin = new Thickness(4, 0, -3, 0);
           }
       }
    #endregion
}
