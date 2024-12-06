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

When loading the persisted layout, the `PersistenceFramework` will instantiate the saved types only if they are allowed. This is controlled by the `PersistenceManager` class, which has predefined types that are allowed by default. You can also register other types by modifying its `AllowedTypes` collection or by using the `AllowTypes` extension method.

#### __[C#] Allowing a type using the AllowedTypes collection of the PersistenceManager__
{{region persistence-framework-allowed-types-0}}
    PersistenceManager manager = new PersistenceManager();
    manager.AllowedTypes.Add(typeof(SolidColorBrush));
{{endregion}}

#### __[VB.NET] Allowing a type using the AllowedTypes collection of the PersistenceManager__
{{region persistence-framework-allowed-types-1}}
    Dim manager As PersistenceManager = New PersistenceManager()
    manager.AllowedTypes.Add(GetType(SolidColorBrush))
{{endregion}}

#### __[C#] Allowing a type using the AllowTypes extension method__
{{region persistence-framework-allowed-types-2}}
    PersistenceManager manager = new PersistenceManager().AllowTypes(typeof(SolidColorBrush));
{{endregion}}

#### __[VB.NET] Allowing a type using the AllowTypes extension method__
{{region persistence-framework-allowed-types-3}}
    Dim manager As PersistenceManager = New PersistenceManager().AllowTypes(GetType(SolidColorBrush))
{{endregion}}

## Allowing Types from the Telerik Assemblies 

Each Telerik assembly has an extension method that will load the types in the AllowedTypes collection of a control, on which it is invoked. In the scope of the PersistenceFramework, calling these methods on the PersistenceManager will update its AllowedTypes collection.

The following example will show you how to allow the types that are used in the next __Telerik.Windows.Controls.Docking.dll__ and __Telerik.Windows.Controls.Navigation.dll__ inside the PersistenceManager.

#### __[C#] Allowing the types that are used in the Telerik.Windows.Controls.Docking and Telerik.Windows.Controls.Navigation assemblies__
{{region persistence-framework-allowed-types-4}}
    PersistenceManager manager = new PersistenceManager()
        .AllowDockingControls()
        .AllowNavigationControls();
{{endregion}}

#### __[VB.NET] Allowing the types that are used in the Telerik.Windows.Controls.Docking and Telerik.Windows.Controls.Navigation assemblies__
{{region persistence-framework-allowed-types-5}}
    Dim manager As PersistenceManager = New PersistenceManager()
        .AllowDockingControls()
        .AllowNavigationControls()
{{endregion}}

## Allowing Internal Types

In cases where internal WPF types need to be added to the AllowedTypes collection, you can obtain them at runtime and utilize the AllowTypes method. One such case is with the native WPF `Selector` class that assigns the `SelectedItems` property to a `SelectedItemCollection` type, which is internal. In this specific scenario, invoking the `AllowInputControls` method will resolve this, however, if you need to allow internal types, you can follow the approach from the following example:

#### __[C#] Allowing internal types via the AllowTypes method__
{{region persistence-framework-allowed-types-6}}
    var listBox = new ListBox();
    manager.AllowTypes(listBox.SelectedItems.GetType());
{{endregion}}

#### __[VB.NET] Allowing internal types via the AllowTypes method__
{{region persistence-framework-allowed-types-7}}
    Dim listBox = New ListBox()
    manager.AllowTypes(listBox.SelectedItems.[GetType]())
{{endregion}}

## TypeRestored Event

The retrieve each type that is present in the saved layout, you can utilize the `TypeRestored` event. You can inspect both the type and its assembly, and decide if the PersistenceFramework will allow its instantiation, by adding it to the AllowedTypes collection. The event arguments are of the type of `TypeRestoredEventArgs` and provide the following API:

* `Type`&mdash;Provides the type that is restored.
* `AssemblyQualifiedName`&mdash;Provides the type's assembly name.

#### __[C#] Utilizing the TypeRestored event__
{{region persistence-framework-allowed-types-8}}
    private void Manager_TypeRestored(object sender, Persistence.Events.TypeRestoredEventArgs e)
    {
        var type = e.Type; // Review the type and decide whether to allow the PersistenceFramework to instantiate it by adding it to the AllowedTypes collection.
    }
{{endregion}}

#### __[VB.NET] Utilizing the TypeRestored event__
{{region persistence-framework-allowed-types-9}}
    Private Sub Manager_TypeRestored(sender As Object, e As Persistence.Events.TypeRestoredEventArgs)
        Dim type = e.Type ' Review the type and decide whether to allow the PersistenceFramework to instantiate it by adding it to the AllowedTypes collection.
    End Sub
{{endregion}}

## Allowing Types when Using IsolatedStorageProvider

To allow types to be instantiated by the PersistenceFramework when working with the `IsolatedStorageProvider`, you need to pass a new PersistenceManager instance to its constructor. On it, you can utilize the AllowTypes extension method or use its AllowedTypes collection.

#### __[C#] Allowing types when using IsolatedStorageProvider__
{{region persistence-framework-allowed-types-10}}
    PersistenceManager manager = new PersistenceManager()
        .AddDockingControls()
        .AddNavigationControls();

    IsolatedStorageProvider isoProvider = new IsolatedStorageProvider(manager);
{{endregion}}

#### __[VB.NET] Allowing types when using IsolatedStorageProvider__
{{region persistence-framework-allowed-types-11}}
    Dim manager As PersistenceManager = New PersistenceManager()
       .AddDockingControls()
       .AddNavigationControls()
       
    Dim isoProvider As IsolatedStorageProvider = New IsolatedStorageProvider(manager)
{{endregion}}