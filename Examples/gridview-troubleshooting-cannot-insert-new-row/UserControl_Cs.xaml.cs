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

    #region gridview-troubleshooting-cannot-insert-new-row_0
    private void ordersGrid_AddingNewDataItem(object sender, Telerik.Windows.Controls.GridView.GridViewAddingNewEventArgs e)
        {
            e.NewObject = new Order() { CustomerID = myCustomerID };
        }
    #endregion
}
