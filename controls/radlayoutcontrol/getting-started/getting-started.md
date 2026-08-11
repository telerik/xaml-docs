---
title: Getting Started
page_title: Getting Started
description: Check out our tutorial that will walk you through the creation of a sample application containing RadLayoutControl.
slug: radlayoutcontrol-getting-started
tags: getting, started, tutorial
published: True
position: 1
---

# Getting Started with {{ site.framework_name }} LayoutControl

This tutorial will walk you through the creation of a sample application that contains __RadLayoutControl__.

* [Adding Telerik Assemblies Using NuGet](#adding-telerik-assemblies-using-nuget)
* [Adding Assembly References Manually](#adding-assembly-references-manually)
* [Defining a RadLayoutControl](#defining-a-radlayoutcontrol)
* [Adding Items in the Control](#adding-items-in-the-control)
* [Layout Groups](#layout-groups)
* [Enable Edit Mode](#enable-edit-mode)
* [Code Example](#code-example)

> The figures in the RadLayoutControl help documentation are showing the control with the __Windows8 theme__ applied. You can see how to set a theme in the [Setting a Theme]({%slug styling-apperance-implicit-styles-overview%}) help article.

## Adding Telerik Assemblies Using NuGet

To use __RadLayoutControl__ when working with NuGet packages, install the `Telerik.Windows.Controls.Navigation.for.Wpf.Xaml` package. The [package name may vary]({%slug nuget-available-packages%}) slightly based on the Telerik dlls set - [Xaml or NoXaml]({%slug xaml-vs-noxaml%})

Read more about NuGet installation in the [Installing UI for WPF from NuGet Package]({%slug nuget-installation%}) article.

>tip With the 2025 Q1 release, the Telerik UI for WPF has a new licensing mechanism. You can learn more about it [here]({%slug installing-license-key%}).

## Adding Assembly References Manually

If you are not using NuGet packages, you can add a reference to the following assemblies:

* __Telerik.Licensing.Runtime__
* __Telerik.Windows.Controls__
* __Telerik.Windows.Controls.Navigation__

You can find a list with the required assemblies for each control from the UI for WPF suite in the [Controls Dependencies]({%slug installation-installing-controls-dependencies-wpf%}) help article.

## Defining a RadLayoutControl

You can add __RadLayoutControl__ manually in XAML as demonstrated in __Example 1__. 

__Example 1: Adding RadLayoutControl in XAML__
<snippet id='radlayoutcontrol-getting-started-getting-started-example_1_adding_radlayoutcontrol_in_xaml-xaml' />

	
__RadLayoutControl__ doesn't display any content when it is not populated with items or layout groups, so at this point only the border of the control should be displayed on the screen.

#### __Figure 1: Empty RadLayoutControl__
![{{ site.framework_name }} RadLayoutControl Empty RadLayoutControl](images/layoutcontrol-getting-started-01.png)

## Adding Items in the Control

You can add items through the __Items__ collection of RadLayoutControl. The layout component works with __LayoutControlGroup__ controls and __UIElements__. In other words you can populate it with all visual elements provided by the framework. __Example 2__ demonstrates this.

__Example 2: Adding items in the RadLayoutControl.__
<snippet id='radlayoutcontrol-getting-started-getting-started-example_2_adding_items_in_the_radlayoutcontrol-xaml' />


#### __Figure 2: RadLayoutControl with few elements added__
![{{ site.framework_name }} RadLayoutControl RadLayoutControl with few elements added](images/layoutcontrol-getting-started-02.png)

> By default the layout control and its groups are ordering their items with __horizontal orientation__. You can see how to change this in the [Orientation]({%slug radlayoutcontrol-features-orientation%}) help article.

You can nest LayoutControlGroups into one another which allows you to separate the layout into different groups that can be arranged along with their items.

__Example 3: Nesting LayoutControlGroups__
<snippet id='radlayoutcontrol-getting-started-getting-started-example_3_nesting_layoutcontrolgroups-xaml' />


#### __Figure 3: RadLayoutControl with nested groups__
![{{ site.framework_name }} RadLayoutControl RadLayoutControl with nested groups](images/layoutcontrol-getting-started-03.png)

>important RadLayoutControl doesn't support data binding and setting its ItemsSource property will throw an exception (NotSupportedException).

## Layout Groups

There are few layout group controls which can be used with __RadLayoutControl__. Each group has different appearance. You can read more about this in the [Layout Groups]({%slug radlayoutcontrol-features-layoutgroups-overview%}) section in the documentation. Additionally, the [Code Example](#code-example) section of this help article demonstrates the different layout groups.

## ScrollViewer Root Element

The RadLayoutControl and its groups wrap their content in a ScrollViewer. The ScrollViewer control measures its children with infinity. This behavior disables the virtualization of all controls placed inside. You can easily disable the ScrollViewer functionality and delegate the scrolling to the child framework element inside. To do that you can set the __ScrollViewer.VerticalScrollBarVisibility__ / __ScrollViewer.HorizontalScrollBarVisibility__ attached properties to the RadLayoutControl and to the groups you want this property applied.

## Enable Edit Mode

The control allows you to rearrange its children at runtime. To enable this the __IsInEditMode__ property of the control should be set to __True__.

__Example 4: Enabling the edit mode of the control__
<snippet id='radlayoutcontrol-getting-started-getting-started-example_4_enabling_the_edit_mode_of_the_control-xaml' />

	
#### __Figure 4: The layout setup from Example 3 with one of the groups selected.__
![{{ site.framework_name }} RadLayoutControl The layout setup from Example 3 with one of the groups selected.](images/layoutcontrol-getting-started-04.png)

> Read more about the edit mode in the [Edit the Layout]({%slug radlayoutcontrol-edit-the-layout%}) article.

## Code Example

This section demonstrates a basic layout set up with nested groups and different group types.

__Example 5: Complete code example__
<snippet id='radlayoutcontrol-getting-started-getting-started-example_5_complete_code_example-xaml' />


#### __Figure 5: RadLayoutPanel example__  
![{{ site.framework_name }} RadLayoutControl RadLayoutPanel example](images/layoutcontrol-getting-started-05.png)

> You can switch between normal and edit mode of the control by setting its __IsInEditMode__ property.

## Setting a Theme

The controls from our suite support different themes. You can see how to apply a theme different than the default one in the [Setting a Theme]({%slug styling-apperance-implicit-styles-overview%}) help article.

>important Changing the theme using implicit styles will affect all controls that have styles defined in the merged resource dictionaries. This is applicable only for the controls in the scope in which the resources are merged. 

To change the theme, you can follow the steps below:

* Choose between the themes and add reference to the corresponding theme assembly (ex: **Telerik.Windows.Themes.Windows8.dll**). You can see the different themes applied in the **Theming** examples from our [WPF Controls Examples](https://demos.telerik.com/wpf/) application.

* Merge the ResourceDictionaries with the namespace required for the controls that you are using from the theme assembly. For the __RadLayoutControl__, you will need to merge the following resources:

	* __Telerik.Windows.Controls__
	* __Telerik.Windows.Controls.Navigation__

__Example 6__ demonstrates how to merge the ResourceDictionaries so that they are applied globally for the entire application.

__Example 6: Merge the ResourceDictionaries__  
<snippet id='radlayoutcontrol-getting-started-getting-started-example_6_merge_the_resourcedictionaries-xaml' />


>Alternatively, you can use the theme of the control via the {% if site.site_name == 'WPF' %}[StyleManager](https://docs.telerik.com/devtools/wpf/styling-and-appearance/stylemanager/common-styling-apperance-setting-theme-wpf){% else %}[StyleManager](https://docs.telerik.com/devtools/silverlight/styling-and-appearance/stylemanager/common-styling-apperance-setting-theme){% endif %}.

__Figure 7__ shows a __RadLayoutControl__ with the **Windows8** theme applied.

#### __Figure 7: RadLayoutControl with the Windows8 theme__
![RadLayoutControl with Windows8 theme](images/radlayoutcontrol-setting-theme.png)

{% if site.site_name == 'WPF' %}
## Telerik UI for WPF Learning Resources

* [Telerik UI for WPF LayoutControl Component](https://www.telerik.com/products/wpf/layoutcontrol.aspx)
* [Getting Started with Telerik UI for WPF Components]({%slug getting-started-first-steps%})
* [Telerik UI for WPF Installation]({%slug installation-guide%})
* [Telerik UI for WPF and WinForms Integration]({%slug winforms-integration%})
* [Telerik UI for WPF Visual Studio Templates]({%slug visual-studio-templates%})
* [Setting a Theme with Telerik UI for WPF]({%slug styling-apperance-implicit-styles-overview%})
* [Telerik UI for WPF Virtual Classroom (Training Courses for Registered Users)](https://learn.telerik.com/learn/course/external/view/elearning/16/telerik-ui-for-wpf) 
* [Telerik UI for WPF License Agreement](https://www.telerik.com/purchase/license-agreement/wpf-dlw-s)
{% endif %}

## See Also
* [Overview]({%slug radlayoutcontrol-overview%})
* [Layout Groups]({%slug radlayoutcontrol-features-layoutgroups-overview%})
* [Layout Panel]({%slug radlayoutcontrol-getting-started-layoutpanel%})
* [Orientation]({%slug radlayoutcontrol-features-orientation%})
* [Edit the Layout]({%slug radlayoutcontrol-edit-the-layout%})

