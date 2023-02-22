---
title: Nested Properties
page_title: Nested Properties
description: Check our &quot;Nested Properties&quot; documentation article for the RadPropertyGrid {{ site.framework_name }} control.
slug: radpropertygrid-nested-properties
tags: nested,properties
published: True
position: 0
---

# Nested Properties

`RadPropertyGrid` can show nested PropertyDefinitions. In order to enable the nested properties support you need to set the `NestedPropertiesVisibility` property to `Visible`. That way, you will be able to modify any editable child properties of reference types.

The following example will show a simple scenario with visible nested properties:

#### __[C#] Preparing sample data__
{{region radpropertygrid-nested-properties-0}}
	DataContext = new Order()
	{
	    OrderDate = new DateTime(1996, 7, 5),
	    ShippedDate = new DateTime(1996, 8, 16),
	    ShipAddress = "Luisenstr. 48",
	    ShipCountry = "Germany",
	    ShipName = "Toms Spezialitaten",
	    ShipPostalCode = "44087",
	    Employee = new Employee()
	    {
	        FirstName = "Nancy",
	        LastName = "Davolio",
	        Title = "Sales Representative",
	        HomePhone = "(206) 555-9857",
	        Department = new Department()
	        {
	            Country = "USA",
	            ID = 1
	        }
	    },
	};
{{endregion}}

#### __[VB.NET] Preparing sample data__
{{region radpropertygrid-nested-properties-1}}
	DataContext = New Order() With {
	    .OrderDate = New DateTime(1996, 7, 5),
	    .ShippedDate = New DateTime(1996, 8, 16),
	    .ShipAddress = "Luisenstr. 48",
	    .ShipCountry = "Germany",
	    .ShipName = "Toms Spezialitaten",
	    .ShipPostalCode = "44087",
	    .Employee = New Employee() With {
	        .FirstName = "Nancy",
	        .LastName = "Davolio",
	        .Title = "Sales Representative",
	        .HomePhone = "(206) 555-9857",
	        .Department = New Department() With {
	            .Country = "USA",
	            .ID = 1
	        }
	    }
	}
{{endregion}}

#### __[XAML] Showing the PropertyDefinitions for the nested properties__
{{region radpropertygrid-nested-properties-2}}
	<telerik:RadPropertyGrid Item="{Binding}" NestedPropertiesVisibility="Visible" />
{{endregion}}

__RadPropertyGrid with visible nested properties__

![RadPropertyGrid with visible nested properties](images/radpropertygrid-features-nested-properties-0.png)

You can find a runnable example for this feature in our {% if site.site_name == 'Silverlight' %}[Demos application](https://demos.telerik.com/silverlight/#PropertyGrid/NestedPropertyDefinitions){% else %}[Demos application](https://demos.telerik.com/wpf/#PropertyGrid/NestedPropertyDefinitions){% endif %}.

## Manually Defining PropertyDefinitions for Nested Properties

You can manually define property definitions for nested properties. To do so, add new `PropertyDefinition` instances to the `NestedProperties` collection of the parent `PropertyDefinition`.

The next example shows how to define a property definition for one of the nested properties:

#### __[XAML] Defining a PropertyDefinition for a nested property__
{{region radpropertygrid-nested-properties-3}}
	<telerik:RadPropertyGrid Item="{Binding}" NestedPropertiesVisibility="Visible" AutoGeneratePropertyDefinitions="False">
	    <telerik:RadPropertyGrid.PropertyDefinitions>
	        <telerik:PropertyDefinition Binding="{Binding Employee}">
	            <telerik:PropertyDefinition.NestedProperties>
	                <telerik:PropertyDefinition DisplayName="First name" Binding="{Binding FirstName}"/>
	            </telerik:PropertyDefinition.NestedProperties>
	        </telerik:PropertyDefinition>
	    </telerik:RadPropertyGrid.PropertyDefinitions>
	</telerik:RadPropertyGrid>
{{endregion}}

## Searching in Nested Properties

RadPropertyGrid exposes the option to search in nested properties. To enable this functionality, set the `SearchInNestedProperties` property to `True`.

#### __[XAML] Setting the SearchInNestedProperties property__
{{region radpropertygrid-nested-properties-4}}
	<telerik:RadPropertyGrid NestedPropertiesVisibility="Visible" SearchInNestedProperties="True"/>
{{region}}

## Specifying the PropertyDefinition Auto-Generating Mode

RadPropertyGrid allows you to specify if property definitions for the nested properties will be auto-generated when the control initially loads. This behavior is controlled by the `AutoGeneratePropertyDefinitionsMode` property, which accepts one of two following options:

* `FirstLevel`&mdash;When this option is set, the property definitions will be auto-generated only for the top-level properties. This is the default value of the AutoGeneratePropertyDefinitionsMode property.
* `AllLevels`&mdash;RadPropertyGrid will recursively generate property definitions for all nested properties when this mode is selected.

#### __[XAML] Setting the AutoGeneratePropertyDefinitionsMode property__
{{region radpropertygrid-nested-properties-5}}
	<telerik:RadPropertyGrid NestedPropertiesVisibility="Visible" AutoGeneratePropertyDefinitionsMode="AllLevels"/>
{{endregion}}

>tip The `AllLevels` mode will also allow you to search in nested properties if the `SearchInNestedProperties` property is set to `True`, without having to expand them beforehand.

## See Also
 * [Getting Started with RadPropertyGrid]({%slug radpropertygrid-getting-started-getting-started%})
 * [Edit Modes]({%slug radpropertygrid-edit-modes%})
 * [Scrolling into View]({%slug radpropertygrid-scrolling%})
