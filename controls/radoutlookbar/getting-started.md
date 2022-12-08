---
title: Getting Started
page_title: Getting Started
description: Check our &quot;Getting Started&quot; documentation article for the RadOutlookBar {{ site.framework_name }} control.
slug: radoutlookbar-getting-started
tags: getting,started
published: True
position: 1
---

# Getting Started

## Adding the RadOutlookBar to the page

{% if site.site_name == 'WPF' %}
>In order to use __RadOutlookBar__ control in your projects you have to add references to the following assemblies:
>	- __Telerik.Windows.Controls__ 
>	- __Telerik.Windows.Controls.Navigation__ 
>	- __Telerik.Windows.Data__  

>You can find more info [here](http://www.telerik.com/help/wpf/installation-installing-controls-dependencies-wpf.html).
{% endif %}

{% if site.site_name == 'Silverlight' %}
>In order to use __RadOutlookBar__ control in your projects you have to add references to the following assemblies:
>	- __Telerik.Windows.Controls__ 
>	- __Telerik.Windows.Controls.Navigation__  

>You can find more info [here](http://www.telerik.com/help/silverlight/installation-installing-controls-dependencies.html).
{% endif %}

![RadOutlookBar Step 1](images/outlook_step1.png)

## Adding icons to the items

#### __[XAML] Example 1__
{{region xaml-radoutlookbar-getting-started_0}}
	<telerik:RadOutlookBar>
	    <telerik:RadOutlookBarItem Header="Item 1" Icon="Letter.png">
	        <TextBlock Text="Item 1 Content" />
	    </telerik:RadOutlookBarItem>
	    <telerik:RadOutlookBarItem Header="Item 2" 
	                               Icon="Letter.png"
	                               IsSelected="True">
	        <TextBlock Text="Item 2 Content" />
	    </telerik:RadOutlookBarItem>
	    <telerik:RadOutlookBarItem Header="Item 3" Icon="Letter.png">
	        <TextBlock Text="Item 3 Content" />
	    </telerik:RadOutlookBarItem>
	</telerik:RadOutlookBar>
{{endregion}}

![WPF RadOutlookBar with Icons for the Items](images/outlook_step3.png)

## Selecting item

By default the first item will be selected. In order to select another item you can use the __IsSelected__ property.        

#### __[XAML] Example 2__
{{region xaml-radoutlookbar-getting-started_1}}
	<UserControl xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
	             xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
	             xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
	             xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
	             xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation">
	    <Grid x:Name="LayoutRoot">
	        <telerik:RadOutlookBar >
	            <telerik:RadOutlookBarItem Header="Item 1">
	                <TextBlock Text="Item 1 Content" />
	            </telerik:RadOutlookBarItem>
	            <telerik:RadOutlookBarItem Header="Item 2">
	                <TextBlock Text="Item 2 Content" />
	            </telerik:RadOutlookBarItem>
	            <telerik:RadOutlookBarItem Header="Item 3">
	                <TextBlock Text="Item 3 Content" />
	            </telerik:RadOutlookBarItem>
	        </telerik:RadOutlookBar>
	    </Grid>
	</UserControl>
{{endregion}}

![RadOutlookBar Icons support](images/outlook_step2.png)

## Handling changes in the selection

To handle the changes in the selection you can use the __SelectionChanged__ event of the __RadOutlookBar__:        

#### __[XAML] Example 3__
{{region xaml-radoutlookbar-getting-started_2}}
	<telerik:RadOutlookBar x:Name="RadOutlookBar1" SelectionChanged="RadOutlookBar1_SelectionChanged">
	    <telerik:RadOutlookBarItem Header="Item 1" Icon="Letter.png">
	        <TextBlock Text="Item 1 Content" />
	    </telerik:RadOutlookBarItem>
	    <telerik:RadOutlookBarItem Header="Item 2" 
	                               Icon="Letter.png"
	                               IsSelected="True">
	        <TextBlock Text="Item 2 Content" />
	    </telerik:RadOutlookBarItem>
	    <telerik:RadOutlookBarItem Header="Item 3" Icon="Letter.png">
	        <TextBlock Text="Item 3 Content" />
	    </telerik:RadOutlookBarItem>
	</telerik:RadOutlookBar>
{{endregion}}

#### __[C#] Example 4__
{{region cs-radoutlookbar-getting-started_3}}
	private void RadOutlookBar1_SelectionChanged(object sender, RoutedEventArgs e)
	{
		RadOutlookBarItem newSelectedItem = (sender as RadOutlookBar).SelectedItem as RadOutlookBarItem;
	}
{{endregion}}

#### __[VB.NET] Example 4__
{{region vb-radoutlookbar-getting-started_3}}
	Private Sub RadOutlookBar1_SelectionChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
	    Dim newSelectedItem As RadOutlookBarItem = TryCast(TryCast(sender, RadOutlookBar).SelectedItem, RadOutlookBarItem)
	End Sub
{{endregion}}

## Limiting active items

To limit the number of items that can be displayed in the active area you can use the __ActiveItemsMaxCount__ property:        

#### __[XAML] Example 5__
{{region xaml-radoutlookbar-getting-started_4}}
	<telerik:RadOutlookBar ActiveItemsMaxCount="2">
	    <telerik:RadOutlookBarItem Header="Item 1" Icon="Letter.png">
	        <TextBlock Text="Item 1 Content" />
	    </telerik:RadOutlookBarItem>
	    <telerik:RadOutlookBarItem Header="Item 2" 
	                               Icon="Letter.png"
	                               IsSelected="True">
	        <TextBlock Text="Item 2 Content" />
	    </telerik:RadOutlookBarItem>
	    <telerik:RadOutlookBarItem Header="Item 3" Icon="Letter.png">
	        <TextBlock Text="Item 3 Content" />
	    </telerik:RadOutlookBarItem>
	</telerik:RadOutlookBar>
{{endregion}}

![WPF RadOutlookBar Active Items Max Count](images/outlook_step4.png)

## Setting a Theme

The controls from our suite support different themes. You can see how to apply a theme different than the default one in the [Setting a Theme]({%slug styling-apperance-implicit-styles-overview%}) help article.

>important Changing the theme using implicit styles will affect all controls that have styles defined in the merged resource dictionaries. This is applicable only for the controls in the scope in which the resources are merged. 

To change the theme, you can follow the steps below:

* Choose between the themes and add reference to the corresponding theme assembly (ex: **Telerik.Windows.Themes.Windows8.dll**). You can see the different themes applied in the **Theming** examples from our {% if site.site_name == 'WPF' %}[WPF Controls Examples](https://demos.telerik.com/wpf/){% else %}[Silverlight Controls Examples](https://demos.telerik.com/silverlight/#Menu/Theming){% endif %} application.

* Merge the ResourceDictionaries with the namespace required for the controls that you are using from the theme assembly. For the RadOutlookBar, you will need to merge the following resources:

	* __Telerik.Windows.Controls__
	* __Telerik.Windows.Controls.Navigation__

__Example 6__ demonstrates how to merge the ResourceDictionaries so that they are applied globally for the entire application.

#### __[XAML] Example 6: Merge the ResourceDictionaries__  
{{region radoutlookbar-getting-started_6}}
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

__Figure 2__ shows a RadOutlookBar with the **Windows8** theme applied.

#### __Figure 2: RadOutlookBar with the Windows8 theme__
![RadOutlookBar with Windows8 theme](images/radoutlookbar-setting-theme.png)

## See Also
 * [Visual Structure]({%slug radoutlookbar-visual-structure%})
 * [Resizing]({%slug radoutlookbar-resizing%})
 * [Selection]({%slug radoutlookbar-selection%})
 * [Events]({%slug radoutlookbar-events%})