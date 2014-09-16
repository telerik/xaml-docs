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

#region radtreeview-populating-with-data-data-binding-to-xml_1
public class XmlNodeItem
{
    public XmlNodeItem()
    {
        this.Items = new ObservableCollection<XmlNodeItem>();
    }
    [XmlAttribute( AttributeName = "Header" )]
    public string Header
    {
        get;
        set;
    }
    public ObservableCollection<XmlNodeItem> Items
    {
        get;
        set;
    }
}
#endregion

#region radtreeview-populating-with-data-data-binding-to-xml_3
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

#region radtreeview-populating-with-data-data-binding-to-xml_5
public class RadTreeViewXmlDataSource : XmlNodeItemList
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
            AddRange( RetrieveData( Application.GetResourceStream( new Uri( value, UriKind.Relative ) ).Stream ) );
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

#region radtreeview-populating-with-data-data-binding-to-xml_6
public class RadTreeViewXmlDataSource : XmlNodeItemList
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
            AddRange( RetrieveData( File.Open( value, FileMode.Open ) ) );
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
