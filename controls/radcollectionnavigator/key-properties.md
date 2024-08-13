---
title: Key Properties
page_title: Key Properties
description: Check our &quot;Key Properties&quot; documentation article for the RadCollectionNavigator {{ site.framework_name }} control.
slug: collectionnavigator_key_properties
tags: key,properties
published: True
position: 3
---

# Key Properties

The purpose of this help article is to show you the key properties of the __RadCollectionNavigator__ control. The topic includes the following properties:

* [ButtonsStyle](#buttonsstyle)
* [CommandButtonsVisibility](#commandbuttonsvisibility)

## ButtonsStyle

Through RadCollectionNavigator's **ButtonStyle** property, you can define a custom style for all of its buttons.

## CommandButtonsVisibility

The **Visibility** of RadCollectionNavigator's buttons is controlled by the **CommandButtonsVisibility** property which is a flags enumeration of type CommandButtonsVisibility. It provides the following values:

* **Add**: **AddNew** button will be visible.
* **Delete**: **Delete** button will be visible.
* **Edit**: **Edit** button will be visible.
* **Navigation**: All navigation buttons will be visible (**MoveToFirst**, **MoveToPrevious**, **MoveToNext**, **MoveToLast**).
* **First**: **MoveToFirst** button will be visible.
* **Previous**: **MoveToPrevious** button will be visible.
* **Next**: **MoveToNext** button will be visible.
* **Last**: **MoveToLast** button will be visible.
* **All**: **All** buttons will be visible.

By default it shows the **Add**, **Delete** and **Navigation** buttons. The **Edit** button is initially hidden, as RadCollectionNavigator does not provide interface for editing.

>RadCollectionNavigator is independent from any DataVisualization controls that are used in combination with it. However, the Edit button can be used in custom solutions if such editing UI is provided.

## See Also

 * [Overview]({%slug collectionnavigator_overview%})
 
 * [Getting Started]({%slug collectionnavigator_getting_started%})
