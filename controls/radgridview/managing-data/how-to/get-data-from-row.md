---
title: Get the data from a row
page_title: Get the data from a row
description: Check out two scenarios for obtaining data from a row - getting the data from the selected row and getting the data from any row in Telerik's {{ site.framework_name }} DataGrid.
slug: gridview-how-to-get-data-from-row
tags: get,the,data,from,a,row
published: True
position: 3
---

# Get the data from a row

This article shows how to obtain the data from a row of RadGridView.

We will consider two scenarios - getting the data from the selected row and getting the data from any GridViewRow. 

* The __SelectedItem__ property of RadGridView returns an object which can be cast to your business object. So, it is very easy to get the underlying data from the selected item:



<snippet id='radgridview-managing-data-how-to-get-data-from-row-block_1-cs' />

<snippet id='radgridview-managing-data-how-to-get-data-from-row-block_1-vb' />


* Getting the data from an __arbitrary GridViewRow__ is almost the same - you just need to cast its __DataContext__ or __Item__ property to your business object:



<snippet id='radgridview-managing-data-how-to-get-data-from-row-block_2-cs' />

<snippet id='radgridview-managing-data-how-to-get-data-from-row-block_2-vb' />





