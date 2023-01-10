---
title: States
page_title: States
description: This article provides information about the states of RadCircularProgressBar control.
slug: radcircularprogressbar-states
tags: states, indeterminate, determinate
published: True
position: 3
---

# {{ site.framework_name }} RadCircularProgressBar States

`RadCircularProgressBar` supports two types of operation modes. Each of these modes is aimed at different scenarios.

## Determinate State

This mode of operation is intended for scenarios where the RadCircularProgressBar's progress can be measured precisely. This state is the default one.

>tip Set the `IsIndeterminate` property of RadCircularProgressBar to __False__ to use this state if it is not the active one.

#### __[XAML] Setting the determinate state__
{{region radcircularprogressbar-states-0}}
    <telerik:RadCircularProgressBar Name="radCircularProgressBar" Value="0.75" IsIndeterminate="False"/>
{{endregion}}

#### __[C#] Setting the determinate state in code__
{{region radcircularprogressbar-states-1}}
    RadCircularProgressBar radCircularProgressBar = new RadCircularProgressBar();
    radCircularProgressBar.Value = 0.75;
    radCircularProgressBar.IsIndeterminate = false;
{{endregion}}

#### __[VB.NET] Setting the determinate state in code__
{{region radcircularprogressbar-states-2}}
    Dim radCircularProgressBar As RadCircularProgressBar = New RadCircularProgressBar()
    radCircularProgressBar.Value = 0.75
    radCircularProgressBar.IsIndeterminate = False
{{endregion}}

__Determinate state__

![Determinate state](images/radcircularprogressbar-states-0.png)

## Indeterminate State

This state is aimed at scenarios where the operation progress cannot be precisely measured. When this mode is active, a circular animation of the progress will be played. To active this mode, set the `IsIndeterminate` property of RadCircularProgressBar to __True__.

#### __[XAML] Setting the indeterminate state__
{{region radcircularprogressbar-states-3}}
    <telerik:RadCircularProgressBar Name="radCircularProgressBar" IsIndeterminate="True"/>
{{endregion}}

#### __[C#] Setting the indeterminate state in code__
{{region radcircularprogressbar-states-4}}
    RadCircularProgressBar radCircularProgressBar = new RadCircularProgressBar();
    radCircularProgressBar.IsIndeterminate = true;
{{endregion}}

#### __[VB.NET] Setting the indeterminate state in code__
{{region radcircularprogressbar-states-5}}
    Dim radCircularProgressBar As RadCircularProgressBar = New RadCircularProgressBar()
    radCircularProgressBar.IsIndeterminate = True
{{endregion}}

__Indeterminate state__

![Indeterminate state](images/radcircularprogressbar-states-1.gif)

## IndeterminateIndicatorRatio

RadCircularProgressBar allows you to modify the ratio of the progress indicator, when the control is in indeterminate state. To do so, set the `IndeterminateIndicatorRatio` property. The accepted values are in the ranges between __0__ and __1__. The default value of this property is __0.125__.

#### __[XAML] Setting the IndeterminateIndicatorRatio__
{{region radcircularprogressbar-states-6}}
    <telerik:RadCircularProgressBar Name="circularProgressBar" IsIndeterminate="True" IndeterminateIndicatorRatio="0.75"/>
{{endregion}}

#### __[C#] Setting the IndeterminateIndicatorRatio in code__
{{region radcircularprogressbar-states-7}}
    RadCircularProgressBar radCircularProgressBar = new RadCircularProgressBar();
    radCircularProgressBar.IsIndeterminate = true;
    radCircularProgressBar.IndeterminateIndicatorRatio = 0.75;
{{endregion}}

#### __[VB.NET] Setting the IndeterminateIndicatorRatio in code__
{{region radcircularprogressbar-states-8}}
    Dim radCircularProgressBar As RadCircularProgressBar = New RadCircularProgressBar()
    radCircularProgressBar.IsIndeterminate = True
    radCircularProgressBar.IndeterminateIndicatorRatio = 0.75
{{endregion}}

## See Also
* [Segments]({%slug radcircularprogressbar-segments%})