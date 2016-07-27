---
title: Getting Started
page_title: Getting Started
description: Getting Started
slug: radbreadcrumb-getting-started
tags: getting,started
published: True
position: 1
---

# Getting Started

This tutorial will walk you through the creation of a __RadBreadcrumb__.	  

## Assembly References

In order to use __RadBreadcrumb__  in your projects, you have to add references to the following assemblies:  

* __Telerik.Windows.Controls__
* __Telerik.Windows.Controls.Navigation__
{% if site.site_name == 'WPF' %}
* __Telerik.Windows.Data__ 

>You can find more info [here]({%slug installation-installing-controls-dependencies-wpf %}).
{% endif %}
{% if site.site_name == 'Silverlight' %}
>You can find more info [here]({%slug installation-installing-controls-dependencies%}).{% endif %}

##  Define a Breadcrumb control

__Example 1__ demonstrates a basic __RadBreadcrumb__ definition.  

#### __[XAML] Example 1: Defining a RadBreadcrumb in XAML__  
{{region xaml-radbreadcrumb-getting-started_0}}
	<telerik:RadBreadcrumb x:Name="breadcrumb" Header="Breadcrumb Header" HorizontalAlignment="Stretch" VerticalAlignment="Top"/>
{{endregion}}

#### __[C#] Example 2: Defining a RadBreadcrumb in code__  
{{region cs-radbreadcrumb-getting-started_1}}
	RadBreadcrumb breadcrumb = new RadBreadcrumb();
	breadcrumb.Header = "Breadcrumb Header";
	breadcrumb.HorizontalAlignment = System.Windows.HorizontalAlignment.Stretch;
	breadcrumb.VerticalAlignment = System.Windows.VerticalAlignment.Top;
{{endregion}}

#### __[VB.NET] Example 2: Defining a RadBreadcrumb in code__  
{{region vb-radbreadcrumb-getting-started_2}}
	Dim breadcrumb As New RadBreadcrumb()
	breadcrumb.Header = "Breadcrumb Header"
	breadcrumb.HorizontalAlignment = System.Windows.HorizontalAlignment.Stretch
	breadcrumb.VerticalAlignment = System.Windows.VerticalAlignment.Top
{{endregion}}

![](images/breadcrumb_gettingstarted_breadcrumb.png)

>The __RadBreacrumb__ control is a __HeaderedItemsControl__ and its Header is used as a root element. Therefore the control always has one root element. If you don't set the __Breadcrumb.Header__ property an empty root element will be created.		  

So far there is an empty __RadBreadcrumb__ containing no items.		

## Add and remove items (RadBreadcrumbItem controls) and set their Header and DropDownHeader properties

You can add items to the __RadBreadcrumb__ control by defining __RadBreadcrumbItem__ controls inside the __RadBreadcrumb__ definition in XAML:		

#### __[XAML] Example 3: Adding RadBreadcrumbItems in XAML__  
{{region xaml-radbreadcrumb-getting-started_3}}
	<telerik:RadBreadcrumb Header="Breadcrumb Header" HorizontalAlignment="Stretch" VerticalAlignment="Top">
	    <telerik:RadBreadcrumbItem Header="BreadcrumbItem 1" DropDownHeader="DropDownItem 1">
	        <telerik:RadBreadcrumbItem Header="BreadcrumbItem 1.1" DropDownHeader="DropDownItem 1.1"/>
	        <telerik:RadBreadcrumbItem Header="BreadcrumbItem 1.2" DropDownHeader="DropDownItem 1.2" />
	        <telerik:RadBreadcrumbItem Header="BreadcrumbItem 1.3" DropDownHeader="DropDownItem 1.3" />
	    </telerik:RadBreadcrumbItem>
	    <telerik:RadBreadcrumbItem Header="BreadcrumbItem 2" DropDownHeader="DropDownItem 2">
	        <telerik:RadBreadcrumbItem Header="BreadcrumbItem 2.1" DropDownHeader="DropDownItem 2.1" />
	        <telerik:RadBreadcrumbItem Header="BreadcrumbItem 2.2" DropDownHeader="DropDownItem 2.2" />
	        <telerik:RadBreadcrumbItem Header="BreadcrumbItem 2.3" DropDownHeader="DropDownItem 2.3" />
	    </telerik:RadBreadcrumbItem>
	    <telerik:RadBreadcrumbItem Header="BreadcrumbItem 3" DropDownHeader="DropDownItem 3" />
	</telerik:RadBreadcrumb>
{{endregion}}

Or you can populate the __RadBreadcrumb.Items__ collection in code-behind:

#### __[C#] Example 4: Adding RadBreadcrumbItems in code__  
{{region cs-radbreadcrumb-getting-started_4}}
	RadBreadcrumbItem item1 = new RadBreadcrumbItem() { Header = "BreadcrumbItem 1", DropDownHeader = "DropDownItem 1" };
	item1.Items.Add(new RadBreadcrumbItem() { Header = "BreadcrumbItem 1.1", DropDownHeader = "DropDownItem 1.1" });
	item1.Items.Add(new RadBreadcrumbItem() { Header = "BreadcrumbItem 1.2", DropDownHeader = "DropDownItem 1.2" });
	item1.Items.Add(new RadBreadcrumbItem() { Header = "BreadcrumbItem 1.3", DropDownHeader = "DropDownItem 1.3" });
	breadcrumb.Items.Add(item1);
	RadBreadcrumbItem item2 = new RadBreadcrumbItem() { Header = "BreadcrumbItem 2", DropDownHeader = "DropDownItem 2" };
	item2.Items.Add(new RadBreadcrumbItem() { Header = "BreadcrumbItem 2.1", DropDownHeader = "DropDownItem 2.1" });
	item2.Items.Add(new RadBreadcrumbItem() { Header = "BreadcrumbItem 2.2", DropDownHeader = "DropDownItem 2.2" });
	item2.Items.Add(new RadBreadcrumbItem() { Header = "BreadcrumbItem 2.3", DropDownHeader = "DropDownItem 2.3" });
	breadcrumb.Items.Add(item2);
	RadBreadcrumbItem item3 = new RadBreadcrumbItem() { Header = "BreadcrumbItem 3", DropDownHeader = "DropDownItem 3" };
	breadcrumb.Items.Add(item3);
{{endregion}}

#### __[VB.NET] Example 4: Adding RadBreadcrumbItems in code__  
{{region vb-radbreadcrumb-getting-started_5}}
	Dim item1 As New RadBreadcrumbItem() With { 
	        Key .Header = "BreadcrumbItem 1", 
	        Key .DropDownHeader = "DropDownItem 1" 
	}
	item1.Items.Add(New RadBreadcrumbItem() With { 
	        Key .Header = "BreadcrumbItem 1.1", 
	        Key .DropDownHeader = "DropDownItem 1.1" 
	})
	item1.Items.Add(New RadBreadcrumbItem() With { 
	        Key .Header = "BreadcrumbItem 1.2", 
	        Key .DropDownHeader = "DropDownItem 1.2" 
	})
	item1.Items.Add(New RadBreadcrumbItem() With { 
	        Key .Header = "BreadcrumbItem 1.3", 
	        Key .DropDownHeader = "DropDownItem 1.3" 
	})
	breadcrumb.Items.Add(item1)
	
	Dim item2 As New RadBreadcrumbItem() With { 
	        Key .Header = "BreadcrumbItem 2", 
	        Key .DropDownHeader = "DropDownItem 2" 
	}
	item2.Items.Add(New RadBreadcrumbItem() With { 
	        Key .Header = "BreadcrumbItem 2.1", 
	        Key .DropDownHeader = "DropDownItem 2.1" 
	})
	item2.Items.Add(New RadBreadcrumbItem() With { 
	        Key .Header = "BreadcrumbItem 2.2", 
	        Key .DropDownHeader = "DropDownItem 2.2" 
	})
	item2.Items.Add(New RadBreadcrumbItem() With { 
	        Key .Header = "BreadcrumbItem 2.3", 
	        Key .DropDownHeader = "DropDownItem 2.3" 
	})
	breadcrumb.Items.Add(item2)
	
	Dim item3 As New RadBreadcrumbItem() With { 
	        Key .Header = "BreadcrumbItem 3", 
	        Key .DropDownHeader = "DropDownItem 3" 
	}
	breadcrumb.Items.Add(item3)
{{endregion}}

![](images/breadcrumb_gettingstarted_breadcrumb_items.png)

In order to remove items from the __RadBreadcrumb__ control, you can remove them from the control's __Items__ collection:

#### __[C#] Example 5: Removing RadBreadcrumbItems__  
{{region cs-radbreadcrumb-getting-started_6}}
	breadcrumb.Items.Remove(item2);
{{endregion}}

#### __[VB.NET] Example 5: Removing RadBreadcrumbItems__  
{{region vb-radbreadcrumb-getting-started_7}}
	breadcrumb.Items.Remove(item2)
{{endregion}}

![](images/breadcrumb_gettingstarted_items_remove.png)

## Enable LinearMode

By default the __RadBreadcrumb__ control has two modes - normal and text mode. In the normal mode you can navigate through the __Breadcrumb.Items__ using the BreadcrumbItems and their dropdown content, while in the text mode you can enter the path that you want to navigate to. The control also provides a __Linear__ mode in which the __BreadcrumbItem DropDown Items__ collection is hidden. In __Linear__ mode you can navigate through the __Items__ collection of the control by taking advantage of the text mode of the __RadBreadcrumb__, using its history, using the key navigation or setting the destination path from code-behind.

In order to enable the __Linear__ mode of the __RadBreadcrumb__ control, you have to set the __IsLinearMode__ property to __True__ :

#### __[XAML] Example 6: Enabling linear mode in XAML__  
{{region xaml-radbreadcrumb-getting-started_8}}
	<telerik:RadBreadcrumb  Header="Breadcrumb Header" HorizontalAlignment="Stretch"
	        VerticalAlignment="Top" IsLinearMode="True">
	    <telerik:RadBreadcrumbItem Header="BreadcrumbItem 1" DropDownHeader="DropDownItem 1">
	        <telerik:RadBreadcrumbItem Header="BreadcrumbItem 1.1" DropDownHeader="DropDownItem 1.1" />
	        <telerik:RadBreadcrumbItem Header="BreadcrumbItem 1.2" DropDownHeader="DropDownItem 1.2" />
	        <telerik:RadBreadcrumbItem Header="BreadcrumbItem 1.3" DropDownHeader="DropDownItem 1.3" />
	    </telerik:RadBreadcrumbItem>
	    <telerik:RadBreadcrumbItem Header="BreadcrumbItem 2" DropDownHeader="DropDownItem 2">
	        <telerik:RadBreadcrumbItem Header="BreadcrumbItem 2.1" DropDownHeader="DropDownItem 2.1" />
	        <telerik:RadBreadcrumbItem Header="BreadcrumbItem 2.2" DropDownHeader="DropDownItem 2.2" />
	        <telerik:RadBreadcrumbItem Header="BreadcrumbItem 2.3" DropDownHeader="DropDownItem 2.3" />
	    </telerik:RadBreadcrumbItem>
	    <telerik:RadBreadcrumbItem Header="BreadcrumbItem 3" DropDownHeader="DropDownItem 3" />
	</telerik:RadBreadcrumb>
{{endregion}}

#### __[C#] Example 7: Enabling linear mode in code__  
{{region cs-radbreadcrumb-getting-started_9}}
	breadcrumb.IsLinearMode = true;
{{endregion}}

#### __[VB.NET] Example 7: Enabling linear mode in code__  
{{region vb-radbreadcrumb-getting-started_10}}
	breadcrumb.IsLinearMode = True
{{endregion}}

![](images/breadcrumb_gettingstarted_linear_mode.png)

## Change the number of paths saved in the Breadcrumb history

By default the __RadBreadcrumb__ control keeps a history of 10 visited paths. If you want to increase or decrease this number, you can set the __HistorySize__ property:		

#### __[XAML] Example 8: Setting the history size in XAML__  
{{region xaml-radbreadcrumb-getting-started_11}}
	<telerik:RadBreadcrumb Header="Breadcrumb Header" HorizontalAlignment="Stretch"
	        VerticalAlignment="Top" HistorySize="15">
	    ...
	</telerik:RadBreadcrumb>
{{endregion}}

#### __[C#] Example 9: Setting the history size in code__  
{{region cs-radbreadcrumb-getting-started_12}}
	breadcrumb.HistorySize = 15;
{{endregion}}

#### __[VB.NET] Example 9: Setting the history size in code__  
{{region vb-radbreadcrumb-getting-started_13}}
	breadcrumb.HistorySize = 15
{{endregion}}

##  Apply a theme

{% if site.site_name == 'Silverlight' %}Add a reference to Telerik.Windows.Themes.Vista.dll.{% endif %}

#### __[XAML] Example 10: Applying a theme__  
{{region xaml-radbreadcrumb-getting-started_14}}

	<telerik:RadBreadcrumb  VerticalAlignment="Top"
	                        Header="Breadcrumb Header"
	                        telerik:StyleManager.Theme="Vista">
	    <telerik:RadBreadcrumbItem DropDownHeader="DropDownItem 1" Header="BreadcrumbItem 1">
	        <telerik:RadBreadcrumbItem DropDownHeader="DropDownItem 1.1" Header="BreadcrumbItem 1.1" />
	        <telerik:RadBreadcrumbItem DropDownHeader="DropDownItem 1.2" Header="BreadcrumbItem 1.2" />
	        <telerik:RadBreadcrumbItem DropDownHeader="DropDownItem 1.3" Header="BreadcrumbItem 1.3" />
	    </telerik:RadBreadcrumbItem>
	    <telerik:RadBreadcrumbItem DropDownHeader="DropDownItem 2" Header="BreadcrumbItem 2">
	        <telerik:RadBreadcrumbItem DropDownHeader="DropDownItem 2.1" Header="BreadcrumbItem 2.1" />
	        <telerik:RadBreadcrumbItem DropDownHeader="DropDownItem 2.2" Header="BreadcrumbItem 2.2" />
	        <telerik:RadBreadcrumbItem DropDownHeader="DropDownItem 2.3" Header="BreadcrumbItem 2.3" />
	    </telerik:RadBreadcrumbItem>
	    <telerik:RadBreadcrumbItem DropDownHeader="DropDownItem 3" Header="BreadcrumbItem 3" />
	</telerik:RadBreadcrumb>
{{endregion}}

## See Also  
 * [Overview]({%slug radbreadcrumb-overvew%})
 * [Features Overview]({%slug radbreadcrumb-features-overview%})