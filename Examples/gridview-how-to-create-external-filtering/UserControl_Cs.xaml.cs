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

#region gridview-how-to-create-external-filtering_0
public class CustomFilterDescriptor : FilterDescriptorBase
{
    private string filterValue;
    private CompositeFilterDescriptor compositeFilter;
    public CustomFilterDescriptor( string filterValue, IEnumerable<string> filterPropertyNames )
    {
        compositeFilter = new CompositeFilterDescriptor();
        compositeFilter.LogicalOperator = FilterCompositionLogicalOperator.Or;
        foreach ( string propertyName in filterPropertyNames )
        {
            this.compositeFilter.FilterDescriptors.Add( new FilterDescriptor( 
                propertyName,
                FilterOperator.Contains, 
                filterValue ) );
        }
    }
    public string FilterValue
    {
        set
        {
            if ( value == null )
                return;
            filterValue = value;
            this.UpdateCompositeFilterValues();
            this.OnPropertyChanged( "FilterValue" );
        }
        get
        {
            return filterValue;
        }
    }
    protected override Expression CreateFilterExpression( ParameterExpression parameterExpression )
    {
        if ( string.IsNullOrEmpty( this.FilterValue ) )
        {
            return Expression.Constant( true );
        }
        return this.compositeFilter.CreateFilterExpression( parameterExpression );
    }
    private void UpdateCompositeFilterValues()
    {
        foreach ( FilterDescriptor descriptor in this.compositeFilter.FilterDescriptors )
        {
            descriptor.Value = this.FilterValue;
        }
    }
}
#endregion

#region gridview-how-to-create-external-filtering_3
public partial class ExternalFiltering : UserControl
{
    private CustomFilterDescriptor customFilter;
    public ExternalFiltering()
    {
        InitializeComponent();
        textBoxSearchFor.Focus();
        this.radGridView.ItemsSource = RadGridViewSampleData.GetEmployees();
        this.radGridView.FilterDescriptors.Add( this.CustomFilterDescriptor );
    }
    public CustomFilterDescriptor CustomFilterDescriptor
    {
        get
        {
            if ( customFilter == null )
            {
                IEnumerable<string> propertyNames = from GridViewColumn column in this.radGridView.Columns
                                                    select column.UniqueName;
                customFilter = new CustomFilterDescriptor( textBoxSearchFor.Text, propertyNames );
            }
            return customFilter;
        }
    }
    private void textBoxSearchFor_TextChanged( object sender, TextChangedEventArgs e )
    {
        this.CustomFilterDescriptor.FilterValue = textBoxSearchFor.Text;
        textBoxSearchFor.Focus();
    }
}
#endregion
}
