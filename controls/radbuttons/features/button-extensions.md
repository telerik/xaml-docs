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

## DropDownExtensions

* __HandleMouseWheelWhenOpen:__ A boolean property that gets or sets if the **MouseWheel** event is handled while a drop-down content of a drop-down button is open. By setting this property to **true** you won't be able to scroll your page while the drop-down content is open. The default value is **false**.

>important This property can be set on the following controls: __RadDropDownButton, RadSplitButton, RadColorPicker, RadTimeSpanPicker, RadDateTimePicker, RadBreadCrumb__.

__Example 1: Set HandleMouseWheelWhenOpen attached property__
```XAML
	<ScrollViewer Height="120">
		<StackPanel Height="800" Background="Bisque">
			<telerik:RadDropDownButton Content="Drop Down Button"  VerticalAlignment="Top" HorizontalAlignment="Left" telerik:DropDownExtensions.HandleMouseWheelWhenOpen="True">
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

>important This property is not supported when the control (for example, RadDropDownButton) has its __KeepOpen__ property set to __True__.

## DropDownButtonExtensions

* __FocusContentOnOpen:__ A boolean property that gets or sets if the drop-down content of a drop-down button control should be focused when its drop-down content is open. The default value is **false**.

__Example 2: Set FocusContentOnOpen attached property__
```XAML
	<telerik:RadDropDownButton Content="Drop Down Button"  VerticalAlignment="Top" HorizontalAlignment="Left" telerik:DropDownButtonExtensions.FocusContentOnOpen="True">
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