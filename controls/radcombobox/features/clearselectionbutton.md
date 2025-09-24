---
title: Clear Selection Button
page_title: Clear Selection Button
description: Check our &quot;Clear Selection Button&quot; documentation article for the RadComboBox {{ site.framework_name }} control.
slug: radcombobox-features-clearselectionbutton
tags: clear,selection,button
published: True
position: 7
---

# Clear Selection Button

This article demonstrates how to enable the clear selection button and change its content.

## Using ClearSelectionButtonVisibility and ClearSelectionButtonContent

The __RadComboBox__ offers an additional button displayed in the drop-down part, which is responsible for clearing the selection. By default this button is __not visible__. However you could make it visible by using the __ClearSelectionButtonVisibility__ property. Also you have the ability to set the content of the button clearing the selection to anything you want.



```XAML
	<telerik:RadComboBox ClearSelectionButtonVisibility="Visible" ClearSelectionButtonContent="Clear Selection"/>
```

![{{ site.framework_name }} RadComboBox with Clear Selection Button](images/RadComboBox_Features_Selection_010.png)

## See Also

 * [Filtering]({%slug radcombobox-features-filtering%})

 * [Edit Modes]({%slug radcombobox-features-edit-modes%})

 * [AutoComplete]({%slug radcombobox-features-autocomplete%})
