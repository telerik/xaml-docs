---
title: Getting Started
page_title: Getting Started
description: Check our &quot;Getting Started&quot; documentation article for the RadBreadcrumb {{ site.framework_name }} control.
slug: radbreadcrumb-getting-started
tags: getting,started
published: True
position: 1
---

# {{ site.framework_name }} RadBreadcrumb Getting Started

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

![{{ site.framework_name }} RadBreadcrumb from Code](images/breadcrumb_gettingstarted_breadcrumb.png)

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

![{{ site.framework_name }} RadBreadcrumb Dropdown Items](images/breadcrumb_gettingstarted_breadcrumb_items.png)

In order to remove items from the __RadBreadcrumb__ control, you can remove them from the control's __Items__ collection:

#### __[C#] Example 5: Removing RadBreadcrumbItems__  
{{region cs-radbreadcrumb-getting-started_6}}
	breadcrumb.Items.Remove(item2);
{{endregion}}

#### __[VB.NET] Example 5: Removing RadBreadcrumbItems__  
{{region vb-radbreadcrumb-getting-started_7}}
	breadcrumb.Items.Remove(item2)
{{endregion}}

![{{ site.framework_name }} RadBreadcrumb with Item Removed](images/breadcrumb_gettingstarted_items_remove.png)

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

![{{ site.framework_name }} RadBreadcrumb Linear Mode](images/breadcrumb_gettingstarted_linear_mode.png)

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

## Setting a Theme

The controls from our suite support different themes. You can see how to apply a theme different than the default one in the [Setting a Theme]({%slug styling-apperance-implicit-styles-overview%}) help article.

>important Changing the theme using implicit styles will affect all controls that have styles defined in the merged resource dictionaries. This is applicable only for the controls in the scope in which the resources are merged. 

To change the theme, you can follow the steps below:

* Choose between the themes and add reference to the corresponding theme assembly (ex: **Telerik.Windows.Themes.Fluent.dll**). You can see the different themes applied in the **Theming** examples from our {% if site.site_name == 'WPF' %}[WPF Controls Examples](https://demos.telerik.com/wpf/){% else %}[Silverlight Controls Examples](https://demos.telerik.com/silverlight/#Breadcrumb/Theming){% endif %} application.

* Merge the ResourceDictionaries with the namespace required for the controls that you are using from the theme assembly. For the __RadBreadcrumb__, you will need to merge the following resources:

	* __Telerik.Windows.Controls__
	* __Telerik.Windows.Controls.Navigation__

__Example 2__ demonstrates how to merge the ResourceDictionaries so that they are applied globally for the entire application.

#### __[XAML] Example 2: Merge the ResourceDictionaries__  
{{region xaml-radbreadcrumb-getting-started_1}}
	<Application.Resources>
		<ResourceDictionary>
			<ResourceDictionary.MergedDictionaries>
				<ResourceDictionary Source="/Telerik.Windows.Themes.Fluent;component/Themes/System.Windows.xaml"/>
				<ResourceDictionary Source="/Telerik.Windows.Themes.Fluent;component/Themes/Telerik.Windows.Controls.xaml"/>
				<ResourceDictionary Source="/Telerik.Windows.Themes.Fluent;component/Themes/Telerik.Windows.Controls.Navigation.xaml"/>
			</ResourceDictionary.MergedDictionaries>
		</ResourceDictionary>
	</Application.Resources>
{{endregion}}

>Alternatively, you can use the theme of the control via the {% if site.site_name == 'WPF' %}[StyleManager](https://docs.telerik.com/devtools/wpf/styling-and-appearance/stylemanager/common-styling-apperance-setting-theme-wpf){% else %}[StyleManager](https://docs.telerik.com/devtools/silverlight/styling-and-appearance/stylemanager/common-styling-apperance-setting-theme){% endif %}.

__Figure 2__ shows a __RadBreadcrumb__ with the **Fluent** theme applied.
	
#### __Figure 2: RadBreadcrumb with the Fluent theme__
![RadBreadcrumb with Fluent theme](images/radbreadcrumb-setting-theme.png)

## See Also  
 * [Overview]({%slug radbreadcrumb-overvew%})
 * [Features Overview]({%slug radbreadcrumb-features-overview%})