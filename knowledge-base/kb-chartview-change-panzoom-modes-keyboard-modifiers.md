---
title: Changing RadChartView Pan and Zoom Modes with Keyboard Modifiers
description: Learn how to set RadChartView pan and zoom modes based on Ctrl and Alt keys for mouse-wheel and drag input in Telerik UI for WPF.
type: how-to
page_title: Changing RadChartView Pan and Zoom Modes with Keyboard Modifiers | Telerik UI for WPF
components: ["chartview"]
slug: kb-chartview-change-panzoom-modes-keyboard-modifiers
tags: radchartview, chartview, pan, zoom, keyboard, modifiers, mouse wheel
res_type: kb
---

## Environment

| Version | Product | Author | 
| ---- | ---- | ---- | 
| 2026.4.1110| RadChartView |[Desislava Yordanova](https://www.telerik.com/blogs/author/desislava-yordanova)| 

## Description

Telerik UI for WPF provides the `ChartPanAndZoomBehavior` class for `RadCartesianChart`. Set its `PanMode` and `ZoomMode` properties from keyboard modifiers to choose the axes for panning and zooming.

This example maps `Ctrl` to both axes, `Alt` to the vertical axis, and no `Ctrl` or `Alt` modifier to the horizontal axis.

## Solution

Attach preview event handlers to the chart and name the behavior in `MainWindow.xaml`:

```xml
<Window x:Class="ModifierDrivenChartModes.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
        Title="Modifier-Driven Chart Modes"
        Height="350"
        Width="525">
    <Grid>
        <telerik:RadCartesianChart
            PreviewMouseWheel="ChartView_PreviewMouseWheel"
            PreviewMouseDown="ChartView_PreviewMouseDown">
            <telerik:RadCartesianChart.HorizontalAxis>
                <telerik:CategoricalAxis />
            </telerik:RadCartesianChart.HorizontalAxis>
            <telerik:RadCartesianChart.VerticalAxis>
                <telerik:LinearAxis />
            </telerik:RadCartesianChart.VerticalAxis>
            <telerik:RadCartesianChart.Series>
                <telerik:BarSeries>
                    <telerik:BarSeries.DataPoints>
                        <telerik:CategoricalDataPoint Category="A" Value="10" />
                        <telerik:CategoricalDataPoint Category="B" Value="20" />
                    </telerik:BarSeries.DataPoints>
                </telerik:BarSeries>
            </telerik:RadCartesianChart.Series>
            <telerik:RadCartesianChart.Behaviors>
                <telerik:ChartPanAndZoomBehavior
                    x:Name="chartPanZoomBehavior"
                    MouseWheelMode="Default" />
            </telerik:RadCartesianChart.Behaviors>
        </telerik:RadCartesianChart>
    </Grid>
</Window>
```

Add the following handlers to the `MainWindow` partial class in `MainWindow.xaml.cs`:

```csharp
using System.Windows;
using System.Windows.Input;
using Telerik.Windows.Controls.ChartView;

namespace ModifierDrivenChartModes
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ChartView_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            this.UpdatePanAndZoomModes();
        }

        private void ChartView_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            this.UpdatePanAndZoomModes();
        }

        private void UpdatePanAndZoomModes()
        {
            ModifierKeys modifiers = Keyboard.Modifiers;
            ChartPanZoomMode mode =
                (modifiers & ModifierKeys.Control) != 0
                    ? ChartPanZoomMode.Both
                    : (modifiers & ModifierKeys.Alt) != 0
                        ? ChartPanZoomMode.Vertical
                        : ChartPanZoomMode.Horizontal;

            this.chartPanZoomBehavior.SetCurrentValue(
                ChartPanAndZoomBehavior.ZoomModeProperty, mode);
            this.chartPanZoomBehavior.SetCurrentValue(
                ChartPanAndZoomBehavior.PanModeProperty, mode);
        }
    }
}
```

The handlers update both modes before mouse-wheel or mouse-down input. `MouseWheelMode="Default"` makes wheel zoom follow `ZoomMode`.

## Notes

The code checks `Ctrl` before `Alt`. If you press both keys, the behavior uses `ChartPanZoomMode.Both`. Modifier changes during an active drag do not update the modes until another preview mouse-down or mouse-wheel event occurs.

The mode mapping controls the axes, not whether dragging pans or zooms. Configure `DragMode`, `DragToPanKeyCombinations`, or `DragToZoomKeyCombinations` separately to choose the drag action.

## See Also

* [RadChartView pan and zoom behavior]({%slug radchartview-features-panzoom%})
