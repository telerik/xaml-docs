---
title: How to Add Labels Inside Bars of RadStackedDataBar and RadStacked100DataBar
description: This article demonstrates how to add labels inside the bars of RadStacked100DataBar.
type: how-to
page_title: Place Labels In RadStackedDataBar and RadStacked100DataBar
slug: kb-databar-add-labels-inside-bars
position: 0
tags: databar, add, labels, inside, bars, radstackeddatabar, radstacked100databar
ticketid: 1449620
res_type: kb
---

## Environment
<table>
	<tr>
		<td>Product</td>
		<td>RadDataBar for WPF</td>
	</tr>
</table>

## Description

How to add labels inside the bars of RadStackedDataBar and RadStacked100DataBar.

## Solution

To achieve this requirement you need to [modify the control template]({%slug styling-apperance-editing-control-templates%}) of the **StackedBarItem** control and add an extra **TextBlock** to it. To position the label (TextBlock) accordingly, you will also have to define a converter similar to the one in **Example 1**:

__Example 1: Define the LabelOffsetConverter__
    ```C#
    public class LabelOffsetConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var barItem = values[0] as StackedBarItem;
            var width = barItem.ActualWidth;
            var dc = barItem.DataContext as DataBarDataItem;
            return new Thickness(width * dc.LeftPercent, 0, 0, 0);
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    ```

As can be observed, the converter calculates the offset based on the **LeftPercent** property of the underlying **DataBarDataItem**. It can be then used in the control template of the StackedBarItem as shown in **Example 2**:

__Example 2: Use the converter in the StackedBarItem template__
    ```XAML
        <local:LabelOffsetConverter x:Key="LabelOffsetConverter" />
        <Style TargetType="dataBars:StackedBarItem">
            <Setter Property="IsTabStop" Value="False"/>
            <Setter Property="Template">
                <Setter.Value>
                    <ControlTemplate TargetType="dataBars:StackedBarItem">
                        <Grid>
                            <dataBars:DataBarShape
                            LeftPercent="{Binding LeftPercent}"
                            RightPercent="{Binding RightPercent}"
                            HeightPercent="{TemplateBinding BarHeightPercent}"
                            Fill="{TemplateBinding BarBrush}"
                            Stroke="{TemplateBinding BarBorderBrush}"
                            StrokeThickness="{TemplateBinding BarBorderThickness}"
                            ShowToolTip="{TemplateBinding ShowToolTip}"
                            Style="{TemplateBinding BarStyle}"/>
                            <TextBlock VerticalAlignment="Center" Text="{Binding Value}">
                                <TextBlock.Margin>
                                    <MultiBinding Converter="{StaticResource LabelOffsetConverter}">
                                        <Binding Path="." RelativeSource="{RelativeSource AncestorType=dataBars:StackedBarItem}" />
                                        <Binding Path="ActualWidth" RelativeSource="{RelativeSource AncestorType=dataBars:StackedBarItem}" />
                                    </MultiBinding>
                                </TextBlock.Margin>
                            </TextBlock>
                        </Grid>
                    </ControlTemplate>
                </Setter.Value>
            </Setter>
        </Style>
    ```

Please note that the use of a **MultiBinding** is required so that the label offset is updated each time the **ActualWidth** of the items changes - in case the control is resized, for example.

## See Also
* [Editing Control Templates]({%slug styling-apperance-editing-control-templates%})
* [RadStackedDataBar Properties]({%slug raddatabar-main_properties%})