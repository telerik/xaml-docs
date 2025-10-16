---
title: ValidationErrorTemplateHelper
page_title: ValidationErrorTemplateHelper - WPF WatermarkTextBox
description: Check our &quot;ValidationErrorTemplateHelper&quot; documentation article for the RadWatermarkTextBox {{ site.framework_name }} control.
slug: radwatermarktextbox-validation-helper
tags: validationerrortemplatehselper
published: True
position: 0
---

# ValidationErrorTemplateHelper

When the control has validation errors, the border around the control will turn red and a little element will appear in the upper right corner of the control. When you hover over the element you can read the validation message. By default, the validation error tooltip message will appear only when the mouse is over this element.

![{{ site.framework_name }} RadWatermarkTextBox Validation Error Template Helper](images/radwatermarktextbox-helper-01.png)

To make the validation message appears when the control is focused, you can set the __ValidationErrorTemplateHelper.ShowWhenFocused__ attached property to true. Its default value is false.

__Example 1: Show Validation Message on Focus__
```XAML
	<telerik:RadWatermarkTextBox telerik:ValidationErrorTemplateHelper.ShowWhenFocused="True" />
```

## See also
 * [Features]({%slug radwatermarktextbox-features%})

 
