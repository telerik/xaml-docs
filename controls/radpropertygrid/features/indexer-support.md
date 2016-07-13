---
title: Indexer Support
page_title: Indexer Support
description: Indexer Support
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

#### __[C#] Example 1: The class hierarchy__

	{{region cs-radpropertygrid-indexer-support_0}}
	public class League
    {
        public string Name { get; set; }
        public ObservableCollection<Club> Clubs { get; set; }
        public Dictionary<string, Club> ClubsByName { get; set; }
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
	{{endregion}}

## Binding to an Item of a Collection Through Indexer

A common scenario when using RadPropertyGrid is when we have a collection member of our business object. **Example 2** shows how to bind to an item at a specified index in the collection:

#### __[XAML] Example 2: Binding to a collection__

	{{region xaml-radpropertygrid-indexer-support_1}}
    <telerik:RadPropertyGrid Item="{Binding League}" AutoGeneratePropertyDefinitions="False">
        <telerik:RadPropertyGrid.PropertyDefinitions>
            <telerik:PropertyDefinition Binding="{Binding Clubs[0]}" DisplayName="Name" />
        </telerik:RadPropertyGrid.PropertyDefinitions>
    </telerik:RadPropertyGrid>
	{{endregion}}

## Binding of NestedProperties

You can also use indexing in **NestedProperties**, as shown in **Example 3**:

#### __[XAML] Example 3: Binding of NestedProperties__

	{{region xaml-radpropertygrid-indexer-support_2}}
    <telerik:RadPropertyGrid Item="{Binding League}" AutoGeneratePropertyDefinitions="False" NestedPropertiesVisibility="Visible">
        <telerik:RadPropertyGrid.PropertyDefinitions>
            <telerik:PropertyDefinition Binding="{Binding Clubs[0]}" DisplayName="First Club">
                <telerik:PropertyDefinition.NestedProperties>
                    <telerik:PropertyDefinition DisplayName="Goalkeeper Name" Binding="{Binding Players[0].Name}"/>
                </telerik:PropertyDefinition.NestedProperties>
            </telerik:PropertyDefinition>
        </telerik:RadPropertyGrid.PropertyDefinitions>
    </telerik:RadPropertyGrid>
	{{endregion}}

## Binding to a Collection Property with a String Key

As our **League** class has a **Dictionary** of clubs, we can access any club by its name, as demonstrated in **Example 4**.

#### __[XAML] Example 4: Binding to item in Dictionary__

	{{region xaml-radpropertygrid-indexer-support_3}}
    <telerik:RadPropertyGrid Item="{Binding League}" AutoGeneratePropertyDefinitions="False" NestedPropertiesVisibility="Visible">
        <telerik:RadPropertyGrid.PropertyDefinitions>
            <telerik:PropertyDefinition Binding="{Binding ClubsByName[Liverpool]}" DisplayName="Club">
                <telerik:PropertyDefinition.NestedProperties>
                    <telerik:PropertyDefinition DisplayName="Goalkeeper Name" Binding="{Binding Players[0].Name}"/>
                </telerik:PropertyDefinition.NestedProperties>
            </telerik:PropertyDefinition>
        </telerik:RadPropertyGrid.PropertyDefinitions>
    </telerik:RadPropertyGrid>
	{{endregion}}

## Binding to an Item which Implements an Indexer

Since our **Club** class implements an indexer, we can also bind to the **Player**, whose number is 25, for example:

#### __[XAML] Example 5: Indexing a class that implements indexer__

	{{region xaml-radpropertygrid-indexer-support_4}}
    <telerik:RadPropertyGrid Item="{Binding League}" AutoGeneratePropertyDefinitions="False">
        <telerik:RadPropertyGrid.PropertyDefinitions>
            <telerik:PropertyDefinition Binding="{Binding ClubsByName[Liverpool][25]}" DisplayName="Player with number 25" />
        </telerik:RadPropertyGrid.PropertyDefinitions>
    </telerik:RadPropertyGrid>
	{{endregion}}

## Using Unbound Mode

Indexer support also works when **AutoGenerateBindingPaths** is set to **False**.

#### __[XAML] Example 6: Indexing when AutoGenerateBindingPaths is set to False__

	{{region xaml-radpropertygrid-indexer-support_5}}
    <telerik:RadPropertyGrid Item="{Binding League}" AutoGenerateBindingPaths="False" AutoGeneratePropertyDefinitions="False" NestedPropertiesVisibility="Visible">
        <telerik:RadPropertyGrid.PropertyDefinitions>
            <telerik:PropertyDefinition Binding="{Binding ClubsByName[Liverpool]}" DisplayName="Club">
                <telerik:PropertyDefinition.NestedProperties>
                    <telerik:PropertyDefinition DisplayName="Goalkeeper Name" Binding="{Binding ClubsByName[Liverpool].Players[0].Name}"/>
                </telerik:PropertyDefinition.NestedProperties>
            </telerik:PropertyDefinition>
        </telerik:RadPropertyGrid.PropertyDefinitions>
    </telerik:RadPropertyGrid>
	{{endregion}}

## See Also

* [Nested Properties]({%slug radpropertygrid-nested-properties%})

* [Unbound Mode]({%slug radpropertygrid-unbound-mode%})
