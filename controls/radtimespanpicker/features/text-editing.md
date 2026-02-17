---
title: Text Editing
page_title: Text Editing
description: Check our &quot;Text Editing&quot; documentation article for the RadTimeSpanPicker {{ site.framework_name }} control.
slug: radtimespanpicker-features-text-input-behavior
tags: text,input, behavior
published: True
position: 1
---

# Text Editing

Till now, the value of the `RadTimeSpanPicker` can be edited through its component in the dropdown content and from the input text box. This topic will walk you through this functionality.
 
## Edit Mode
  
The edit mode of the control is controlled from `EditMode` property. Its default value is `TextAndDropDown`. This means that you will be able to edit the `TimeSpan` by directly entering the value in the input text box, or choose a time from the dropdown.

The `EditMode` property is an enumeration, and it contains the following values:
* `None`&mdash;The user won't be able to edit the value of the control.
* `TextOnly`&mdash;The user will be restricted to edit the value through the text inside the control. The dropdown button will collapse. The `FormatString` property will determine the edited sections.
* `DropDown`&mdash;The user will be restricted from editing the value through the TimeSpanComponents inside the dropdown button.
* `TextAndDropDown`&mdash;The user will be able to directly edit through the TextBox and the TimeSpanComponents inside the DropDownButton.

>important The TimeSpanText (visible text in the TimeSpanPicker) is formatted differently depending on EditMode and StringFormat properties: 
	* __EditMode is TextOnly or TextAndDropDown__&mdash;TimeSpanТеxt is formatted using the StringFormat with the major difference that days will be visible even in scenarios with optional days in the format string. This is implemented for 	better text edit usability. 
	* __EditMode is None or DropDown__&mdash;TimeSpanText is formatted with the StringFormat property as expected. If StringFormat is set to empty string or null, 'g' string format is used as the default format.

## Spin Mode  

The spin behavior in the RadTimeSpanPicker controls could be controlled by setting the `SpinMode` property.

>important The value of the different sections inside RadTimeSpanPicker TextBox can be spun through the __Keyboard.Up/Down__ key or the __MouseWheel__ button.

The SpinMode property is an enumeration that exposed the following values:        

* `None`&mdash;Disables the spin behavior  
* `CurrentSectionOnly`&mdash;The value of the other sections will never change when spinning the current section. For example, if you spin up the minutes and you reach 59, spinning one more time will set the minutes to 0 but won't change the hour's section.
* `AllSections`&mdash;When spinning a section, a value will be added/remove from the TimeSpan value. This will lead to changes in the other sections bigger than the current spun one. If maximum (or minimum) of the section is reached, the bigger section is increased (or decreased with a single step).

Below you can find the default spin step for the different sections.

* __Days__&mdash;1
* __Hours__&mdash;1
* __Minutes__&mdash;10  
* __Seconds__&mdash;10 
* __Millisecods__&mdash;100

>important The PageUp(Home) and PageDown(End) buttons are not used in the spin operations. When the PageUp/PageDown button is pressed, the first/last section will be selected.

## ValueEditing Event

With text editing functionality of the control, a new event was introduced. The `ValueEditing` event is called when the `Value` property of the RadTimeSpanPicker is about to change on edit operation via textbox or dropdown popup—thus allowing you to customize the editing process of the control further. Below we will cover the basic scenarios, which demonstrate how you can take advantage of this event.

>important By default, the `ValueEditing` event will not be fired when modifying the `Value` property from the dropdown popup. You can follow the approach from this [article]({%slug kb-timespanpicker-value-editing-dropdown%}) to introduce support for this scenario.

The type of the passed event arguments is `ValueEditingEventArgs` and expose the following properties:
* `Cancel`&mdash;Gets or sets a value indicating whether the new value of the control should be applied.
* `SectionType`&mdash;Gets the edit section type.
* `DigitChar`&mdash;Gets the digit char if the edit is a result of digit key press.
* `IsDelete`&mdash;Gets a value indicating whether the edit is the result of a delete operation.
* `NewValue`&mdash;Gets or sets the new System.TimeSpan value.
* `CurrentValue`&mdash;Gets the current System.TimeSpan value of the control.
* `SpinAction`&mdash;Gets a value indicating if this is a spin operation and its type.

### Increase or decrease the spin step of a section

If you want to increase or decrease the TimeSpan section with a specific interval when the spin operation is performed, you can create custom code to specify the step for each section. In the event handler of the ValueEditing event, we can check the current section and modify the step of our needs. The following example demonstrates how we can change the spin step for Days (5 days) and Hours (2 hours).

__Custom spin steps__
```XAML
	private void RadTimeSpanPicker_ValueEditing(object sender, ValueEditingEventArgs e)
	{
		if (e.NewValue.HasValue)
		{
			if (e.SpinAction != SpinAction.None)
			{
				int spinStepMultiplier = (e.SpinAction == SpinAction.KeyUp || e.SpinAction == SpinAction.MouseWheelUp) ? 1 : -1;
				switch (e.SectionType)
				{
					case EditSectionType.Hours:
						e.NewValue = ((TimeSpan)e.CurrentValue).Add((double)TimeSpan.FromHours(5 * spinStepMultiplier));
						break;
					case EditSectionType.Days:
						e.NewValue = ((TimeSpan)e.CurrentValue).Add((double)TimeSpan.FromDays(2 * spinStepMultiplier));
						break;
					default:
						return;
				}
			}
		}
	}
```

### Set Minimum and Maximum TimeSpan values

To set minimum and maximum TimeSpan, we can again achieve this using custom code. In the ValueEditing event handler, we can use the NewValue property from the event arguments to check if the value falls inside a specific TimeSpan range. The following example demonstrates how we can achieve this.

__Set Minimum and Maximum TimeSpan__
```XAML
	private void RadTimeSpanPicker_ValueEditing(object sender, ValueEditingEventArgs e)
	{
		if (e.NewValue.HasValue)
		{
		    e.NewValue = this.CoerceTimeSpanValue(e.NewValue.Value);
		}
	}
	
	private TimeSpan CoerceTimeSpanValue(TimeSpan newTimeSpan)
	{
		TimeSpan minValue = new TimeSpan(2,15,20,20,100);
		TimeSpan maxValue = new TimeSpan(20,25,30,35,500);

		if (newTimeSpan > maxValue)
		{
			return maxValue;
		} 
		else if (newTimeSpan < minValue)
		{
			return minValue;
		}
		return newTimeSpan;
	}
```

## Pasting new TimeSpan value

In a scenario when the user selects all the text inside the TextBox then paste, if the pasted text is parsed to TimeSpan (parsed with standard format strings "c", "g", "G" and the current format string property) the ValueEditing event will be called. If it is not canceled in the event handler, it will be set to a new value of the control.

## Tab Navigation

RadTimeSpanPicker control provides an easy way to navigate between its TimeSpan sections using the __Tab__ key. The built-in Tab navigation is control by the `TabNavigationMode` property. The TabNavigationMode property is an enumeration that exposed the following values:

>important TabNavigationModes `Once` and `Cycle` require `EditMode` property to be set to `TextOnly` or `TextAndDropDown`.

* `Once`&mdash;Edit sections are navigated one by one by pressing the tab key. The focus will leave control after the last TimeSpanPicker section.
* `Cycle`&mdash;Edited sections are navigated one by one by pressing the tab key. The focus will cycle between the edited TimeSpanPicker sections. The focus will not leave control after the last section.
* `None`&mdash;Pressing Tab key does not move the focus from section to section. 

## See Also 
 * [Overview]({%slug radtimespanpicker-overview%}) 
 * [Visual Structure]({%slug radtimespanpicker-visual-structure%})
