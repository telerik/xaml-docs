---
title: Serialization Options
page_title: Serialization Options
description: The PersistenceManager class allows you to specify which properties of the UIElements to be saved. To take advantage of this feature you need to set the PersistenceManager.SerializationOptions attached property.
slug: persistence-framework-defining-properties
tags: serialization,options
published: True
position: 1
---

# Serialization Options

The __PersistenceManager__ class allows you to specify which properties of the __UIElements__ to be persisted. 

In order to take advantage of this feature you need to set the __PersistenceManager.SerializationOptions__ attached property on the corresponding UIElement. The property expects a collection of type __SerializationMetadataCollection__ which can host the following two types of elements.

* [PropertyNameMetadata](#serialization-by-property-name): Determines the UIElement properties to be persisted by PersistenceManager.

* [PropertyTypeMetadata](#serialization-by-property-type): Determines properties of what type to be persisted by PersistenceManager.

## Serialization by Property Name

The __PropertyNameMetadata__ class allows you to provide a name or a path to a property and based on a condition to decide whether the property should get serialized or not. 

The PropertyNameMetadata class provides the following properties:

* __Condition__: Defines the condition under which the property will get persisted. It is a __SerializationMetadataCondition__ enumeration and exposes the following members:  
	* __Only__: States that only this property will be persisted. This is the __default condition__.
	* __Except__: States that this property won't be persisted.

* __Expression__: Defines a regular expression as a base for a Regex that is applied over the property names of the object that is being serialized. The Expression property also takes into account the value of the SearchType property. 

	__Example 1: Using Expression to serialize only the Width property of a RadButton__
	```XAML
		 <telerik:RadButton>
            <telerik:PersistenceManager.SerializationOptions>
                <telerik:SerializationMetadataCollection>
                    <telerik:PropertyNameMetadata Condition="Only" Expression="^\b(Width)\b$" SearchType="PropertyName" />
                </telerik:SerializationMetadataCollection>
            </telerik:PersistenceManager.SerializationOptions>
        </telerik:RadButton>
	```
	
	__Example 2: Using Expression to serialize all properties (of RadButton) containing Width in their name - like Width, MinWidth and MaxWidth__
	```XAML
		<telerik:RadButton>
            <telerik:PersistenceManager.SerializationOptions>
                <telerik:SerializationMetadataCollection>
                    <telerik:PropertyNameMetadata Condition="Only" Expression="Width" SearchType="PropertyName" />
                </telerik:SerializationMetadataCollection>
            </telerik:PersistenceManager.SerializationOptions>
        </telerik:RadButton>
	```
	
* __IsRecursive__: Determines whether the Expression will be evaluated in depth.			

* __SearchType__: Determines whether the searched Expression is based on a property name or a property path. It is a __MetadataSearchCriteria__ enumeration that allows you to choose between the following values:			
	* __PropertyName__: The Expression value will be evaluated against a property name in the UIElement.
	* __PropertyPath__: The Expression value will be evaluated against the full path of the property (the path from the serialization root to the property)			.

__Example 3: Setting up PropertyNameMetadata__
```XAML
	<telerik:RadButton>
		<telerik:PersistenceManager.SerializationOptions>
			<telerik:SerializationMetadataCollection>
				<!-- Searching (and serializing) all properties of RadButton, except Background --> 
				<telerik:PropertyNameMetadata Condition="Except" Expression="^\b(Background)\b$" SearchType="PropertyName" />
			</telerik:SerializationMetadataCollection>
		</telerik:PersistenceManager.SerializationOptions>
	</telerik:RadButton>
```

## Serialization by Property Type

The __PropertyTypeMetadata__ class allows you to provide a property type or a type name, and based on a condition to decide whether the property should get serialized or not. 

The PropertyTypeMetadata class exposes the following properties:		

* __AllowSubClasses__: Determines whether properties of types that are sub-classes of the specified type should be persisted.

* __Condition__: Define the condition under which the specified type of properties will be persisted. It is a __SerializationMetadataCondition__ enumeration and exposes the following members:
	* __Only__: States that only this type of properties will be persisted. This is the __default condition__.
	* __Except__: States that no property of the specified type will be persisted.				

* __IsRecursive__: Determines whether an in-depth search for properties of the specified type should be executed.

* __Type__: Defines the type of properties that should be persisted. You can use this property as an alternative to the __TypeString__ property.

* __TypeString__: Defines the type of the properties that should be persisted. You can use this property as an alternative to the __Type__ property.

	>tip The __Type__ property has a higher priority than __TypeString__.

__Example 4: Setting up PropertyTypeMetadata using the Type property__
```XAML
	<telerik:RadButton>
		<telerik:PersistenceManager.SerializationOptions>
			<telerik:SerializationMetadataCollection>
				<!-- Searching (and serializing) only properties of type Thickness --> 
				<telerik:PropertyTypeMetadata Condition="Only" Type="{x:Type Thickness}"/>    
			</telerik:SerializationMetadataCollection>
		</telerik:PersistenceManager.SerializationOptions>
	</telerik:RadButton>
```

__Example 5: Setting up PropertyTypeMetadata using the TypeString property__
```XAML
	<telerik:RadButton>
		<telerik:PersistenceManager.SerializationOptions>
			<telerik:SerializationMetadataCollection>
				<!-- Searching (and serializing) only properties of type Thickness --> 				 
				<telerik:PropertyTypeMetadata Condition="Only" TypeString="System.Windows.Thickness"/>
			</telerik:SerializationMetadataCollection>
		</telerik:PersistenceManager.SerializationOptions>
	</telerik:RadButton>
```

## Multiple Options

The __SerializationMetadataCollection__ class allows you to define what operator to be used when evaluating multiple metadata elements (PropertyNameMetadata and PropertyTypeMetadata). To do this, set the __Operator__ property. It is of type LogicalOperator (enum) and allows the following values:

* __And__: A property should fulfill all conditions defined by the items in the SerializationMetadataCollection in order to be persisted.

* __Or__: A property can fulfill only a single of the conditions defined by the items in the SerializationMetadataCollection in order to be persisted. This is the __default operator__.

__Example 6: Using multiple options with And operator__
```XAML
	<telerik:RadButton>
		<telerik:PersistenceManager.SerializationOptions>
				<telerik:SerializationMetadataCollection Operator="And">
					<!-- Searching (and serializing) only properties of type Double that don't contain the string "Width" in their names -->
					<telerik:PropertyTypeMetadata Condition="Only" TypeString="System.Double"/>
					<telerik:PropertyNameMetadata Condition="Except" Expression="Width" SearchType="PropertyName" />
				</telerik:SerializationMetadataCollection>
			</telerik:PersistenceManager.SerializationOptions>
		</telerik:RadButton>
```
	
## ShouldSerialize Method

SerializationMetadataCollection and its children (PropertyNameMetadata and PropertyTypeMetadata objects) expose the __ShouldSerialize__ method. The method allows you to check if a property should be serialized based on the applied metadata. 

__Example 7: Checking if properties containing Width in their names will be serialized based on the settings applied to the PropertyNameMetadata object__
```XAML
	PropertyNameMetadata propertyNameMetadata = PersistenceManager.GetSerializationOptions(this.radButton)[0];
	var widthPropertyInfo = typeof(RadButton).GetProperty("Width");
	MatchResult result = propertyNameMetadata.ShouldSerialize(widthPropertyInfo, "Width");	
```

The __MatchResult__ is an enum that can have the following values:
* __Full__: All conditions in the SerializationMetadataCollection are met.
* __None__: None of the conditions in the SerializationMetadataCollection are met.
* __Partial__: Only some of the conditions of the SerializationMetadataCollection are met.

## See Also
* [Getting Started]({%slug persistence-framework-getting-started%})
* [Save in a Stream]({%slug persistence-framework-save-stream%})
* [Cross-Version Support]({%slug persistence-framework-cross-version-support%})
