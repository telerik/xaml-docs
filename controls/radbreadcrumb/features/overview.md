---
title: Overview
page_title: Overview
description: Overview
slug: radbreadcrumb-features-overview
tags: overview
published: True
position: 0
---

# Overview

The __RadBreadcrumb__ and __RadBreacrumbItem__ controls expose a set of properties to allow further customization of their behavior and layout:

## RadBreadcrumb Common Properties

* __Header__: Gets/sets the root element of the breadcrumb control.

* __CurrentItem__: A property of type object, which gets the current destination data item.

* __CurrentContainer__: A property of type RadBreadcrumbBarItem, which gets the RadBreadcrumbItem container of the current destination data item.

* __Path__: Gets/sets the destination target path.

* __PathSeparator__: Gets/sets the path separator symbol.

	![](images/breadcrumb_features_overview_path_separator.png)

* __IsLinearMode__: A property of type bool, which controls whether the breadcrumb is in linear mode. By default this property is __False__ .

* __IsIconVisible__: A property of type bool, which controls whether the icon of the breadcrumb control should be displayed. By default this property is __False__ .

* __IsTextModeEnabled__: A property of type bool, which controls whether the text mode of the breadcrumb is enabled. By default this property is __True__ .

* __IsHistoryEnabled__: A property of type bool, which specifies whether history of visited paths should be kept. By default this property is __True__ .

	>tip Even if the __IsHistoryEnabled__ property is set to False, you can add items to the RadBreadcrumb.HistoryItems collection. You can use this collection to create a set of favorites for example.

## RadBreadcrumbItem Common Properties

* __Header__: Gets/sets the header of the BreadcrumbItem.

* __DropDownHeader__: Gets/sets the header of the RadBreadcrumbItem that is used to visualize the item when displayed inside its parent's dropdown content.

	![](images/breadcrumb_features_overview_dropdown_header.png)

* __TextModePath__: Gets/sets the string representation of the RadBreadcrumbItem in text mode

	![](images/breadcrumb_features_overview_textmodepath.png)

* __Image__: A property of type ImageSource, which allows setting an icon for the item.

	![](images/breadcrumb_features_overview_itemimage.png)

>Please avoid using the character set as a __PathSeparator__ in the __Header__ of the items, because this can lead to an unexpected behavior when you try to expand a path. Also, keep in mind that the __'\'__ character is the default PathSeparator.
	
## See Also
 * [Visual Structure]({%slug radbreadcrumb-visual-structure%})
 * [Getting Started]({%slug radbreadcrumb-getting-started%})
 * [Databinding ]({%slug radbreadcrumb-databinding%})