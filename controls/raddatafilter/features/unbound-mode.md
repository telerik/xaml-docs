---
title: Unbound Mode
page_title: Unbound Mode
description: Check our &quot;Unbound Mode&quot; documentation article for the RadDataFilter {{ site.framework_name }} control.
slug: raddatafilter-features-unbound-mode
tags: unbound,mode
published: True
position: 4
---

# Unbound Mode

There are scenarios, in which you might want to use __RadDataFilter__ only for its UI without passing any data to it. This scenarios will require you to use the __RadDataFilter's Unbound Mode__ feature. The usage of this feature consists in manually setting some of the __RadDataFilter's__ properties and handling events.

The example in this topic will show you a __RadGridView__ bound to a list of __Employee__ objects. A __RadDataFilter__ will be used as UI to filter the data, but the filtering itself will be done outside the __RadDataFilter__ via manipulation of __FilterDescriptor__ objects.

Here is the XAML for the example. In it you can see a __RadGridView__ and a __RadDataFilter__.



<snippet id='raddatafilter-features-unbound-mode-block_1-xaml' />



When in __Unbound Mode__, __RadDataFilter__ has no __Source__. The developer instructs it what properties to show in its drop-downs by assigning its __ItemPropertyDefinitions__ property. This is a collection of __ItemPropertyDefinition objects__ that contains all the information regarding the properties, their type, their attributes, etc. 

Here is the code-behind for the example. In it you should take notice at the instantiation of the __ItemPropertyDefinition__ class and the objects passed to its constructor as arguments. Also take a closer look at the code inside the event handler for the __FilterDescriptors__ collection's __CollectionChanged__ event. In it is implemented the actual filtering. This is done by synchronizing the __FilterDescriptors__ collection of the __RadDataFilter__ with the one of the __RadDataGridView__.

>At the end of the topic you can find the code for the __Employee__ class, used in the example.



<snippet id='raddatafilter-features-unbound-mode-block_2-cs' />

<snippet id='raddatafilter-features-unbound-mode-block_2-vb' />




Here is also the code for the __Employee__ class, used in the example.



<snippet id='raddatafilter-features-unbound-mode-block_3-cs' />

<snippet id='raddatafilter-features-unbound-mode-block_3-vb' />




## See Also

 * [Getting Started]({%slug datafilter-getting-started%})

 * [Data Annotations]({%slug raddatafilter-features-data-annotations%})

 * [Source and Filtered Source]({%slug raddatafilter-features-source-and-filtered-source%})
