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

#region radcombobox-populating-with-data-binding-to-object_1
public class Agency
{
    public Agency()
    {
    }
    public Agency( string name, string phone, string zip )
    {
        this.Name = name;
        this.Phone = phone;
        this.Zip = zip;
    }
    public string Name
    {
        get;
        set;
    }
    public string Phone
    {
        get;
        set;
    }
    public string Zip
    {
        get;
        set;
    }
}
#endregion

#region radcombobox-populating-with-data-binding-to-object_3
public class AgencyViewModel
{
    private ObservableCollection<Agency> agencies;
    public ObservableCollection<Agency> Agency
    {
        get
        {
            if ( agencies == null )
            {
                agencies = new ObservableCollection<Agency>();
                agencies.Add( new Agency( "Exotic Liquids", "(171) 555-2222", "EC1 4SD" ) );
                agencies.Add( new Agency( "New Orleans Cajun Delights", "(100) 555-4822", "70117" ) );
                agencies.Add( new Agency( "Grandma Kelly's Homestead", "(313) 555-5735", "48104" ) );
                agencies.Add( new Agency( "Tokyo Traders", "(03) 3555-5011", "100" ) );
                agencies.Add( new Agency( "Cooperativa de Quesos 'Las Cabras'", "(98) 598 76 54", "33007" ) );
                agencies.Add( new Agency( "Mayumi's", "(06) 431-7877", "545" ) );
                agencies.Add( new Agency( "Pavlova, Ltd.", "(03) 444-2343", "3058" ) );
                agencies.Add( new Agency( "Specialty Biscuits, Ltd.", "(161) 555-4448", "M14 GSD" ) );
                agencies.Add( new Agency( "PB Knäckebröd AB", "031-987 65 43", "S-345 67" ) );
                agencies.Add( new Agency( "Refrescos Americanas LTDA", "(11) 555 4640", "5442" ) );
                agencies.Add( new Agency( "Heli Süßwaren GmbH & Co. KG", "(New Item) (010) 9984510", "10785" ) );
                agencies.Add( new Agency( "Plutzer Lebensmittelgroßmärkte AG", "(New Item) (069) 992755", "60439" ) );
                agencies.Add( new Agency( "Nord-Ost-Fisch Handelsgesellschaft mbH", "(New Item) (04721) 8713", "27478" ) );
                agencies.Add( new Agency( "Formaggi Fortini s.r.l.", "(New Item) (0544) 60323", "48100" ) );
                agencies.Add( new Agency( "Norske Meierier", "(New Item) (0)2-953010", "1320" ) );
                agencies.Add( new Agency( "Bigfoot Breweries", "(New Item) (503) 555-9931", "97101" ) );
                agencies.Add( new Agency( "Svensk Sjöföda AB", "(New Item) 08-123 45 67", "S-123 45" ) );
                agencies.Add( new Agency( "Aux joyeux ecclésiastiques", "(New Item) (1) 03.83.00.68", "75004" ) );
                agencies.Add( new Agency( "New England Seafood Cannery", "(New Item) (617) 555-3267", "2134" ) );
                agencies.Add( new Agency( "Leka Trading", "(New Item) 555-8787", "512" ) );
                agencies.Add( new Agency( "Lyngbysild", "(New Item) 43844108", "2800" ) );
                agencies.Add( new Agency( "Zaanse Snoepfabriek", "(New Item) (12345) 1212", "9999 ZZ" ) );
                agencies.Add( new Agency( "Karkki Oy", "(New Item) (953) 10956", "53120" ) );
                agencies.Add( new Agency( "G'day, Mate", "(New Item) (02) 555-5914", "2042" ) );
                agencies.Add( new Agency( "Ma Maison", "(New Item) (514) 555-9022", "H1J 1C3" ) );
                agencies.Add( new Agency( "Pasta Buttini s.r.l.", "(New Item) (089) 6547665", "84100" ) );
                agencies.Add( new Agency( "Escargots Nouveaux", "(New Item) 85.57.00.07", "71300" ) );
                agencies.Add( new Agency( "Gai pâturage", "(New Item) 38.76.98.06", "74000" ) );
                agencies.Add( new Agency( "Forêts d'érables", "(New Item) (514) 555-2955", "J2S 7S8" ) );
            }
            return agencies;
        }
    }
}
#endregion
}
