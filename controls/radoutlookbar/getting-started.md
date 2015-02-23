---
title: Getting Started
page_title: Getting Started
description: Getting Started
slug: radoutlookbar-getting-started
tags: getting,started
published: True
position: 0
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

#### __XAML__
{{region radoutlookbar-getting-started_0}}
	<telerik:RadOutlookBar x:Name="RadOutlookBar1">
	    <telerik:RadOutlookBarItem Header="Item 1" Icon="Letter.png">{{endregion}}
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

![](images/outlook_step3.png)

## Selecting item

By default the first item will be selected. In order to select another item you can use the __IsSelected__ property.        

#### __XAML__
{{region radoutlookbar-getting-started_1}}
	<UserControl x:Class="RadOutlookBarHelpExamples.MainPage" 
	             xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
	             xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
	             xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
	             xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
	             xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation">
	    <Grid x:Name="LayoutRoot">
	        <telerik:RadOutlookBar x:Name="RadOutlookBar1">
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

#### __XAML__
{{region radoutlookbar-getting-started_2}}
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

#### __C#__
{{region radoutlookbar-getting-started_1}}
	private void RadOutlookBar1_SelectionChanged(object sender, RoutedEventArgs e)
	{
		RadOutlookBarItem newSelectedItem = (sender as RadOutlookBar).SelectedItem as RadOutlookBarItem;
	}
{{endregion}}

#### __VB.NET__
{{region radoutlookbar-getting-started_1}}
	Private Sub RadOutlookBar1_SelectionChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
		Dim newSelectedItem As RadOutlookBarItem = TryCast(TryCast(sender, RadOutlookBar).SelectedItem, RadOutlookBarItem)
	End Sub
{{endregion}}

## Limiting active items

To limit the number of items that can be displayed in the active area you can use the __ActiveItemsMaxCount__ property:        

#### __XAML__
{{region radoutlookbar-getting-started_3}}
    <telerik:RadOutlookBar x:Name="RadOutlookBar1" ActiveItemsMaxCount="2">
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

![](images/outlook_step4.png)

# See Also
 * [Visual Structure]({%slug radoutlookbar-visual-structure%})
 * [Resizing]({%slug radoutlookbar-resizing%})
 * [Selection]({%slug radoutlookbar-selection%})
 * [Events]({%slug radoutlookbar-events%})