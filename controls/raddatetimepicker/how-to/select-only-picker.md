---
title: How to create a select-only RadDateTimePicker
page_title: How to create a select-only RadDateTimePicker
description: Check our &quot;How to create a select-only RadDateTimePicker&quot; documentation article for the RadDateTimePicker {{ site.framework_name }} control.
slug: raddatetimepicker-how-to-select-only-picker
tags: how,to,create,a,select-only,raddatetimepicker
published: True
position: 5
---

# How to create a select-only RadDateTimePicker

This tutorial shows you how to modify the default __RadDateTimePicker__ in such a way that the user is not allowed to type in the control but only to choose from the drop down picker. 

To do this you will have to slightly modify the template of your __RadDateTimePicker__ control. You have to go through the following steps:

* Generate the default __RadDateTimePicker's__ template.

>tipTo see how to do this [read here]({%slug raddatetimepicker-styling-raddatetimepicker%}).

* Select the __RadWatermarkTextBox__ called __PART_DateTimeInput__ and set its __IsReadOnly__ property to __True__.

This will achieve the desired behavior. However, a specific grey visual element will appear on the top of your __RadDateTimePicker__ input box control. To remove it you will have to modify the default style used by the __RadWatermarkTextBox__ control.

* After generating the __RadWatermarkTextBox's__ style in the __Resources__ pane in Expression Blend you can find the __ControlBackground_ReadOnly__ brush and set it to the __RadDateTimePicker's__ background color.

>tipLearn more about the __RadWatermarkTextBox__ [here]({%slug radwatermarktextbox-overview%}).

## See Also

 * [Visual Structure]({%slug raddatetimepicke-visual-structure%})

 * [Watermark]({%slug raddatetimepicker-features-watermark%})

 * [How to set the first day of the week]({%slug raddatetimepicker-how-to-set-first-day-calendar%})

 * [How to implement custom parsing]({%slug raddatetimepicker-how-to-implement-custom-parsing%})