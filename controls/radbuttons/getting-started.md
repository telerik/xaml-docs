---
title: Getting Started
page_title: Getting Started
description: Getting Started
slug: radbuttons-getting-started
tags: getting,started
published: True
position: 3
---

# Getting Started



The RadControls for {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} provide you with a set of buttons that can be used in different scenarios. You have the following at hand:

* [RadButton](#RadButton) - a standard-like button that triggers some logic when clicked.

* [RadDropDownButton](#RadDropDownButton) - a button that displays a drop down popup when clicked.

* [RadRadioButton](#RadRadioButton) - a button that can be checked, but not unchecked via the UI. You can group them in order to allow only one button to be checked at a time.

* [RadSplitButton](#RadSplitButton) - a button that combines a __RadButton__ and a __RadDropDownButton__. It has a button part that can be clicked and triggers some logic, and a drop down part, which opens a popup upon clicking.

* [RadToggleButton](#RadToggleButton) - a standard-like button that can be toggled.

>__RadButtons__ are located in the __Telerik.Windows.Controls.dll__ and in order to use them in your project you have to add a reference to the assembly. {% if site.site_name == 'WPF' %} You can find more info [here](http://www.telerik.com/help/wpf/installation-installing-controls-dependencies-wpf.html).{% endif %}{% if site.site_name == 'Silverlight' %} You can find more info [here](http://www.telerik.com/help/silverlight/installation-installing-controls-dependencies.html).{% endif %}

Then in XAML you have to declare the namespace: xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"

## RadButton

Here is an example of a __RadButton__ that executes some logic when it is clicked.

#### __XAML__

{{region radbuttons-getting-started_0}}
	<telerik:RadButton x:Name="radButton" 
					   HorizontalAlignment="Left"
					   VerticalAlignment="Top"
					   Click="radButton_Click"
					   Content="Click Me!" />
{{endregion}}



#### __C#__

{{region radbuttons-getting-started_1}}
	private void radButton_Click( object sender, RoutedEventArgs e )
	{
	    //implement your logic here.
	}
{{endregion}}



#### __VB.NET__

{{region radbuttons-getting-started_2}}
	Private Sub radButton_Click(sender As Object, e As RoutedEventArgs)
	 'implement your logic here.
	End Sub
{{endregion}}


![](images/RadButtons_Getting_Started_01.png)

## RadDropDownButton

Here is an example of a __RadDropDownButton__ that contains a list of actions in its DropDown Content.

#### __XAML__

{{region radbuttons-getting-started_3}}
	<telerik:RadDropDownButton HorizontalAlignment="Left" 
							   VerticalAlignment="Top"
							   Content="Actions">
		<telerik:RadDropDownButton.DropDownContent>
			<telerik:RadContextMenu>
				<telerik:RadMenuItem Header="Add" />
				<telerik:RadMenuItem Header="Edit" />
				<telerik:RadMenuItem Header="Delete" />
			</telerik:RadContextMenu>
		</telerik:RadDropDownButton.DropDownContent>
	</telerik:RadDropDownButton>
{{endregion}}



![](images/RadButtons_Getting_Started_02.png)

## RadRadioButton

Here is an example of several __RadRadioButtons__ placed in two groups.

#### __XAML__

{{region radbuttons-getting-started_4}}
	<StackPanel HorizontalAlignment="Left" 
				VerticalAlignment="Top"
				Orientation="Horizontal">
		<StackPanel Margin="0,0,20,0">
			<telerik:RadRadioButton Margin="0,0,0,5" Content="Male" />
			<telerik:RadRadioButton Content="Female" />
		</StackPanel>
		<StackPanel>
			<telerik:RadRadioButton Margin="0,0,0,5" Content="Over 18" />
			<telerik:RadRadioButton Content="Under 18" />
		</StackPanel>
	</StackPanel>
{{endregion}}



![](images/RadButtons_Getting_Started_03.png)

## RadSplitButton

Here is an example of a __RadSplitButton__ definition, where a __ListBox__ control is used to display a list of items in the __RadSplitButton.DropDownContent__. The __Content__ of the __RadSplitButton__ is bound to the __SelectedItem__ of the __ListBox__.

#### __XAML__

{{region radbuttons-getting-started_5}}
	<telerik:RadSplitButton HorizontalAlignment="Left" 
							VerticalAlignment="Top"
							Content="{Binding Path=SelectedItem.Content, ElementName=FindActions}">
		<telerik:RadSplitButton.DropDownContent>
			<ListBox x:Name="FindActions" SelectionMode="Single">
				<ListBoxItem Content="Quick Find" IsSelected="True" />
				<ListBoxItem Content="Find in Files" />
				<ListBoxItem Content="Find Symbols" />
			</ListBox>
		</telerik:RadSplitButton.DropDownContent>
	</telerik:RadSplitButton>
{{endregion}}


![](images/RadButtons_Getting_Started_04.png)

## RadToggleButton

Here is an example of a __RadToggleButton__ that toggles the "Monthly Newsletter" feature of a form.

#### __XAML__

{{region radbuttons-getting-started_6}}
	<StackPanel HorizontalAlignment="Left" 
				VerticalAlignment="Top"
				Orientation="Horizontal">
		<telerik:RadToggleButton Margin="0,0,10,0">
			<telerik:RadToggleButton.Content>
				<Image Source="/Silverlight.Help.RadButtons;component/Demos/Images/newsletter.png" Stretch="None" />
			</telerik:RadToggleButton.Content>
		</telerik:RadToggleButton>
		<TextBlock Text="Send a monthly newsletter" />
	</StackPanel>
{{endregion}}



![](images/RadButtons_Getting_Started_05.png)

# See Also

 * [Visual Structure]({%slug radbuttons-visual-structure%})

 * [Commands]({%slug radbuttons-features-commands%})

 * [Events]({%slug radbuttons-events%})

 * [Styles and Templates]({%slug radbuttons-styles-and-templates-overview%})
