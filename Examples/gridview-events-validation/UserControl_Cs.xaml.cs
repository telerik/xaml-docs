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

#region gridview-events-validation_1
this.radGridView.CellValidating += new EventHandler<GridViewCellValidatingEventArgs>(radGridView_CellValidating);
#endregion

#region gridview-events-validation_3
private void radGridView_CellValidating( object sender, GridViewCellValidatingEventArgs e )
{
    if ( e.Cell.Column.UniqueName == "CountryId" )
    {
        int newValue = Int32.Parse( e.NewValue.ToString() );
        if ( newValue < 0 || newValue > 12 )
        {
            e.IsValid = false;
            e.ErrorMessage = "The entered value must be between 0 and 12";
        }
    }
}
#endregion

#region gridview-events-validation_6
this.radGridView.CellValidated += new EventHandler<GridViewCellValidatedEventArgs>(radGridView_CellValidated);
#endregion

#region gridview-events-validation_9
this.radGridView.RowValidating += new EventHandler<GridViewRowValidatingEventArgs>(radGridView_RowValidating);
#endregion

#region gridview-events-validation_12
this.radGridView.RowValidated += new EventHandler<GridViewRowValidatedEventArgs>(radGridView_RowValidated);
#endregion

#region gridview-events-validation_15
private void radGridView_RowValidating( object sender, GridViewRowValidatingEventArgs e )
{
    e.IsValid = false;
}
#endregion
}
