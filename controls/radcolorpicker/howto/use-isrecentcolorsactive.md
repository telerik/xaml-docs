---
title: Use IsRecentColorsActive property
page_title: Use IsRecentColorsActive property
description: Check our &quot;Use IsRecentColorsActive property&quot; documentation article for the RadColorPicker {{ site.framework_name }} control.
slug: radcolorpicker-howto-use-isrecentcolorsactive
tags: use,isrecentcolorsactive,property
published: True
position: 4
---

# Use IsRecentColorsActive property

This article will show you how to use the __IsRecentColorsActive__ property of the __RadColorPicker__ control.

The final result should look like this

![Rad Color Picker How To Use Is Recent Colors Active](images/RadColorPicker_HowTo_Use_IsRecentColorsActive.png)

For the purpose of this article we will use the __AdditionalContent__ property of the __RadColorPicker__ control to add a customized button at the bottom of the drop down content. This can be implemented by the following code:		


```XAML
	<telerik:RadColorPicker x:Name="xColorPicker" IsRecentColorsActive="True">
		<telerik:RadColorPicker.AdditionalContent>
			<telerik:RadButton Click="RadButton_Click">
				<StackPanel Orientation="Horizontal">
					<Image Width="16"
						   Height="16"
						   Margin="0 0 10 0"
						   Source="palette-add.png" />
					<TextBlock Text="Create Custom Color..." />
				</StackPanel>
			</telerik:RadButton>
		</telerik:RadColorPicker.AdditionalContent>
	</telerik:RadColorPicker>
```

>The __RecentColors__ palette is visible when the __IsRecentColorsActive__ property of the __RadColorPicker__ control is set to __True__ and the selected color does not exist in __MainPalette__, __HeaderPalette__ or __StandartPalette__.		  

In the button's Click event handler we display a __RadExpander__ control which hosts a __RadColorEditor__. This layout will be used to customize colors:		


```XAML
	<StackPanel>
			<telerik:RadColorPicker x:Name="xColorPicker" IsRecentColorsActive="True">
				<telerik:RadColorPicker.AdditionalContent>
					<telerik:RadButton Click="RadButton_Click">
						<StackPanel Orientation="Horizontal">
							<Image Width="16"
							       Height="16"
							       Margin="0 0 10 0"
							       Source="palette-add.png" />
							<TextBlock Text="Create Custom Color..." />
						</StackPanel>
					</telerik:RadButton>
				</telerik:RadColorPicker.AdditionalContent>
			</telerik:RadColorPicker>
	
			<telerik:RadExpander x:Name="xExpander"
			                     Width="400"
			                     Header="RadColorEditor"
			                     Opacity="0">
				<StackPanel>
					<telerik:RadColorEditor x:Name="xColorEditor"
					                        Width="400"
					                        Height="250"
					                        HorizontalAlignment="Center" />
					<telerik:RadButton Width="90"
					                   Height="30"
					                   Click="OK_RadButton_Click"
					                   Content="Get Color" />
				</StackPanel>
			</telerik:RadExpander>
		</StackPanel>
```


```C#	
	private void RadButton_Click(object sender, RoutedEventArgs e)
	{
		this.xColorPicker.IsDropDownOpen = false;
		this.xExpander.Opacity = 1;
		this.xExpander.IsExpanded = true;
	}
```


```VB.NET
    Private Sub RadButton_Click(sender As Object, e As RoutedEventArgs)
        Me.xColorPicker.IsDropDownOpen = False
        Me.xExpander.Opacity = 1
        Me.xExpander.IsExpanded = True
    End Sub
```

Finally in the confirmation's button Click event handler we implement the selection logic of the customized color.	


```C#
	private void OK_RadButton_Click(object sender, RoutedEventArgs e)
	{
		this.xColorPicker.SelectedColor = this.xColorEditor.SelectedColor;
		this.xExpander.IsExpanded = false;
		this.xExpander.Opacity = 0;
		this.xColorPicker.IsDropDownOpen = true;
	}
```


```VB.NET
    Private Sub OK_RadButton_Click(sender As Object, e As RoutedEventArgs)
        Me.xColorPicker.SelectedColor = Me.xColorEditor.SelectedColor
        Me.xExpander.IsExpanded = False
        Me.xExpander.Opacity = 0
        Me.xColorPicker.IsDropDownOpen = True
    End Sub
```

Now we are able to run the project and select a custom color following these steps:		

1. Click the "Create Custom Color" button.  
	![Rad Color Picker How To Use Is Recent Colors Active 1](images/RadColorPicker_HowTo_Use_IsRecentColorsActive_1.png)

2. Create a customized color using the thumbs and pick it.  
	![Rad Color Picker How To Use Is Recent Colors Active 2](images/RadColorPicker_HowTo_Use_IsRecentColorsActive_2.png)

3. Your custom color will be added to the __RecentColors__ palette.  
	![Rad Color Picker How To Use Is Recent Colors Active 3](images/RadColorPicker_HowTo_Use_IsRecentColorsActive_3.png)