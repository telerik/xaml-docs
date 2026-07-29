---
title: Navigator
page_title: Navigator
description: The DockingNavigator allows for navigating through the RadDocking panes by pressing the Ctrl + Tab or Alt + F7 key combinations. 
slug: raddocking-navigator
tags: navigator
published: True
position: 14
---

# Navigator

Since the __R2 2020 SP1__ version, the RadDocking allows you to navigate through its panes with the help of the __DockingNavigator__. Press the __Ctrl + Tab__ or __Alt + F7__ key combinations, use the arrow keys to navigate between panes and get a preview of their content. 

## Key Properties

The __DockingNavigator__ control consists of two listboxes allowing for the navigation between the RadPanes/RadDocumentPanes and a preview image showing the content of the current pane. It also has a header, description and footer sections showing more information about the selected pane. The following properties allow you to easily modify its look. 

* __IconTemplate__: Gets or sets the ContentTemplate of the icon presenter next to the header of the navigator. 
* __IconTemplateSelector__: Gets or sets the ContentTemplateSelector of the icon presenter next to the header of the navigator.
* __HeaderStringFormat__: Gets or sets the string format that will be applied to the header of the navigator, if the __HeaderTemplate__ property is not set. 
* __HeaderTemplate__: Gets or sets a DataTemplate that will be applied to the header of the navigator. 
* __HeaderTemplateSelector__: Gets or sets a DataTemplateSelector that allows to select a different DataTemplate depending on the currently selected pane. 
* __DescriptionStringFormat__: Gets or sets the string format that will be applied to the description of the selected pane, if the __DescriptionTemplate__ property is not set. 
* __DescriptionTemplate__: Gets or sets a DataTemplate that will be applied to the presenter of the description for the selected pane. 
* __DescriptionTemplateSelector__: Gets or sets a DataTemplateSelector that will be applied to the presenter of the description for the selected pane.
* __ActivePanesListBoxHeader__: Gets or sets a string displayed over the __DockingNavigatorListBox__ showing the non-document panes.
* __ActiveDocumentsListBoxHeader__: Gets or sets a string displayed over the __DockingNavigatorListBox__ showing the RadDocumentPanes.
* __ActivePanesListBoxStyle__: Gets or sets the __Style__ of the listbox showing the non-document panes. The __TargetType__ should be __DockingNavigatorListBox__.
* __ActiveDocumentsListBoxStyle__: Gets or sets the __Style__ of the listbox showing the RadDocumentPanes. The __TargetType__ should be __DockingNavigatorListBox__.
* __ItemTemplateSelector__: Gets or sets an __DockingNavigatorItemTemplateSelector__ instance, which allows you to specify DataTemplates for normal and document panes.
* __PreviewHeader__: Gets or sets a string displayed over the preview image. 
* __PreviewHeight__: Gets or sets the height of the preview image. 
* __PreviewWidth__: Gets or sets the width of the preview image.
* __FooterStringFormat__: Gets or sets the string format that will be applied to the footer of the navigator, if the __FooterTemplate__ property is not set. 
* __FooterTemplate__: Gets or sets a DataTemplate that will be applied to the footer of the navigator. 
* __FooterTemplateSelector__: Gets or sets a DataTemplateSelector that allows to select a different DataTemplate depending on the currently selected pane.

> The values of the __ActivePanesListBoxHeader__, __ActiveDocumentsListBoxHeader__ and __PreviewHeader__ properties are localized with the following keys: __Docking_ActivePanes__, __Docking_ActiveDocuments__ and __Docking_PreviewHeader__. For more information, check out the [Localization]({%slug raddocking-localization%}) article. 

## Attached Properties

The __DockingNavigator__ exposes several attached properties which can be set on RadPane/RadDocumentPane instances in order to transfer information, which can be displayed while navigating. Those properties are used to prepare a __NavigatorItemViewModel__ object, which is the DataContext inside the __ItemTemplateSelector__.

* __Icon__: Gets or sets an object that will represent the icon for that pane.
* __Header__: Gets or sets a object that will represent the header for that pane. 
* __Footer__: Gets or sets a object that will represent the footer for that pane. 
* __Description__: Gets or sets a object that will represent the description for that pane. 

## Navigator Property 

__Example 1__ demonstrates how you can set the __Navigator__ property of the RadDocking to an instance of the __DockingNavigator__. It also demonstrates how you can set the DockingNavigator attached properties on the RadPanes/RadDocumentPanes in order to display additional information for a pane while navigating.

__Example 1: RadDocking with Navigator property set__
<snippet id='raddocking-features-navigator-example_1_raddocking_with_navigator_property_set-xaml' />


#### __Figure 1: Result from showing the navigator in Example 1__
![DockingNavigator in Fluent theme](images/docking_navigator.png)

## Events

The DockingNavigator class exposes several useful events, which can be used to alter its behavior: 

* __Opening__: Raised before the DockingNavigator is opened. The event handler receives two arguments:

    * The sender argument contains the DockingNavigator. This argument is of type object, but can be cast to the DockingNavigator type.

    * A __NavigatorOpeningEventArgs__ object. It exposes a __Cancel__ property, which allows for preventing the opening. 

    __Example 2: Handling the Opening event__
    <snippet id='raddocking-features-navigator-example_2_handling_the_opening_event-cs' />

	<snippet id='raddocking-features-navigator-example_2_handling_the_opening_event-vb' />


* __Closed__: Raised after the DockingNavigator is closed. The event handler receives two arguments:

    * The sender argument contains the DockingNavigator. This argument is of type object, but can be cast to the DockingNavigator type.

    * A __NavigatorClosedEventArgs__ object. It exposes a __PaneToActivate__ property of type RadPane, which gets or sets the pane that will be activated. 

## See Also

 * [RadPane]({%slug raddocking-panes-radpane%})
 * [RadDocumentPane]({%slug raddocking-panes-raddocumentpane%})
