---
title: Busy Indicator
page_title: Busy Indicator
description: Learn how to display a notification whenever a longer-running process is being handled by Telerik's {{ site.framework_name }} DataGrid by incorporating the RadBusyIndicator.
slug: gridview-busy-indicator
tags: busy,indicator
published: True
position: 13
---

# Busy Indicator

RadGridView enables you to display a notification whenever a longer-running process is being handled by the control by incorporating a [RadBusyIndicator]({%slug radbusyindicator-overview%}) inside its control template. This makes the UI more informative and the user experience smoother.

## Enabling the Indicator

To activate the indicator you have to set RadGridView's __IsBusy__ boolean property to __True__. 

__Example 1: Setting the IsBusy property__

```XAML
	<telerik:RadGridView IsBusy="True"/>
```

You can data bind this property in any way that suits your custom logic. Note that the indicator will be visible only when the __IsBusy__ property is set to __True__.

{% figure 1, "RadGridView with busy indicator", "gridview-features-isbusy.gif" %}

## Progress Determination

The indicator itself can be either determined or indetermined. These correspond to the following scenarios: 

* a specific period of time

* an indetermined amount of time

The default the indicator is indetermined. If you need a determined __RadBusyIndicator__ you have to set the value of the __BusyIndicatorIsIndeterminate__ property of the RadGridView control to __False__.

In this case you also need to specify the __BusyIndicatorProgressValue__ property, which will indicate how much of the predefined time has already elapsed. You can set its value through XAML or code-behind. However, to get the most out of it, you have to bind it to a percentage value (between 0 and 100) indicating the state of the ongoing process. If it is less or equal to 0 the donut will be empty and when it is grater or equal to 100 the donut will be filled.

__Example 2: Defining a determined indicator__

```XAML
	<telerik:RadGridView BusyIndicatorIsIndeterminate="False" BusyIndicatorProgressValue="67" />
```

{% figure 2, "RadGridView with determined busy indicator", "gridview-features-progress-value.png" %}

>A good example of how to define and update a determined busy indicator has been demonstrated in the [following article]({%slug radbusyindicator-features-report-progress-value%}).

## Custom Busy Content

RadGridView also provides the option to customize what's shown as the indicator's content while it is active through the __BusyIndicatorContent__ and __BusyIndicatorContentTemplate__ properties.

__Example 3: Setting BusyIndicatorContent__

```XAML
	<telerik:RadGridView BusyIndicatorContent="Loading data..." />
```

__Example 4: Setting BusyIndicatorContentTemplate__

```XAML
	<telerik:RadGridView>
        <telerik:RadGridView.BusyIndicatorContentTemplate>
            <DataTemplate>
                <StackPanel Orientation="Horizontal" DataContext="{Binding RelativeSource={RelativeSource AncestorType=telerik:RadGridView}}">
                    <TextBlock Text="Loading... " FontWeight="Bold" />
                    <TextBlock Text="{Binding BusyIndicatorProgressValue}" FontWeight="Bold" />
                    <TextBlock Text="%" FontWeight="Bold" />
                </StackPanel>
            </DataTemplate>
        </telerik:RadGridView.BusyIndicatorContentTemplate>
	</telerik:RadGridView>
```

{% figure 3, "RadGridView with busy indicator with custom content template", "gridview-features-content-template.png" %}

## See Also

* [RadBusyIndicator]({%slug radbusyindicator-overview%})
