---
title: Cross Version Support with IsolatedStorageProvider
page_title: How to Use AllowCrossVersion Property with IsolatedStorageProvider
description: Enable cross version support when using RadPersistenceFramework IsolatedStorageProvider. 
type: how-to
slug: kb-persistenceframework-allowcrossversion-isolatedstorageprovider
position: 0
tags: provider,allowcrossverion
ticketid: 1422122
res_type: kb
---

## Environment
<table>
    <tbody>
	    <tr>
	    	<td>Product Version</td>
	    	<td>2019.2 722</td>
	    </tr>
	    <tr>
	    	<td>Product</td>
	    	<td>RadPersistenceFramework for WPF</td>
	    </tr>
    </tbody>
</table>

## Description

How to use the AllowCrossVersion property with RadPersistenceFramework's IsolatedStorageProvider.

## Solution

1. Create a new PersistenceManager instance and set its [AllowCrossVersion]({%slug persistence-framework-cross-version-support%}) property.

2. Create a new IsolatedStorageProvider instance and pass the PersistenceManager in its constructor.


```C#
	var manager = new PersistenceManager() { AllowCrossVersion = true };
	var storageProvider = new IsolatedStorageProvider(manager);
```