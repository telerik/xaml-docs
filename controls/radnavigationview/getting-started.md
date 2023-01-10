---
title: Getting Started
page_title: Getting Started
description: This article will walk you through the creation of a sample application that contains a RadNavigationView control.
slug: radnavigationview-getting-started
tags: getting,started,navigationviewitem
position: 2
---

# {{ site.framework_name }} RadNavigationView Getting Started

This tutorial walks you through the creation of a sample application that contains a __RadNavigationView__ control. We also demonstrate a few optional features.
			
## Assembly References

To use __RadNavigationView__, add references to the following assemblies:
* __Telerik.Windows.Controls__
* __Telerik.Windows.Controls.Navigation__
* __Telerik.Windows.Data__

>tip To find the required assemblies for each control, see the [Controls Dependencies]({%slug installation-installing-controls-dependencies-wpf%}) article.

## Defining RadNavigationView

__Example 1__ demonstrates how you can define a RadNavigationView in xaml.

#### __[XAML] Example 1: Defining RadNavigationView__
{{region xaml-radnavigationview-getting-started-0}}
    <telerik:RadNavigationView x:Name="navigationView"  />
{{endregion}}

## Populating with Items

Populate the control with items by adding RadNavigationViewItems to its Items collection:

#### __[XAML] Example 2: Populating with Items in xaml__
{{region xaml-radnavigationview-getting-started-1}}
    <telerik:RadNavigationView x:Name="navigationView" PaneHeader="Header">
        <telerik:RadNavigationView.Items>
            <telerik:RadNavigationViewItem Content="Bookmarks">
                <telerik:RadNavigationViewItem.Icon>
                    <telerik:RadGlyph Glyph="&#xe303;" FontSize="16"/>
                </telerik:RadNavigationViewItem.Icon>
            </telerik:RadNavigationViewItem>
            <telerik:RadNavigationViewItem Content="Favorites">
                <telerik:RadNavigationViewItem.Icon>
                    <telerik:RadGlyph Glyph="&#xe301;" FontSize="16"/>
                </telerik:RadNavigationViewItem.Icon>
            </telerik:RadNavigationViewItem>
            <telerik:RadNavigationViewItem Content="Files">
                <telerik:RadNavigationViewItem.Icon>
                    <telerik:RadGlyph Glyph="&#xe901;" FontSize="16"/>
                </telerik:RadNavigationViewItem.Icon>
            </telerik:RadNavigationViewItem>
        </telerik:RadNavigationView.Items>
        <telerik:RadNavigationView.Content>
            <TextBlock Text="Content" Foreground="Black" Margin="5"/>
        </telerik:RadNavigationView.Content>
    </telerik:RadNavigationView>
{{endregion}}

Another way to populate RadNavigationView with items is to use data binding. See the [DataBinding]({%slug radnavigationview-populating-with-data-databinding%}) article for details.

#### __Figure 1: Result from Example 1 in the Office 2016 theme__
![RadNavigationView populated with items](images/NavigationView_GettingStarted.png)

>Check out the [Icon and IconTemplate]({%slug common-styling-appearance-radglyph%}) article for more information on those properties. 

## Opening/Closing the NavigationPane in code

By default, users can open or close the NavigationPane that hosts the RadNavigationViewItems by clicking the RadToggleButton. You can manage the state of the control programmatically by setting the __IsPaneOpen__ property of the __RadNavigationView__. This is demonstrated in __Examples 3 and 4__:

#### __[XAML] Example 3: Setting the IsPaneOpen property in xaml__
{{region cs-radnavigationview-getting-started-2}}
     <telerik:RadNavigationView x:Name="navigationView" IsPaneOpen="True" />
{{endregion}}

#### __[C#] Example 4: Setting the IsPaneOpen property in code__
{{region cs-radnavigationview-getting-started-3}}
    this.navigationView.IsPaneOpen = true;
{{endregion}}

#### __[VB.NET] Example 4: Setting the IsPaneOpen property in code__
{{region cs-radnavigationview-getting-started-4}}
    Me.navigationView.IsPaneOpen = True
{{endregion}}

## Changing the Width of the Navigation Pane

* To control the width of the NavigationPane when it's opened, use the __ExpandedPaneWidth__ property.

* To control the width of the NavigationPane when it's closed, use the __CompactPaneWidth__ property.

__Example 5__ demonstrates how you can set the  property in order to increase the default width when the navigation pane is closed.

#### __[XAML] Example 5: Setting the CompactPaneWidth property__
{{region xaml-radnavigationview-getting-started-5}}
     <telerik:RadNavigationView x:Name="navigationView" PaneHeader="Header" CompactPaneWidth="150">
        <telerik:RadNavigationView.Items>
            <telerik:RadNavigationViewItem Content="Bookmarks">
                <telerik:RadNavigationViewItem.Icon>
                    <telerik:RadGlyph Glyph="&#xe303;" FontSize="16"/>
                </telerik:RadNavigationViewItem.Icon>
            </telerik:RadNavigationViewItem>
            <telerik:RadNavigationViewItem Content="Favorites">
                <telerik:RadNavigationViewItem.Icon>
                    <telerik:RadGlyph Glyph="&#xe301;" FontSize="16"/>
                </telerik:RadNavigationViewItem.Icon>
            </telerik:RadNavigationViewItem>
            <telerik:RadNavigationViewItem Content="Files">
                <telerik:RadNavigationViewItem.Icon>
                    <telerik:RadGlyph Glyph="&#xe901;" FontSize="16"/>
                </telerik:RadNavigationViewItem.Icon>
            </telerik:RadNavigationViewItem>
        </telerik:RadNavigationView.Items>
        <telerik:RadNavigationView.Content>
            <TextBlock Text="My Content" Foreground="Black" Margin="5"/>
        </telerik:RadNavigationView.Content>
    </telerik:RadNavigationView>
{{endregion}}

#### __Figure 2: Result from Example 5 in the Office 2016 theme__
![RadNavigationView with CompactPaneWidth set](images/NavigationView_CompactPaneWidth.png)

## Navigation

__RadNavigationView__ doesn't perform any navigation automatically. To perform navigation-related tasks or change the content of the RadNavigationView control, you must handle either of the following events:

* The __ItemClick__ event that is raised when a user clicks a __RadNavigationViewItem__.

* The __SelectionChanged__ event that is raised when a user clicks a __RadNavigationViewItem__ and this results in the selection of a new item.

Alternatively, you can use the __SelectedItem__ property to change the content. This is demonstrated in the [DataBinding]({%slug radnavigationview-populating-with-data-databinding%}) article.  

## More Features

To further customize __RadNavigationView__, you can also control:

* The DisplayMode.

    The __RadNavigationView__ control dynamically changes its layout based on its size. It has three display modes: __Minimal__, __Compact__ and __Expanded__. You can read more about them in the [Display Mode]({%slug radnavigationview-display-mode%}) article.

* The PaneHeader and PaneFooter.

    The __RadNavigationView__ control allows you to customize its header and footer. You can set them to simple strings or add a custom control. Check out the [Header and Footer]({%slug radnavigationview-header-and-footer%}) article for more information.
	
## Setting a Theme

The controls from our suite support different themes. You can see how to apply a theme different than the default one in the [Setting a Theme]({%slug styling-apperance-implicit-styles-overview%}) help article.

>important Changing the theme using implicit styles will affect all controls that have styles defined in the merged resource dictionaries. This is applicable only for the controls in the scope in which the resources are merged. 

To change the theme, you can follow the steps below:

* Choose between the themes and add reference to the corresponding theme assembly (ex: **Telerik.Windows.Themes.Windows8.dll**). You can see the different themes applied in the **Theming** examples from our [WPF Controls Examples](https://demos.telerik.com/wpf/) application.

* Merge the ResourceDictionaries with the namespace required for the controls that you are using from the theme assembly. For the __RadNavigationView__, you will need to merge the following resources:

	* __Telerik.Windows.Controls__
	* __Telerik.Windows.Controls.Navigation__

__Example 3__ demonstrates how to merge the ResourceDictionaries so that they are applied globally for the entire application.

#### __[XAML] Example 3: Merge the ResourceDictionaries__  
{{region radnavigationview-getting-started_6}}
	<Application.Resources>
		<ResourceDictionary>
			<ResourceDictionary.MergedDictionaries>
				<ResourceDictionary Source="/Telerik.Windows.Themes.Windows8;component/Themes/System.Windows.xaml"/>
				<ResourceDictionary Source="/Telerik.Windows.Themes.Windows8;component/Themes/Telerik.Windows.Controls.xaml"/>
				<ResourceDictionary Source="/Telerik.Windows.Themes.Windows8;component/Themes/Telerik.Windows.Controls.Navigation.xaml"/>
			</ResourceDictionary.MergedDictionaries>
		</ResourceDictionary>
	</Application.Resources>
{{endregion}}

>Alternatively, you can use the theme of the control via the {% if site.site_name == 'WPF' %}[StyleManager](https://docs.telerik.com/devtools/wpf/styling-and-appearance/stylemanager/common-styling-apperance-setting-theme-wpf){% else %}[StyleManager](https://docs.telerik.com/devtools/silverlight/styling-and-appearance/stylemanager/common-styling-apperance-setting-theme){% endif %}.

__Figure 3__ shows a RadNavigationView with the **Windows8** theme applied.

#### __Figure 3: RadNavigationView with the Windows8 theme__
![RadNavigationView with Windows8 theme](images/radnavigationview-setting-theme.png)	

## See Also 

* [DataBinding]({%slug radnavigationview-populating-with-data-databinding%})
* [Display Mode]({%slug radnavigationview-display-mode%})
* [Icon and IconTemplate]({%slug radnavigationview-icon-and-icontemplate%})
