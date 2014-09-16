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
<table><th><tr><td>

Message</td><td>

Reason for displaying</td></tr></th><tr><td>

HorizontalAxis not set</td></tr><tr><td>

VerticalAxis not set</td></tr><tr><td>

PolarAxis not set</td></tr><tr><td>

AngleAxis not set</td><td>

The corresponding axis is not set</td></tr><tr><td>

No series added</td><td>

There are no series added to the control</td></tr><tr><td>

No data to plot</td><td>

There is no data added to the defined series</td></tr></table>

When the axes are properly set but there is no series defined all charting components notify you with the “No series added” message. If the series are defined but the data of the series is not set, the message is “No data to plot”.

You are allowed to customize the visualized content by using the following properties:
        

* __EmptyContent__ - this property is of type object and it gets or sets the content that will be visualized when the charting component cannot visualize anything on the screen. Please note that this object will be displayed in all of the above mentioned cases.
            

	
<telerik:RadCartesianChart EmptyContent="This is a custom string" >
</telerik:RadCartesianChart>




* __EmptyContentTemplate__ - this property is of type DataTemplate and it gets or sets the data template that will be applied to the EmptyContent object.
            

	
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




# See Also
