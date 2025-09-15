---
title: Selection not Displayed Correctly when Special Slots are Used
description: The selection is not highlighted correctly when using special slots.
type: troubleshooting
page_title: Selected Slots Not Drawn Properly when Using Special Slots
slug: kb-scheduleview-selection-not-correct-when-using-special-slots
position: 0
tags: scheduleview, selection, not, correct, when, using, special, slots
ticketid: 1457707
res_type: kb
---

## Environment
<table>
	<tr>
		<td>Product Version</td>
		<td>2020.2.617</td>
	</tr>
	<tr>
		<td>Product</td>
		<td>RadScheduleView for WPF</td>
	</tr>
</table>

## Description

The selection is not highlighted correctly when using special slots.

## Solution

The reason behind this behavior is that the **HighlightItem** controls that show the selection are drawn in the same panel as the HighlightItem controls that show the special slots. In some situations, the HighlightItems of the special slots are generated after those displaying the selection. In those cases the selection still works, but the special slot is drawn over the selection visual, so it seems like the selection is wrong.

To avoid this, you need to set the **Panel.ZIndex** attached property of the HighlightItems that show the special slots to a low value.

__Example 1: Set HighlightItem's ZIndex__
```XAML

  <local:SpecialSlotStyleSelector x:Key="SpecialSlotStyleSelector">
    <local:SpecialSlotStyleSelector.NonworkingHourStyle>
      <Style TargetType="telerik:HighlightItem">
        <Setter Property="Panel.ZIndex" Value="-100" />
        <Setter Property="Template">
          <Setter.Value>
            <ControlTemplate>
              <Border Background="LightGray">
                <StackPanel Orientation="Horizontal" VerticalAlignment="Top" HorizontalAlignment="Left">
                  <TextBlock Text="{Binding Slot.Description}" FontSize="10" FontStyle="Italic" Foreground="DarkSlateGray" />
                </StackPanel>
              </Border>
            </ControlTemplate>
          </Setter.Value>
        </Setter>
      </Style>
    </local:SpecialSlotStyleSelector.NonworkingHourStyle>
  </local:SpecialSlotStyleSelector>
```

## See Also
* [Available Themes]({%slug common-styling-appearance-available-themes%})
