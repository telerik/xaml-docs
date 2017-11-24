---
title: Getting Started
page_title: Getting Started
description: Getting Started
slug: radbook-getting-started
tags: getting,started
published: True
position: 1
---

# Getting Started

This article will walk you through defining and using a RadBook control.

## Assembly References

In order to use the __RadBook__ control in your projects you have to add references to the following assemblies:  
* __Telerik.Windows.Controls__
* __Telerik.Windows.Controls.Navigation__ 
{% if site.site_name == 'WPF' %}
* __Telerik.Windows.Data__  
{% endif %}

{% if site.site_name == 'WPF' %}
>You can find more info [here](http://www.telerik.com/help/wpf/installation-installing-controls-dependencies-wpf.html).
{% endif %}
{% if site.site_name == 'Silverlight' %}
>You can find more info [here](http://www.telerik.com/help/silverlight/installation-installing-controls-dependencies.html).
{% endif %}

## Define a RadBook control

__RadBook__ is an __ItemsControl__. The pages of the book are represented by the __RadBookItem__ control. __RadBookItem__ is a __ContentControl__. Below is a basic declaration of __RadBook__ with several pages:

#### __[XAML] Example 1: Defining a RadBook__  
{{region xaml-radbook-getting-started_0}}
	<telerik:RadBook Margin="50">
		<telerik:RadBookItem Background="Red">
			<TextBlock Text="Page 1" FontSize="36"/>
		</telerik:RadBookItem>
		<telerik:RadBookItem Background="BlueViolet">
			<TextBlock Text="Page 2" HorizontalAlignment="Right" FontSize="36"/>
		</telerik:RadBookItem>
		<telerik:RadBookItem Background="RosyBrown">
			<TextBlock Text="Page 3" FontSize="36"/>
		</telerik:RadBookItem>
		<telerik:RadBookItem Background="Chocolate">
			<TextBlock Text="Page 4" HorizontalAlignment="Right" FontSize="36"/>
		</telerik:RadBookItem>
	</telerik:RadBook>
{{endregion}}

This is the result of the above code:

![RadBook Getting Started - Step1](images/book_step1.png)

## Adding content to the pages of the Book

You can add any UIElement as a content of the pages. RadBookItem has a Content property which you can populate with a single root panel which contains the page content.

#### __[XAML] Example 2: Adding RadBookItems__  
{{region xaml-radbook-getting-started_1}}
	<telerik:RadBook Margin="50">
		<telerik:RadBookItem Background="Red">
			<StackPanel>
				<TextBlock Text="Page 1" FontSize="36"/>
				<Button Content="Click Me"/>
			</StackPanel>
		</telerik:RadBookItem>
		<telerik:RadBookItem Background="BlueViolet">
			<StackPanel>
				<TextBlock Text="Page 2" HorizontalAlignment="Right" FontSize="36"/>
				<Image Source="Koala.jpg" Width="320" Height="240"/>
			</StackPanel>
		</telerik:RadBookItem>
		<telerik:RadBookItem Background="RosyBrown">
			<TextBlock Text="Page 3" FontSize="36"/>
		</telerik:RadBookItem>
		<telerik:RadBookItem Background="Chocolate">
			<TextBlock Text="Page 4" HorizontalAlignment="Right" FontSize="36"/>
		</telerik:RadBookItem>
	</telerik:RadBook>
{{endregion}}

![RadBook Getting Started - Step2](images/book_step2.png)

## Setting the initial page

To set the initial page that will be displayed - set the __RightPageIndex__ property:

#### __[XAML] Example 3: Setting the intially displayed page__  
{{region xaml-radbook-getting-started_2}}
	<telerik:RadBook Margin="50" x:Name="RadBook1" RightPageIndex="3">
		<telerik:RadBookItem Background="Red">
			<StackPanel>
				<TextBlock Text="Page 1" FontSize="36"/>
				<Button Content="Click Me"/>
			</StackPanel>
		</telerik:RadBookItem>
		<telerik:RadBookItem Background="BlueViolet">
			<StackPanel>
				<TextBlock Text="Page 2" HorizontalAlignment="Right" FontSize="36"/>
				<Image Source="Koala.jpg" Width="320" Height="240"/>
			</StackPanel>
		</telerik:RadBookItem>
		<telerik:RadBookItem Background="RosyBrown">
			<TextBlock Text="Page 3" FontSize="36"/>
		</telerik:RadBookItem>
		<telerik:RadBookItem Background="Chocolate">
			<TextBlock Text="Page 4" HorizontalAlignment="Right" FontSize="36"/>
		</telerik:RadBookItem>
	</telerik:RadBook>
{{endregion}}

![RadBook Getting Started - Step3](images/book_step3.png)

## See Also
 * [Data Binding and Data Templates]({%slug radbook-data-templates%})
 * [Events]({%slug radbook-events%})
 * [Page Flip Mode]({%slug radbook-page-flip-mode%})