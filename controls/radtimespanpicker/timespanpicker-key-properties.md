---
title: Key Properties
page_title: Key Properties
description: Key Properties
slug: radtimespanpicker-features-key-properties
tags: properties,features,key,properties
published: True
position: 3
---

# Key Properties

The purpose of this help article is to provide a detailed information about some of the key properties of the __RadTimeSpanPicker__ control.

## StringFormat

The __StringFormat__ property is used for formatting the representation of the selected TimeSpan value to any desired format. By using it the current format of the TimeSpan could easily be changed.

The following example demonstrates how to set the __StringFormat__ property.

#### __[XAML] Example 1: Setting StringFormat__

{{region radtimespanpicker-features-key-properties_0}}
	<telerik:RadTimeSpanPicker StringFormat="d' Days, 'h' hours and 'mm' minutes'">
		<telerik:RadTimeSpanPicker.TimeSpanComponents>
			<telerik:DayTimeSpanComponent/>
			<telerik:HourTimeSpanComponent/>
			<telerik:MinuteTimeSpanComponent/>
		</telerik:RadTimeSpanPicker.TimeSpanComponents>
    </telerik:RadTimeSpanPicker>
{{endregion}}

#### __Figure 1: The new StringFormat representation of the TimeSpan__

![](images/RadTimeSpanPicker_Key_Properties_01.png)

>A detailed inforamation about the supported formats you could find [here](https://msdn.microsoft.com/en-us/library/ee372287%28v=vs.110%29.aspx).

# See Also

 * [Overview]({%slug radtimespanpicker-overview%})

 * [Getting Started]({%slug radtimespanpicker-getting-started%})