---
title: How to Use RadDocking in Prism
page_title: How to Use RadDocking in Prism
description: How to Use RadDocking in Prism
slug: raddocking-how-to-use-raddocking-in-prism
tags: how,to,prism
published: True
position: 8
---

# How to Use RadDocking in Prism

[Prism](https://github.com/PrismLibrary) can be thought of as a set of libraries for building scalable, maintainable and testable XAML applications. It provides a number of features such as modularity, view regions and commanding. A common scenario is to use RadDocking control with Prism. The recommended approach is to declare the entire Docking control as a Prism region and add the RadPanes as region Views, after which all that is required is to create a custom RegionAdapter that would adapt the control's PanesSource to that region’s Views.

For further details you could check the [Docking PRISM Implementation with MEF](https://github.com/telerik/xaml-sdk/tree/master/Docking/ShellPrism) example in our SDK Repository which demonstrates how to implement the main functionality of RadDocking using PRISM and MEF. The covered scenarios include:

 * MEF
 * MVVM
 * CustomRegionAdapter
 * CustomRegionBehavior which helps Activation implementation
 * Activation
 * Custom Event aggregators
 * Predefined docking layout at start up
 * Save and Load docking layout on application start up and exit
 * Adding new documents at runtime

For detailed description on the implementation check the [Using RadDocking with PRISM in WPF/Silverlight](http://www.telerik.com/blogs/using-raddocking-with-prism-in-wpf-silverlight) blog post.

# See Also

 * [PanesSource - MVVM Support]({%slug raddocking-features-panes-panesource%})