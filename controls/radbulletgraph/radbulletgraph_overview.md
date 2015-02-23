---
title: Overview
page_title: Overview
description: Overview
slug: radbulletgraph_overview
tags: overview
published: True
position: 0
---

# Overview

{% if site.site_name == 'Silverlight' %}![](images/RadBulletGraph_Overview_01.png){% endif %}
{% if site.site_name == 'WPF' %}![](images/RadBulletGraph_Overview_01_WPF.png){% endif %}

Thank you for choosing Telerik __RadBulletGraph__!

The __RadBulletGraph__ control is a variation of linear gauge. It combines a number of indicators, as well as the data indicator into one control, which is light weight, easily customizable and straightforward to setup and use. The control a great  tool for dashboards as it is the optimal way to present a lot of information in relatively small size.

__Key features:__

* Easy to use – Using Telerik __RadBulletGraph__ is as easy as just dragging & dropping it from the toolbox.

* The Telerik __RadBulletGraph__ control supports the full design specification (as of March 12, 2010) : non zero-based scale, negative featured measures, projected values, having many comparative measures and quantitative ranges is not a problem.

* Data Binding Support - the control can be easily data bound to your business data, either by setting its properties directly, or by using a binding declaration.

* Styling and appearance - Telerik __RadBulletGraph__ is a 100% lookless control providing full support for Expression Blend. 

* MVVM support - Telerik __RadBulletGraph__ can be integrated with the Model-View-ViewModel (MVVM) pattern to get better control over chart customization. The control exposes fully separates functionality from appearance, thus providing you the power to completely restyle it without changing a single line of code.

__RadBulletGraph elements__

The following screenshot demonstrates the elements available in the Bullet graph control:  
![](images/radbulletgraphelements.png)

__Types of Bullet graphs__

There are two main types of bullet graphs - __horizontal__ and __vertical__, depending on the direction in which the control is drawn.

Below is a basic declaration of a __horizontal__ graph:

#### __C#__
{{region radbulletgraph_overview_0}}
	<telerik:RadHorizontalBulletGraph FeaturedMeasure="330" ComparativeMeasure="550"> 
	</telerik:RadHorizontalBulletGraph>
{{endregion}}

We can declare a __vertical__ bullet graph as shown in the code below:

#### __C#__
{{region radbulletgraph_overview_1}}
	<telerik:RadVerticalBulletGraph FeaturedMeasure="270" ComparativeMeasure="250">                   
	</telerik:RadVerticalBulletGraph>
{{endregion}}