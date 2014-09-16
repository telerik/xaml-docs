---
title: Event Model
page_title: Event Model
description: Event Model
slug: gridview-filtering-event-model
tags: event,model
publish: True
position: 12
---

# Event Model



RadGridView provides a rich filtering event model that allows customization and configuration of the default filtering behavior.

## Filtering Event

The Filtering event is fired just before the actual filtering occurs. Here you have a chance to cancel filtering by using the setting the Cancel property of the event arguments to true. The Added and Removed properties of the event arguments contain dummy IFilterDescriptor’s which can only be used for reading purposes. They simply carry information. They cannot and should not be modified in anyway since this will have no effect on the actual filtering performed in the data engine. For example, imagine that the user has typed “John” in one of the field filters. He then decides to change this string to “Mary”. What you will see in the Filtering event arguments is one dummy Removed descriptor that says “John” and one dummy Added descriptor tha says “Mary”. But in fact, nothing like this has happened behind the scenes where the Value of single filter descriptor will be simply changed from “John” to “Mary”. The Added and Removed dummy descriptors are a way of informing you what has happened, but they are not real. So there is no point in trying to modify them – they are not going to be used by anyone.

## Filtered Event

The Filtered event is fired after filtering occurs. The Added and Removed properties of the event arguments contain dummy IFilterDescriptor’s which can only be used for reading purposes. They simply carry information. They cannot and should not be modified in anyway since this will have no effect on anything. For example, imagine that the user has typed “John” in one of the field filters. He then decides to change this string to “Mary”. What you will see in the Filtered event arguments is one dummy Removed descriptor that says “John” and one dummy Added descriptor tha says “Mary”. But in fact, nothing like this has happened behind the scenes where the Value of a single filter descriptor has been changed from “John” to “Mary”. The Added and Removed dummy descriptors are a way of informing you what has happened, but they are not real. So there is no point in trying to modify them – they are not going to be used by the data engine.

## FilterOperatorsLoading Event

The FilterOperatorsLoading event will be fired before the filtering UI is presented to the end user. This event gives you the chance to remove some of the filtering operators through the AvailableOperators property of the event arguments as demonstrated [here]({%slug gridview-filtering-howto-remove-some-of-the-available-filter-operators%}). It also lets you define the default selected operators as shown [here]({%slug gridview-filtering-howto-change-the-default-selected-filter-operator%}).

## FieldFilterEditorCreated Event

The FieldFilterEditorCreated event is fired after the default field filter editors have been created in the factory and before they are shown to the end user. This event lets you modify the default editors and adjust their appearance and behavior like demonstrated in this [article]({%slug gridview-filtering-howto-customize-the-default-field-filter-editor%}). If you want to replace the default editors with your own, you have to inherit from GridViewColumn and override the CreateFieldFilterEditor method. To learn how to create and bind your custom editor, please take a look at this [article]({%slug gridview-filtering-howto-create-a-custom-field-filter-editor%}).

## DistinctValuesLoading Event

The DistinctValuesLoading event is fired before the filtering UI is presented to the end user when the grid is in a Popup filtering mode. You can use this event to change the amount of distinct values displayed. To learn how, please take a look at this [article]({%slug gridview-filtering-howto-display-all-distinct-values%}).

# See Also
