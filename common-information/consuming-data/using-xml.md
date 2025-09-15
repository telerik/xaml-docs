---
title: Using XML
page_title: Using XML
description: This article will demonstrate how you can create in-memory data and use it in your {{ site.framework_name }} application.
slug: consuming-data-using-xml
tags: using,xml
published: True
position: 5
---

# Using XML

The purpose of this tutorial is to show you how to read data from XML document and use it in the context of your {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} application. The following common tasks will be examined:

* Deserializing data. 


* Reading data with Linq to XML. 


* Reading data with __XMLReader__. 

## Deserializing Data 

The most straight-forward way to read data from XML document is to deserialize it using the __XmlSerializer__ class. Here is a sample code showing how this can be achieved: 

#### __C#__

```C#
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
	```



#### __VB.NET__

```VB.NET
	Private Function RetrieveData() As XmlNodeItemList
	    Dim xmlDocument As String = "/DataSource/XmlData.xml"
	    ' 1. Get the resource stream for the file located in the application package.'
	    Dim xmlStream As Stream = Application.GetResourceStream(New Uri(xmlDocument, UriKind.Relative)).Stream
	    ' 1. Get the stream for the file located on the local hard drive.'
	    Dim xmlStream As Stream = File.Open(xmlDocument, FileMode.Open)
	    ' 2. Create a new instance of the XmlSerializer class.'
	    Dim serializer As New XmlSerializer(GetType(XmlNodeItemList))
	    ' 3. Create a new instance of the StreamReader class.'
	    Dim reader As New StreamReader(xmlStream)
	    ' 4. Deserialize the data'
	    Dim list As XmlNodeItemList = DirectCast(serializer.Deserialize(reader), XmlNodeItemList)
	End Function
	```



## Reading Data With Linq to XML 

Before reading you should load your XML file to an __XElement__ or __XDocument__ object. This can be done with the __Load()__ method. You can input from string, from __TextReader__, from __XMLReader__ and of course from file: 

#### __C#__

```C#
	XDocument myXML = XDocument.Load( "MyXML.xml" );
	```



#### __VB.NET__

```VB.NET
	Dim myXML As XDocument = XDocument.Load("MyXML.xml")
	```



On the next step you can use standard query operators to read the XML. Here is a sample code: 

#### __C#__

```C#
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
	```



#### __VB.NET__

```VB.NET
	Dim personsList As List(Of Person) = (From person In myXml.Descendants("person") _
	    Where DirectCast(person.Element("address").Attribute("country"), String).Equals("Bulgaria") _
	    Select New Person()).ToList()
	```



## Reading Data with XMLReader 

The following example navigates through a stream to determine the current node type, and then uses  __XmlWriter__ to output the  __XmlReader__ content. 

#### __C#__

```C#
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
	```



#### __VB.NET__

```VB.NET
	Using reader As XmlReader = XmlReader.Create(New StringReader(xmlString))
	    Dim ws As New XmlWriterSettings()
	    ws.Indent = True
	    Using writer As XmlWriter = XmlWriter.Create(output, ws)
	
	        ' Parse the file and display each of the nodes.'
	        While reader.Read()
	            Select Case reader.NodeType
	                Case XmlNodeType.Element
	                    writer.WriteStartElement(reader.Name)
	                    Exit Select
	                Case XmlNodeType.Text
	                    writer.WriteString(reader.Value)
	                    Exit Select
	                Case XmlNodeType.XmlDeclaration, XmlNodeType.ProcessingInstruction
	                    writer.WriteProcessingInstruction(reader.Name, reader.Value)
	                    Exit Select
	                Case XmlNodeType.Comment
	                    writer.WriteComment(reader.Value)
	                    Exit Select
	                Case XmlNodeType.EndElement
	                    writer.WriteFullEndElement()
	                    Exit Select
	            End Select
	
	        End While
	    End Using
	End Using
	```



## See Also

 * [In-Memory Data]({%slug consuming-data-in-memory-data%})

{% if site.site_name == 'Silverlight' %} 
 * [DomainDataSource Support]({%slug consuming-data-domain-datasource-support%})
{% endif %}
