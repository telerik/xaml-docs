---
title: Annotation Labels
page_title: Annotation Labels
description: Annotation Labels
slug: radchartview-annotations-labels
tags: annotation,labels
published: True
position: 7
---

# Annotation Labels

The CartesianStrokedAnnotation class provides infrastructure for annotation labels. Currently the __CartesianGridLine__ and __CartesianPlotBand__ annotations inherit it and provide out-of-the-box support for this feature.      

## Properties

The CartesianStrokedAnnotation base class provides a __Label__ property to specify the label string and __LabelDefinition__ to control its properties like Format, Template and positioning. Annotations provide a mechanism for label positioning that consists of three layers - primary (__Location__), secondary (__HorizontalAlignment/VerticalAlignment__), and tertiary (__HorizontalOffset/ VerticalOffset__).
        

* __Location__ 
	This property defines the primary location of the annotation label visual. It allows you to position the label in 5 different positions, as illustrated below:
	
	![Rad Chart View-annotations-label-location](images/RadChartView-annotations-label-location.png)

* __Horizontal / Vertical Alignment__ 
	In conjunction with Location property, you can use the Horizontal/Vertical Alignment properties to further specify the position of the label. Refer to the table below for for possible combinations of these properties:
	
	![Rad Chart View-annotations-alignment-location](images/RadChartView-annotations-alignment-location.png)

* __Horizontal / Vertical Offset __ 
	Besides the Location, HorizontalAlignment and Vertical Alignment, you can use the __HorizontalOffset__ and __VerticalOffset__ to specify an offset in pixels. This offset is applied after the aforementioned properties.