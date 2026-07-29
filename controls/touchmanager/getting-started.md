---
title: Getting Started
page_title: Getting Started
description: Check our &quot;Getting Started&quot; documentation article for the TouchManager {{ site.framework_name }} control.
slug: touchmanager-getting-started
tags: getting,started,touch,manager,touchmanager
published: True
position: 2
---

# Getting started with {{ site.framework_name }} TouchManager

This article demonstrates a simple image gallery implemented with __TouchManager__ and demonstrates the basic usage of the manager.

## Adding Telerik Assemblies Using NuGet

To use __TouchManager__ when working with NuGet packages, install the `Telerik.Windows.Controls.for.Wpf.Xaml` package. The [package name may vary]({%slug nuget-available-packages%}) slightly based on the Telerik dlls set - [Xaml or NoXaml]({%slug xaml-vs-noxaml%})

Read more about NuGet installation in the [Installing UI for WPF from NuGet Package]({%slug nuget-installation%}) article.

>tip With the 2025 Q1 release, the Telerik UI for WPF has a new licensing mechanism. You can learn more about it [here]({%slug installing-license-key%}).

## Adding Assembly References Manually

If you are not using NuGet packages, you can add a reference to the following assemblies:		

* __Telerik.Licensing.Runtime__
* __Telerik.Windows.Controls__

You can find the required assemblies for each control from the suite in the {% if site.site_name == 'Silverlight' %}[Controls Dependencies]({%slug installation-installing-controls-dependencies%}){% else %}[Controls Dependencies]({%slug installation-installing-controls-dependencies-wpf%}){% endif %} help article.

First, we can create the UI of the gallery (Example 1). We will use one panel to hold several Image elements that will represent the gallery with the small images (the thumbnails). Then we can add another panel that will display the selected image.

__Example 1: Defining the UI of the TouchManager example__
<snippet id='touchmanager-getting-started-block_1-xaml' />

This is the frame over which we will implement the touch interactions - swipe and tap. 

Here is an image that demonstrates the view:
![Getting Started 01](images/touchmanager_getting_started_01.png)

Let us start by implementing the swipe of the gallery items. We can do that by handling the swipe and swipe inertia events of TouchManager. Example 2 demonstrates how to subscribe to the events:

__Example 2: Subscribing to TouchManager events__
<snippet id='touchmanager-getting-started-block_2-cs' />
<snippet id='touchmanager-getting-started-block_3-vb' />

The logic for the swipe action will be implemented in the Swipe and SwipeInertia event handlers. We can place the implementation in a separate method and use it in the handlers.

__Example 3: Event handlers implementation__
<snippet id='touchmanager-getting-started-block_4-cs' />
<snippet id='touchmanager-getting-started-block_5-vb' />

Although we are working directly only with the Swipe and SwipeInertia events, we are going to handle the related events for consistency - SwipeStarted, SwipeFinisihed, SwipeInertiaStarted and SwipeInertiaFinished. 

__Example 4: Event handlers implementation__
<snippet id='touchmanager-getting-started-block_6-cs' />
<snippet id='touchmanager-getting-started-block_7-vb' />
	
> The __SwipeInertia__ event won't be fired unless the __SwipeInertiaStarted__ is handled.
> `args.Handled=true`

Now when you swipe horizontally through the gallery, the images will scroll.

{% if site.site_name == 'WPF' %}
## Telerik UI for WPF Learning Resources

* [Telerik UI for WPF TouchManager Component](https://www.telerik.com/products/wpf/touch-manager.aspx)
* [Getting Started with Telerik UI for WPF Components]({%slug getting-started-first-steps%})
* [Telerik UI for WPF Installation]({%slug installation-installing-which-file-do-i-need%})
* [Telerik UI for WPF and WinForms Integration]({%slug winforms-integration%})
* [Telerik UI for WPF Visual Studio Templates]({%slug visual-studio-templates%})
* [Setting a Theme with Telerik UI for WPF]({%slug styling-apperance-implicit-styles-overview%})
* [Telerik UI for WPF Virtual Classroom (Training Courses for Registered Users)](https://learn.telerik.com/learn/course/external/view/elearning/16/telerik-ui-for-wpf) 
* [Telerik UI for WPF License Agreement](https://www.telerik.com/purchase/license-agreement/wpf-dlw-s)
{% endif %}

## See Also
* [Overview]({%slug touchmanager-overview%})
* [Events]({%slug touchmanager-events%})
* [Features]({%slug touchmanager-features%})