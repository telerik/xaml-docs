---
title: Formatting Display of DateTime Values in RadComboBox
description: "How to convert all DateTime values to list of formatted strings in RadComboBox."
type: how-to
page_title: How to Display DateTime Values as Formatted Strings in RadComboBox
slug: kb-combobox-datetimevalues-to-formattedstrings
position: 0
tags: datetime, allowmultipleselection,multipleselectionboxtemplate
ticketid: 1622029
res_type: kb
---

## Environment

<table>
    <tbody>
        <tr>
            <td>Product Version</td>
            <td>2023.2.718</td>
        </tr>
        <tr>
            <td>Product</td>
            <td>RadComboBox for WPF</td>
        </tr>
    </tbody>
</table>

## Description

How to format `DateTime` values to strings in the [Selection Box]({%slug radcombobox-general-information-visual-structure%}) element of the `RadComboBox`.

## Solution

To get the desired effect, you can bind to the `SelectedItems` or to the original string value and use an `IValueConverter` to format the values.


```C#
	public class DateTimeStringConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			var dateStrings = ((string)value).Split(',');
			var format = parameter.ToString();
			List<string> result = new List<string>();
			foreach (string dateString in dateStrings)
			{
				var date = DateTime.Parse(dateString, CultureInfo.InvariantCulture);
				result.Add(date.ToString(format, CultureInfo.InvariantCulture));
			}
			return string.Join(", ", result);
		}
	}
```

In the XAML code you can use the `RadComboBox` `MultipleSelectionBoxTemplate` property and bind the `Text` property of the `TextBlock` to the context provided in the `DataTemplate` with the converter.


```XAML
	<telerik:RadComboBox x:Name="radComboBox" AllowMultipleSelection="True">
		<telerik:RadComboBox.MultipleSelectionBoxTemplate>
			<DataTemplate>
				<TextBlock Text="{Binding Converter={StaticResource DateTimeStringConverter}, ConverterParameter='m/dd/yyyy' }"/>
			</DataTemplate>
		</telerik:RadComboBox.MultipleSelectionBoxTemplate>
	</telerik:RadComboBox>
```
