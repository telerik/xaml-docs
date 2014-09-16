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

#region radchart-performance-tips-and-tricks_0
public class AddRangeObservableCollection<T> : ObservableCollection<T>
{
    private bool suppressOnCollectionChanged;
    public void AddRange( IEnumerable<T> items )
    {
        if ( items == null )
        {
            throw new ArgumentNullException( "items" );
        }
        if ( items.Any() )
        {
            try
            {
                this.suppressOnCollectionChanged = true;
                foreach ( var item in items )
                {
                    this.Add( item );
                }
            }
            finally
            {
                this.suppressOnCollectionChanged = false;
                this.OnCollectionChanged( new NotifyCollectionChangedEventArgs( NotifyCollectionChangedAction.Reset ) );
            }
        }
    }
    protected override void OnCollectionChanged( NotifyCollectionChangedEventArgs e )
    {
        if ( !this.suppressOnCollectionChanged )
        {
            base.OnCollectionChanged( e );
        }
    }
}
#endregion
}
