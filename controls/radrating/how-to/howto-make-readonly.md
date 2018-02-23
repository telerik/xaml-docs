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

Example 1 demonstrates a regular __RadRating__ declaration, where __telerik__ points to: __&lt;xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation" /&gt;__

#### __[XAML] Example 1: Declare a RadRating__
{{region xaml-howto-make-readonly_0}}
	<telerik:RadRating x:Name="radRating" Value="2.5" />
{{endregion}}

In order to make the __RadRating__ control read only you have to set its __IsReadOnly__ property to true:

#### __[XAML] Example 2: Make the RadRating readonly in Xaml__
{{region xaml-howto-make-readonly_1}}
	<telerik:RadRating x:Name="radRating" Value="2.5" IsReadOnly="True" />
{{endregion}}

#### __[C#] Example 3 Make the RadRating readonly in code__
{{region cs-howto-make-readonly_2}}
	this.radRating.IsReadOnly = true;
{{endregion}}

#### __VB.NET__
{{region vb-howto-make-readonly_3}}
	Me.radRating.IsReadOnly = true
{{endregion}}

#### __Figure 1: Result from Examples 2 and 3__
![Readonly RadRating](images/rating_howto_readonly.png)