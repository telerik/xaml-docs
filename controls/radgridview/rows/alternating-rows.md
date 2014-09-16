---
title: Alternating Rows
page_title: Alternating Rows
description: Alternating Rows
slug: radgridview-rows-alternating-rows
tags: alternating,rows
publish: True
position: 3
---

# Alternating Rows



## 

The __RadGridView__ allows you to have alternating rows. In order to define the pattern of alternation you have to set the __AlternationCount__ property. For example if you want to alternate each second row, you have to set its value to __2__. Setting it to __3__ makes each third row to be alternated.

In order to style the alternating rows, you can specify the __AlternateRowStyle__ and/or the __AlternateRowBackground__ properties.

>tipTo learn more about styling the rows and the alternating rows you can read [here]({%slug gridview-styling-a-row%}).
          

Here is an example of __RadGridView__ with __AlternationCount__ set to __3__ and __AlternateRowBackground__ color set to __Coral__.

#### __XAML__

{{region radgridview-rows-alternating-rows_0}}
	<telerik:RadGridView x:Name="radGridView"
	                         AutoGenerateColumns="False"
	                         AlternationCount="3"
	                         AlternateRowBackground="Coral">
	    ...
	</telerik:RadGridView>
	{{endregion}}

![](images/RadGridView_Rows_Alternating_Rows_01.png)
