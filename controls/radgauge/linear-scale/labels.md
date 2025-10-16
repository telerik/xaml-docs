---
title: Labels
page_title: Labels
description: Check our &quot;Labels&quot; documentation article for the RadGauge {{ site.framework_name }} control.
slug: linear-scale-labels
tags: labels
published: True
position: 2
---

# Labels

Tick labels are shown for the major tick marks. You can set the label location around the scale bar, the font properties (like family, size and foreground), the format of the label, or even change the whole control template for a label. To change the location of the tick mark label you should use the __LabelLocation__ property of the scale element in XAML as shown below:


```XAML
	<telerik:RadHorizontalLinearGauge Grid.Column="0" Width="250" Height="100" telerik:StyleManager.Theme="Windows8">
	    <telerik:HorizontalLinearScale Min="0" Max="100" />
	</telerik:RadHorizontalLinearGauge>
	<telerik:RadHorizontalLinearGauge Grid.Column="1" Width="250" Height="100" >
	    <telerik:HorizontalLinearScale Min="0" Max="100" LabelLocation="OverOutside" />
	</telerik:RadHorizontalLinearGauge>
```

You can use the GaugeRange element to set specific color to your labels. The LinearScale element has the boolean __LabelUseRangeColor__ property. If its value is True, then each label within the range uses a color according to the specified __LabelForeground__ property:


```XAML
	<telerik:RadHorizontalLinearGauge Width="250" Height="100" telerik:StyleManager.Theme="Windows8">
	    <telerik:HorizontalLinearScale Min="0" Max="100" 
	                         RangeLocation="OverOutside"
	                         LabelUseRangeColor="True">
	        <telerik:HorizontalLinearScale.Ranges> 
	                <telerik:GaugeRange Min="50" Max="100"
	                                    StartWidth="0"
	                                    EndWidth="0.08"
	                                    Background="#FF25A0DA"
	                                    LabelForeground="#FF25A0DA" />
	        </telerik:HorizontalLinearScale.Ranges>
	    </telerik:HorizontalLinearScale>
	</telerik:RadHorizontalLinearGauge>
```

![{{ site.framework_name }} RadGauge HorizontalLinearScale with LabelUseRangeColor](images/LinearScaleLabelRangeColor.png)