---
title: Getting Started
page_title: Getting Started
description: Check our &quot;Getting Started&quot; documentation article for the RadExpressionEditor {{ site.framework_name }} control.
slug: radexpressioneditor-getting-started
tags: getting,started
published: True
position: 2
---

# Getting Started with {{ site.framework_name }} ExpressionEditor

This tutorial will walk your through the creation of a sample application containing __RadExpressionEditor__ and will show you how to: 

* Use __RadExpressionEditor__ in your project;

* Utilize __RadExpressionEditor__ with other controls.

## Adding Telerik Assemblies Using NuGet

To use __RadExpressionEditor__ when working with NuGet packages, install the `Telerik.Windows.Controls.Expressions.for.Wpf.Xaml` package. The [package name may vary]({%slug nuget-available-packages%}) slightly based on the Telerik dlls set - [Xaml or NoXaml]({%slug xaml-vs-noxaml%})

Read more about NuGet installation in the [Installing UI for WPF from NuGet Package]({%slug nuget-installation%}) article.

>tip With the 2025 Q1 release, the Telerik UI for WPF has a new licensing mechanism. You can learn more about it [here]({%slug installing-license-key%}).

## Adding Assembly References Manually

If you are not using NuGet packages, you can add a reference to the following assemblies:

* __Telerik.Licensing.Runtime__
* __Telerik.Windows.Controls__
* __Telerik.Windows.Controls.Data__
* __Telerik.Windows.Controls.Input__
* __Telerik.Windows.Controls.Expressions__
* __Telerik.Windows.Controls.Navigation__
* __Telerik.Windows.Data__
* __Telerik.Windows.Documents__
* __Telerik.Windows.Documents.Core__
* __Telerik.Windows.Documents.Flow__

You can find the required assemblies for each control from the suite in the [Controls Dependencies]({%slug installation-installing-controls-dependencies-wpf%}) help article.

## Adding RadExpressionEditor to the project

* Create a new project;

>important If you are using **{{ site.minimum_net_core_version }}** and later, please note that instead of the **Telerik.Windows.Documents.dll** you need to use the new **Telerik.Windows.Controls.RichTextBox.dll** assembly.

>In case you use [Implicit Styles]({%slug styling-apperance-implicit-styles-overview%}), please make sure all the needed resource dictionaries are merged:  
* System.Windows.xaml
* Telerik.Windows.Controls.xaml
* Telerik.Windows.Controls.Expressions.xaml
* Telerik.Windows.Controls.Navigation.xaml
* Telerik.Windows.Documents.xaml

* Define __RadExpressionEditor__ as demonstrated below:

__Example 1__
<snippet id='radexpressioneditor-getting-started-example_1-xaml' />


Now, when running the application, __RadExpressionEditor__ will be displayed:

![{{ site.framework_name }} RadExpressionEditor Initial Layout](images/RadExpressionEditor_GettingStarted.png)

## Binding RadExpressionEditor

The scenario we will try to create here would be to implement __RadExpressionEditor__ as an advanced manual filter for __RadGridView__. For that purpose, we will firstly create a new class __Employee__ with a couple of exposed properties and a method creating sample data:

__Example 2__

<snippet id='radexpressioneditor-getting-started-example_2-cs' />

<snippet id='radexpressioneditor-getting-started-example_2-vb' />


In our case we will create a simple __ViewModel__ taking care for the connection between the model and view. It will be set as __DataContext__ of the application.

__Example 3__

<snippet id='radexpressioneditor-getting-started-example_3-cs' />

<snippet id='radexpressioneditor-getting-started-example_3-vb' />


Once we declared the business object and the corresponding __ViewModel__, we can define __RadExpressionEditor__ and bind it appropriately. 

__Example 4__

<snippet id='radexpressioneditor-getting-started-example_4-xaml' />


The functionality for defining a filter for __RadGridView__ will be implemented in the handler of __ExpressionChanged__ event:  

__Example 5__

<snippet id='radexpressioneditor-getting-started-example_5-cs' />

<snippet id='radexpressioneditor-getting-started-example_5-vb' />


On running the application and testing the functionality of adding a filter descriptor for __RadGridView__, you should see a similar result:

![{{ site.framework_name }} RadExpressionEditor and RadGridView](images/RadExpressionEditor_GettingStarted2.png)![{{ site.framework_name }} RadExpressionEditor Filtering RadGridView](images/RadExpressionEditor_GettingStarted3.png)

Still, using the __Calculation Panel__ and the items in each __Category__, you are empowered to create far more complex filtering expressions.  

>You can access ExpressionEditor.Expression.Type.

>__RadExpressionEditor__ provides support for dynamic objects with __ICustomTypeProvider__ or __ICustomTypeDescriptor__ implementation. It will scan the object's properties and show them in the __Fields list__.

## Customizing the editor

You can edit the [template of the control]({%slug radexpressioneditor-styles-and-templates-templates-structure%}), extend its default editor and use your custom version of it to serve your requirements. The default editor for the ExpressionEditor is an __ExpressionTextBox__. 

## Pasting
     
By default pasting in the editor is not supported. This is the behavior as the inner ExpressionTextBox is configured to not accept returns. You can resolve this with the following approach ensuring the pasting will be executed in code:

__Example 7__
<snippet id='radexpressioneditor-getting-started-example_7-cs' />


## Setting a Theme

The controls from our suite support different themes. You can see how to apply a theme different than the default one in the [Setting a Theme]({%slug styling-apperance-implicit-styles-overview%}) help article.

>important Changing the theme using implicit styles will affect all controls that have styles defined in the merged resource dictionaries. This is applicable only for the controls in the scope in which the resources are merged. 

To change the theme, you can follow the steps below:

* Choose between the themes and add reference to the corresponding theme assembly (ex: **Telerik.Windows.Themes.Windows8.dll**). You can see the different themes applied in the **Theming** examples from our [WPF Controls Examples](https://demos.telerik.com/wpf/) application.

* Merge the ResourceDictionaries with the namespace required for the controls that you are using from the theme assembly. For the __RadExpressionEditor__, you will need to merge the following resources:

	* __System.Windows.xaml__
	* __Telerik.Windows.Controls.xaml__
	* __Telerik.Windows.Controls.Expressions.xaml__
	* __Telerik.Windows.Controls.Navigation.xaml__
	* __Telerik.Windows.Documents.xaml__

__Example 8__ demonstrates how to merge the ResourceDictionaries so that they are applied globally for the entire application.

__Example 8: Merge the ResourceDictionaries__  
<snippet id='radexpressioneditor-getting-started-example_8_merge_the_resourcedictionaries-xaml' />


>Alternatively, you can use the theme of the control via the [StyleManager](https://docs.telerik.com/devtools/wpf/styling-and-appearance/stylemanager/common-styling-apperance-setting-theme-wpf)

__Figure 14__ shows a __RadExpressionEditor__ with the **Windows8** theme applied.

#### __Figure 14: RadExpressionEditor with the Windows8 theme__
![RadExpressionEditor with Windows8 theme](images/radexpressionEditor-setting-theme.png)

## Telerik UI for WPF Learning Resources

* [Telerik UI for WPF ExpressionEditor Component](https://www.telerik.com/products/wpf/expressioneditor.aspx)
* [Getting Started with Telerik UI for WPF Components]({%slug getting-started-first-steps%})
* [Telerik UI for WPF Installation]({%slug installation-guide%})
* [Telerik UI for WPF and WinForms Integration]({%slug winforms-integration%})
* [Telerik UI for WPF Visual Studio Templates]({%slug visual-studio-templates%})
* [Setting a Theme with Telerik UI for WPF]({%slug styling-apperance-implicit-styles-overview%})
* [Telerik UI for WPF Virtual Classroom (Training Courses for Registered Users)](https://learn.telerik.com/learn/course/external/view/elearning/16/telerik-ui-for-wpf) 
* [Telerik UI for WPF License Agreement](https://www.telerik.com/purchase/license-agreement/wpf-dlw-s)

