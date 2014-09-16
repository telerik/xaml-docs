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

#region radtreeview-populating-with-data-hierarchical-data-templates_0
public class MyViewModel : INotifyPropertyChanged
{
    private String title;
    private DateTime dateCreated;
    private double price;
    public MyViewModel()
    {
        RelatedItems = new ObservableCollection<object>();
    }
    public double Price
    {
        get
        {
            return this.price;
        }
        set
        {
            if ( this.Price == value )
                return;
            this.price = value;
            OnPropertyChanged( "Price" );
        }
    }
    public DateTime DateCreated
    {
        get
        {
            return this.dateCreated;
        }
        set
        {
            if ( this.DateCreated == value )
                return;
            this.dateCreated = value;
            OnPropertyChanged( "DateCreated" );
        }
    }
    public String Title
    {
        get
        {
            return this.title;
        }
        set
        {
            if ( this.Title == value )
                return;
            this.title = value;
            OnPropertyChanged( "Title" );
        }
    }
    public IList<object> RelatedItems
    {
        get;
        set;
    }
    public event PropertyChangedEventHandler PropertyChanged;
    protected virtual void OnPropertyChanged( string info )
    {
        PropertyChangedEventHandler temp = this.PropertyChanged;
        if ( temp != null )
            temp( this, new PropertyChangedEventArgs( info ) );
    }
}
#endregion

#region radtreeview-populating-with-data-hierarchical-data-templates_2
public static IList<object> GetItems( string name )
{
    var result = new ObservableCollection<object>();
    foreach ( var num in Enumerable.Range( 1, 5 ) )
    {
        var item = new MyViewModel();
        item.DateCreated = DateTime.Today.AddDays( -num % 15 );
        item.Price = num * 100 + Convert.ToDouble( num ) / 100;
        item.Title = String.Format( "{0} {1}", name, num );
        for ( int i = 0; i < 5; i++ )
        {
            var child = new MyViewModel();
            child.DateCreated = DateTime.Today.AddDays( -num % 5 - i );
            child.Price = num * 100 + Convert.ToDouble( num + i ) / 100;
            child.Title = String.Format( "{0} {1}'s {2}", name, num, i );
            item.RelatedItems.Add( child );
            for ( int j = 0; j < 3; j++ )
            {
                var grandChild = new MyViewModel();
                grandChild.DateCreated = DateTime.Today.AddDays( -num % 5 - i + 2 );
                grandChild.Price = num * 100 + Convert.ToDouble( num + i ) / 100;
                grandChild.Title = String.Format( "{0} {1} : {2}'s {3}", name, num, i, j );
                child.RelatedItems.Add( grandChild );
            }
        }
        result.Add( item );
    }
    return result;
}
#endregion

#region radtreeview-populating-with-data-hierarchical-data-templates_5
this.radTreeView.ItemsSource = MyViewModel.GetItems( "Item" );
#endregion
}
