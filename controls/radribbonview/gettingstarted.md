---
title: Getting Started
page_title: Getting Started
description: Check our &quot;Getting Started&quot; documentation article for the RadRibbonView WPF control.
slug: radribbonview-gettingstarted
tags: getting,started
published: True
position: 1
---

# Getting Started with WPF RibbonView

This tutorial will walk you through the creation of a sample application that contains `RadRibbonView`.

>important Before reading this tutorial you should get familiar with the [visual]({%slug radribbonview-visual-structure%}) and [functional]({%slug radribbonview-functional-structure%}) structure of the control.

* [Adding Telerik Assemblies Using NuGet](#adding-telerik-assemblies-using-nuget)
* [Adding Assembly References Manually](#adding-assembly-references-manually)
* [Defining a RadRibbonView](#defining-a-radribbonview)
* [Adding Ribbon Tabs](#adding-ribbon-tabs)
* [Adding Content in the Ribbon Tabs](#adding-content-in-the-ribbon-tabs)
* [Resizing](#resizing)
* [Setting up the Application Button Icon](#setting-up-the-application-button-icon)
* [Setting up the Application Title and Name](#setting-up-the-application-title-and-name)
* [Setting up the Ribbon Backstage](#setting-up-the-ribbon-backstage)
* [Setting up the Quick Access Toolbar](#setting-up-the-quick-access-toolbar)
* [Code Example](#code-example)

## Adding Telerik Assemblies Using NuGet

To use __RadRibbonView__ when working with NuGet packages, install the `Telerik.Windows.Controls.RibbonView.for.Wpf.Xaml` package. The [package name may vary]({%slug nuget-available-packages%}) slightly based on the Telerik dlls set - [Xaml or NoXaml]({%slug xaml-vs-noxaml%})

Read more about NuGet installation in the [Installing UI for WPF from NuGet Package]({%slug nuget-installation%}) article.

>tip With the 2025 Q1 release, the Telerik UI for WPF has a new licensing mechanism. You can learn more about it [here]({%slug installing-license-key%}).

## Adding Assembly References Manually

If you are not using NuGet packages, you can add a reference to the following assemblies:

* __Telerik.Licensing.Runtime__
* __Telerik.Windows.Controls__
* __Telerik.Windows.Controls.Input__
* __Telerik.Windows.Controls.Navigation__
* __Telerik.Windows.Controls.RibbonView__
* __Telerik.Windows.Data__

## Defining a RadRibbonView

You can add a RadRibbonView manually in XAML as demonstrated in the following example:

__Adding a RadRibbonView in XAML__
<snippet id='radribbonview-gettingstarted-block_1-xaml' />
	
At this state, the ribbonview is empty - there are not tabs, backstage or any other ribbon components. You can learn about the controls that the RadRibbonView can contain from the [Features]({%slug radribbonview-ribbon-tab%}) section of the documentation.

__Empty RadRibbonView__

![WPF RadRibbonView Empty RadRibbonView](images/ribbonview-getting-started-01.png)

## Adding Ribbon Tabs

The RadRibbonView helps users to quickly find the tools and options they need in order to complete a task. Tools and options are organized in logical groups that are collected together under specific tabs. The ribbon tabs allows you to categorize the commands to be displayed to the users. The class that represents the ribbon tab is the [RadRibbonTab]({%slug radribbonview-ribbon-tab%}).

>tip You can also use contextual tabs. You can read more about this in the [Contextual Tabs]({%slug radribbonview-contextual-tabs%}) topic.

The tabs can be added in the `Items` collection of RadRibbonView. The RadRibbonTab class exposes the `Header` property that is used to define the content of its header. 

The next examples demonstrate how to do this in XAML and code-behind:

__Adding RadRibbonTabs in XAML__  
<snippet id='radribbonview-gettingstarted-block_2-xaml' />
	
__Adding RadRibbonTabs in code__
<snippet id='radribbonview-gettingstarted-block_3-cs' />
<snippet id='radribbonview-gettingstarted-block_4-vb' />

__RadRibbonView with several RadRibbonTabs defined in its Items collection__

![WPF RadRibbonView RadRibbonView with several RadRibbonTabs defined in its Items collection](images/ribbonview-getting-started-02.png)

## Adding Content in the Ribbon Tabs

RadRibbonTab is a `HeaderedItemsControl`, which means that it can contain a collection of items. The children of the ribbon tab should be objects of type `RadRibbonGroup`. They expose a Header property that is used to define the content of their header.

__Adding RadRibbonGroups__
<snippet id='radribbonview-gettingstarted-block_5-xaml' />

#### __A RadRibbonTab with a couple RadRibbonGroups defined in its Items collection__

![WPF RadRibbonView A RadRibbonTab with a couple RadRibbonGroups defined in its Items collection](images/ribbonview-getting-started-03.png)

The RadRibbonGroup element is also a HeaderedItemsControl and it can have child elements on its own.

__Adding RadRibbonGroup content__
<snippet id='radribbonview-gettingstarted-block_6-xaml' />

__A RadRibbonGroup with a couple ribbon buttons defined in its Items collection__

![WPF RadRibbonView A RadRibbonGroup with a couple ribbon buttons defined in its Items collection](images/ribbonview-getting-started-04.png)

>important The Items collection of RadRibbonTab can contain any UIElement. However, if you do not wrap it manually into a RadRibbonGroup control, the ribbonview will do it automatically.

>tip You can find more information about RadRibbonGroup in the [Ribbon Group]({%slug radribbonview-ribbon-group%}) help article.

## Resizing

One of the most important features of RadRibbonView is the dynamic layout resizing. It refers to the RadRibbonView's ability to optimize its layout depending on how much space is available. This process can't be automated; however, the RadRibbonView's API gives you the ability to specify how you would like the resizing to occur. 

Check out the following topics, which are tightly connected to the resizing behavior:  

* [Resizing]({%slug radribbonview-resizing%})
* [Ordered Wrap Panel]({%slug radribbonview-ordered-wrap-panel%})
* [Collapsible Panel]({%slug radribbonview-collapsible-panel%})
	
## Setting up the Application Button Icon

You can se the icon of the ribbonview's application button through the `ApplicationButtonImageSource` property, which is of type `ImageSource`.

__Setting the RadRibbonView application button image source in XAML__
<snippet id='radribbonview-gettingstarted-block_7-xaml' />
	
__Setting the RadRibbonView application button image source in code__
<snippet id='radribbonview-gettingstarted-block_8-cs' />
<snippet id='radribbonview-gettingstarted-block_9-vb' />

__RadRibbonView application button image__

![WPF RadRibbonView RadRibbonView application button image](images/ribbonview-getting-started-05.png)

## Setting up the Application Title and Name

The header displayed at the title bar of RadRibbonView is constructed by its `Title` and `ApplicationName` properties with a dash separator between them. You can take a peek at the [Visual Structure]({%slug radribbonview-visual-structure%}) article to see how it looks.

__Setting the RadRibbonView application title and name__
<snippet id='radribbonview-gettingstarted-block_10-xaml' />

__Title and ApplicationName properties reflected in the UI__

![WPF RadRibbonView Title and ApplicationName properties reflected in the UI](images/ribbonview-getting-started-06.png)

>important You can also see the [Change Title]({%slug radribbonview-howto-change-title%}) and [Hide the Title]({%slug radribbonview-howto-hide-title%}) help articles.

## Setting the Color of the Title

The RadRibbonView control exposes the `TitleBarBackground` property that will allow you to customize the color of the control's title.

__Setting the color of the RadRibbonView's title__
<snippet id='radribbonview-gettingstarted-block_11-xaml' />

__RadRibbonView with a different color set to the title__

![WPF RadRibbonView with a different color set to the title](images/ribbonview-getting-started-10.png)

## Setting up the Ribbon Backstage

The __backstage menu__ is equivalent to the __File__ menu of the traditional menu UIs. It is represented by the rectangular button (the __application button__) in the upper-left corner of the RadRibbonView control. The backstage menu appears when a user clicks the application button. This menu can be used to display controls used to perform actions on the entire document like save, print and send.

To declare a backstage menu in RadRibbonView you can set its `Backstage` property to an object of type `RadRibbonBackstage`. 

__Sample backstage definition with several child RadRibbonBackstageItems in its Items collection.__
<snippet id='radribbonview-gettingstarted-block_12-xaml' />

__RadRibbon Backstage example__

![WPF RadRibbonView RadRibbon Backstage example](images/ribbonview-getting-started-07.png)

>tip You can learn more about the backstage control in the [Ribbon Backstage]({%slug radribbonview-ribbon-backstage%}) help article. 

## Setting up the Quick Access Toolbar

The Quick Access Toolbar is used to render a set of RadRibbonView controls (commands) that are most commonly used in the application. It is rendered right above the ApplicationButton to make it easily accessible to users. To declare the Quick Access ToolBar, you need to set the `QuickAccessToolBar` property. 

__Sample setup of QuickAccessToolBar__
<snippet id='radribbonview-gettingstarted-block_13-xaml' />

__QuickAccessToolBar visualization with one of its buttons hovered__  

![WPF RadRibbonView QuickAccessToolBar Hovered Button](images/ribbonview-getting-started-08.png)

>tip For more information and a practical example you can see the [Quick Access Toolbar]({%slug radribbonview-qat%}) topic.  

## Code Example

This section contains all features demonstrated in the article assembled into a single example.

__Complete code example__
<snippet id='radribbonview-gettingstarted-block_14-xaml' />

__RadRibbonView example__  

![WPF RadRibbonView RadRibbonView example](images/ribbonview-getting-started-09.png)

## Setting a Theme

The controls from our suite support different themes. You can see how to apply a theme different than the default one in the [Setting a Theme]({%slug styling-apperance-implicit-styles-overview%}) help article.

>important Changing the theme using implicit styles will affect all controls that have styles defined in the merged resource dictionaries. This is applicable only for the controls in the scope in which the resources are merged. 

To change the theme, you can follow the steps below:

* Choose between the themes and add reference to the corresponding theme assembly (ex: **Telerik.Windows.Themes.Windows8.dll**). You can see the different themes applied in the **Theming** examples from our [WPF Controls Examples](https://demos.telerik.com/wpf/) application.

* Merge the ResourceDictionaries with the namespace required for the controls that you are using from the theme assembly. For the RadRibbonView, you will need to merge the following resources:

	* __Telerik.Windows.Controls__
	* __Telerik.Windows.Controls.Input__
	* __Telerik.Windows.Controls.Navigation__
	* __Telerik.Windows.Controls.RibbonView__

The following example demonstrates how to merge the ResourceDictionaries so that they are applied globally for the entire application.

__Merge the ResourceDictionaries__  
<snippet id='radribbonview-gettingstarted-block_15-xaml' />

>Alternatively, you can use the theme of the control via the [StyleManager]({%slug styling-apperance-implicit-styles-overview%}#setting-a-theme-using-stylemanager) theming approach.

__RadRibbonView with the Windows8 theme__

![WPF RadRibbonView with Windows8 theme](images/radribbonView-setting-theme.png)  

## Telerik UI for WPF Learning Resources

* [Telerik UI for WPF RibbonView Component](https://www.telerik.com/products/wpf/ribbonview.aspx)
* [Getting Started with Telerik UI for WPF Components]({%slug getting-started-first-steps%})
* [Telerik UI for WPF Installation]({%slug installation-guide%})
* [Telerik UI for WPF and WinForms Integration]({%slug winforms-integration%})
* [Telerik UI for WPF Visual Studio Templates]({%slug visual-studio-templates%})
* [Setting a Theme with Telerik UI for WPF]({%slug styling-apperance-implicit-styles-overview%})
* [Telerik UI for WPF Virtual Classroom (Training Courses for Registered Users)](https://learn.telerik.com/learn/course/external/view/elearning/16/telerik-ui-for-wpf) 
* [Telerik UI for WPF License Agreement](https://www.telerik.com/purchase/license-agreement/wpf-dlw-s)

## See Also
 * [Commands Support]({%slug radribbonview-features-commands-support%})
 * [Developer Focused Examples]({%slug radribbonview-sdk-examples%})
 * [Events]({%slug radribbonview-events-overview%}) 
 * [Keyboard Support]({%slug radribbonview-keyboard-support%})
 * [Minimization]({%slug radribbonview-minimization%})
 * [Ribbon Backstage]({%slug radribbonview-ribbon-backstage%}) 
 * [Ribbon Group]({%slug radribbonview-ribbon-group%})
 * [Ribbon Tab]({%slug radribbonview-ribbon-tab%})
 * [RibbonButtons - Overview]({%slug radribbonview-buttons-overview%})
 * [Screen Tips]({%slug radribbonview-screentips%}) 
 * [Quick Access Toolbar]({%slug radribbonview-qat%}) 
