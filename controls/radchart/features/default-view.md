---
title: DefaultView
page_title: DefaultView
description: DefaultView
slug: radchart-features-default-view
tags: defaultview
published: True
position: 17
---

# DefaultView



## 

Usually, when you have a chart to display, it contains title, chart and legend. For this common case, __RadChart__ provides you with __DefaultView__. RadChart.DefaultView is of type __ChartDefaultView__ and contains [ChartTitle]({%slug radchart-features-chart-title%}), [ChartArea]({%slug radchart-features-chart-area%}) and [ChartLegend]({%slug radchart-features-chart-legend%}).

![](images/RadChart_GeneralInformation_VisualStructure_01.png)

When you create your chart declaratively or from the code behind, with static data or using data binding, the chart is displayed using the default view. However, if you need to customize the layout, use __RadChart.UseDefaultLayout__ property and set it to __False__. In this case, you have to build the layout you need and set it to the __RadChar.Content__ property as it is shown in [Creating Chart with Custom Layout]({%slug radchart-populating-with-data-creating-a-chart-with-custom-layout%}).
        

You can find more information about using __DefaultView__ or a custom layout here: [Creating Chart Declaratively]({%slug radchart-populating-with-data-creating-chart-declaratively%}) and [Creating Chart in Code Behind]({%slug radchart-populating-with-data-creating-chart-in-code-behind%}).
        

## See Also

 * [Chart Title]({%slug radchart-features-chart-title%})

 * [Chart Area]({%slug radchart-features-chart-area%})

 * [Chart Legend]({%slug radchart-features-chart-legend%})

 * [RadChart Visual Structure]({%slug radchart-general-information-visual-structure%})

 * [Populating with Data Overview]({%slug radchart-populating-with-data-overview%})

 * [Data Binding Support Overview]({%slug radchart-populating-with-data-data-binding-support-overview%})
