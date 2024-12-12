---
title: Breaking Changes
page_title: Breaking Changes
description: This article lists the breaking changes introduced in the RadPersistenceFramework for WPF component through the releases.
slug: persistence-framework-breaking-changes
tags: breaking, changes, backward,compadibility
published: True
position: 6
---

# Breaking Changes

This article lists and describes the breaking changes introduced in the RadPersistenceFramework. For a full list of changes, see the [Release History](https://www.telerik.com/support/whats-new/wpf/release-history) pages of the Telerik UI for WPF product.

## 2024 Q4 (2024.4.1213)

The `PersistenceManager` now requires to provide a list of allowed types. If the list is `null` or if a type that is deserialized is not presented in the list, a `NotSupportedException` is thrown. 

The `IsolatedStorageProvider` is also affected as it uses the `PersistenceManager`.

The following example shows how to properly initialize the manager and add allowed types. Read more about this in the [Allowed Types]({%slug persistence-framework-allowed-types%}) article.

#### __[C#] Adding allowed types__
{{region persistence-framework-breaking-changes-0}}
	// add Telerik types
    PersistenceManager manager = new PersistenceManager()
		.AllowNavigationControls()
		.AllowRichTextBoxControls();

	// add custom types
	manager.AllowedTypes.Add(typeof(MyCustomType));
	
	IsolatedStorageProvider isoProvider = new IsolatedStorageProvider(manager);
{{endregion}}

## See Also  
 * [Getting Started]({%slug persistence-framework-getting-started%})
 * [Release History](https://www.telerik.com/support/whats-new/wpf/release-history)
 * [UI for WPF Demos](https://demos.telerik.com/wpf/) 
