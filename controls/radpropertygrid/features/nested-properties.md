---
title: Nested Properties
page_title: Nested Properties
description: Nested Properties
slug: radpropertygrid-nested-properties
tags: nested,properties
published: True
position: 0
---

# Nested Properties

RadPropertyGrid can show nested PropertyDefinitions. In order to enable the nested properties support you need to set RadPropertyGrid's __NestedPropertiesVisibility__ property to __"Visible"__. That way you will be able to modify any editable child properties of reference types.

#### __[XAML] Example 1: Setting NestedPropertiesVisibility__

	{{region xaml-radpropertygrid-nested-properties_0}}
	<telerik:RadPropertyGrid Item="{Binding}" NestedPropertiesVisibility="Visible" />
{{endregion}}

#### __[C#] Example 2: Preparing sample data__

	{{region cs-radpropertygrid-nested-properties_1}}
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

#### __[VB.NET] Example 2: Preparing sample data__

	{{region vb-radpropertygrid-nested-properties_1}}
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

For a full example please check the __Nested Properties__  {% if site.site_name == 'Silverlight' %}[demo](http://demos.telerik.com/silverlight/#PropertyGrid/NestedPropertyDefinitions){% endif %}{% if site.site_name == 'WPF' %}[demo](http://demos.telerik.com/wpf/#PropertyGrid/NestedPropertyDefinitions){% endif %} about NestedPropertyDefinitions.

You can define a nested property like so:

#### __[XAML] Example 3: Defining nested property__

	{{region xaml-radpropertygrid-nested-properties_2}}
	<telerik:RadPropertyGrid x:Name="PropertyGrid1">
	    <telerik:RadPropertyGrid.PropertyDefinitions>
	        <telerik:PropertyDefinition Binding="{Binding Employee}">
	            <telerik:PropertyDefinition.NestedProperties>
	                <telerik:PropertyDefinition DisplayName="First name" Binding="{Binding FirstName}"/>
	            </telerik:PropertyDefinition.NestedProperties>
	        </telerik:PropertyDefinition>
	    </telerik:RadPropertyGrid.PropertyDefinitions>
	</telerik:RadPropertyGrid>
{{endregion}}

>After __Q1 2012__ searching in the nested hierarchy is supported.

>Before __Q1 2012__ the NestedPropertiesVisibility property has modes __FlatMode__ and __NestedPropertiesMode__.

## See Also

 * [Getting Started with RadPropertyGrid]({%slug radpropertygrid-getting-started-getting-started%})

 * [Edit Modes]({%slug radpropertygrid-edit-modes%})

 * [Scrolling into View]({%slug radpropertygrid-scrolling%})
