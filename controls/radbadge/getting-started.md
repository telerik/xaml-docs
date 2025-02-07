---
title: Getting Started
page_title: Getting Started - Badge WPF
description: Check our &quot;Getting Started&quot; documentation article for the RadBadge WPF control.
slug: radbadge-getting-started
tags: getting,started
published: True
position: 2
---

# Getting Started with {{ site.framework_name }} Badge

This tutorial will walk you through the creation of a sample application that contains a __RadBadge__ control.

## Assembly References

To use __RadBadge__, add references to the following assemblies:

* __Telerik.Licensing.Runtime__
* __Telerik.Windows.Controls__

>tip With the 2025 Q1 release, the Telerik UI for WPF has a new licensing mechanism. You can learn more about it [here]({%slug installing-license-key%}).

### Adding Telerik Assemblies Using NuGet

To use __RadBadge__ when working with NuGet packages, install the `Telerik.Windows.Controls.for.Wpf.Xaml` package. The [package name may vary]({%slug nuget-available-packages%}) slightly based on the Telerik dlls set - [Xaml or NoXaml]({%slug xaml-vs-noxaml%})

Read more about NuGet installation in the [Installing UI for WPF from NuGet Package]({%slug nuget-installation%}) article.

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

{% if site.site_name == 'WPF' %}
## Telerik UI for WPF Learning Resources

* [Telerik UI for WPF BadgeControl Component](https://www.telerik.com/products/wpf/badge-control.aspx)
* [Getting Started with Telerik UI for WPF Components]({%slug getting-started-first-steps%})
* [Telerik UI for WPF Installation]({%slug installation-installing-which-file-do-i-need%})
* [Telerik UI for WPF and WinForms Integration]({%slug winforms-integration%})
* [Telerik UI for WPF Visual Studio Templates]({%slug visual-studio-templates%})
* [Setting a Theme with Telerik UI for WPF]({%slug styling-apperance-implicit-styles-overview%})
* [Telerik UI for WPF Virtual Classroom (Training Courses for Registered Users)](https://learn.telerik.com/learn/course/external/view/elearning/16/telerik-ui-for-wpf) 
* [Telerik UI for WPF License Agreement](https://www.telerik.com/purchase/license-agreement/wpf-dlw-s)
{% endif %}

## See Also  
* [Key Properties]({%slug radbadge-key-properties%})
