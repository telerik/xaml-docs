---
title: Cross-Version Support
page_title: Cross-Version Support
description: Check our &quot;Cross-Version Support&quot; documentation article for the RadPersistenceFramework {{ site.framework_name }} control.
slug: persistence-framework-cross-version-support
tags: allowcrossversion,
published: True
position: 6
---

# Cross-Version Support

When serializing an object the PersistenceFramework takes the concrete version of the assembly where the specific class is stored and saves it in the serialization info (see Example 1). If you reference a different version of the assembly that holds the serialized object and try to deserialize it, an exception will be thrown and the object's state won't be restored. 

__Example 1: RadButton instance type stored in the serialization XML__
```XML
	<string>Telerik.Windows.Controls.RadButton, Telerik.Windows.Controls, Version=2018.3.619.40, Culture=neutral, PublicKeyToken=5803cfa389c90ce7</string>
```

There are two mechanisms that can be used to resolve this.

## AllowCrossVersion

The __AllowCrossVersion__ property gives you the ability to serialize Telerik controls with one version and deserialize them with another version. To enable this set the property to True.

__Example 2: Setting AllowCrossVersion__
```C#
	PersistenceManager manager = new PersistenceManager();
	manager.AllowCrossVersion = true;
```

> This is applicable only for Telerik controls.

## TypeRestored

The __TypeRestored__ event allows you to manually restore the type of the deserialized object. This can be used as an alternative to the AllowCrossVersion property. Additionally, the event is useful if you migrate to a newer version of the .NET framework and there is a native type stored with the previous version.

__Example 3: Using the TypeRestored event__
```C#
	private void SubscribeToTypeRestored()
	{       
		PersistenceManager manager = new PersistenceManager();
		manager.TypeRestored += OnPresistenceManagerTypeRestored;
	}
	
	private void OnPresistenceManagerTypeRestored(object sender, Telerik.Windows.Persistence.Events.TypeRestoredEventArgs e)
	{
		if (e.Type == null)
		{
			var assemblyName = e.AssemblyQualifiedName.Substring(0, e.AssemblyQualifiedName.IndexOf(", Version"));
			e.Type = Type.GetType(assemblyName);
		}
	}
```

## See Also
* [Getting Started]({%slug persistence-framework-getting-started%})
* [Custom Property Provider]({%slug persistence-framework-custom-property-provider%})
