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

The purpose of this help article is to provide detailed information about some of the key properties of the __RadTimeSpanPicker__ control.
<Comment: Is this article going to get longer soon? If not, the sentence above seems odd to me. It claims that the article will discuss key properties (plural) of the control but only one property is discussed. Perhaps reword the previous sentence as "This help article will provide information about the __StringFormat__ property, a key property of the __RadTimeSpanPicker__ control." Later, when you have a few properties to discuss, the sentence above seems OK. ALSO, the header 1 "Key Properties" seems wrong since there is only one property. I suggest you change it to "StrongFormat Property" until this article expands to discuss more than one property. The same goes for the title, page_title and description above. They all suggest more than one property in this article will be discussed.>
## StringFormat

You can use the __StringFormat__ property for formatting the representation of the selected TimeSpan value to any desired format. By using it the current format of the TimeSpan could easily be changed.

The following example demonstrates how to set the __StringFormat__ property.

#### __[XAML] Example 1: Setting the StringFormat of the RadTimeSpanPicker__

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

>You can find detailed inforamation about the supported formats of the TimeSpan [here](https://msdn.microsoft.com/en-us/library/ee372287%28v=vs.110%29.aspx).

# See Also

 * [Overview]({%slug radtimespanpicker-overview%})

 * [Getting Started]({%slug radtimespanpicker-getting-started%})
