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

#region gridview-managing-data-validation_2
private void radGridView_CellValidating( object sender, Telerik.Windows.Controls.GridViewCellValidatingEventArgs e )
{
    if ( e.Cell.Column.UniqueName == "OrderNO" )
    {
        if ( e.NewValue.ToString().Length < 5 )
        {
            e.IsValid = false;
            e.ErrorMessage = "OrderNO must be longer than five characters.";
        }
    }
}
#endregion

#region gridview-managing-data-validation_4
public class Order
{
    private string orderNo;
    public string OrderNO
    {
        get
        {
            return this.orderNo;
        }
        set
        {
            if ( value.Length < 5 )
            {
                throw new Exception( "OrderNo should be longer than 5 characters." );
            }
            this.orderNo = value;
        }
    }
}
#endregion

#region gridview-managing-data-validation_7
private void radGridView_RowValidating( object sender, Telerik.Windows.Controls.GridViewRowValidatingEventArgs e )
{
    Order order = e.Row.DataContext as Order;
    if ( String.IsNullOrEmpty( order.OrderNO ) || order.OrderNO.Length < 5 )
    {
        GridViewCellValidationResult validationResult = new GridViewCellValidationResult();
        validationResult.PropertyName = "OrderNO";
        validationResult.ErrorMessage = "OrderNO is required and must be at least five characters";
        e.ValidationResults.Add( validationResult );
        e.IsValid = false;
    }
    if ( order.Total < 0 )
    {
        GridViewCellValidationResult validationResult = new GridViewCellValidationResult();
        validationResult.PropertyName = "Total";
        validationResult.ErrorMessage = "Total must be positive";
        e.ValidationResults.Add( validationResult );
        e.IsValid = false;
    }
}
#endregion

#region gridview-managing-data-validation_9
[Required]
public string OrderNO
{
    get
    {
        return this.orderNo;
    }
    set
    {
        ValidationContext validationContext = new ValidationContext( this, null, null );
        validationContext.MemberName = "OrderNO";
        Validator.ValidateProperty( value, validationContext );
        this.orderNo = value;
    }
}
#endregion
}
