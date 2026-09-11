---
title: Change the Color or Text Color of GridViewCell Based on a Property's Value
description: Use a property's value to change the background or foreground (text color) of a GridViewCell in a conditional style.
components: ["gridview"]
type: how-to
page_title: Apply a Different Background or Foreground on the GridViewCell Based on a Condition
slug: kb-gridview-change-color-baseon-conditions
position: 
tags: radgridview, background, foreground, text color, condition, cell, gridview, converter
ticketid: 1431006
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2019.3 917</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadGridView for WPF</td>
		</tr>
	</tbody>
</table>


## Description
How to change the background or text color (foreground) of a GridViewCell based on the value of a property of the underlying data item.

## Solution
To achieve the desired result, you need to create a converter with multiple conditions.


```C#
	public class ValueToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int count = (int)value;
            if (count < 0 && count >=-2)
                return new SolidColorBrush(Colors.Orange);
            else if (count < -2)
                return new SolidColorBrush(Colors.Red);
            else if (count > 0 && count <=2)
                return new SolidColorBrush(Colors.GreenYellow);
            else if (count > 2)
                return new SolidColorBrush(Colors.Green);
            if (parameter?.ToString() == "Foreground")
                return new SolidColorBrush(Colors.Black);
            return new SolidColorBrush(Colors.White);
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
```


```XAML
    <Grid.Resources>
        <local:ValueToColorConverter x:Key="ColorConverter"/>
	<!-- If you are using the StyleManager theming mechanism with the XAML binaries, remove the BasedOn attributes -->
        <!-- You can set Background, Foreground (text color), or both based on the converter -->
        <Style TargetType="telerik:GridViewCell" BasedOn="{StaticResource GridViewCellStyle}">
            <Setter Property="Background" Value="{Binding Value, Converter={StaticResource ColorConverter}}"/>
            <Setter Property="Foreground" Value="{Binding Value, Converter={StaticResource ColorConverter}, ConverterParameter=Foreground}"/>
        </Style>
    </Grid.Resources>
```
