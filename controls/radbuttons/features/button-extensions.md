---
title: Button Extensions
page_title: Button Extensions
description: Button Extensions
slug: radbuttons-features-button-extensions
tags: button, extensions, dropdown, attached, property,
published: True
position: 13
---

# Button Extensions

Telerik suite provides build-in extensions that can change different behaviors of the button controls. This article will go through these extensions.

## DropDownExtensions extension class

* __HandleMouseWheelWhenOpen:__ A boolean property that gets or sets if MouseWheel event is handled while a drop-down content of DropDownButton is open. Setting this property to true you won't be able to scroll your page while the drop-down content is open. The default value is false.

>This property can be set on the following controls: __RadDropDownButton, RadSplitButton, RadColorPicker, RadTimeSpanPicker, RadDateTimePicker, RadBreadCrumb__ 

#### __[XAML] Example 1: Set HandleMouseWheelWhenOpen attached property__
{{region xaml-radbuttons-features-button-extensions_0}}
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
{{endregion}}

>This property is not supported when the control (for example, RadDropDownButton) has __KeepOpen__ property set to __True__.

## DropDownButtonExtensions extension class

* __FocusContentOnOpen:__ A boolean property that gets or sets if the drop-down content of DropDownButton control should be focused when its drop-down content is open. The default value is false.

#### __[XAML] Example 2: Set FocusContentOnOpen attached property__
{{region xaml-radbuttons-features-button-extensions_1}}
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
{{endregion}}

## See Also

* [EventToCommandBehavior]({%slug common-event-to-command-behavior%})
* [Attached Behavior]({%slug common-mvvm-attached-behavior%})
* [DelegateCommand]({%slug common-mvvm-delegate-command-implementation%})
