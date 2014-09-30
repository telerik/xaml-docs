---
title: Overview
page_title: Overview
description: Overview
slug: radcombobox-events-overview
tags: overview
published: True
position: 0
---

# Overview

This topic covers the specific events exposed by the __RadComboBox__ control.

The __RadComboBox__ is an __ItemsControl__. Almost all of the exposed events are inherited from the __ItemsControl__ class. __RadComboBox__ adds two additional events for the developer.

* __DropDownOpened__ - occurs when the drop-down list of the combo box opens. The __DropDownOpened__ event handler receives two arguments:

	* The sender argument contains the __RadComboBox__. This argument is of type object, but can be cast to the __RadComboBox__ type.

	* An __EventArgs__ object.

* __DropDownClosed__ - occurs when the drop-down list of the ComboBox closes. The __DropDownClosed__ event handler receives two arguments:

	* The sender argument contains the __RadComboBox__. This argument is of type object, but can be cast to the __RadComboBox__ type.

	* An __EventArgs__ object.

* __SelectionChanged -__ occurs when the selected item is changed. The SelectionChanged event handler receives two arguments:

	* The sender argument contains the __RadComboBox__. This argument is of type object, but can be cast to the __RadComboBox__ type.

	* A __SelectionChangedEventArgs__ object which has the following properties:

		1. AddedItems - gets a list that contains the items that were selected. 

		1. RemovedItems - gets a list that contains the items that were unselected.
		
# See Also

 * [Visual Structure]({%slug radcombobox-general-information-visual-structure%})

 * [Getting Started]({%slug radcombobox-getting-started%})
