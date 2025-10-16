---
title: Quadrant-style gauge
page_title: Quadrant-style gauge
description: Check our &quot;Quadrant-style gauge&quot; documentation article for the RadGauge {{ site.framework_name }} control.
slug: radial-scale-quadrant-style-gauge
tags: quadrant-style,gauge
published: True
position: 9
---

# Quadrant-style gauge

Many gauge application requires radial scale which have a quadrant shape: 

For the purpose the RadRadialGauge object exposes an enumerable with 4 orientations of the quadrant gauges:

* __North-West__ - the RadRadialGauge control has a template which represents north-west oriented quadrant circle.          

	```XAML
		<telerik:RadQuadrantNWGauge Width="120" Height="120" telerik:StyleManager.Theme="Windows8">
			<telerik:QuadrantNWScale Min="0" Max="50" MajorTickStep="10">
				<telerik:QuadrantNWScale.Indicators>
					<telerik:Needle IsAnimated="True" />
					<telerik:Pinpoint />
				</telerik:QuadrantNWScale.Indicators>
			</telerik:QuadrantNWScale>
		</telerik:RadQuadrantNWGauge>
	```

	![{{ site.framework_name }} RadGauge Quadrant North West Scale](images/QuadrantNWGauge.png)

* __North-East__ - the RadRadialGauge control has a template which represents north-east oriented quadrant circle.          

	```XAML
		<telerik:RadQuadrantNEGauge Width="120" Height="120" telerik:StyleManager.Theme="Windows8">
			<telerik:QuadrantNEScale Min="0" Max="50" MajorTickStep="10">
				<telerik:QuadrantNEScale.Indicators>
					<telerik:Needle IsAnimated="True" />
					<telerik:Pinpoint />
				</telerik:QuadrantNEScale.Indicators>
			</telerik:QuadrantNEScale>
		</telerik:RadQuadrantNEGauge>
	```

	![{{ site.framework_name }} RadGauge Quadrant North East Scale](images/QuadrantNEGauge.png)

* __South-East__ - the RadRadialGauge control has a template which represents south-east oriented quadrant circle.

	```XAML
		<telerik:RadQuadrantSEGauge Width="120" Height="120" telerik:StyleManager.Theme="Windows8">
			<telerik:QuadrantSEScale Min="0" Max="50" MajorTickStep="10">
				<telerik:QuadrantSEScale.Indicators>
					<telerik:Needle IsAnimated="True" />
					<telerik:Pinpoint />
				</telerik:QuadrantSEScale.Indicators>
			</telerik:QuadrantSEScale>
		</telerik:RadQuadrantSEGauge>
	```

	![{{ site.framework_name }} RadGauge Quadrant South East Scale](images/QuadrantSEGauge.png)

* __South-West__ - the RadRadialGauge control has a template which represents south-west oriented quadrant circle.          

	```XAML
		<telerik:RadQuadrantSWGauge Width="120" Height="120" telerik:StyleManager.Theme="Windows8">
			<telerik:QuadrantSWScale Min="0" Max="50" MajorTickStep="10" >
				<telerik:QuadrantSWScale.Indicators>
					<telerik:Needle IsAnimated="True" />
					<telerik:Pinpoint />
				</telerik:QuadrantSWScale.Indicators>
			</telerik:QuadrantSWScale>
		</telerik:RadQuadrantSWGauge>
	```

	![{{ site.framework_name }} RadGauge Quadrant South West Scale](images/QuadrantSWGauge.png)