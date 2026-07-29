---
title: Getting Started
page_title: Getting Started
description: Check our &quot;Getting Started&quot; documentation article for the RadCarousel {{ site.framework_name }} control.
slug: carousel-getting-started
tags: getting,started
published: True
position: 1
---

# Getting Started with {{ site.framework_name }} Carousel

This tutorial will walk you through the creation of a simple application containing **RadCarousel** and will show you how to:

## Assembly References

To use __RadCarousel__, add references to the following assemblies:

* __Telerik.Licensing.Runtime__
* __Telerik.Windows.Controls__
* __Telerik.Windows.Controls.Navigation__
* __Telerik.Windows.Data__

You can find the required assemblies for each control from the suite in the [Controls Dependencies]({%slug installation-installing-controls-dependencies-wpf%}) help article.

>tip With the 2025 Q1 release, the Telerik UI for WPF has a new licensing mechanism. You can learn more about it [here]({%slug installing-license-key%}).

## Adding Telerik Assemblies Using NuGet

To use `__RadCarousel__` when working with NuGet packages, install the `Telerik.Windows.Controls.Navigation.for.Wpf.Xaml` package. The [package name may vary]({%slug nuget-available-packages%}) slightly based on the Telerik dlls set - [Xaml or NoXaml]({%slug xaml-vs-noxaml%})

Read more about NuGet installation in the [Installing UI for WPF from NuGet Package]({%slug nuget-installation%}) article.

## Adding RadCarousel to the Project

__Example 1: Adding RadGridView to application__
<snippet id='radcarousel-carousel-getting-started-example_1_adding_radgridview_to_application-xaml' />

## Binding RadCarousel to a Collection of Custom Objects

For the purpose of this tutorial we will create a new **Employee** class with a couple of properties:

__Example 2: The Employee class__

<snippet id='radcarousel-carousel-getting-started-example_2_the_employee_class-cs' />
<snippet id='radcarousel-carousel-getting-started-example_2_the_employee_class-vb' />


Furthermore, as some data will be needed, we will create **EmployeeService** class that provides a static **GetEmployees()** method:

__Example 3: The EmployeeService class__

<snippet id='radcarousel-carousel-getting-started-example_3_the_employeeservice_class-cs' />
<snippet id='radcarousel-carousel-getting-started-example_3_the_employeeservice_class-vb' />


Once all the data is prepared, we may set the RadCarousel's **ItemsSource**:

__Example 4: Setting RadCarousel's ItemsSource__

<snippet id='radcarousel-carousel-getting-started-example_4_setting_radcarousel_s_itemssource-cs' />
<snippet id='radcarousel-carousel-getting-started-example_4_setting_radcarousel_s_itemssource-vb' />


After running the application, you will see the following result:

#### __Figure 1: RadCarousel displaying a list of employees__

![RadCarousel displaying a list of employees](images/carousel_BoundToCollection.png)

## Display images in RadCarousel

Generally, RadCarousel may be easily used for displaying images and navigating through them. All you need to do is to add those that you want to be visualized in a **List<Image>** for example and set RadCarousel's ItemsSource:

__Example 5: Setting RadCarousel's ItemsSource to a list of images__

<snippet id='radcarousel-carousel-getting-started-example_5_setting_radcarousel_s_itemssource_to_a_list_of_images-cs' />
<snippet id='radcarousel-carousel-getting-started-example_5_setting_radcarousel_s_itemssource_to_a_list_of_images-vb' />


**Figure 2** shows the final result:

#### __Figure 2: RadCarousel displaying a list of images__

![RadCarousel displaying a list of images](images/carousel_DisplayImages.png)

## Setting a Theme

The controls from our suite support different themes. You can see how to apply a theme different than the default one in the [Setting a Theme]({%slug styling-apperance-implicit-styles-overview%}) help article.

>important Changing the theme using implicit styles will affect all controls that have styles defined in the merged resource dictionaries. This is applicable only for the controls in the scope in which the resources are merged. 

To change the theme, you can follow the steps below:

* Choose between the themes and add reference to the corresponding theme assembly (ex: **Telerik.Windows.Themes.Material.dll**). You can see the different themes applied in the **Theming** examples from our [WPF Controls Examples](https://demos.telerik.com/wpf/) application.

* Merge the ResourceDictionaries with the namespace required for the controls that you are using from the theme assembly. For the __RadCarousel__, you will need to merge the following resources:

	* __Telerik.Windows.Controls__
	* __Telerik.Windows.Controls.Navigation__

__Example 2__ demonstrates how to merge the ResourceDictionaries so that they are applied globally for the entire application.

__Example 2: Merge the ResourceDictionaries__  
<snippet id='radcarousel-carousel-getting-started-example_5_setting_radcarousel_s_itemssource_to_a_list_of_images-xaml' />

>Alternatively, you can use the theme of the control via the {% if site.site_name == 'WPF' %}[StyleManager](https://docs.telerik.com/devtools/wpf/styling-and-appearance/stylemanager/common-styling-apperance-setting-theme-wpf){% else %}[StyleManager](https://docs.telerik.com/devtools/silverlight/styling-and-appearance/stylemanager/common-styling-apperance-setting-theme){% endif %}.

__Figure 4__ shows a __RadCarousel__ with the **Material** theme applied.
	
#### __Figure 4: RadCarousel with the Material theme__
![RadCarousel with Material theme](images/radcarousel-setting-theme.png)

{% if site.site_name == 'WPF' %}
## Telerik UI for WPF Learning Resources

* [Telerik UI for WPF Carousel Component](https://www.telerik.com/products/wpf/carousel.aspx)
* [Getting Started with Telerik UI for WPF Components]({%slug getting-started-first-steps%})
* [Telerik UI for WPF Installation]({%slug installation-guide%})
* [Telerik UI for WPF and WinForms Integration]({%slug winforms-integration%})
* [Telerik UI for WPF Visual Studio Templates]({%slug visual-studio-templates%})
* [Setting a Theme with Telerik UI for WPF]({%slug styling-apperance-implicit-styles-overview%})
* [Telerik UI for WPF Virtual Classroom (Training Courses for Registered Users)](https://learn.telerik.com/learn/course/external/view/elearning/16/telerik-ui-for-wpf) 
* [Telerik UI for WPF License Agreement](https://www.telerik.com/purchase/license-agreement/wpf-dlw-s)
{% endif %}

## See Also

* [Data Binding]({%slug carousel-data-binding%})

* [Carousel Properties]({%slug carousel-properties%})

