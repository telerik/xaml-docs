---
title: Indexer Support
page_title: Indexer Support
description: Check our &quot;Indexer Support&quot; documentation article for the RadPropertyGrid {{ site.framework_name }} control.
slug: radpropertygrid-features-indexer-support
tags: indexer,support
published: True
position: 19
---

# Indexer Support

In **R2 2016**, Telerik introduced **Indexer Support** for RadPropertyGrid's **PropertyDefinition** bindings. It covers the following scenarios:

* [Binding to an Item of a Collection Through Indexer](#binding-to-an-item-of-a-collection-through-indexer)

* [Binding of NestedProperties](#binding-of-nestedproperties)

* [Binding to a collection property with a string key](#binding-to-a-collection-property-with-a-string-key)

* [Binding to an Item which Implements an Indexer](#binding-to-an-item-which-implements-an-indexer)

* [Using Unbound Mode](#using-unbound-mode)

For the purposes of this article, we will assume the following class hierarchy is present:

__Example 1: The class hierarchy__

	```C#
	public class League
	{
	    public string Name { get; set; }
	    public ObservableCollection<Club> Clubs { get; set; }
	    public Dictionary<string, Club> ClubsDictionary { get; set; }
	}
	public class Club
	{
	    public string Name { get; set; }
	    public DateTime Established { get; set; }
	    public int StadiumCapacity { get; set; }
	    public ObservableCollection<Player> Players { get; set; }
	    public Player this[int index]
	    {
	        get { return this.Players.First(x => x.Number == index); }
	    }
	}
	public class Player
	{
	    public string Name { get; set; }
	    public int Number { get; set; }
	    public string Position { get; set; }
	}
```
```VB.NET
	Public Class League
	    Public Property Name() As String
	    Public Property Clubs() As ObservableCollection(Of Club)
	    Public Property ClubsDictionary() As Dictionary(Of String, Club)
	End Class
	Public Class Club
	    Public Property Name() As String
	    Public Property Established() As Date
	    Public Property StadiumCapacity() As Integer
	    Public Property Players() As ObservableCollection(Of Player)
	    Default Public ReadOnly Property Item(ByVal index As Integer) As Player
	        Get
	            Return Me.Players.First(Function(x) x.Number = index)
	        End Get
	    End Property
	End Class
	Public Class Player
	    Public Property Name() As String
	    Public Property Number() As Integer
	    Public Property Position() As String
	End Class
```

## Binding to an Item of a Collection Through Indexer

A common scenario when using RadPropertyGrid is when we have a collection member of our business object. **Example 2** shows how to bind to an item at a specified index in the collection:

__Example 2: Binding to a collection__

	```XAML
	<telerik:RadPropertyGrid Item="{Binding League}"  AutoGeneratePropertyDefinitions="False">
	    <telerik:RadPropertyGrid.PropertyDefinitions>
	        <telerik:PropertyDefinition Binding="{Binding Clubs[0]}" DisplayName="Name" />
	    </telerik:RadPropertyGrid.PropertyDefinitions>
	</telerik:RadPropertyGrid>
```

## Binding of NestedProperties

You can also use indexing in **NestedProperties**, as shown in **Example 3**:

__Example 3: Binding of NestedProperties__

	```XAML
	<telerik:RadPropertyGrid Item="{Binding League}" AutoGeneratePropertyDefinitions="False" NestedPropertiesVisibility="Visible">
	    <telerik:RadPropertyGrid.PropertyDefinitions>
	        <telerik:PropertyDefinition Binding="{Binding Clubs[0]}" DisplayName="Club">
	            <telerik:PropertyDefinition.NestedProperties>
	                <telerik:PropertyDefinition DisplayName="Goalkeeper Name" Binding="{Binding Players[0].Name}"/>
	            </telerik:PropertyDefinition.NestedProperties>
	        </telerik:PropertyDefinition>
	    </telerik:RadPropertyGrid.PropertyDefinitions>
	</telerik:RadPropertyGrid>
```

## Binding to a Collection Property with a String Key

As our **League** class has a **Dictionary** of clubs, we can access any club by its name, as demonstrated in **Example 4**.

__Example 4: Binding to item in Dictionary__

	```XAML
	<telerik:RadPropertyGrid Item="{Binding League}" AutoGeneratePropertyDefinitions="False" NestedPropertiesVisibility="Visible">
	    <telerik:RadPropertyGrid.PropertyDefinitions>
	        <telerik:PropertyDefinition Binding="{Binding ClubsDictionary[Liverpool]}" DisplayName="Club">
	            <telerik:PropertyDefinition.NestedProperties>
	                <telerik:PropertyDefinition DisplayName="Goalkeeper Name" Binding="{Binding Players[0].Name}"/>
	            </telerik:PropertyDefinition.NestedProperties>
	        </telerik:PropertyDefinition>
	    </telerik:RadPropertyGrid.PropertyDefinitions>
	</telerik:RadPropertyGrid>
```

## Binding to an Item which Implements an Indexer

Since our **Club** class implements an indexer, we can also bind to the **Player**, whose number is 25, for example:

__Example 5: Indexing a class that implements indexer__

	```XAML
	<telerik:RadPropertyGrid Item="{Binding League}" AutoGeneratePropertyDefinitions="False">
	    <telerik:RadPropertyGrid.PropertyDefinitions>
	        <telerik:PropertyDefinition Binding="{Binding ClubsDictionary[Liverpool][25]}" DisplayName="Player with number 25" />
	    </telerik:RadPropertyGrid.PropertyDefinitions>
	</telerik:RadPropertyGrid>
```

## Using Unbound Mode

Indexer support also works when **AutoGenerateBindingPaths** is set to **False**.

__Example 6: Indexing when AutoGenerateBindingPaths is set to False__

	```XAML
	<telerik:RadPropertyGrid Item="{Binding League}" AutoGenerateBindingPaths="False" AutoGeneratePropertyDefinitions="False" NestedPropertiesVisibility="Visible">
	    <telerik:RadPropertyGrid.PropertyDefinitions>
	        <telerik:PropertyDefinition Binding="{Binding ClubsDictionary[Liverpool]}" DisplayName="Club">
	            <telerik:PropertyDefinition.NestedProperties>
	                <telerik:PropertyDefinition DisplayName="Chelsea Goalkeeper Name" Binding="{Binding Clubs[Chelsea].Players[0].Name}"/>
	            </telerik:PropertyDefinition.NestedProperties>
	        </telerik:PropertyDefinition>
	    </telerik:RadPropertyGrid.PropertyDefinitions>
	</telerik:RadPropertyGrid>
```

## See Also

* [Nested Properties]({%slug radpropertygrid-nested-properties%})

* [Unbound Mode]({%slug radpropertygrid-unbound-mode%})
