---
title: Serialization Options
page_title: Serialization Options
description: Serialization Options
slug: persistence-framework-defining-properties
tags: serialization,options
published: True
position: 1
---

# Serialization Options



## PersistenceManager SerializationOptions

The __PersistenceManager__ allows you to specify which properties of the __UIElements__ to be persisted. In order to take advantage of this feature you need to set the __PersistenceManager.SerializationOptions__ property. It allows you to define:
		

* __PropertyNameMetadata__ - determines the __UIElement__ properties to be persisted by the __PersistenceManager__

* __PropertyTypeMetadata__ - determines properties of what type to be persisted by the __PersistenceManager__

## PropertyNameMetadata

The __PropertyNameMetadata__ class exposes the following members:
		

* __Condition__ - this property allows you to define the condition under which the property will be persisted. It is a __SerializationMetadataCondition__ enumeration and exposes the following members:
			

* __Only__ - states that only this property will be persisted;
				

* __Except__ - states that this property won't be persisted.
				

* __Expression__ - this property allows you to define a regular expression that will be evaluated against the value of the __SearchType__ property
			

* __IsRecursive__ - this property controls whether the __Expression__ will be evaluated in depth.
			

* __SearchType__ - this property controls against what the __Expression__ should be evaluated. It is a __MetadataSearchCriteria__ enumeration that allows you to choose between the following values:
			

* __PropertyName__ - the __Expression__ will be evaluated against a property name in the __UIElement__

* __PropertyPath__ - the __Expression__ will be evaluated against the full path of the property (the path from the serialization root to the property)
				

* __ShouldSerialize() -__ this method evaluates the __PropertyNameMetadata__ properties to decide whether a property should or shouldn't be persisted
			

## PropertyTypeMetadata

The __PropertyTypeMetadata__ class exposes the following members:
		

* __AllowSubclasses__ - determines whether properties of types that are sub-classes of the specified type should be persisted
			

* __Condition__ - this property allows you to define the condition under which the specified type of properties will be persisted. It is a __SerializationMetadataCondition__ enumeration and exposes the following members:
			

* __Only__ - states that only this type of properties will be persisted;
				

* __Except__ - states that no property of the specified type will be persisted.
				

* __IsRecursive__ - this property controls whether an in-depth search for properties of the specified type should be implemented
			

* __Type__ - defines the type of properties that should be persisted and is of type __Type__. This property cannot be set in XAML.
			

* __TypeString__ - is of type string and allows you to set the type of the properties that should be persisted in XAML.
			

* __ShouldSerialize()__ - this method evaluates the __PropertyTypeMetadata__ properties to decide whether a property should or shouldn't be persisted
			

## SerializationMetadataCollection

The __PersistenceManager.SerializationOptions__ property is of type __SerializationMetadataCollection__. The __SerializationMetadataCollection__ class is a collection of __ISerializationMetadata__ and this is why it can be filled with __PropertyTypeMetadata__ and __PropertyNameMetadata__ items.
		

The __SerializationMetadataCollection__ also exposes an __Operator__ property that controls the relationship between its items. The __Operator__ property is a __LogicalOperator__ enumeration that exposes the following members:
		

* __And__ - a property should fulfill all conditions defined by the items in the __SerializationMetadataCollection__in order to be persisted
			

* __Or__ - if a property fulfills even one of the conditions defined by the __SerializationMetadataCollection__items, it will be persisted
			

The __SerializationMetadataCollection__ class exposes the following methods:
		

* __ShouldSerialize()__ - the method evaluates each __SerializationMetadataCollection__ item in order to determine which properties should be persisted.
			

For example in the __RadTreeView__ definition we can define only the __IsExpanded__ and __IsSelected__ properties to be persisted:
		

#### __XAML__

{{region persistence-framework-defining-properties_0}}
	<telerik:RadTreeView x:Name="treeView">
	 <telerik:PersistenceManager.SerializationOptions>
	  <telerik:SerializationMetadataCollection Operator="Or">
	   <telerik:PropertyNameMetadata Condition="Only" Expression="IsSelected" SearchType="PropertyName" />
	   <telerik:PropertyNameMetadata Condition="Only" Expression="IsExpanded" SearchType="PropertyName" />
	  </telerik:SerializationMetadataCollection>
	 </telerik:PersistenceManager.SerializationOptions>
	 <telerik:RadTreeViewItem Header="Beverages">
	  <telerik:RadTreeViewItem Header="Chai" />
	  <telerik:RadTreeViewItem Header="Chang" />
	  <telerik:RadTreeViewItem Header="Ipoh Coffee" />
	  <telerik:RadTreeViewItem Header="Chartreuse verte" />
	  <telerik:RadTreeViewItem Header="Sasquatch Ale" />
	 </telerik:RadTreeViewItem>
	 <telerik:RadTreeViewItem Header="Condiments">
	<telerik:RadTreeViewItem Header="Aniseed Syrup" />
	  <telerik:RadTreeViewItem Header="Genen Shouyu" />
	  <telerik:RadTreeViewItem Header="Gula Malacca" />
	  <telerik:RadTreeViewItem Header="Louisiana Hot Spiced Okra" />
	  <telerik:RadTreeViewItem Header="Louisiana Fiery Hot Pepper Sauce" />
	 </telerik:RadTreeViewItem>
	 <telerik:RadTreeViewItem Header="Confections">
	  <telerik:RadTreeViewItem Header="Teatime Chocolate Biscuits" />
	  <telerik:RadTreeViewItem Header="Sir Rodney's Marmalade" />
	  <telerik:RadTreeViewItem Header="Zaanse koeken" />
	  <telerik:RadTreeViewItem Header="Chocolade" />
	  <telerik:RadTreeViewItem Header="Maxilaku" />
	  <telerik:RadTreeViewItem Header="Valkoinen suklaa" />
	 </telerik:RadTreeViewItem>
	</telerik:RadTreeView>
	{{endregion}}



Or you can define all properties to be persisted except the __IsSelected__ property:
		

#### __XAML__

{{region persistence-framework-defining-properties_1}}
	<telerik:RadTreeView x:Name="treeView" >
	 <telerik:PersistenceManager.SerializationOptions>
	  <telerik:SerializationMetadataCollection>
	   <telerik:PropertyNameMetadata Condition="Except" Expression="IsSelected" SearchType="PropertyName" />
	  </telerik:SerializationMetadataCollection>
	 </telerik:PersistenceManager.SerializationOptions>
	...
	</telerik:RadTreeView>
	{{endregion}}