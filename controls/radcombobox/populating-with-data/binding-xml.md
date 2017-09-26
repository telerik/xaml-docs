---
title: Binding to XML
page_title: Binding to XML
description: Binding to XML
slug: radcombobox-populating-with-data-binding-xml
tags: binding,to,xml
published: True
position: 8
---

# Binding to XML

The purpose of this tutorial is to show you how to bind a __RadComboBox__ control to a data defined in a XML file. In a few words, the operations you need to perform are to convert the XML to a collection of business objects and then bind that collection using the __ItemsSource__ property of the __RadComboBox__.

The final result should look like the snapshot below:

![](images/RadComboBox_PopulatingWithData_BindingToXML_010.png)

The next code snippet shows the XML declaration, used in this tutorial:

#### __XAML__

{{region radcombobox-populating-with-data-binding-xml_0}}
	<?xml version="1.0" encoding="utf-8" ?>
	<Items>
	    <XmlNodeItem Team="Barcelona" Country="Spain"/>
	    <XmlNodeItem Team="Juventus" Country="Italy"/>
	    <XmlNodeItem Team="Inter" Country="Italy"/>
	    <XmlNodeItem Team="Ac Milan" Country="Italy"/>
	    <XmlNodeItem Team="Real M" Country="Spain"/>
	    <XmlNodeItem Team="Arsenal" Country="England"/>
	    <XmlNodeItem Team="Manchester U" Country="England"/>
	    <XmlNodeItem Team="Bayern" Country="Germany"/>
	    <XmlNodeItem Team="Porto" Country="Portugal"/>
	    <XmlNodeItem Team="Liverpool" Country="England"/>
	    <XmlNodeItem Team="Ajax" Country="Holland"/>
	    <XmlNodeItem Team="Olimpic M" Country="France"/>
	</Items>
{{endregion}}

* Add a new __RadComboBox__ declaration in your XAML.

#### __XAML__

{{region radcombobox-populating-with-data-binding-xml_1}}
	<telerik:RadComboBox x:Name="radComboBox" Width="200"/>
{{endregion}}

* Create a new class named __XmlNodeItem__. This class is pretty simple and it represents a separate node from the XML document. Its properties are __Team__ and __Country__. Both of the properties are of type string. Here is the source code:

#### __C#__

{{region radcombobox-populating-with-data-binding-xml_2}}
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
{{endregion}}

#### __VB.NET__

{{region radcombobox-populating-with-data-binding-xml_3}}
	Public Class XmlNodeItem
	Private _Team As String
	    <XmlAttribute(AttributeName = "Team")> _
	    Public Property Team() As String
	        Get
	            Return _Team
	        End Get
	        Set(ByVal value As String)
	            _Team = value
	        End Set
	        End Property
	
	        Private _Country As String
	        <XmlAttribute(AttributeName = "Country")> _
	        Public Property Country() As String
	            Get
	                Return _Country
	            End Get
	            Set(ByVal value As String)
	                _Country = value
	            End Set
	        End Property
	    End Class
{{endregion}}

* Create a new class named __XmlNodeItemList__, which derives from __ObservableCollection__ of __XmlNodeItem__. This is a collection that will be created from the XML file. The __RadComboBox__ will be bound to this collection.

#### __C#__

{{region radcombobox-populating-with-data-binding-xml_4}}
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
{{endregion}}

#### __VB.NET__

{{region radcombobox-populating-with-data-binding-xml_5}}
	    <XmlRoot(ElementName = "Items")> _
	    Public Class XmlNodeItemList
	        Inherits ObservableCollection(Of XmlNodeItem)
	        Public Sub AddRange(ByVal range As IEnumerable(Of XmlNodeItem))
	            For Each node As XmlNodeItem In range
	                Me.Add(node)
	            Next
	        End Sub
	    End Class
{{endregion}}

Create a new class named __RadComboBoxXmlDataSource__, which derives from __XmlNodeItemList__. Practically, this will be the data source for the __RadComboBox__. The class takes a path to the XML file and deserializes the data in the private method __RetrieveData()__.

#### __C#__

{{region radcombobox-populating-with-data-binding-xml_6}}
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
{{endregion}}

#### __VB.NET__

{{region radcombobox-populating-with-data-binding-xml_7}}
	    Public Class RadComboBoxXmlDataSource
	        Inherits XmlNodeItemList
	        Private m_source As String
	
	        Public Property Source() As String
	            Get
	                Return Me.m_source
	            End Get
	            Set(ByVal value As String)
	                Me.m_source = value
	                AddRange(RetrieveData(Application.GetResourceStream(New Uri(value, UriKind.Relative)).Stream))
	            End Set
	        End Property
	
	        Private Function RetrieveData(ByVal xmlStream As Stream) As XmlNodeItemList
	            Dim serializer As New XmlSerializer(GetType(XmlNodeItemList))
	            Dim reader As New StreamReader(xmlStream)
	            Dim list As XmlNodeItemList = DirectCast(serializer.Deserialize(reader), XmlNodeItemList)
	            Return list
	        End Function
	    End Class
{{endregion}}

* The next step is to declare the __RadComboBoxXmlDataSource__ as a resource in your application. Don't pass a valid string url to the __Source__ property.

#### __XAML__

{{region radcombobox-populating-with-data-binding-xml_8}}
	<UserControl.Resources>
	    <example:RadComboBoxDataSource x:Key="DataSource"  Source="RadComboBoxBindingToXml.xml"/>
	</UserControl.Resources>
{{endregion}}

* Update your __RadComboBox__ declaration - set the __ItemsSource__ property.

#### __XAML__

{{region radcombobox-populating-with-data-binding-xml_9}}
	<telerik:RadComboBox x:Name="radComboBox" Width="200" ItemsSource="{Binding Source={StaticResource DataSource}}"/>
{{endregion}}

* The last step is to create a custom __DateTemplate__ and set it to the __RadComboBox__'s __ItemTemplate__ property. Without it, the __RadComboBox__ won't know how to interpret the data source.

>tipFor more information about the __RadComboBox__ binding support, take a look at the [DataBinding Support Overview]({%slug radcombobox-populating-with-data-binding-support-overview%}) topic.

#### __XAML__

{{region radcombobox-populating-with-data-binding-xml_10}}
	<DataTemplate x:Key="ComboBoxCustomTemplate">
	    <StackPanel Margin="5" Orientation="Horizontal">
	        <TextBlock Text="{Binding Team}" Foreground="Blue"/>
	        <TextBlock Text=" ("/>
	        <TextBlock Text="{Binding Country}"/>
	        <TextBlock Text=")"/>
	    </StackPanel>
	</DataTemplate>
{{endregion}}

* Update your __RadComboBox__ declaration for the last time and set its __ItemTemplate__ property.

#### __XAML__

{{region radcombobox-populating-with-data-binding-xml_11}}
	<telerik:RadComboBox x:Name="radComboBox" Width="200" ItemsSource="{Binding Source={StaticResource DataSource}}" ItemTemplate="{StaticResource ComboBoxCustomTemplate}"/>
{{endregion}}

The result is shown on the snapshot below.

![](images/RadComboBox_PopulatingWithData_BindingToXML_020.png)

## See Also

 * [DataBinding Support Overview]({%slug radcombobox-populating-with-data-binding-support-overview%})

 * [Filtering]({%slug radcombobox-features-filtering%})

 * [Edit Modes]({%slug radcombobox-features-edit-modes%})
