---
title: Make the RadRating read only
page_title: Make the RadRating read only
description: Check our &quot;Make the RadRating read only&quot; documentation article for the RadRating {{ site.framework_name }} control.
slug: howto-make-readonly
tags: make,the,radrating,read,only
published: True
position: 0
---

# Make the RadRating read only

The purpose of this tutorial is to show you how to make the __RadRating__ read only.

Example 1 demonstrates a regular __RadRating__ declaration, where __telerik__ points to: __&lt;xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation" /&gt;__

__Example 1: Declare a RadRating__
```XAML
	<telerik:RadRating x:Name="radRating" Value="2.5" />
```

In order to make the __RadRating__ control read only you have to set its __IsReadOnly__ property to true:

__Example 2: Make the RadRating readonly in Xaml__
```XAML
	<telerik:RadRating x:Name="radRating" Value="2.5" IsReadOnly="True" />
```

__Example 3 Make the RadRating readonly in code__
```C#
	this.radRating.IsReadOnly = true;
```
```VB.NET
	Me.radRating.IsReadOnly = true
```

#### __Figure 1: Result from Examples 2 and 3__
![Readonly RadRating](images/rating_howto_readonly.png)