---
title: Getting Started
page_title: Getting Started - Badge WPF
description: Check our &quot;Getting Started&quot; documentation article for the RadBadge WPF control.
slug: radbadge-getting-started
tags: getting,started
published: True
position: 2
---

# {{ site.framework_name }} RadBadge Getting Started

This tutorial will walk you through the creation of a sample application that contains a __RadBadge__ control.

## Assembly References

To use __RadBadge__, add references to the following assemblies:

* __Telerik.Windows.Controls__

## Defining the RadBadge

#### __[C#] Defining RadBage in XAML__
{{region radbadge-getting-started-0}}
	<telerik:RadButton Content="Notifications" VerticalAlignment="Center" HorizontalAlignment="Center">
		<telerik:RadBadge.Badge>
			<telerik:RadBadge BadgeType="Add"  />
		</telerik:RadBadge.Badge>
	</telerik:RadButton>
{{endregion}}

#### Figure 1: RadBadge Example
![{{ site.framework_name }} RadBadge RadBadge Example](images/radbadge-getting-started-0.PNG)

## See Also  
* [Key Properties]({%slug radbadge-key-properties%})
