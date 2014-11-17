---
title: Empty Content
page_title: Empty Content
description: Empty Content
slug: radchartview-features-empty-content
tags: empty,content
published: True
position: 8
---

# Empty Content



Engineers at Telerik designed the RadChartView so that it prompts you with a message when something prevents it from visualizing any content on the screen. The message you see depends on the scenario in which you use RadChartView.

## 

When there are no axes defined and if the corresponding charting component uses axes to visualize the series, RadChartView may give you one of the following default messages:

|Message|Reason for displaying|
|-------|---------------------|
|HorizontalAxis not set|      |
|VerticalAxis not set|        |
|PolarAxis not set|           | 
|AngleAxis not set|The corresponding axis is not set|
|No series added|There are no series added to the control|
|No data to plot|There is no data added to the defined series|

When the axes are properly set but there is no series defined all charting components notify you with the “No series added” message. If the series are defined but the data of the series is not set, the message is “No data to plot”.

You are allowed to customize the visualized content by using the following properties:
        

* __EmptyContent__ - this property is of type object and it gets or sets the content that will be visualized when the charting component cannot visualize anything on the screen. Please note that this object will be displayed in all of the above mentioned cases.
            

#### __XAML__
{{region radchartview-empty-content}}
    <telerik:RadCartesianChart EmptyContent="This is a custom string" >
    </telerik:RadCartesianChart>
{{endregion}}


* __EmptyContentTemplate__ - this property is of type DataTemplate and it gets or sets the data template that will be applied to the EmptyContent object.

#### __XAML__
{{region radchartview-empty-content_2}}
    <telerik:RadCartesianChart>
        <telerik:RadCartesianChart.EmptyContentTemplate>
            <DataTemplate>
                <StackPanel>
                      <Image Source="Error.jpg"></Image>
                      <TextBlock Text="There is an error in the settings of the control!"></TextBlock>
                </StackPanel>
            </DataTemplate>
        </telerik:RadCartesianChart.EmptyContentTemplate>
    </telerik:RadCartesianChart>
{{endregion}}
# See Also
