---
title: Events
page_title: Events
description: Events
slug: raddataservicedatasource-events
tags: events
published: True
position: 1
---

# Events

This topic will go through the event model exposed by __RadDataServiceDataSource__ and the purposes for which each event can be used.

* [LoadingData](#loadingdata)
* [LoadedData](#loadeddata)
* [SubmittingChanges](#submittingchanges)
* [SubmittedChanges](#submittedchanges)

## LoadingData

At this stage the data loading operation can be canceled, as the event is raised before the loading is to be executed. Also, the __LoadingDataEventArgs__ event arguments provide information regarding the generated query which can be modified as well.

* __Cancel__: Boolean property that gets or sets the value whether the event should be canceled or not.
* __Query__: Property of type [DataServiceQuery](https://msdn.microsoft.com/en-us/library/system.data.services.client.dataservicequery(v=vs.110).aspx) which can be fetched and modified.

## LoadedData

This event provides various information and options regarding the processed query. The __LoadedDataEventArgs__ event arguments inherit from the [AsyncCompletedEventArgs](https://msdn.microsoft.com/en-us/library/system.componentmodel.asynccompletedeventargs(v=vs.110).aspx) and expose the properties listed below.

* __Cancelled__: Boolean property that provides information whether an asynchronous operation has been canceled. 
* __Entities__: Gets all top-level entities that were loaded.
* __Error__: Provides information which particular error occurred during the operation.
* __HasError__: Boolean property giving information whether the operation has failed.
* __IsErrorHandled__: When there is an error it can be handled through the __MarkErrorAsHandled__ method of the event arguments. In such case the property will return __True__. Otherwise, it will return __False__.
* __TotalEntityCount__: Gets the total entity count for the load operation.
* __UserState__: Gets the unique identifier for the asynchronous task.

## SubmittingChanges

Through this event the submitting of the made changes can be canceled. Also, the [SaveChangesOptions](https://msdn.microsoft.com/en-us/library/system.data.services.client.savechangesoptions(v=vs.110).aspx) can be modified. The event arguments are of type __DataServiceSubmittingChangesEventArgs__ which expose the following properties.

* __Cancel__: boolean property that gets or sets the value whether the event should be canceled or not.
* __SaveChangesOptions__: Gets or sets the save changes options.

## SubmittedChanges

The __DataServiceSubmittedChangesEventArgs__ also inherit from the [AsyncCompletedEventArgs](https://msdn.microsoft.com/en-us/library/system.componentmodel.asynccompletedeventargs(v=vs.110).aspx). As an addition to them the __DataServiceResponse__, __HasError__ and __IsErrorHandled__ properties are added as well the __MarkErrorAsHandled__ method.

* __Cancelled__: Boolean property that provides information whether an asynchronous operation has been canceled. 
* __DataServiceResponse__: Gets the response from the service.
* __Error__: Provides information which particular error occurred during the operation.
* __HasError__: Boolean property giving information whether the operation has failed.
* __IsErrorHandled__: When there is an error it can be handled through the __MarkErrorAsHandled__ method of the event arguments. In such case the property will return __True__. Otherwise, it will return __False__.
* __UserState__: Gets the unique identifier for the asynchronous task.

## See Also

* [The DataServiceContext]({%slug raddataservicedatasource-loading-the-dataservicecontext%})
* [The DataServiceQuery]({%slug raddataservicedatasource-loading-the-dataservicequery%})
