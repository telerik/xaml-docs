---
title: Change the Color of GridViewCell Based on a Property's Value
description: Using a Property's Value to Change the Background of a GridViewCell.
type: how-to
page_title: Apply a Different Background on the GridViewCell Based on a Condition
slug: kb-gridview-change-color-baseon-conditions
position: 
tags: background, condition, cell, gridview, converter
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
How to change the color of a GridViewCell based on the value of a property of the underlying data item.

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
        <Style TargetType="telerik:GridViewCell" BasedOn="{StaticResource GridViewCellStyle}">
            <Setter Property="Background" Value="{Binding Value, Converter={StaticResource ColorConverter}}"/>
        </Style>
    </Grid.Resources>
```
