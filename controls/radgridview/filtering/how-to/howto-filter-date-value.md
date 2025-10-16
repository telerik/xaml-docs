---
title: Filter on Date and Time
page_title: Filter on Date and Time
description: Get started with the filtering functionality of Telerik's {{ site.framework_name }} DataGrid and learn how to filter on both the date and time portion.
slug: gridview-filtering-howto-filter-date-time-value
tags: filter,on,date,and,time
published: True
position: 13
---

# Filter on Date and Time

By default, when a GridViewDataColumn is bound to a property of type **DateTime** the generated field filter editor is a [RadDateTimePicker]({%slug raddatetimepicke-getting-started%}). It's [InputMode]({%slug raddatetimepicker-features-input-modes%}), however, is DatePicker which means that only the **Date** portion of the DateTime object can be selected through the UI.

Most probably, however, your __DateTime data contains a time part which is different than 00:00:00__. When you filter and select a DateTime value, this selected DateTime will have its time part equal to zero. Since DateTime objects with different time parts are not equal for the .NET Framework, you will have no match.

A possible approach in the case when you also wish to filter out the **Time** portion is to handle the [FieldFilterEditorCreated]({%slug gridview-filtering-howto-customize-the-default-field-filter-editor%}) event and set the InputMode of the RadDateTimePicker editor to **DateTimePicker**. **Example 1** demonstrates how this can be achieved.

__Example 1: Change the InputMode of the RadDateTimePicker filter editor to DateTimePicker__

```C#
	private void GridView_FieldFilterEditorCreated(object sender, Telerik.Windows.Controls.GridView.EditorCreatedEventArgs e)
	{
	    if (e.Column.UniqueName == "HireDate")
	    {
	        Telerik.Windows.Controls.RadDateTimePicker picker = e.Editor as Telerik.Windows.Controls.RadDateTimePicker;
	        if (picker != null)
	        {
	            picker.InputMode = Telerik.Windows.Controls.InputMode.DateTimePicker;
	        }
	    }
	}
```

Another approach, if you want to filter only on the Date portion of the DateTime objects would be to __bind your column directly to the Date (or Year) property__ of the DateTime object.

__Example 2: Bind the column to the Date portion of the property__

```XAML
	<telerik:GridViewDataColumn DataMemberBinding="{Binding HireDate.Date}" />
```

As an alternative solution, you can benefit from the [FilterMemberPath]({%slug gridview-filtering-basic%}#filtermemberpath) property of the column. You can use it to __filter the column on a property different from the one it displays__ in its cells.

__Example 3: Filter only on the Date portion of the property with FilterMemberPath__

```XAML
	<telerik:GridViewDataColumn DataMemberBinding="{Binding HireDate}" FilterMemberPath="HireDate.Date" />
```

## See Also

* [Basic Filtering]({%slug gridview-filtering-basic%})
* [Customize the Default Field Filter Editor]({%slug gridview-filtering-howto-customize-the-default-field-filter-editor%})