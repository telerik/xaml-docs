---
title: Gotchas
page_title: Gotchas
description: Gotchas
slug: radchartview-gotchas
tags: gotchas
published: True
position: 11
site_name: Silverlight
---

# Gotchas

## Null auto-generated x:Name fields

Setting x:Name on a series object in XAML will produce an auto-generated field in the code-behind as usual but this field will be null at run-time. This happens because RadChartView keeps its series and other internal objects in strongly typed collections in order to avoid casting (and exceptions related to casting). It appears that there is a known bug in the Silverlight framework that causes the [FindName()](http://msdn.microsoft.com/en-us/library/system.windows.frameworkelement.findname(v=VS.95).aspx) method to fail when searching for the series because they are not in an actual UIElement collection but in a custom collection that is not related to Silverlight. Currently the only way to get the series object that was declared in XAML is to find it in the __Series__ property of RadChartView.
        
