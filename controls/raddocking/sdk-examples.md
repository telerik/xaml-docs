---
title: SDK Examples
page_title: SDK Examples
description: SDK Examples
slug: raddocking-sdk-examples
tags: sdk,examples
published: True
position: 6
---

# SDK Examples



The [Telerik XAML SDK repository](https://github.com/telerik/xaml-sdk/tree/master/) provides additional demos for most of the Telerik UI for {% if site.site_name == 'WPF' %}WPF{% endif %}{% if site.site_name == 'Silverlight' %}Silverlight{% endif %} controls. The examples demonstrate many specific user case scenarios, that might be really helpful. In this article you can find the complete list of all SDK examples for __RadDocking__.

## List of all RadDocking SDK examples:{% if site.site_name == 'WPF' %}

* __Auto generated tag__ - This example demonstrates how to mark SplitContainers and PaneGroups as auto-generated. In that way the Docking control will clean them once they are not needed, i.e. when there is nothing inside them, which can be used later. Only the RadSplitContainers and RadPaneGroups can have this property set. All the children of a SplitContainer should be marked as auto-generated in order it to be cleaned up by the Docking control. 

The example shows how to set this property in XAML and in code to the dynamically generated RadPanes. The saving of the layout in xml file demonstrates easier how the elements are removed if they are auto-generated.

* __Click flyout behavior with animation__ - This example demonstrates how to create a custom FlyoutBehavior for the RadDocking control in order to achieve a ClickFlyoutBehavior with slide in/out animations. The example is available for both Silverlight and WPF.

* __Close single pane in tool window__ - This example demonstrates how to create a custom ItemsFactory and ToolWindow in order to customize the way the Close button of the floating ToolWindow closes Panes when there are multple Panes in the PaneGroup for Silverllight and WPF. The example shows how to achieve a behavior, where the close button closes only the current  active Pane rather then the hole PaneGroup.

* __Compass programming__ - This example demonstrates how to customize which compasses are shown when dragging different RadPanes in the control.

When dragging a "Green" RadPane only the center compass over other "Green" RadPanes is show and the all of the root compasses.
When dragging a "Purple" RadPane all of the compasses (right, left, top, bottom and center) over other "Purple" RadPanes are shown and none of the root compasses.

More details could be found in our online help:
For WPF - http://www.telerik.com/help/wpf/raddocking-how-to-implement-conditional-docking.html
For Silverlight - http://www.telerik.com/help/silverlight/raddocking-how-to-implement-conditional-docking.html

* __Custom DockingPanesFactory__ - 
This example demonstrates how to use a custom DockingPanesFactory in order to add the RadPanes from the PanesSource collection to a predefined empty RadPaneGroups in the control.

* __Docking inside win forms__ - This example illustrates how to work-around an exception thrown when dragging a Pane.
The issue is caused because the Application.Current is Specific for WPF Application.
Therefore when using WPF controls in WinForms Application it needs to be initialized an instance of WPF Application. This shoud be done in the WinForms Application.

* __Floating Panes taskbar icons__ - 
This example demonstrates how to show the floating Panes in the taskbar and set a default icon or a specific icon for specific Panes.

* __MDI Layout__ - 
This example demonstrates how to achieve MDI layout with the Docking control.

* __Nested RadDocking Save and Load of layout__ - 
This example demonstrates how to save and load the layout in nested RadDocking scenarios. The approved mechanism is to save/load each controls layout separately but simultaneously.

* __How to use PanesSource in nested RadDocking scenarios__ - 
This example demonstrates how the PanesSource collection could be used in nested RadDocking scnearios.

* __Open closed panes with context menu__ - This example demonstrates how to show the closed RadPanes when you close them by their close button also shows how to permanently close a RadPane for Silverlight and WPF.

* __Ordered unpinned panes__ - The example demonstrates how to keep the unpinned RadPanes ordered the way they were defined in XAML while pining/unpinning them at run-time.

* __Pane group items source__ - IMPORTANT: With our Q3 2013 SP release of RadDocking there is a new functionality for achieving MVVM scenarios that require an equivalent of ItemsSource with the addition of PanesSource. More details about the PanesSource feature can be found here: For WPF: http://www.telerik.com/help/wpf/raddocking-features-panes-panesource.html For SL: http://www.telerik.com/help/silverlight/raddocking-features-panes-panesource.html The example demonstrates how to extend the functionality of RadDocking with the use of Attached Properties in order to  set a collection of Panes as ItemsSource of a specific PaneGroup for Silverlight and WPF. For more detailed infroamtion could be found in this blog post:  http://blogs.telerik.com/xamlteam/posts/13-01-14/extending-the-functionality-of-radcontrols-with-attached-properties

* __Save/Load layout with PaneSource__ - 
This examples demonstrates how to handle scenarios where the layout of the RadDocking is loaded and the there is a PaneSource collection set. In this scenario if the saved layout matches the PaneSource collection no conflicts are found and all is well, but if the bound collection contains more instances of RadPanes then the saved in the layout XML the additional RadPane instance in the PanesSource collection will be disregarded. This is an expected behavior that needs to be handled.

* __Restore focus to floating Pane content__ - 
This example demonstrates how to restore the keyboard focus to the last focused element in the RadPane when it is made floating. Click in one of the TextBox controls and then make that RadPane floating by drag it by its header.

* __Save load layout__ - This example demonstrates how the Save/Load layout functionality work in the RadDocking control.  If a Panes content/properties needs to be persisted when the layout is saved setting the  SerializationTag is required. In order to exclude a Pane from the Save layout functionality  setting the ExcludedFromLayoutSave is required.

* __PRISM Implementation with MEF__ - 
This example shows how to implement the main functionality of RadDocking using PRISM and MEF. Here are the covered scenarios
 - MEF
 - MVVM
 - CustomRegionAdapter
 - CustomRegionBehavior which helps Avtivation implementation
 - Activation
 - Custom Event aggregators
 - Predefined docking layout at start up
 - Save and Load docking layout on application start up and exit
 - Adding new documents at runtime

* __How to get the SplitContainer's DockState__ - 
This example demonstrates how to get the DockState of a SplitContainer. The DockState is an enumeration that represents the state of a SplitContainer compared to the root of the RadDocking.

* __Visual Studio Implementation with MVVM__ - 
This example shows how to implement the main functionality of RadDocking using MVVM in VS-like scenarios. Here are the covered points:
 - MVVM
 - Activation
 - Predefined docking layout at start up
 - Save and Load docking layout on application start up and exit
 - Adding new documents at runtime
 - Custom Compass logic

* __Win forms inside docking__ - This example illustrates how to work-around the airspace problem of WPF and WinForms working together. More information about the problem you could find here: http://msdn.microsoft.com/en-us/library/aa970688.aspx
In order to be work-arounded all Popups, including the Windows, should have AllowTransparency property set to False.
This leads to some glitches in the Docking control, which fixes are provided in the project.

In order to trigger ActivePaneChanged and set properly ActivePane for the RadDocking when clicking on WinForms control, you should handle MouseDown WinForms event.

To work arond the problem with the AutoHide are a ClickFlyoutBehavior should be set to the Docking control.{% endif %}{% if site.site_name == 'Silverlight' %}

* __Auto generated tag__ - This example demonstrates how to mark SplitContainers and PaneGroups as auto-generated. In that way the Docking control will clean them once they are not needed, i.e. when there is nothing inside them, which can be used later. Only the RadSplitContainers and RadPaneGroups can have this property set. All the children of a SplitContainer should be marked as auto-generated in order it to be cleaned up by the Docking control. 

The example shows how to set this property in XAML and in code to the dynamically generated RadPanes. The saving of the layout in xml file demonstrates easier how the elements are removed if they are auto-generated.

* __Click flyout behavior with animation__ - This example demonstrates how to create a custom FlyoutBehavior for the RadDocking control in order to achieve a ClickFlyoutBehavior with slide in/out animations. The example is available for both Silverlight and WPF.

* __Close single pane in tool window__ - This example demonstrates how to create a custom ItemsFactory and ToolWindow in order to customize the way the Close button of the floating ToolWindow closes Panes when there are multple Panes in the PaneGroup for Silverllight and WPF. The example shows how to achieve a behavior, where the close button closes only the current  active Pane rather then the hole PaneGroup.

* __Compass programming__ - This example demonstrates how to customize which compasses are shown when dragging different RadPanes in the control.

When dragging a "Green" RadPane only the center compass over other "Green" RadPanes is show and the all of the root compasses.
When dragging a "Purple" RadPane all of the compasses (right, left, top, bottom and center) over other "Purple" RadPanes are shown and none of the root compasses.

More details could be found in our online help:
For WPF - http://www.telerik.com/help/wpf/raddocking-how-to-implement-conditional-docking.html
For Silverlight - http://www.telerik.com/help/silverlight/raddocking-how-to-implement-conditional-docking.html

* __Custom DockingPanesFactory__ - 
This example demonstrates how to use a custom DockingPanesFactory in order to add the RadPanes from the PanesSource collection to a predefined empty RadPaneGroups in the control.

* __MDI Layout__ - 
This example demonstrates how to achieve MDI layout with the Docking control.

* __Nested RadDocking Save and Load of layout__ - 
This example demonstrates how to save and load the layout in nested RadDocking scenarios. The approved mechanism is to save/load each controls layout separately but simultaneously.

* __How to use PanesSource in nested RadDocking scenarios__ - 
This example demonstrates how the PanesSource collection could be used in nested RadDocking scnearios.

* __Open closed panes with context menu__ - This example demonstrates how to show the closed RadPanes when you close them by their close button also shows how to permanently close a RadPane for Silverlight and WPF.

* __Ordered unpinned panes__ - The example demonstrates how to keep the unpinned RadPanes ordered the way they were defined in XAML while pining/unpinning them at run-time.

* __Pane group items source__ - IMPORTANT: With our Q3 2013 SP release of RadDocking there is a new functionality for achieving MVVM scenarios that require an equivalent of ItemsSource with the addition of PanesSource. More details about the PanesSource feature can be found here: For WPF: http://www.telerik.com/help/wpf/raddocking-features-panes-panesource.html For SL: http://www.telerik.com/help/silverlight/raddocking-features-panes-panesource.html The example demonstrates how to extend the functionality of RadDocking with the use of Attached Properties in order to  set a collection of Panes as ItemsSource of a specific PaneGroup for Silverlight and WPF. For more detailed infroamtion could be found in this blog post:  http://blogs.telerik.com/xamlteam/posts/13-01-14/extending-the-functionality-of-radcontrols-with-attached-properties

* __Save/Load layout with PaneSource__ - 
This examples demonstrates how to handle scenarios where the layout of the RadDocking is loaded and the there is a PaneSource collection set. In this scenario if the saved layout matches the PaneSource collection no conflicts are found and all is well, but if the bound collection contains more instances of RadPanes then the saved in the layout XML the additional RadPane instance in the PanesSource collection will be disregarded. This is an expected behavior that needs to be handled.

* __Restore focus to floating Pane content__ - 
This example demonstrates how to restore the keyboard focus to the last focused element in the RadPane when it is made floating. Click in one of the TextBox controls and then make that RadPane floating by drag it by its header.

* __Save load layout__ - This example demonstrates how the Save/Load layout functionality work in the RadDocking control.  If a Panes content/properties needs to be persisted when the layout is saved setting the  SerializationTag is required. In order to exclude a Pane from the Save layout functionality  setting the ExcludedFromLayoutSave is required.

* __PRISM Implementation with MEF__ - 
This example shows how to implement the main functionality of RadDocking using PRISM and MEF. Here are the covered scenarios
 - MEF
 - MVVM
 - CustomRegionAdapter
 - CustomRegionBehavior which helps Avtivation implementation
 - Activation
 - Custom Event aggregators
 - Predefined docking layout at start up
 - Save and Load docking layout on application start up and exit
 - Adding new documents at runtime

* __How to get the SplitContainer's DockState__ - 
This example demonstrates how to get the DockState of a SplitContainer. The DockState is an enumeration that represents the state of a SplitContainer compared to the root of the RadDocking.

* __Visual Studio Implementation with MVVM__ - 
This example shows how to implement the main functionality of RadDocking using MVVM in VS-like scenarios. Here are the covered points:
 - MVVM
 - Activation
 - Predefined docking layout at start up
 - Save and Load docking layout on application start up and exit
 - Adding new documents at runtime
 - Custom Compass logic{% endif %}

>You can also check the [SDK Samples Browser]({%slug sdk-samples-browser%}) that provides a more convenient approach in exploring and executing the examples in the Telerik XAML SDK repository. The SDK Samples Browser application is available for download from [this link](http://demos.telerik.com/xaml-sdkbrowser/).

# See Also
