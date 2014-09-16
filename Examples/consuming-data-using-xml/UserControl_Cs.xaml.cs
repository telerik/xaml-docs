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

#region consuming-data-using-xml_0
private XmlNodeItemList RetrieveData()
{
    string xmlDocument = "/DataSource/XmlData.xml";
    // 1. Get the resource stream for the file located in the application package.
    Stream xmlStream = Application.GetResourceStream( new Uri( xmlDocument, UriKind.Relative ) ).Stream;
    // 1. Get the stream for the file located on the local hard drive.
    Stream xmlStream = File.Open( xmlDocument, FileMode.Open );
    // 2. Create a new instance of the XmlSerializer class.
    XmlSerializer serializer = new XmlSerializer( typeof( XmlNodeItemList ) );
    // 3. Create a new instance of the StreamReader class.
    StreamReader reader = new StreamReader( xmlStream );
    // 4. Deserialize the data
    XmlNodeItemList list = (XmlNodeItemList)serializer.Deserialize( reader );
}
#endregion

#region consuming-data-using-xml_2
XDocument myXML = XDocument.Load( "MyXML.xml" );
#endregion

#region consuming-data-using-xml_4
List<Person> personsList =   
    ( from person in myXml.Descendants( "person" )   
      where (( string )person.Element( "address" ).Attribute( "country" )).Equals( "Bulgaria" )
      select new Person()
      {   
          FirstName = person.Element( "firstName" ).Value,
          LastName = person.Element( "lastName" ).Value,
          Address = new Location()
          {  
              City = person.Element( "address" ).Attribute( "city" ).Value,
              Country = person.Element( "address" ).Attribute( "country" ).Value
          }  
      } ).ToList();
#endregion

#region consuming-data-using-xml_6
using (XmlReader reader = XmlReader.Create(new StringReader(xmlString)))
{
    XmlWriterSettings ws = new XmlWriterSettings();
    ws.Indent = true;
    using (XmlWriter writer = XmlWriter.Create(output, ws))
    {
        // Parse the file and display each of the nodes.
        while (reader.Read())
        {
            switch (reader.NodeType)
            {
                case XmlNodeType.Element:
                    writer.WriteStartElement(reader.Name);
                    break;
                case XmlNodeType.Text:
                    writer.WriteString(reader.Value);
                    break;
                case XmlNodeType.XmlDeclaration:
                case XmlNodeType.ProcessingInstruction:
                    writer.WriteProcessingInstruction(reader.Name, reader.Value);
                    break;
                case XmlNodeType.Comment:
                    writer.WriteComment(reader.Value);
                    break;
                case XmlNodeType.EndElement:
                    writer.WriteFullEndElement();
                    break;
            }
        }
    }
}
#endregion
}
