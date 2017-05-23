---
title: Changes
page_title: Changes
description: Changes
slug: radmap-changes
tags: changes
published: True
position: 0
---

# Changes

To see the fixes and features included in our latest official release please refer to our {% if site.site_name == 'Silverlight' %} [Release History](http://www.telerik.com/support/whats-new/silverlight/release-history) {% endif %} {% if site.site_name == 'WPF' %} [Release History](http://www.telerik.com/support/whats-new/wpf/release-history) {% endif %}.

## R2 2017

### What's Changed

* __BingMapProvider, BingRouteProvider, BingSearchProvider, BingGeocodeProvider are deleted.__
	
	The providers use the old Bing SOAP services which will be stopped in June 2017. Instead, you can use the new [REST map provider]({%slug radmap-features-providers-bing-rest-map%}). 
	
	The BingMapProvider can be easility replaced with __BingRestMapProvider__ using the same Bing Key. BingRestMapProvider is REST services based and displays the same image map tiles the BingMapProvider does.
	
	BingRouteProvider and BingGeocodeProvider can be replaced with __BingRestMapProvider__.
	
	BingSearchProvider has no replacement currently in RadMap. This is because Bing stops the SOAP Search API in June 30 2017 and they also have no current replacement for search. They might release a new REST based search API as stated in [this forum post](https://social.msdn.microsoft.com/Forums/en-US/65650056-822d-463a-b519-b7bf01413f6f/how-to-search-near-by-restaurants-in-bing-maps?forum=bingmapsservices).

* __BingMapTrafficProvider is deleted.__
	
	This is due to a limitation in the Bing Maps developer API terms of use. Also the service which stays behind this provider might be stopped at some point, so if you use RadMap with old version (before R2 2017), this provider might also stop working.

	Currently there is no direct replacement of BingMapTrafficProvider. Instead, you can use Bing REST Traffic API and retrieve traffic information. Then you can use the data and display map objects over RadMap. You can check the [Using the REST Services with .NET](https://msdn.microsoft.com/en-us/library/jj819168.aspx) MSDN tutorial.

## Q1 2014

### What's Fixed

* Fixed: The AsyncShapeFileReader does not read very small DBF-files

* Fixed: BingMapProvider memory leaks 

* Fixed: InvalidOperationException is thrown when using VisualizationLayer and changing themes runtime 

* Fixed: Specific PathData is not displayed in VisualizationLayer

### What's New

* Feature: Add ability to setup RectangleGeometryData using coordinates of the top-left (NW) and bottom-right (SE) corners of the rectangle
