---
title: How to hide/show the pop-up pane in code
page_title: How to hide/show the pop-up pane in code
description: Check our &quot;How to hide/show the pop-up pane in code&quot; documentation article for the RadDateTimePicker {{ site.framework_name }} control.
slug: raddatetimepicker-how-to-hide-show-pop-up-in-code
tags: how,to,hide/show,the,pop-up,pane,in,code
published: True
position: 1
---

# How to hide/show the pop-up pane in code

The purpose of this tutorial is to demonstrate you how to show and hide the __RadDateTimePicker's__ content in code. 

In order to do this you have to use the __RadDateTimePicker's IsDropDownOpen__ boolean property. Whenever you set its value to __True__ the content (the calendar and/or the clock) will be shown, otherwise setting its value to __False__ will hide the content. 

For example:

#### __C#__

```C#
	this.radDateTimePicker.IsDropDownOpen = true;
```



#### __VB.NET__

```VB.NET
	Me.radDateTimePicker.IsDropDownOpen = True
```

## See Also

 * [Visual Structure]({%slug raddatetimepicke-visual-structure%})

 * [Input Modes]({%slug raddatetimepicker-features-input-modes%})

 * [Events]({%slug raddatetimepicker-events%})
