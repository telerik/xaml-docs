---
title: Change the color of GridViewCell Based on value when using DataTable
description: Using a converter to change the background of a GridViewCell
type: how-to
page_title: Change the color of GridView elements using a converter
slug: kb-gridview-change-color-baseon-conditions
position: 
tags: 
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
How to change the background color of a GridViewCell using a converter.

## Solution
To achieve the desired result, you need to create a converter with multiple conditions.

#### __[C#]__
{{region kb-gridview-change-color-baseon-conditions-0}}
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
{{endregion}}

#### __[XAML]__
{{region kb-gridview-change-color-baseon-conditions-0}}
    <Grid.Resources>
        <local:ValueToColorConverter x:Key="ColorConverter"/>
        <Style TargetType="telerik:GridViewCell">
            <Setter Property="Background" Value="{Binding Value, Converter={StaticResource ColorConverter}}"/>
        </Style>
    </Grid.Resources>
{{endregion}}