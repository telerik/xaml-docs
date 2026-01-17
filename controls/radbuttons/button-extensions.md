---
title: Button Extensions
page_title: Button Extensions
description: This article lists the built-in extensions that can change different behaviors of the button controls.
slug: radbuttons-features-button-extensions
tags: button, extensions, dropdown, attached, property,
published: True
position: 13
---

# Button Extensions

The Telerik suite provides built-in extensions that can change different behaviors of the button controls. This article will go through these extensions.

## Prevent Scrolling When DropDownButton is Opened

The drop down buttons allows you to prevent scrolling within the application while the drop down is opened. To enable this, set the `DropDownExtensions.HandleMouseWheelWhenOpen` [attached property](https://learn.microsoft.com/en-us/dotnet/desktop/wpf/properties/attached-properties-overview) to `True`.

This property is not supported when the button control has its `KeepOpen` property set to `True`.

__Set HandleMouseWheelWhenOpen attached property__  
```XAML
	<ScrollViewer Height="120">
		<StackPanel Height="800" Background="Bisque">
			<telerik:RadDropDownButton Content="Drop Down Button"  VerticalAlignment="Top" HorizontalAlignment="Left"
									   telerik:DropDownExtensions.HandleMouseWheelWhenOpen="True">
				<telerik:RadDropDownButton.DropDownContent>
					<telerik:RadListBox Height="50">
						<telerik:RadListBoxItem Content="item 1"/>
						<telerik:RadListBoxItem Content="item 2"/>
						<telerik:RadListBoxItem Content="item 3"/>
						<telerik:RadListBoxItem Content="item 4"/>
						<telerik:RadListBoxItem Content="item 5"/>
						<telerik:RadListBoxItem Content="item 6"/>
						<telerik:RadListBoxItem Content="item 7"/>
						<telerik:RadListBoxItem Content="item 8"/>
					</telerik:RadListBox>
				</telerik:RadDropDownButton.DropDownContent>
			</telerik:RadDropDownButton>
		</StackPanel>
	</ScrollViewer>
```

The `DropDownExtensions.HandleMouseWheelWhenOpen` property is supported by the following controls - `RadDropDownButton`, `RadSplitButton`, `RadColorPicker`, `RadTimeSpanPicker`, `RadDateTimePicker`, `RadBreadCrumb`.

## Focus DropDown Content When DropDown is Opened

To focus the content element in the drop down content of a RadDropDownButton, set the `DropDownButtonExtensions.FocusContentOnOpen` [attached property](https://learn.microsoft.com/en-us/dotnet/desktop/wpf/properties/attached-properties-overview) to `True`.

__Set FocusContentOnOpen attached property__
```XAML
	<telerik:RadDropDownButton Content="Drop Down Button" VerticalAlignment="Top" HorizontalAlignment="Left" 
							   telerik:DropDownButtonExtensions.FocusContentOnOpen="True">
		<telerik:RadDropDownButton.DropDownContent>
			<telerik:RadListBox >
				<telerik:RadListBoxItem Content="item 1"/>
				<telerik:RadListBoxItem Content="item 2"/>
				<telerik:RadListBoxItem Content="item 3"/>
				<telerik:RadListBoxItem Content="item 4"/>
			</telerik:RadListBox>
		</telerik:RadDropDownButton.DropDownContent>
	</telerik:RadDropDownButton>
```

## See Also  
* [EventToCommandBehavior]({%slug common-event-to-command-behavior%})
* [Attached Behavior]({%slug common-mvvm-attached-behavior%})
* [DelegateCommand]({%slug common-mvvm-delegate-command-implementation%})