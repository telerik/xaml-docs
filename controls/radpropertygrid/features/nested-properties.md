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



## 

RadPropertyGrid can show nested PropertyDefinitions. In order to enable the nested properties support you need to set RadPropertyGrid's __NestedPropertiesVisibility__ property to __"Visible"__. That way you will be able to modify any editable child properties of reference types.
        

#### [XAML]Example 1: Setting NestedPropertiesVisibility

	{{region radpropertygrid-getting-started-getting-started_7}}
	<telerik:RadPropertyGrid x:Name="PropertyGrid1" Item="{Binding}"
	 NestedPropertiesVisibility="Visible" />
	{{endregion}}



#### [C#]Example 2: Preparing sample data

	{{region radpropertygrid-getting-started-getting-started_8}}
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



#### [VB.NET]Example 2: Preparing sample data

	{{region radpropertygrid-getting-started-getting-started_9}}
	    DataContext = New Order() With { _
		.OrderDate = New DateTime(1996, 7, 5), _
		.ShippedDate = New DateTime(1996, 8, 16), _
		.ShipAddress = "Luisenstr. 48", _
		.ShipCountry = "Germany", _
		.ShipName = "Toms Spezialitaten", _
		.ShipPostalCode = "44087", _
		.Employee = New Employee() With { _
			.FirstName = "Nancy", _
			.LastName = "Davolio", _
			.Title = "Sales Representative", _
			.HomePhone = "(206) 555-9857", _
			.Department = New Department() With { _
				.Country = "USA", _
				.ID = 1 _
			} _
		} _
	}
	{{endregion}}



For a full example please check the __Nested Properties__  {% if site.site_name == 'Silverlight' %}[demo](http://demos.telerik.com/silverlight/#PropertyGrid/NestedPropertyDefinitions){% endif %}{% if site.site_name == 'WPF' %}[demo](http://demos.telerik.com/wpf/#PropertyGrid/NestedPropertyDefinitions){% endif %} about NestedPropertyDefinitions.
        

You can define a nested property like so:
        

#### [XAML]Example 3: Defining nested property

	{{region radpropertygrid-nested-properties_0}}
	  <telerik:RadPropertyGrid x:Name="PropertyGrid1" 
	                           AutoGeneratePropertyDefinitions="False" 
	                           NestedPropertiesVisibility="Visible">
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
          

# See Also

 * [Getting Started with RadPropertyGrid]({%slug radpropertygrid-getting-started-getting-started%})

 * [Edit Modes]({%slug radpropertygrid-edit-modes%})

 * [Scrolling into View]({%slug radpropertygrid-scrolling%})
