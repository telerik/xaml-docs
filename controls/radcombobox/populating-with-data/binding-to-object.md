---
title: Binding to Object
page_title: Binding to Object
description: Binding to Object
slug: radcombobox-populating-with-data-binding-to-object
tags: binding,to,object
published: True
position: 4
---

# Binding to Object



To bind the __RadComboBox__ to a collection of business objects, you should use its __ItemsSource__ property and define the __DataTemplate__ that is needed to display the data from the collection. If you want the changes to the collection to be automatically reflected to the __RadComboBoxItems__, the collection should implement the __INotifyCollectionChanged__ interface, as well as your business object to implement the __INotifyPropertyChanged__ interface.

The following tutorial will guide you how to bind a __RadComboBox__ to a collection of business objects. Two cases will be shown:

* [Using custom ItemTemplate](#Using_Custom_ItemTemplate)

* [Using DisplayMemberPath property](#Using_DisplayMemberPath)

>tipBefore reading this tutorial you should get familiar with the [Data Binding]({%slug radcombobox-populating-with-data-binding-support-overview%}) support of the __RadComboBox__ control.

In order to bind a __RadComboBox__ to a collection of business objects, you should perform the following instructions:

* Add a new __RadComboBox__ declaration in your XAML.

#### __XAML__

{{region radcombobox-populating-with-data-binding-to-object_0}}
	<telerik:RadComboBox Width="200" x:Name="radComboBox"/>
	{{endregion}}



* Create a new business object named __Agency__. Its structure is shown on the next code-snippet.

#### __C#__

{{region radcombobox-populating-with-data-binding-to-object_1}}
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
	{{endregion}}



#### __VB.NET__

{{region radcombobox-populating-with-data-binding-to-object_2}}
	Public Class Agency
	    Public Sub New()
	    End Sub
	    Public Sub New(ByVal name As String, ByVal phone As String, ByVal zip As String)
	        Me.Name = name
	        Me.Phone = phone
	        Me.Zip = zip
	    End Sub
	Private _Name As String
	    Public Property Name() As String
	        Get
	            Return _Name
	        End Get
	        Set(ByVal value As String)
	            _Name = value
	        End Set
	    End Property
	Private _Phone As String
	    Public Property Phone() As String
	        Get
	            Return _Phone
	        End Get
	        Set(ByVal value As String)
	            _Phone = value
	        End Set
	    End Property
	Private _Zip As String
	    Public Property Zip() As String
	        Get
	            Return _Zip
	        End Get
	        Set(ByVal value As String)
	            _Zip = value
	        End Set
	    End Property
	End Class
	{{endregion}}



The __RadComboBox__ control will be bound to an __ObservableCollection__ of __Agency__ objects.

* Create a new class named __AgencyViewModel__. In fact, this will be the data source for the combo box. This class has only one purpose - to initialize a collection with sample data.

#### __C#__

{{region radcombobox-populating-with-data-binding-to-object_3}}
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
	{{endregion}}



#### __VB.NET__

{{region radcombobox-populating-with-data-binding-to-object_4}}
	Public Class AgencyViewModel
	    Private agencies As ObservableCollection(Of Agency)
	
	    Public ReadOnly Property Agency() As ObservableCollection(Of Agency)
	        Get
	            If agencies Is Nothing Then
	
	                agencies = New ObservableCollection(Of Agency)()
	
	                agencies.Add(New Agency("Exotic Liquids", "(171) 555-2222", "EC1 4SD"))
	                agencies.Add(New Agency("New Orleans Cajun Delights", "(100) 555-4822", "70117"))
	                agencies.Add(New Agency("Grandma Kelly's Homestead", "(313) 555-5735", "48104"))
	                agencies.Add(New Agency("Tokyo Traders", "(03) 3555-5011", "100"))
	                agencies.Add(New Agency("Cooperativa de Quesos 'Las Cabras'", "(98) 598 76 54", "33007"))
	                agencies.Add(New Agency("Mayumi's", "(06) 431-7877", "545"))
	                agencies.Add(New Agency("Pavlova, Ltd.", "(03) 444-2343", "3058"))
	                agencies.Add(New Agency("Specialty Biscuits, Ltd.", "(161) 555-4448", "M14 GSD"))
	                agencies.Add(New Agency("PB Knäckebröd AB", "031-987 65 43", "S-345 67"))
	                agencies.Add(New Agency("Refrescos Americanas LTDA", "(11) 555 4640", "5442"))
	                agencies.Add(New Agency("Heli Süßwaren GmbH & Co. KG", "(New Item) (010) 9984510", "10785"))
	                agencies.Add(New Agency("Plutzer Lebensmittelgroßmärkte AG", "(New Item) (069) 992755", "60439"))
	                agencies.Add(New Agency("Nord-Ost-Fisch Handelsgesellschaft mbH", "(New Item) (04721) 8713", "27478"))
	                agencies.Add(New Agency("Formaggi Fortini s.r.l.", "(New Item) (0544) 60323", "48100"))
	                agencies.Add(New Agency("Norske Meierier", "(New Item) (0)2-953010", "1320"))
	                agencies.Add(New Agency("Bigfoot Breweries", "(New Item) (503) 555-9931", "97101"))
	                agencies.Add(New Agency("Svensk Sjöföda AB", "(New Item) 08-123 45 67", "S-123 45"))
	                agencies.Add(New Agency("Aux joyeux ecclésiastiques", "(New Item) (1) 03.83.00.68", "75004"))
	                agencies.Add(New Agency("New England Seafood Cannery", "(New Item) (617) 555-3267", "2134"))
	                agencies.Add(New Agency("Leka Trading", "(New Item) 555-8787", "512"))
	                agencies.Add(New Agency("Lyngbysild", "(New Item) 43844108", "2800"))
	                agencies.Add(New Agency("Zaanse Snoepfabriek", "(New Item) (12345) 1212", "9999 ZZ"))
	                agencies.Add(New Agency("Karkki Oy", "(New Item) (953) 10956", "53120"))
	                agencies.Add(New Agency("G'day, Mate", "(New Item) (02) 555-5914", "2042"))
	                agencies.Add(New Agency("Ma Maison", "(New Item) (514) 555-9022", "H1J 1C3"))
	                agencies.Add(New Agency("Pasta Buttini s.r.l.", "(New Item) (089) 6547665", "84100"))
	                agencies.Add(New Agency("Escargots Nouveaux", "(New Item) 85.57.00.07", "71300"))
	                agencies.Add(New Agency("Gai pâturage", "(New Item) 38.76.98.06", "74000"))
	                agencies.Add(New Agency("Forêts d'érables", "(New Item) (514) 555-2955", "J2S 7S8"))
	            End If
	
	            Return agencies
	        End Get
	    End Property
	End Class
	{{endregion}}



* Declare the __AgencyViewModel__ as a resource in your XAML.

#### __XAML__

{{region radcombobox-populating-with-data-binding-to-object_5}}
	<UserControl.Resources>
	    <example:AgencyViewModel x:Key="DataSource"/>
	</UserControl.Resources>
	{{endregion}}



* Update your __RadComboBox__ declaration and its __ItemsSource__ property.

#### __XAML__

{{region radcombobox-populating-with-data-binding-to-object_6}}
	<telerik:RadComboBox Width="200" x:Name="radComboBox" ItemsSource="{Binding Source={StaticResource DataSource}, Path=Agency}"/>
	{{endregion}}



## Using Custom ItemTemplate

The final step is to create a custom __DataTemplate__ and set it to the __RadComboBox__'s __ItemTemplate__ property.

* Add the following __DataTemplate__ declaration in your XAML resources.

#### __XAML__

{{region radcombobox-populating-with-data-binding-to-object_7}}
	<UserControl.Resources>
	    <example:AgencyViewModel x:Key="DataSource"/>
	
	    <DataTemplate x:Key="ComboBoxCustomTemplate">
	        <Grid Margin="5,5,5,5" Width="350">
	            <Grid.ColumnDefinitions>
	                <ColumnDefinition />
	                <ColumnDefinition />
	            </Grid.ColumnDefinitions>
	            <Grid.RowDefinitions>
	                <RowDefinition />
	                <RowDefinition />
	            </Grid.RowDefinitions>
	            <TextBlock FontWeight="Bold" Grid.ColumnSpan="2" Text="{Binding Name}" />
	            <TextBlock Grid.Row="1" Text="Phone:" />
	            <TextBlock Grid.Row="1" Foreground="Blue" Margin="40,0,0,0"
	                        Text="{Binding Phone}" />
	            <TextBlock Grid.Row="1" Grid.Column="1" Text="Zip:" />
	            <TextBlock Grid.Row="1" Foreground="Blue" Grid.Column="1" Margin="26,0,0,0"
	                        Text="{Binding Zip}" />
	        </Grid>
	    </DataTemplate>
	</UserControl.Resources>
	{{endregion}}



* Update your __RadComboBox__ declaration and set its __ItemTemplate__ property like in the example below.

#### __XAML__

{{region radcombobox-populating-with-data-binding-to-object_8}}
	<telerik:RadComboBox Width="200" x:Name="radComboBox" ItemsSource="{Binding Source={StaticResource DataSource}, Path=Agency}" ItemTemplate="{StaticResource ComboBoxCustomTemplate}"/>
	{{endregion}}



Run your demo, the end result is shown on the snapshot below.




         
      ![](images/RadComboBox_PopulatingWithData_BindingToObject_020.png)

## Using DisplayMemberPath

Instead of creating a custom __ItemTemplate__, an alternative approach is to use the __DisplayMemberPath__ property. Its purpose is to get or set a path to a value on the source object to serve as the visual representation of the object.

For example, instead of setting the __ItemTemplate__, set the __RadComboBox__'s __DisplayMemberPath__ property to point the __Name__property of the __Agency__ object.

#### __XAML__

{{region radcombobox-populating-with-data-binding-to-object_9}}
	<telerik:RadComboBox Width="200" x:Name="radComboBox" ItemsSource="{Binding Source={StaticResource DataSource}, Path=Agency}" DisplayMemberPath="Name"/>
	{{endregion}}



The end result is shown on the next snapshot.




         
      ![](images/RadComboBox_PopulatingWithData_BindingToObject_030.png)

>If neither the __DisplayMemberPath__ nor the __ItemTemplate__ are set, then the content of the item would be set to the value returned by the__ToString()__ method of the business object.

# See Also

 * [Binding to WCF Service]({%slug radcombobox-populating-with-data-binding-to-wcf%})

 * [Binding to ADO.NET Data Service]({%slug radcombobox-populating-with-data-binding-adonet%})

 * [Binding to XML]({%slug radcombobox-populating-with-data-binding-xml%})
