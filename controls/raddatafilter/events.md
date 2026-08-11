---
title: Events
page_title: Events
description: Check our &quot;Events&quot; documentation article for the RadDataFilter {{ site.framework_name }} control.
slug: raddatafilter-events
tags: datafilter, events
published: True
position: 6
---

# Events

This topic will describe the various events exposed by **RadDataFilter**.

* **AutoGeneratingItemPropertyDefinition**: Occurs when RadDataFilter auto-generates item property definitions. Through the **ItemPropertyDefinition** you can get ahold of the generated property definition and cancel its creation if it does not pass your criteria.

   __Example 1: Cancel the creation of a property definition__
   <snippet id='raddatafilter-events-example_1_cancel_the_creation_of_a_property_definition-cs' />


* **EditorCreated**: Occurs when a filter editor has been created and before it is added to the visual tree. Use this event if you want to customize the editor for a given property definition. A good example of how to achieve this can be found in the [Create Custom Filter Editors]({%slug raddatafilter-how-to-create-custom-filter-editors%}) article.

   __Example 2: Configure the generated editor__
   <snippet id='raddatafilter-events-example_2_configure_the_generated_editor-cs' />


* **FilterOperatorsLoading**: Occurs before the filter operators are loaded. Use this event if you want to remove one or more filter operators from the list or want to change the default operator.

   __Example 3: Configure the filter operators__
   <snippet id='raddatafilter-events-example_3_configure_the_filter_operators-cs' />


## See Also  
* [Create Custom Filter Editors]({%slug raddatafilter-how-to-create-custom-filter-editors%})
