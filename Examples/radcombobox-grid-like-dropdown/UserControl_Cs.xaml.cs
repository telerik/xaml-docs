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

#region radcombobox-grid-like-dropdown_0
public class Dealer
{
    public Dealer( string name, string description, string phone )
    {
        this.Name = name;
        this.Description = description;
        this.Phone = phone;
    }
    public string Name
    {
        get;
        set;
    }
    public string Description
    {
        get;
        set;
    }
    public string Phone
    {
        get;
        set;
    }
}
#endregion

#region radcombobox-grid-like-dropdown_2
public class DealerViewModel
{
    private ObservableCollection<Dealer> dealers;
    public ObservableCollection<Dealer> Dealers
    {
        get
        {
            if ( dealers == null )
                this.CraeteDealers();
            return dealers;
        }
    }
    private void CraeteDealers()
    {
        this.dealers = new ObservableCollection<Dealer>();
        this.dealers.Add( new Dealer( "USA Auto-Osa Ericsson", "USA", "02-222222" ) );
        this.dealers.Add( new Dealer( "USA Auto-Osa Ericsson", "USA", "03-333333" ) );
        this.dealers.Add( new Dealer( "USA Auto-Osa Ericsson", "USA", "04-444444" ) );
        this.dealers.Add( new Dealer( "Canada Auto-Osa Ericsson", "Canada", "02-222222" ) );
        this.dealers.Add( new Dealer( "Canada Auto-Osa Ericsson", "Canada", "03-333333" ) );
        this.dealers.Add( new Dealer( "Canada Auto-Osa Ericsson", "Canada", "04-444444" ) );
        this.dealers.Add( new Dealer( "Germany Auto-Osa Ericsson", "Germany", "02-222222" ) );
        this.dealers.Add( new Dealer( "Germany Auto-Osa Ericsson", "Germany", "03-333333" ) );
        this.dealers.Add( new Dealer( "Germany Auto-Osa Ericsson", "Germany", "04-444444" ) );
    }
}
#endregion
}
