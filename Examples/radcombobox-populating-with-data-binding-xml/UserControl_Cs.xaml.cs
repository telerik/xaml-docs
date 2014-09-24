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

#region radcombobox-populating-with-data-binding-xml_2
public class XmlNodeItem
{
    [XmlAttribute( AttributeName = "Team" )]
    public string Team
    {
        get;
        set;
    }

    [XmlAttribute( AttributeName = "Country" )]
    public string Country
    {
        get;
        set;
    }
}
#endregion

#region radcombobox-populating-with-data-binding-xml_4
[XmlRoot( ElementName = "Items" )]
public class XmlNodeItemList : ObservableCollection<XmlNodeItem>
{
    public void AddRange( IEnumerable<XmlNodeItem> range )
    {
        foreach ( XmlNodeItem node in range )
        {
            this.Add( node );
        }
    }
}
#endregion

#region radcombobox-populating-with-data-binding-xml_6
public class RadComboBoxXmlDataSource : XmlNodeItemList
{
    private string source;

    public string Source
    {
        get
        {
            return this.source;
        }
        set
        {
            this.source = value;
            AddRange(this.RetrieveData(Application.GetResourceStream(new Uri(value, UriKind.Relative)).Stream));
        }
    }

    private XmlNodeItemList RetrieveData( Stream xmlStream )
    {
        XmlSerializer serializer = new XmlSerializer( typeof( XmlNodeItemList ) );
        StreamReader reader = new StreamReader( xmlStream );
        XmlNodeItemList list = ( XmlNodeItemList )serializer.Deserialize( reader );
        return list;
    }
}
#endregion
}
