---
title: Insert, Delete and Editing Operations
page_title: Insert, Delete and Editing Operations
description: Insert, Delete and Editing Operations
slug: raddataform-add-edit-delete-buttons
tags: insert,delete,and,editing,operations
published: True
position: 0
---

# CRUD Operations


This article explains how the CRUD operations of __RadDataForm__ work.

## Overview

RadDataForm’s Source property accepts IEnumerable values and manages them as follows: 

* If the underlying value implements IEditableCollectionView, the current implementation of its methods is used. 
* Otherwise, a new instance of Telerik’s QueryableCollectionView (which implements both interfaces) is initialized, using the Source value as its SourceCollection.

We will now examine the [Insert](#insert), [Remove](#remove) and [Edit](#edit) operations, respectively.

## Insert

RadDataForm's insert operation is determined by the bound data source collection. It will be available if:

* The collection implements the **IEditableCollectionView** interface

* The collection is an **IList** without a fixed size and with a public default constructor

* The collection implements an **Add** method with a single parameter and has a public default constructor

In any other case, the DataForm will not be able to add an item and the respective **Add** button will be disabled. 

#### __Figure 1: DataForm with disabled Add and Remove buttons__

![raddataform-crud-operations-1](images/raddataform-crud-operations-1.png)

## Remove

Similarly to the the Insert operation, you will be able to remove items in the following cases:

* The collection implements the **IEditableCollectionView** interface

* The collection is an **IList** without a fixed size

* The collection implements a **Remove** method with a single parameter

#### __Figure 2: DataForm with enabled Add and Remove buttons__

![raddataform-crud-operations-2](images/raddataform-crud-operations-2.png)


## Edit

If the current item is not null and the DataForm is not in editing mode, the **Edit** button will be enabled and editing functionality will be available.

If the items of the data source implement the **IEditableObject** or the **INotifyPropertyChanged** interface, you will be able to revert any pending changes with the **Cancel** button. 

>Note that in the latter case **EnablePropertyChangedBasedCancel** should be set to **True**

>**EnablePropertyChangedBasedCancel** is not supported when using custom DataTemplates.

Please note that when an edit is started, the Navigation and AddNew commands get disabled, until the editing operation is committed, or cancelled. 

>For more information on the behaviour of the **OK** and **Cancel** buttons you could check the article on [AutoCommit Settings]({%slug raddataform-auto-commit%})

RadDataForm supports editing of types that do not implement the IEditableObject or INotifyPropertyChanged interfaces. Still, please note that in this case you cannot take advantage of the cancel edit feature and the **Cancel** button will not be enabled.

>You can find a detailed explanation on how to implement the IEditableObject in this: [MSDN article](http://msdn.microsoft.com/en-us/library/system.componentmodel.ieditableobject.aspx)

### AutoEdit

The AutoEdit property indicates whether RadDataForm should automatically enter edit mode when loading or navigating items. The default value is **False**. If you need to have RadDataForm in edit mode by default, instead of having to click the edit button every time you need to edit a record, you can set AutoEdit to **True**. 

>Please note that setting AutoEdit to True will disable the **Add** button and you won't be able to add new entries.
