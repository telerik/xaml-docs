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



>__RadButtons__ are located in the __Telerik.Windows.Controls.dll__ and in order to use them in your project you have to add a reference to the assembly.<br/>{% if site.site_name == 'WPF' %}You can find more info [here](http://www.telerik.com/help/wpf/installation-installing-controls-dependencies-wpf.html).{% endif %}{% if site.site_name == 'Silverlight' %}You can find more info [here](http://www.telerik.com/help/silverlight/installation-installing-controls-dependencies.html).{% endif %}

Then in XAML you have to declare the namespace:
__xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"__

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

## RadPathButton

The greatest advantage of this control is that users can visualize a custom path geometry in the button. Also, the geometry can be positioned relatively to the __Content__ of the button. Here is an example of a __RadPathButton__ that executes some logic when it is clicked.
  
#### __XAML__  
    <telerik:RadPathButton x:Name="pathButton"
                                 Width="100"
                                 Height="30"
                                 Margin="20"
                                 Click="pathButton_Click"
                                 ContentPlacement="Right"
                                 Content="Click Me!"
                                 PathGeometry="M3,7L9,7L9,4L13,8L9,12L9,9L3,9z" />


#### __C#__
	private void pathButton_Click( object sender, RoutedEventArgs e )
    {
        //implement your logic here.
    }


#### __VB__

	Private Sub pathButton_Click(sender As Object, e As RoutedEventArgs)
    'implement your logic here.'
    End Sub


![Rad Path Button 2](images/RadPathButton2.png)

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

Here is an example of a __RadSplitButton__ definition, where a __ListBox__ control is used to display a list of items in the __RadSplitButton____DropDownContent__. The __Content__ of the __RadSplitButton__ is bound to the __SelectedItem__ of the __ListBox__.

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
