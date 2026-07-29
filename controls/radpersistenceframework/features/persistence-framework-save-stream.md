---
title: Save in a Stream
page_title: Save in a Stream
description: Check our &quot;Save in a Stream&quot; documentation article for the RadPersistenceFramework {{ site.framework_name }} control.
slug: persistence-framework-save-stream
tags: save,in,a,stream
published: True
position: 2
---

# Save in a Stream

The __PersistenceFramework__ allows you to save the layout of __UIElements__ in a stream. The __PersistenceManager__ exposes the following methods that persist the data in a stream:		

* __Save__ - this method saves the data in a stream. It should receive the __UIElement__ object which properties will be persisted. It returns the stream with the persisted data.		  

* __Load__ - this method loads the persisted data. It should receive the __UIElement__ object which properties should be restored and the stream that holds the object's persisted properties.		  

For the purpose of this tutorial, let's define the following __RadTreeView__ control:		


<snippet id='radpersistenceframework-features-persistence-framework-save-stream-block_1-xaml' />

In order to persist the __RadTreeView__'s properties in a stream, you need to create an instance of the __PersistenceManager__:		


<snippet id='radpersistenceframework-features-persistence-framework-save-stream-block_2-cs' />
<snippet id='radpersistenceframework-features-persistence-framework-save-stream-block_2-vb' />

The persisted visual state of the __RadTreeView__ control can be restored using the __PersistencaManager__.__Load__ method:		


<snippet id='radpersistenceframework-features-persistence-framework-save-stream-block_3-cs' />
<snippet id='radpersistenceframework-features-persistence-framework-save-stream-block_3-vb' />

>tip Please keep in mind that before loading the persisted data from a stream, you need to make sure that the stream's position matches the beginning of the persisted bytes. In case when the persisted data is saved in a new stream, before loading it, you should set the __Stream.Position__ to __0L__.