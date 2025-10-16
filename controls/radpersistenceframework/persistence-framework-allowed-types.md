---
title: Allowed Types
page_title: Allowed Types
description: Register types that are allowed to be instantiated by the deserialization mechanism of PersistenceFramework.
slug: persistence-framework-allowed-types
tags: allowed types, types, persistence framework
published: True
position: 8
---

# Allowed Types

When loading the persisted layout, the PersistenceFramework will instantiate the saved types only if they are allowed. Otherwise, an exception is thrown.

To allow specific types, add them in the `AllowedTypes` collection of the `PersistenceManager` class. 

When the `PersistenceManager` gets initialized the `AllowedTypes` collection is automatically filled with several WPF native types and also types from the `Telerik.Windows.Controls` assembly.

If the deserializer reaches an unknown type an `UnauthorizedDeserializationException` is thrown.

__Allowing a type using the AllowedTypes collection of the PersistenceManager__
```C#
    PersistenceManager manager = new PersistenceManager();
    manager.AllowedTypes.Add(typeof(SolidColorBrush));
```
```VB.NET
    Dim manager As PersistenceManager = New PersistenceManager()
    manager.AllowedTypes.Add(GetType(SolidColorBrush))
```

__Allowing a type using the AllowedTypes extension method__
```C#
    PersistenceManager manager = new PersistenceManager().AllowedTypes(typeof(SolidColorBrush));
```
```VB.NET
    Dim manager As PersistenceManager = New PersistenceManager().AllowedTypes(GetType(SolidColorBrush))
```

In case the AllowedTypes property is assigned to a `null` value, a `NotSupportedException` is thrown.

## Allowing Types from the Telerik Assemblies 

Each Telerik assembly has an extension method part of the associated `AllowedTypesExtensions` class that allows you to automatically load the Telerik types in the `AllowedTypes` collection of the `PersistenceManager`. 

The following example shows how to allow the types that are defined in the `Telerik.Windows.Controls.Docking` and `Telerik.Windows.Controls.Navigation` assemblies.

__Allowing the types that are used in the Telerik.Windows.Controls.Docking and Telerik.Windows.Controls.Navigation assemblies__
```C#
    PersistenceManager manager = new PersistenceManager()
        .AllowDockingControls()
        .AllowNavigationControls();
```
```VB.NET
    Dim manager As PersistenceManager = New PersistenceManager()
        .AllowDockingControls()
        .AllowNavigationControls()
```

## Allowing Internal Types

In cases where internal WPF types need to be added to the AllowedTypes collection, you can obtain them at runtime and utilize the AllowTypes method. One such case is with the native WPF `Selector` class that assigns the `SelectedItems` property to a `SelectedItemCollection` type, which is internal. In this specific scenario, invoking the `AllowInputControls` method will resolve this, however, if you need to allow internal types, you can follow the approach from the following example:

__Allowing internal types via the AllowedTypes method__
```C#
    var listBox = new ListBox();
    manager.AllowedTypes(listBox.SelectedItems.GetType());
```
```VB.NET
    Dim listBox = New ListBox()
    manager.AllowedTypes(listBox.SelectedItems.[GetType]())
```

## TypeRestored Event

To retrieve each type that is present in the saved layout, you can utilize the `TypeRestored` event. You can inspect both the type and its assembly, and decide whether to allow the PersistenceFramework to instantiate it, by adding it to the AllowedTypes collection. The event arguments are of the type of `TypeRestoredEventArgs` and provide the following API:

* `Type`&mdash;Provides the type that is restored.
* `AssemblyQualifiedName`&mdash;Provides the type's assembly name.

__Utilizing the TypeRestored event__
```C#
    private void Manager_TypeRestored(object sender, Persistence.Events.TypeRestoredEventArgs e)
    {
        var type = e.Type; // Review the type and decide whether to allow the PersistenceFramework to instantiate it by adding it to the AllowedTypes collection.
    }
```
```VB.NET
    Private Sub Manager_TypeRestored(sender As Object, e As Persistence.Events.TypeRestoredEventArgs)
        Dim type = e.Type ' Review the type and decide whether to allow the PersistenceFramework to instantiate it by adding it to the AllowedTypes collection.
    End Sub
```

## Allowing Types when Using IsolatedStorageProvider

To allow types to be instantiated by the PersistenceFramework when working with the `IsolatedStorageProvider`, you need to pass a new `PersistenceManager` instance to its constructor. On it, you can utilize the AllowTypes extension method or use its AllowedTypes collection.

__Allowing types when using IsolatedStorageProvider__
```C#
    PersistenceManager manager = new PersistenceManager()
        .AllowDockingControls()
        .AllowNavigationControls();
		
	manager.AllowedTypes.Add(typeof(MyCustomType));

    IsolatedStorageProvider isoProvider = new IsolatedStorageProvider(manager);
```
```VB.NET
    Dim manager As PersistenceManager = New PersistenceManager()
       .AllowDockingControls()
       .AllowNavigationControls()
	   
	manager.AllowedTypes.Add(GetType(MyCustomType))
       
    Dim isoProvider As IsolatedStorageProvider = New IsolatedStorageProvider(manager)
```
