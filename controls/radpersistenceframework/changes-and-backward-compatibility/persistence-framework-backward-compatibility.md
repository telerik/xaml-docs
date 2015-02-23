---
title: Backward Compatibility
page_title: Backward Compatibility
description: Backward Compatibility
slug: persistence-framework-backward-compatibility
tags: backward,compatibility
published: True
position: 0
---

# Backward Compatibility

## RadPersistenceFramework for Q3 2011

The __PersistenceManager.GetStorage()__ method returns an object of type __ObjectStorage__ that exposes the following properties:		

* __Count__ - this property is of type __int__ and it gets the number of persisted objects.			

* __Items__ - this property gets the collection of persisted objects.			

* __Keys__ - this property gets the collection of the persisted objects' __StorageId__ values.			

You can find more information about the __GetStorage()__ method in the [Isolated Storage]({%slug persistence-framework-isolated-storage%}) article.