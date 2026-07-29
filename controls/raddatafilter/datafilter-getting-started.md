---
title: Getting Started
page_title: Getting Started
description: Check our &quot;Getting Started&quot; documentation article for the RadDataFilter {{ site.framework_name }} control.
slug: datafilter-getting-started
tags: getting,started
published: True
position: 3
---

# Getting Started with {{ site.framework_name }} DataFilter

__RadDataFilter__ is a control that allows you to filter your data. It allows you to create complex filter criteria within unlimited number of filter conditions combined by logical operators. You can easily add nested filter criteria by clicking on the button for adding nested operators. This topic will help you to quickly get started using this control. It will focus on the following:

* [Adding RadDataFilter](#adding-raddatafilter)

* [Configuring the RadDataFilter](#configuring-the-raddatafilter)

* [Filtering a Collection](#filtering-a-collection)

* [Filtering a RadGridView](#filter-radgridview)

* [Exposing the Filtered Collection](#exposing-the-filtered-collection)

## Adding Telerik Assemblies Using NuGet

To use __RadDataFilter__ when working with NuGet packages, install the `Telerik.Windows.Controls.Data.for.Wpf.Xaml` package. The [package name may vary]({%slug nuget-available-packages%}) slightly based on the Telerik dlls set - [Xaml or NoXaml]({%slug xaml-vs-noxaml%})

Read more about NuGet installation in the [Installing UI for WPF from NuGet Package]({%slug nuget-installation%}) article.

>tip With the 2025 Q1 release, the Telerik UI for WPF has a new licensing mechanism. You can learn more about it [here]({%slug installing-license-key%}).

## Adding Assembly References Manually

If you are not using NuGet packages, you can add a reference to the following assemblies:

* __Telerik.Licensing.Runtime__
* __Telerik.Windows.Controls__
* __Telerik.Windows.Controls.Data__
* __Telerik.Windows.Data__

You can find the required assemblies for each control from the suite in the {% if site.site_name == 'Silverlight' %}[Controls Dependencies]({%slug installation-installing-controls-dependencies%}){% else %}[Controls Dependencies]({%slug installation-installing-controls-dependencies-wpf%}){% endif %} help article.

## Adding RadDataFilter

To use the __RadDataFilter__ in the XAML you have to add the following namespace declaration:

__Example 1: Namespace declaration__  
<snippet id='raddatafilter-datafilter-getting-started-example_1_namespace_declaration-xaml' />


__Example 2: Creating RadDataFilter__  
<snippet id='raddatafilter-datafilter-getting-started-example_2_creating_raddatafilter-xaml' />


## Configuring the RadDataFilter

You can configure __RadDataFilter__ via the properties that it exposes. You can do the following:

* Use __DataAnotations__ to mark the members of your business objects. [Read more]({%slug raddatafilter-features-data-annotations%})

* Use the __RadDataFilter__ in __Unbound Mode__. [Read more]({%slug raddatafilter-features-unbound-mode%})

* Access the __FilterDescriptors__ collection. [Read more]({%slug raddatafilter-features-filter-descriptors%})

## Filtering a Collection

> To learn more about the usage of the __Source__ and the __FilteredSource__ properties, read the [Source and Filtered Source]({%slug raddatafilter-features-source-and-filtered-source%}) article.

__RadDataFilter__ can filter any collection that implements the __IEnumerable__ interface. The only thing that you have to do is to pass the collection to its __Source__ property.

The collection in this example will hold business objects of type __Employee__. Here is the code for the __Employee__ class:

__Example 3: Defining the Employee class__  
<snippet id='raddatafilter-datafilter-getting-started-example_3_defining_the_employee_class-cs' />

<snippet id='raddatafilter-datafilter-getting-started-example_3_defining_the_employee_class-vb' />


__Example 4: Creating RadDataFilter__ 
<snippet id='raddatafilter-datafilter-getting-started-example_4_creating_raddatafilter-xaml' />


Prepare a simple collection of employees and pass it to the __Source__ property of the __RadDataFilter__.

__Example 5: Creating a collection of Employees__

<snippet id='raddatafilter-datafilter-getting-started-example_5_creating_a_collection_of_employees-cs' />

<snippet id='raddatafilter-datafilter-getting-started-example_5_creating_a_collection_of_employees-vb' />


After the collection has been passed to the __Source__ property, the user will be able to filter it via the __RadDataFilter__'s UI. In order to learn how to access the filtered collection, please read the next section.

## Filter RadGridView

__RadGridView__ can be filtered through its __RadGridView.Items__ collection. The __Employees__ collection in this example holds business objects of type Employee and needs to be defined in the DataContext of the __LayoutRoot Grid__. You then need to pass it to the __ItemsSource__ property of __RadGridView__. After that, you can create your __RadDataFilter__ and bind its __RadDataFilter.Source__ property to the __RadGridView.Items__ collection using an __ElementName__ binding.        

__Example 6: Binding the RadDataFilter to the Items collection of the RadGridView__
<snippet id='raddatafilter-datafilter-getting-started-example_6_binding_the_raddatafilter_to_the_items_collection_of_the_radgridview-xaml' />


![{{ site.framework_name }} RadDataFilter Bound to the Items collection of RadGridView](images/RadDataFilter_GettingStarted_01.png)

>You __can't use__ both RadDataFilter and RadGridView's __built in filtering__  because they are automatically synchronized with each other.          

## Exposing the Filtered Collection

The filtered collection inside the __RadDataFilter__ can be accessed via the __FilteredSource__ property. It exposes this set of data matching to the current filter criteria. Here is an example of a __ListBox__ that displays the data filtered by the __RadDataFilter__.

__Example 7: Filtering data in a ListBox__  
<snippet id='raddatafilter-datafilter-getting-started-example_7_filtering_data_in_a_listbox-xaml' />


![Rad Data Filter raddatafilter gettingstarted 02](images/RadDataFilter_raddatafilter_gettingstarted_03.png)

## Setting a Theme

The controls from our suite support different themes. You can see how to apply a theme different than the default one in the [Setting a Theme]({%slug styling-apperance-implicit-styles-overview%}) help article.

>important Changing the theme using implicit styles will affect all controls that have styles defined in the merged resource dictionaries. This is applicable only for the controls in the scope in which the resources are merged. 

To change the theme, you can follow the steps below:

* Choose between the themes and add reference to the corresponding theme assembly (ex: **Telerik.Windows.Themes.Windows8.dll**). You can see the different themes applied in the **Theming** examples from our {% if site.site_name == 'WPF' %}[WPF Controls Examples](https://demos.telerik.com/wpf/){% else %}[Silverlight Controls Examples](https://demos.telerik.com/silverlight/#DataFilter/Theming){% endif %} application.

* Merge the ResourceDictionaries with the namespace required for the controls that you are using from the theme assembly. For the __RadDataFilter__, you will need to merge the following resources:

	* __Telerik.Windows.Controls__
	* __Telerik.Windows.Controls.Data__

__Example 8__ demonstrates how to merge the ResourceDictionaries so that they are applied globally for the entire application.

__Example 8: Merge the ResourceDictionaries__  
<snippet id='raddatafilter-datafilter-getting-started-example_8_merge_the_resourcedictionaries-xaml' />


>Alternatively, you can use the theme of the control via the [StyleManager](https://docs.telerik.com/devtools/wpf/styling-and-appearance/stylemanager/common-styling-apperance-setting-theme-wpf).

__Figure 2__ shows a __RadDataFilter__ with the **Windows8** theme applied.
	
#### __Figure 2: RadDataFilter with the Windows8 theme__
![RadDataFilter with Windows8 theme](images/raddatafilter-setting-theme.png)

{% if site.site_name == 'WPF' %}
## Telerik UI for WPF Learning Resources

* [Telerik UI for WPF DataFilter Component](https://www.telerik.com/products/wpf/datafilter.aspx)
* [Getting Started with Telerik UI for WPF Components]({%slug getting-started-first-steps%})
* [Telerik UI for WPF Installation]({%slug installation-guide%})
* [Telerik UI for WPF and WinForms Integration]({%slug winforms-integration%})
* [Telerik UI for WPF Visual Studio Templates]({%slug visual-studio-templates%})
* [Setting a Theme with Telerik UI for WPF]({%slug styling-apperance-implicit-styles-overview%})
* [Telerik UI for WPF Virtual Classroom (Training Courses for Registered Users)](https://learn.telerik.com/learn/course/external/view/elearning/16/telerik-ui-for-wpf) 
* [Telerik UI for WPF License Agreement](https://www.telerik.com/purchase/license-agreement/wpf-dlw-s)
{% endif %}

## See Also
 * [Visual Structure]({%slug raddatafilter-visual-structure%})
 * [End User Manual]({%slug datafilter-end-user-manual%})
 * [Styles and Templates - Overview]({%slug raddatafilter-styles-and-templates-overview%})

