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

#region raddatafilter-features-unbound-mode_1
    public UnboundModeSample()
    {
        InitializeComponent();
        ItemPropertyDefinition nameDefinition = new ItemPropertyDefinition( "Name", typeof( string ), "Employee's Name" );
        this.radDataFilter.ItemPropertyDefinitions.Add( nameDefinition );
        this.radDataFilter.FilterDescriptors.CollectionChanged += this.FilterDescriptors_CollectionChanged;
        this.radGridView.ItemsSource = RadGridViewSampleData.GetEmployees();
    }
    private void FilterDescriptors_CollectionChanged( object sender, NotifyCollectionChangedEventArgs e )
    {
        if ( e.Action == NotifyCollectionChangedAction.Add )
        {
            this.radGridView.FilterDescriptors.AddRange( e.NewItems.OfType<IFilterDescriptor>() );
        }
        else if ( e.Action == NotifyCollectionChangedAction.Remove )
        {
            foreach ( var item in e.OldItems.OfType<IFilterDescriptor>() )
            {
                this.radGridView.FilterDescriptors.Remove( item );
            }
        }
    }
#endregion

#region raddatafilter-features-unbound-mode_3
public class Employee
{
    public Employee( string name, string companyName, string title )
    {
        this.Name = name;
        this.CompanyName = companyName;
        this.Title = title;
    }
    public string Name
    {
        get;
        set;
    }
    public string CompanyName
    {
        get;
        set;
    }
    public string Title
    {
        get;
        set;
    }
}
#endregion
}
