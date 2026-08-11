---
title: Implementing View-ViewModel 
page_title: Implementing View-ViewModel 
description: Check our &quot;Implementing View-ViewModel&quot; documentation article for the RadScheduleView {{ site.framework_name }} control.
slug: radscheduleview-populating-with-data-implementing-view-model
tags: implementing,view-viewmodel,
published: True
position: 1
---

# Implementing View-ViewModel 

The purpose of this tutorial is to show you how to bind a __RadScheduleView__ with a ViewModel.

>Before reading this tutorial you should get familiar with the [Data Binding]({%slug radscheduleview-populating-with-data-data-binding-support-overview%}) support of the __RadScheduleView__ control.

* Add a new __RadScheduleView__ declaration in your XAML



<snippet id='radscheduleview-populating-with-data-implementing-view-model-block_1-xaml' />

* Create a new class named __MyViewModel__.



<snippet id='radscheduleview-populating-with-data-implementing-view-model-block_2-cs' />
<snippet id='radscheduleview-populating-with-data-implementing-view-model-block_3-vb' />

* In the __MyViewModel__ class add two properties:

1. __Appointments__ - we will bind the __AppointmentsSource__ property of the __RadScheduleView__ to this property.

1. __ResourcesTypes__ - we will bind the __ResourceTypesSource__ property of the __RadScheduleView__ to this property.



<snippet id='radscheduleview-populating-with-data-implementing-view-model-block_4-cs' />
<snippet id='radscheduleview-populating-with-data-implementing-view-model-block_5-vb' />

* Let's create a method in the ViewModel that generates some Resources:            



<snippet id='radscheduleview-populating-with-data-implementing-view-model-block_6-cs' />
<snippet id='radscheduleview-populating-with-data-implementing-view-model-block_7-vb' />

* All we have to do is to initialize the __resourceTypes__ and __appointments__ fields:            



<snippet id='radscheduleview-populating-with-data-implementing-view-model-block_8-cs' />
<snippet id='radscheduleview-populating-with-data-implementing-view-model-block_9-vb' />

* The ViewModel is complete. Now, let's return to the View. Add some __ViewDefinitions__, __GroupDescriptionsSource__ and bind the __AppointmentsSource__ and __ResourceTypes__



<snippet id='radscheduleview-populating-with-data-implementing-view-model-block_10-xaml' />

* Finally, set the DataContext:            



<snippet id='radscheduleview-populating-with-data-implementing-view-model-block_11-cs' />
<snippet id='radscheduleview-populating-with-data-implementing-view-model-block_12-vb' />

## See Also

 * [Implementing View-ViewModel ]({%slug radscheduleview-populating-with-data-implementing-view-model%})