---
title: Make the RadRating read only
page_title: Make the RadRating read only
description: Make the RadRating read only
slug: howto-make-readonly
tags: make,the,radrating,read,only
published: True
position: 0
---

# Make the RadRating read only

The purpose of this tutorial is to show you how to make the __RadRating__ read only.

Here is a regular __RadRating__ declaration, where __telerik__ points to: __<xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation" />__

#### __XAML__
{{region howto-make-readonly_0}}
	<telerik:RadRating x:Name="radRating" Value="2.5" />
{{endregion}}

In order to make the __RadRating__ control read only you have to set its __IsReadOnly__ property to true:

#### __XAML__
{{region howto-make-readonly_1}}
	<telerik:RadRating x:Name="radRating" Value="2.5" IsReadOnly="True" />
{{endregion}}

#### __C#__
{{region howto-make-readonly_2}}
	this.radRating.IsReadOnly = true
{{endregion}}

#### __VB.NET__
{{region howto-make-readonly_3}}
	Me.radRating.IsReadOnly = true;
{{endregion}}

![](images/rating_howto_readonly.png)