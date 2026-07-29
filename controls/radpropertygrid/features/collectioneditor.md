---
title: CollectionEditors
page_title: CollectionEditors
description: Check our &quot;CollectionEditors&quot; documentation article for the RadPropertyGrid {{ site.framework_name }} control.
slug: radpropertygrid-collectioneditor
tags: collectioneditors
published: True
position: 5
---

# CollectionEditors

__CollectionEditor__ and __CollectionEditorPicker__ are editor controls that provide UI for editing collections and their items. Currently they are used in the domain of RadPropertyGrid as default editors for **IEnumerable** type-compatible properties, but they can be successfully used out of this context as standalone editors:

__Example 1: Defining CollectionEditor__

<snippet id='radpropertygrid-features-collectioneditor-block_1-xaml' />

![Rad Property Grid Collection Editor](images/RadPropertyGrid_CollectionEditor.png)

![Rad Property Grid Collection Editor Picker](images/RadPropertyGrid_CollectionEditorPicker.png)

>important If you want CollectionEditor to work with a __custom collection__, then the edited collection type should implement __ICollectionView__ and __IEditableCollectionView__ interfaces.

## Dependencies

Both of them are located in the __Telerik.Windows.Controls.Data__ assembly (Telerik.Windows.Controls.Data.PropertyGrid namespace) and depend on the following assemblies:
        
* __Telerik.Windows.Data__

* __Telerik.Windows.Controls__

* __Telerik.Windows.Controls.Data__

* __Telerik.Windows.Control.Input__

## Internal Structure

CollectionEditor relies on the **IEditableCollectionView** interface. In case that the edited collection type implements ICollectionView and IEditableCollectionView, its custom implementation is utilized and if it does not, an instance of QueryableCollectionView is used instead.
        

The following listed commands, defined in the CollectionEditorCommands class, invoke their IEditableCollectionView method counterparts, when they are executed:

* __MoveCurrentToNext__

* __MoveCurrentToPrevious__

* __AddNew__

* __Delete__

## Customizing Commands

It is possible to customize the default commands for the CollectionEditor and the CollectionEditorPicker in a MVVM-friendly way. The following examples are using the CollectionEditor control but the same changes can be applied for the CollectionEditorPicker as well.

“Execute logic” methods

The methods listed below identify the logic that is executed when a certain command’s invocation takes place.

__Example 3: CollectionEditor's executable commands__

<snippet id='radpropertygrid-features-collectioneditor-block_2-cs' />
<snippet id='radpropertygrid-features-collectioneditor-block_2-vb' />

“Can-execute logic” methods

With the help of those methods you can identify whether a certain command can be executed or not.

__Example 4: CollectionEditor's "can-execute" methods__

<snippet id='radpropertygrid-features-collectioneditor-block_3-cs' />
<snippet id='radpropertygrid-features-collectioneditor-block_3-vb' />

## Designing a custom CommandProvider

The first step is to create your own class that inherits from **CollectionNavigatorBaseCommandProvider**:

__Example 5: Creating a class that provides the custom commands__

<snippet id='radpropertygrid-features-collectioneditor-block_4-cs' />
<snippet id='radpropertygrid-features-collectioneditor-block_4-vb' />

Those commands, which logic is up to get customized, should have their corresponding methods overridden. In the following example we will customize: MoveCurrentToNext, MoveCurrentToPrevious.

## MoveCurrentToNext and MoveCurrentToPrevious

In case you have a requirement to ask for the customer`s approval when moving through items, you need to update the commands as in the following examples:

__Example 6: Overriding the default commands__

<snippet id='radpropertygrid-features-collectioneditor-block_5-cs' />
<snippet id='radpropertygrid-features-collectioneditor-block_5-vb' />

The last thing to be done is to set CommandProvider Property of the CollectionEditor to be the newly-created CustomCommandProvider class:

__Example 7: Assigning the CommandProvider__

<snippet id='radpropertygrid-features-collectioneditor-block_6-xaml' />

__Example 8: Assigning the CommandProvider__

<snippet id='radpropertygrid-features-collectioneditor-block_7-cs' />
<snippet id='radpropertygrid-features-collectioneditor-block_7-vb' />

Modifying the methods will result in the following action when trying to move to the next item:

![customize commands](images/RadPropertyGrid_CollectionEditor_CustomizeCommands.png)

## Add/Remove Items 

**CollectionEditor** allows you to add and remove items to the underlying collection through the **Add** and **Remove** buttons. The availability of this functionality relies on the type of the bound collection and whether it supports such operations. **Figure 1** and **Figure 2** show the state of the buttons when the **CollectionEditor** is bound to an **ObservableCollection** and an **Array** respectively.

>important **The business object should expose a default constructor in order to have the "Add" button enabled.**

#### **Figure 1: CollectionEditor bound to a collection that supports add/remove functionalities**

![CollectionEditor bound to a collection that supports add/remove functionalities](images/CollectionEditor_AddRemove_Enabled.png)

#### **Figure 2: CollectionEditor bound to a collection that does not support add/remove functionalities**

![CollectionEditor bound to a collection that does not support add/remove functionalities](images/CollectionEditor_AddRemove_Disabled.png)

## See Also

* [Nested Properties]({%slug radpropertygrid-nested-properties%})

* [Data Annotations]({%slug radpropertygrid-data-annotations%})

* [Defining Property Sets]({%slug radpropertygrid-defining-propertysets%})