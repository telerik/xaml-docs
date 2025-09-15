---
title: Radiuses
page_title: Radiuses
description: This article provides information about the track and indicator radiuses of RadCircularProgressBar control.
slug: radcircularprogressbar-radiuses
tags: radiuses, indicator radius, track radius
published: True
position: 8
---

# Radiuses

`RadCircularProgressBar` allows you to change the radius of the track, the primary and the secondary progress indicator. To change the track's radius, set the `TrackStartRadius` and `TrackEndRadius` properties. To modify the radius of the progress indicators, set the `IndicatorStartRadius` and `IndicatorEndRadius` properties.

>important If you set the `IndicatorStartRadius` and `IndicatorEndRadius` properties, their values will modify the radius of both the primary and secondary progress indicator.

__Changing the track and progress indicators radiuses__
```XAML
    <telerik:RadCircularProgressBar Name="circularProgressBar" 
                                    Value="0.5"
                                    SecondaryValue="0.75"
                                    UseRoundedSegments="True"
                                    IndicatorStartRadius="0.75"
                                    IndicatorEndRadius="1"
                                    TrackStartRadius="0.85"
                                    TrackEndRadius="0.9"/>
```

__Changing the track and progress indicators radiuses in code__
```C#
    RadCircularProgressBar radCircularProgressBar = new RadCircularProgressBar();
    radCircularProgressBar.Value = 0.5;
    radCircularProgressBar.SecondaryValue = 0.75;

    radCircularProgressBar.UseRoundedSegments = true;

    radCircularProgressBar.IndicatorStartRadius = 0.75;
    radCircularProgressBar.IndicatorEndRadius = 1;

    radCircularProgressBar.TrackStartRadius = 0.85;
    radCircularProgressBar.TrackEndRadius = 0.9;
```
```VB.NET
    Dim radCircularProgressBar As RadCircularProgressBar = New RadCircularProgressBar()
    radCircularProgressBar.Value = 0.5
    radCircularProgressBar.SecondaryValue = 0.75

    radCircularProgressBar.UseRoundedSegments = True

    radCircularProgressBar.IndicatorStartRadius = 0.75
    radCircularProgressBar.IndicatorEndRadius = 1

    radCircularProgressBar.TrackStartRadius = 0.85
    radCircularProgressBar.TrackEndRadius = 0.9
```

![RadCircularProgressBar with modified radiuses](images/radcircularprogressbar-radiuses-0.png)

## See Also
* [Angles]({%slug radcircularprogressbar-angles%})
* [Segments]({%slug radcircularprogressbar-segments%})
* [States]({%slug radcircularprogressbar-states%})