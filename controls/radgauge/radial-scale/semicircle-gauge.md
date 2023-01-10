---
title: Semicircle gauge
page_title: Semicircle gauge
description: Check our &quot;Semicircle gauge&quot; documentation article for the RadGauge {{ site.framework_name }} control.
slug: radial-scale-semicircle-gauge
tags: semicircle,gauge
published: True
position: 8
---

# {{ site.framework_name }} RadGauge Semicircle gauge

Many gauge application require radial scale which have a semicircle shape:

For the purpose the RadRadialGauge object exposes an enumerable with 4 orientations of the semicircle gauges:

* __North__ - the RadRadialGauge control has a template which represents north-oriented semi-circle.          

	#### __XAML__
	{{region radial-scale-semicircle-gauge_0}}
		<telerik:RadSemicircleNorthGauge telerik:StyleManager.Theme="Windows8">
			<telerik:SemicircleNorthScale>
				<telerik:SemicircleNorthScale.Indicators>
					<telerik:Needle Value="20" />
					<telerik:Pinpoint />
				</telerik:SemicircleNorthScale.Indicators>
			</telerik:SemicircleNorthScale>
		</telerik:RadSemicircleNorthGauge>
	{{endregion}}

	![{{ site.framework_name }} RadGauge Semicircle North Scale](images/SemicircleNGauge.png)

* __South__ - the RadRadialGauge control has a template which represents south-oriented semi-circle.          

	#### __XAML__
	{{region radial-scale-semicircle-gauge_1}}
		<telerik:RadSemicircleSouthGauge telerik:StyleManager.Theme="Windows8">
			<telerik:SemicircleSouthScale>
				<telerik:SemicircleSouthScale.Indicators>
					<telerik:Needle Value="20" />
					<telerik:Pinpoint />
				</telerik:SemicircleSouthScale.Indicators>
			</telerik:SemicircleSouthScale>
		</telerik:RadSemicircleSouthGauge>
	{{endregion}}

	![{{ site.framework_name }} RadGauge Semicircle South Scale](images/SemicircleSGauge.png)

* __East__ - the RadRadialGauge control has a template which represents east-oriented semi-circle.          

	#### __XAML__
	{{region radial-scale-semicircle-gauge_2}}
		<telerik:RadSemicircleEastGauge telerik:StyleManager.Theme="Windows8">
			<telerik:SemicircleEastScale>
				<telerik:SemicircleEastScale.Indicators>
					<telerik:Needle Value="20" />
					<telerik:Pinpoint />
				</telerik:SemicircleEastScale.Indicators>
			</telerik:SemicircleEastScale>
		</telerik:RadSemicircleEastGauge>
	{{endregion}}

	![{{ site.framework_name }} RadGauge Semicircle East Scale](images/SemicircleEGauge.png)

* __West__ - the RadRadialGauge control has a template which represents west-oriented semi-circle.          

	#### __XAML__
	{{region radial-scale-semicircle-gauge_3}}
		<telerik:RadSemicircleWestGauge telerik:StyleManager.Theme="Windows8">
			<telerik:SemicircleWestScale>
				<telerik:SemicircleWestScale.Indicators>
					<telerik:Needle Value="20" />
					<telerik:Pinpoint />
				</telerik:SemicircleWestScale.Indicators>
			</telerik:SemicircleWestScale>
		</telerik:RadSemicircleWestGauge>
	{{endregion}}

	![{{ site.framework_name }} RadGauge Semicircle West Scale](images/SemicircleWGauge.png)