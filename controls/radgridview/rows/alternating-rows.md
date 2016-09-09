---
title: Alternating Rows
page_title: Alternating Rows
description: Alternating Rows
slug: radgridview-rows-alternating-rows
tags: alternating,rows
published: True
position: 3
---

# Alternating Rows

__RadGridView__ allows you to have alternating rows should you need to improve readability. 

In order to define the pattern of alternation, you have to set the __AlternationCount__ property. For example, if you want to alternate each second row, you have to set its value to __2__. Setting the __AlternationCount__ property to __3__ shows an alternating color for each third row.

#### __[XAML] Example 1: Setting the AlternationCount Property:__

![](images/RadGridView_Rows_Alternating_Rows_02.png)

{{region xaml-radgridview-rows-alternating-rows_0}}

	<telerik:RadGridView x:Name="radGridView"
	                         AlternationCount="2">
	    ...
	</telerik:RadGridView>
{{endregion}}

In order to style the alternating rows, you can specify the __AlternateRowStyle__ and/or the __AlternateRowBackground__ properties. If you do not specify an AlternateRowBackground a default color will be picked, based on the current theme.

>tipTo learn more about styling the rows and the alternating rows you can read [here]({%slug gridview-styling-a-row%}).

__Example 2__ shows __RadGridView__ with __AlternationCount__ set to __3__ and __AlternateRowBackground__ color set to __Coral__.

#### __[XAML] Example 2: Setting the AlternateRowBackground Property:__

{{region xaml-radgridview-rows-alternating-rows_1}}

	<telerik:RadGridView x:Name="radGridView"
	                         AlternationCount="2"
	                         AlternateRowBackground="Coral">
	    ...
	</telerik:RadGridView>
{{endregion}}

![](images/RadGridView_Rows_Alternating_Rows_01.png)
